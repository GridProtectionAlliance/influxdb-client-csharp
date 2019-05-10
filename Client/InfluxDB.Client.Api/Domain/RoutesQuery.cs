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
    /// RoutesQuery
    /// </summary>
    [DataContract]
    public partial class RoutesQuery :  IEquatable<RoutesQuery>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoutesQuery" /> class.
        /// </summary>
        /// <param name="self">self.</param>
        /// <param name="ast">ast.</param>
        /// <param name="analyze">analyze.</param>
        /// <param name="suggestions">suggestions.</param>
        public RoutesQuery(string self = default(string), string ast = default(string), string analyze = default(string), string suggestions = default(string))
        {
            this.Self = self;
            this.Ast = ast;
            this.Analyze = analyze;
            this.Suggestions = suggestions;
        }

        /// <summary>
        /// Gets or Sets Self
        /// </summary>
        [DataMember(Name="self", EmitDefaultValue=false)]
        public string Self { get; set; }

        /// <summary>
        /// Gets or Sets Ast
        /// </summary>
        [DataMember(Name="ast", EmitDefaultValue=false)]
        public string Ast { get; set; }

        /// <summary>
        /// Gets or Sets Analyze
        /// </summary>
        [DataMember(Name="analyze", EmitDefaultValue=false)]
        public string Analyze { get; set; }

        /// <summary>
        /// Gets or Sets Suggestions
        /// </summary>
        [DataMember(Name="suggestions", EmitDefaultValue=false)]
        public string Suggestions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoutesQuery {\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
            sb.Append("  Ast: ").Append(Ast).Append("\n");
            sb.Append("  Analyze: ").Append(Analyze).Append("\n");
            sb.Append("  Suggestions: ").Append(Suggestions).Append("\n");
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
            return this.Equals(input as RoutesQuery);
        }

        /// <summary>
        /// Returns true if RoutesQuery instances are equal
        /// </summary>
        /// <param name="input">Instance of RoutesQuery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoutesQuery input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Self == input.Self ||
                    (this.Self != null &&
                    this.Self.Equals(input.Self))
                ) && 
                (
                    this.Ast == input.Ast ||
                    (this.Ast != null &&
                    this.Ast.Equals(input.Ast))
                ) && 
                (
                    this.Analyze == input.Analyze ||
                    (this.Analyze != null &&
                    this.Analyze.Equals(input.Analyze))
                ) && 
                (
                    this.Suggestions == input.Suggestions ||
                    (this.Suggestions != null &&
                    this.Suggestions.Equals(input.Suggestions))
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
                if (this.Self != null)
                    hashCode = hashCode * 59 + this.Self.GetHashCode();
                if (this.Ast != null)
                    hashCode = hashCode * 59 + this.Ast.GetHashCode();
                if (this.Analyze != null)
                    hashCode = hashCode * 59 + this.Analyze.GetHashCode();
                if (this.Suggestions != null)
                    hashCode = hashCode * 59 + this.Suggestions.GetHashCode();
                return hashCode;
            }
        }

    }

}
