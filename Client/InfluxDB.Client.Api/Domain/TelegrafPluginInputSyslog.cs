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
    /// TelegrafPluginInputSyslog
    /// </summary>
    [DataContract]
    public partial class TelegrafPluginInputSyslog : TelegrafRequestPlugin,  IEquatable<TelegrafPluginInputSyslog>
    {
        /// <summary>
        /// Defines Name
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NameEnum
        {
            /// <summary>
            /// Enum Syslog for value: syslog
            /// </summary>
            [EnumMember(Value = "syslog")]
            Syslog = 1

        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public NameEnum Name { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TelegrafPluginInputSyslog" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TelegrafPluginInputSyslog() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TelegrafPluginInputSyslog" /> class.
        /// </summary>
        /// <param name="name">name (required) (default to NameEnum.Syslog).</param>
        /// <param name="comment">comment.</param>
        /// <param name="config">config (required).</param>
        public TelegrafPluginInputSyslog(NameEnum name = NameEnum.Syslog, TypeEnum type = TypeEnum.Input, string comment = default(string), TelegrafPluginInputSyslogConfig config = default(TelegrafPluginInputSyslogConfig)) : base(type)
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for TelegrafPluginInputSyslog and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "config" is required (not null)
            if (config == null)
            {
                throw new InvalidDataException("config is a required property for TelegrafPluginInputSyslog and cannot be null");
            }
            else
            {
                this.Config = config;
            }
            this.Comment = comment;
        }


        /// <summary>
        /// Gets or Sets Comment
        /// </summary>
        [DataMember(Name="comment", EmitDefaultValue=false)]
        public string Comment { get; set; }

        /// <summary>
        /// Gets or Sets Config
        /// </summary>
        [DataMember(Name="config", EmitDefaultValue=false)]
        public TelegrafPluginInputSyslogConfig Config { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TelegrafPluginInputSyslog {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  Config: ").Append(Config).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as TelegrafPluginInputSyslog);
        }

        /// <summary>
        /// Returns true if TelegrafPluginInputSyslog instances are equal
        /// </summary>
        /// <param name="input">Instance of TelegrafPluginInputSyslog to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TelegrafPluginInputSyslog input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && base.Equals(input) && 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
                ) && base.Equals(input) && 
                (
                    
                    (this.Config != null &&
                    this.Config.Equals(input.Config))
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
                int hashCode = base.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Comment != null)
                    hashCode = hashCode * 59 + this.Comment.GetHashCode();
                if (this.Config != null)
                    hashCode = hashCode * 59 + this.Config.GetHashCode();
                return hashCode;
            }
        }

    }

}
