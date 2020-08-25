using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using InfluxDB.Client.Api.Domain;
using InfluxDB.Client.Core;
using InfluxDB.Client.Writes;
using NodaTime;
using NUnit.Framework;
using Duration = NodaTime.Duration;
using Task = System.Threading.Tasks.Task;

namespace InfluxDB.Client.Test
{
    [TestFixture]
    public class ItWriteApiRaceTest : AbstractItClientTest
    {
        [SetUp]
        public new async Task SetUp()
        {
            _organization = await FindMyOrg();

            var retention = new BucketRetentionRules(BucketRetentionRules.TypeEnum.Expire, 3600);

            _bucket = await Client.GetBucketsApi()
                .CreateBucketAsync(GenerateName("h2o"), retention, _organization);

            //
            // Add Permissions to read and write to the Bucket
            //
            var resource =
                new PermissionResource(PermissionResource.TypeEnum.Buckets, _bucket.Id, null, _organization.Id);

            var readBucket = new Permission(Permission.ActionEnum.Read, resource);
            var writeBucket = new Permission(Permission.ActionEnum.Write, resource);

            var loggedUser = await Client.GetUsersApi().MeAsync();
            Assert.IsNotNull(loggedUser);

            var authorization = await Client.GetAuthorizationsApi()
                .CreateAuthorizationAsync(await FindMyOrg(), new List<Permission> { readBucket, writeBucket });

            _token = authorization.Token;

            Client.Dispose();
            var options = new InfluxDBClientOptions.Builder().Url(InfluxDbUrl).AuthenticateToken(_token)
                .Org(_organization.Id).Bucket(_bucket.Id).Build();
            Client = InfluxDBClientFactory.Create(options);
        }

        private Bucket _bucket;
        private Organization _organization;
        private string _token;


        [Test]
        public void Race()
        {
            var options = new InfluxDBClientOptions.Builder().Url(InfluxDbUrl)
                .LoadConfig()
                .Url(InfluxDbUrl)
                .AuthenticateToken(_token)
                .Build();
            var point = PointData.Measurement("race-test")
                                 .Tag("test", "stress")
                                 .Field("value", 1);

            const int RANGE = 1000;
            using (var gateStart = new ManualResetEventSlim(false))
            using (var gate = new CountdownEvent(RANGE))
            using (var gateEnd = new CountdownEvent(RANGE))
            {
                for (int i = 0; i < RANGE; i++)
                {
                    var trd = new Thread(() =>
                    {
                        gateStart.Wait();
                        using (WriteApi writer = Client.GetWriteApi())
                        {
                            writer.WritePoint(point);
                            gate.Signal();
                            gate.Wait();
                        }
                        gateEnd.Signal();
                    });
                    trd.Start();
                }
                gateStart.Set();
                gateEnd.Wait();
            }
        }
    }
}