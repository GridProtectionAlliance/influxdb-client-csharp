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
    /// Contains the configuration for the log viewer
    /// </summary>
    [DataContract]
    public partial class LogViewProperties :  IEquatable<LogViewProperties>
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum LogViewer for value: log-viewer
            /// </summary>
            [EnumMember(Value = "log-viewer")]
            LogViewer = 1

        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Defines Shape
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ShapeEnum
        {
            /// <summary>
            /// Enum ChronografV2 for value: chronograf-v2
            /// </summary>
            [EnumMember(Value = "chronograf-v2")]
            ChronografV2 = 1

        }

        /// <summary>
        /// Gets or Sets Shape
        /// </summary>
        [DataMember(Name="shape", EmitDefaultValue=false)]
        public ShapeEnum Shape { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LogViewProperties" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LogViewProperties() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LogViewProperties" /> class.
        /// </summary>
        /// <param name="type">type (required).</param>
        /// <param name="shape">shape (required).</param>
        /// <param name="columns">Defines the order, names, and visibility of columns in the log viewer table (required).</param>
        public LogViewProperties(TypeEnum type = default(TypeEnum), ShapeEnum shape = default(ShapeEnum), List<LogViewerColumn> columns = default(List<LogViewerColumn>))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for LogViewProperties and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            // to ensure "shape" is required (not null)
            if (shape == null)
            {
                throw new InvalidDataException("shape is a required property for LogViewProperties and cannot be null");
            }
            else
            {
                this.Shape = shape;
            }
            // to ensure "columns" is required (not null)
            if (columns == null)
            {
                throw new InvalidDataException("columns is a required property for LogViewProperties and cannot be null");
            }
            else
            {
                this.Columns = columns;
            }
        }



        /// <summary>
        /// Defines the order, names, and visibility of columns in the log viewer table
        /// </summary>
        /// <value>Defines the order, names, and visibility of columns in the log viewer table</value>
        [DataMember(Name="columns", EmitDefaultValue=false)]
        public List<LogViewerColumn> Columns { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LogViewProperties {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Shape: ").Append(Shape).Append("\n");
            sb.Append("  Columns: ").Append(Columns).Append("\n");
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
            return this.Equals(input as LogViewProperties);
        }

        /// <summary>
        /// Returns true if LogViewProperties instances are equal
        /// </summary>
        /// <param name="input">Instance of LogViewProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LogViewProperties input)
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
                    this.Shape == input.Shape ||
                    (this.Shape != null &&
                    this.Shape.Equals(input.Shape))
                ) && 
                (
                    this.Columns == input.Columns ||
                    this.Columns != null &&
                    this.Columns.SequenceEqual(input.Columns)
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
                if (this.Shape != null)
                    hashCode = hashCode * 59 + this.Shape.GetHashCode();
                if (this.Columns != null)
                    hashCode = hashCode * 59 + this.Columns.GetHashCode();
                return hashCode;
            }
        }

    }

}
