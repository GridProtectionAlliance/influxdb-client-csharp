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
    /// QueryConfig
    /// </summary>
    [DataContract]
    public partial class QueryConfig :  IEquatable<QueryConfig>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryConfig" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected QueryConfig() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryConfig" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="database">database (required).</param>
        /// <param name="measurement">measurement (required).</param>
        /// <param name="retentionPolicy">retentionPolicy (required).</param>
        /// <param name="areTagsAccepted">areTagsAccepted (required).</param>
        /// <param name="rawText">rawText.</param>
        /// <param name="tags">tags (required).</param>
        /// <param name="groupBy">groupBy (required).</param>
        /// <param name="fields">fields (required).</param>
        /// <param name="range">range.</param>
        public QueryConfig(string id = default(string), string database = default(string), string measurement = default(string), string retentionPolicy = default(string), bool? areTagsAccepted = default(bool?), string rawText = default(string), Object tags = default(Object), QueryConfigGroupBy groupBy = default(QueryConfigGroupBy), List<Field> fields = default(List<Field>), QueryConfigRange range = default(QueryConfigRange))
        {
            // to ensure "database" is required (not null)
            if (database == null)
            {
                throw new InvalidDataException("database is a required property for QueryConfig and cannot be null");
            }
            else
            {
                this.Database = database;
            }
            // to ensure "measurement" is required (not null)
            if (measurement == null)
            {
                throw new InvalidDataException("measurement is a required property for QueryConfig and cannot be null");
            }
            else
            {
                this.Measurement = measurement;
            }
            // to ensure "retentionPolicy" is required (not null)
            if (retentionPolicy == null)
            {
                throw new InvalidDataException("retentionPolicy is a required property for QueryConfig and cannot be null");
            }
            else
            {
                this.RetentionPolicy = retentionPolicy;
            }
            // to ensure "areTagsAccepted" is required (not null)
            if (areTagsAccepted == null)
            {
                throw new InvalidDataException("areTagsAccepted is a required property for QueryConfig and cannot be null");
            }
            else
            {
                this.AreTagsAccepted = areTagsAccepted;
            }
            // to ensure "tags" is required (not null)
            if (tags == null)
            {
                throw new InvalidDataException("tags is a required property for QueryConfig and cannot be null");
            }
            else
            {
                this.Tags = tags;
            }
            // to ensure "groupBy" is required (not null)
            if (groupBy == null)
            {
                throw new InvalidDataException("groupBy is a required property for QueryConfig and cannot be null");
            }
            else
            {
                this.GroupBy = groupBy;
            }
            // to ensure "fields" is required (not null)
            if (fields == null)
            {
                throw new InvalidDataException("fields is a required property for QueryConfig and cannot be null");
            }
            else
            {
                this.Fields = fields;
            }
            this.Id = id;
            this.RawText = rawText;
            this.Range = range;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Database
        /// </summary>
        [DataMember(Name="database", EmitDefaultValue=false)]
        public string Database { get; set; }

        /// <summary>
        /// Gets or Sets Measurement
        /// </summary>
        [DataMember(Name="measurement", EmitDefaultValue=false)]
        public string Measurement { get; set; }

        /// <summary>
        /// Gets or Sets RetentionPolicy
        /// </summary>
        [DataMember(Name="retentionPolicy", EmitDefaultValue=false)]
        public string RetentionPolicy { get; set; }

        /// <summary>
        /// Gets or Sets AreTagsAccepted
        /// </summary>
        [DataMember(Name="areTagsAccepted", EmitDefaultValue=false)]
        public bool? AreTagsAccepted { get; set; }

        /// <summary>
        /// Gets or Sets RawText
        /// </summary>
        [DataMember(Name="rawText", EmitDefaultValue=false)]
        public string RawText { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public Object Tags { get; set; }

        /// <summary>
        /// Gets or Sets GroupBy
        /// </summary>
        [DataMember(Name="groupBy", EmitDefaultValue=false)]
        public QueryConfigGroupBy GroupBy { get; set; }

        /// <summary>
        /// Gets or Sets Fields
        /// </summary>
        [DataMember(Name="fields", EmitDefaultValue=false)]
        public List<Field> Fields { get; set; }

        /// <summary>
        /// Gets or Sets Range
        /// </summary>
        [DataMember(Name="range", EmitDefaultValue=false)]
        public QueryConfigRange Range { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryConfig {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Database: ").Append(Database).Append("\n");
            sb.Append("  Measurement: ").Append(Measurement).Append("\n");
            sb.Append("  RetentionPolicy: ").Append(RetentionPolicy).Append("\n");
            sb.Append("  AreTagsAccepted: ").Append(AreTagsAccepted).Append("\n");
            sb.Append("  RawText: ").Append(RawText).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  GroupBy: ").Append(GroupBy).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            sb.Append("  Range: ").Append(Range).Append("\n");
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
            return this.Equals(input as QueryConfig);
        }

        /// <summary>
        /// Returns true if QueryConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of QueryConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Database == input.Database ||
                    (this.Database != null &&
                    this.Database.Equals(input.Database))
                ) && 
                (
                    this.Measurement == input.Measurement ||
                    (this.Measurement != null &&
                    this.Measurement.Equals(input.Measurement))
                ) && 
                (
                    this.RetentionPolicy == input.RetentionPolicy ||
                    (this.RetentionPolicy != null &&
                    this.RetentionPolicy.Equals(input.RetentionPolicy))
                ) && 
                (
                    this.AreTagsAccepted == input.AreTagsAccepted ||
                    (this.AreTagsAccepted != null &&
                    this.AreTagsAccepted.Equals(input.AreTagsAccepted))
                ) && 
                (
                    this.RawText == input.RawText ||
                    (this.RawText != null &&
                    this.RawText.Equals(input.RawText))
                ) && 
                (
                    
                    (this.Tags != null &&
                    this.Tags.Equals(input.Tags))
                ) && 
                (
                    
                    (this.GroupBy != null &&
                    this.GroupBy.Equals(input.GroupBy))
                ) && 
                (
                    this.Fields == input.Fields ||
                    this.Fields != null &&
                    this.Fields.SequenceEqual(input.Fields)
                ) && 
                (
                    
                    (this.Range != null &&
                    this.Range.Equals(input.Range))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Database != null)
                    hashCode = hashCode * 59 + this.Database.GetHashCode();
                if (this.Measurement != null)
                    hashCode = hashCode * 59 + this.Measurement.GetHashCode();
                if (this.RetentionPolicy != null)
                    hashCode = hashCode * 59 + this.RetentionPolicy.GetHashCode();
                if (this.AreTagsAccepted != null)
                    hashCode = hashCode * 59 + this.AreTagsAccepted.GetHashCode();
                if (this.RawText != null)
                    hashCode = hashCode * 59 + this.RawText.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.GroupBy != null)
                    hashCode = hashCode * 59 + this.GroupBy.GetHashCode();
                if (this.Fields != null)
                    hashCode = hashCode * 59 + this.Fields.GetHashCode();
                if (this.Range != null)
                    hashCode = hashCode * 59 + this.Range.GetHashCode();
                return hashCode;
            }
        }

    }

}
