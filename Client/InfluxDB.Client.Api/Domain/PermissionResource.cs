/* 
 * Influx API Service
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * OpenAPI spec version: 0.1.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OpenAPIDateConverter = InfluxDB.Client.Api.Client.OpenAPIDateConverter;

namespace InfluxDB.Client.Api.Domain
{
    /// <summary>
    /// PermissionResource
    /// </summary>
    [DataContract]
    public partial class PermissionResource :  IEquatable<PermissionResource>
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Authorizations for value: authorizations
            /// </summary>
            [EnumMember(Value = "authorizations")]
            Authorizations = 1,

            /// <summary>
            /// Enum Buckets for value: buckets
            /// </summary>
            [EnumMember(Value = "buckets")]
            Buckets = 2,

            /// <summary>
            /// Enum Dashboards for value: dashboards
            /// </summary>
            [EnumMember(Value = "dashboards")]
            Dashboards = 3,

            /// <summary>
            /// Enum Orgs for value: orgs
            /// </summary>
            [EnumMember(Value = "orgs")]
            Orgs = 4,

            /// <summary>
            /// Enum Sources for value: sources
            /// </summary>
            [EnumMember(Value = "sources")]
            Sources = 5,

            /// <summary>
            /// Enum Tasks for value: tasks
            /// </summary>
            [EnumMember(Value = "tasks")]
            Tasks = 6,

            /// <summary>
            /// Enum Telegrafs for value: telegrafs
            /// </summary>
            [EnumMember(Value = "telegrafs")]
            Telegrafs = 7,

            /// <summary>
            /// Enum Users for value: users
            /// </summary>
            [EnumMember(Value = "users")]
            Users = 8,

            /// <summary>
            /// Enum Variables for value: variables
            /// </summary>
            [EnumMember(Value = "variables")]
            Variables = 9,

            /// <summary>
            /// Enum Scrapers for value: scrapers
            /// </summary>
            [EnumMember(Value = "scrapers")]
            Scrapers = 10,

            /// <summary>
            /// Enum Secrets for value: secrets
            /// </summary>
            [EnumMember(Value = "secrets")]
            Secrets = 11,

            /// <summary>
            /// Enum Labels for value: labels
            /// </summary>
            [EnumMember(Value = "labels")]
            Labels = 12,

            /// <summary>
            /// Enum Views for value: views
            /// </summary>
            [EnumMember(Value = "views")]
            Views = 13,

            /// <summary>
            /// Enum Documents for value: documents
            /// </summary>
            [EnumMember(Value = "documents")]
            Documents = 14

        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PermissionResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionResource" /> class.
        /// </summary>
        /// <param name="type">type (required).</param>
        /// <param name="id">if id is set that is a permission for a specific resource. if it is not set it is a permission for all resources of that resource type..</param>
        /// <param name="name">optional name of the resource if the resource has a name field..</param>
        /// <param name="orgID">if orgID is set that is a permission for all resources owned my that org. if it is not set it is a permission for all resources of that resource type..</param>
        /// <param name="org">optional name of the organization of the organization with orgID..</param>
        public PermissionResource(TypeEnum type = default(TypeEnum), string id = default(string), string name = default(string), string orgID = default(string), string org = default(string))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for PermissionResource and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            this.Id = id;
            this.Name = name;
            this.OrgID = orgID;
            this.Org = org;
        }


        /// <summary>
        /// if id is set that is a permission for a specific resource. if it is not set it is a permission for all resources of that resource type.
        /// </summary>
        /// <value>if id is set that is a permission for a specific resource. if it is not set it is a permission for all resources of that resource type.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// optional name of the resource if the resource has a name field.
        /// </summary>
        /// <value>optional name of the resource if the resource has a name field.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// if orgID is set that is a permission for all resources owned my that org. if it is not set it is a permission for all resources of that resource type.
        /// </summary>
        /// <value>if orgID is set that is a permission for all resources owned my that org. if it is not set it is a permission for all resources of that resource type.</value>
        [DataMember(Name="orgID", EmitDefaultValue=false)]
        public string OrgID { get; set; }

        /// <summary>
        /// optional name of the organization of the organization with orgID.
        /// </summary>
        /// <value>optional name of the organization of the organization with orgID.</value>
        [DataMember(Name="org", EmitDefaultValue=false)]
        public string Org { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PermissionResource {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OrgID: ").Append(OrgID).Append("\n");
            sb.Append("  Org: ").Append(Org).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PermissionResource);
        }

        /// <summary>
        /// Returns true if PermissionResource instances are equal
        /// </summary>
        /// <param name="input">Instance of PermissionResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PermissionResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.OrgID == input.OrgID ||
                    (this.OrgID != null &&
                    this.OrgID.Equals(input.OrgID))
                ) && 
                (
                    this.Org == input.Org ||
                    (this.Org != null &&
                    this.Org.Equals(input.Org))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OrgID != null)
                    hashCode = hashCode * 59 + this.OrgID.GetHashCode();
                if (this.Org != null)
                    hashCode = hashCode * 59 + this.Org.GetHashCode();
                return hashCode;
            }
        }

    }

}
