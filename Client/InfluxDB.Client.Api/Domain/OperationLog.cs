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
    /// OperationLog
    /// </summary>
    [DataContract]
    public partial class OperationLog :  IEquatable<OperationLog>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OperationLog" /> class.
        /// </summary>
        /// <param name="description">A description of the event that occurred..</param>
        /// <param name="time">Time event occurred, RFC3339Nano..</param>
        /// <param name="links">links.</param>
        public OperationLog(string description = default(string), DateTime? time = default(DateTime?), OperationLogLinks links = default(OperationLogLinks))
        {
            this.Description = description;
            this.Time = time;
            this.Links = links;
        }

        /// <summary>
        /// A description of the event that occurred.
        /// </summary>
        /// <value>A description of the event that occurred.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Time event occurred, RFC3339Nano.
        /// </summary>
        /// <value>Time event occurred, RFC3339Nano.</value>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public DateTime? Time { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public OperationLogLinks Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OperationLog {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(input as OperationLog);
        }

        /// <summary>
        /// Returns true if OperationLog instances are equal
        /// </summary>
        /// <param name="input">Instance of OperationLog to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OperationLog input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
                ) && 
                (
                    
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }

    }

}
