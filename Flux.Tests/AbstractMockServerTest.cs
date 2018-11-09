using Newtonsoft.Json.Linq;
using WireMock.ResponseBuilders;
using Wmhelp.XPath2.yydebug;

namespace Flux.Tests
{
    public class AbstractMockServerTest : AbstractTest
    {
        protected IResponseBuilder CreateErrorResponse(string influxDbError) 
        {
            string body = "{\"error\":\"" + influxDbError + "\"}";

            return Response.Create().WithStatusCode(500)
                .WithHeader("X-Influx-Error", influxDbError)
                .WithBody(body);
        }

        protected IResponseBuilder CreateResponse(string data, string contentType = "text/csv")
        {
            return Response.Create()
                            .WithHeader("Content-Type", contentType + "; charset=utf-8")
                            .WithHeader("Date", "Tue, 26 Jun 2018 13:15:01 GMT")
                            .WithBody(data);
        }
    }
}