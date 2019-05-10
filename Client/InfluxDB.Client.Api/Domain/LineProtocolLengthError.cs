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
    /// LineProtocolLengthError
    /// </summary>
    [DataContract]
    public partial class LineProtocolLengthError :  IEquatable<LineProtocolLengthError>
    {
        /// <summary>
        /// code is the machine-readable error code.
        /// </summary>
        /// <value>code is the machine-readable error code.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum Invalid for value: invalid
            /// </summary>
            [EnumMember(Value = "invalid")]
            Invalid = 1

        }

        /// <summary>
        /// code is the machine-readable error code.
        /// </summary>
        /// <value>code is the machine-readable error code.</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LineProtocolLengthError" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public LineProtocolLengthError()
        {
        }


        /// <summary>
        /// message is a human-readable message.
        /// </summary>
        /// <value>message is a human-readable message.</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; private set; }

        /// <summary>
        /// max length in bytes for a body of line-protocol.
        /// </summary>
        /// <value>max length in bytes for a body of line-protocol.</value>
        [DataMember(Name="maxLength", EmitDefaultValue=false)]
        public int? MaxLength { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LineProtocolLengthError {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  MaxLength: ").Append(MaxLength).Append("\n");
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
            return this.Equals(input as LineProtocolLengthError);
        }

        /// <summary>
        /// Returns true if LineProtocolLengthError instances are equal
        /// </summary>
        /// <param name="input">Instance of LineProtocolLengthError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LineProtocolLengthError input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.MaxLength == input.MaxLength ||
                    (this.MaxLength != null &&
                    this.MaxLength.Equals(input.MaxLength))
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.MaxLength != null)
                    hashCode = hashCode * 59 + this.MaxLength.GetHashCode();
                return hashCode;
            }
        }

    }

}
