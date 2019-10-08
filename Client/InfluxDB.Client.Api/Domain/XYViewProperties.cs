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
    /// XYViewProperties
    /// </summary>
    [DataContract]
    public partial class XYViewProperties : ViewProperties,  IEquatable<XYViewProperties>
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Xy for value: xy
            /// </summary>
            [EnumMember(Value = "xy")]
            Xy = 1

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
        /// Gets or Sets Geom
        /// </summary>
        [DataMember(Name="geom", EmitDefaultValue=false)]
        public XYGeom Geom { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="XYViewProperties" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected XYViewProperties() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="XYViewProperties" /> class.
        /// </summary>
        /// <param name="type">type (required).</param>
        /// <param name="queries">queries (required).</param>
        /// <param name="colors">Colors define color encoding of data into a visualization (required).</param>
        /// <param name="shape">shape (required).</param>
        /// <param name="note">note (required).</param>
        /// <param name="showNoteWhenEmpty">If true, will display note when empty (required).</param>
        /// <param name="axes">axes (required).</param>
        /// <param name="legend">legend (required).</param>
        /// <param name="xColumn">xColumn.</param>
        /// <param name="yColumn">yColumn.</param>
        /// <param name="shadeBelow">shadeBelow.</param>
        /// <param name="geom">geom (required).</param>
        public XYViewProperties(TypeEnum type = default(TypeEnum), List<DashboardQuery> queries = default(List<DashboardQuery>), List<DashboardColor> colors = default(List<DashboardColor>), ShapeEnum shape = default(ShapeEnum), string note = default(string), bool? showNoteWhenEmpty = default(bool?), Axes axes = default(Axes), Legend legend = default(Legend), string xColumn = default(string), string yColumn = default(string), bool? shadeBelow = default(bool?), XYGeom geom = default(XYGeom)) : base()
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for XYViewProperties and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            // to ensure "queries" is required (not null)
            if (queries == null)
            {
                throw new InvalidDataException("queries is a required property for XYViewProperties and cannot be null");
            }
            else
            {
                this.Queries = queries;
            }
            // to ensure "colors" is required (not null)
            if (colors == null)
            {
                throw new InvalidDataException("colors is a required property for XYViewProperties and cannot be null");
            }
            else
            {
                this.Colors = colors;
            }
            // to ensure "shape" is required (not null)
            if (shape == null)
            {
                throw new InvalidDataException("shape is a required property for XYViewProperties and cannot be null");
            }
            else
            {
                this.Shape = shape;
            }
            // to ensure "note" is required (not null)
            if (note == null)
            {
                throw new InvalidDataException("note is a required property for XYViewProperties and cannot be null");
            }
            else
            {
                this.Note = note;
            }
            // to ensure "showNoteWhenEmpty" is required (not null)
            if (showNoteWhenEmpty == null)
            {
                throw new InvalidDataException("showNoteWhenEmpty is a required property for XYViewProperties and cannot be null");
            }
            else
            {
                this.ShowNoteWhenEmpty = showNoteWhenEmpty;
            }
            // to ensure "axes" is required (not null)
            if (axes == null)
            {
                throw new InvalidDataException("axes is a required property for XYViewProperties and cannot be null");
            }
            else
            {
                this.Axes = axes;
            }
            // to ensure "legend" is required (not null)
            if (legend == null)
            {
                throw new InvalidDataException("legend is a required property for XYViewProperties and cannot be null");
            }
            else
            {
                this.Legend = legend;
            }
            // to ensure "geom" is required (not null)
            if (geom == null)
            {
                throw new InvalidDataException("geom is a required property for XYViewProperties and cannot be null");
            }
            else
            {
                this.Geom = geom;
            }
            this.XColumn = xColumn;
            this.YColumn = yColumn;
            this.ShadeBelow = shadeBelow;
        }


        /// <summary>
        /// Gets or Sets Queries
        /// </summary>
        [DataMember(Name="queries", EmitDefaultValue=false)]
        public List<DashboardQuery> Queries { get; set; }

        /// <summary>
        /// Colors define color encoding of data into a visualization
        /// </summary>
        /// <value>Colors define color encoding of data into a visualization</value>
        [DataMember(Name="colors", EmitDefaultValue=false)]
        public List<DashboardColor> Colors { get; set; }


        /// <summary>
        /// Gets or Sets Note
        /// </summary>
        [DataMember(Name="note", EmitDefaultValue=false)]
        public string Note { get; set; }

        /// <summary>
        /// If true, will display note when empty
        /// </summary>
        /// <value>If true, will display note when empty</value>
        [DataMember(Name="showNoteWhenEmpty", EmitDefaultValue=false)]
        public bool? ShowNoteWhenEmpty { get; set; }

        /// <summary>
        /// Gets or Sets Axes
        /// </summary>
        [DataMember(Name="axes", EmitDefaultValue=false)]
        public Axes Axes { get; set; }

        /// <summary>
        /// Gets or Sets Legend
        /// </summary>
        [DataMember(Name="legend", EmitDefaultValue=false)]
        public Legend Legend { get; set; }

        /// <summary>
        /// Gets or Sets XColumn
        /// </summary>
        [DataMember(Name="xColumn", EmitDefaultValue=false)]
        public string XColumn { get; set; }

        /// <summary>
        /// Gets or Sets YColumn
        /// </summary>
        [DataMember(Name="yColumn", EmitDefaultValue=false)]
        public string YColumn { get; set; }

        /// <summary>
        /// Gets or Sets ShadeBelow
        /// </summary>
        [DataMember(Name="shadeBelow", EmitDefaultValue=false)]
        public bool? ShadeBelow { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class XYViewProperties {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Queries: ").Append(Queries).Append("\n");
            sb.Append("  Colors: ").Append(Colors).Append("\n");
            sb.Append("  Shape: ").Append(Shape).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  ShowNoteWhenEmpty: ").Append(ShowNoteWhenEmpty).Append("\n");
            sb.Append("  Axes: ").Append(Axes).Append("\n");
            sb.Append("  Legend: ").Append(Legend).Append("\n");
            sb.Append("  XColumn: ").Append(XColumn).Append("\n");
            sb.Append("  YColumn: ").Append(YColumn).Append("\n");
            sb.Append("  ShadeBelow: ").Append(ShadeBelow).Append("\n");
            sb.Append("  Geom: ").Append(Geom).Append("\n");
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
            return this.Equals(input as XYViewProperties);
        }

        /// <summary>
        /// Returns true if XYViewProperties instances are equal
        /// </summary>
        /// <param name="input">Instance of XYViewProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(XYViewProperties input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && base.Equals(input) && 
                (
                    this.Queries == input.Queries ||
                    this.Queries != null &&
                    this.Queries.SequenceEqual(input.Queries)
                ) && base.Equals(input) && 
                (
                    this.Colors == input.Colors ||
                    this.Colors != null &&
                    this.Colors.SequenceEqual(input.Colors)
                ) && base.Equals(input) && 
                (
                    this.Shape == input.Shape ||
                    (this.Shape != null &&
                    this.Shape.Equals(input.Shape))
                ) && base.Equals(input) && 
                (
                    this.Note == input.Note ||
                    (this.Note != null &&
                    this.Note.Equals(input.Note))
                ) && base.Equals(input) && 
                (
                    this.ShowNoteWhenEmpty == input.ShowNoteWhenEmpty ||
                    (this.ShowNoteWhenEmpty != null &&
                    this.ShowNoteWhenEmpty.Equals(input.ShowNoteWhenEmpty))
                ) && base.Equals(input) && 
                (
                    
                    (this.Axes != null &&
                    this.Axes.Equals(input.Axes))
                ) && base.Equals(input) && 
                (
                    
                    (this.Legend != null &&
                    this.Legend.Equals(input.Legend))
                ) && base.Equals(input) && 
                (
                    this.XColumn == input.XColumn ||
                    (this.XColumn != null &&
                    this.XColumn.Equals(input.XColumn))
                ) && base.Equals(input) && 
                (
                    this.YColumn == input.YColumn ||
                    (this.YColumn != null &&
                    this.YColumn.Equals(input.YColumn))
                ) && base.Equals(input) && 
                (
                    this.ShadeBelow == input.ShadeBelow ||
                    (this.ShadeBelow != null &&
                    this.ShadeBelow.Equals(input.ShadeBelow))
                ) && base.Equals(input) && 
                (
                    this.Geom == input.Geom ||
                    (this.Geom != null &&
                    this.Geom.Equals(input.Geom))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Queries != null)
                    hashCode = hashCode * 59 + this.Queries.GetHashCode();
                if (this.Colors != null)
                    hashCode = hashCode * 59 + this.Colors.GetHashCode();
                if (this.Shape != null)
                    hashCode = hashCode * 59 + this.Shape.GetHashCode();
                if (this.Note != null)
                    hashCode = hashCode * 59 + this.Note.GetHashCode();
                if (this.ShowNoteWhenEmpty != null)
                    hashCode = hashCode * 59 + this.ShowNoteWhenEmpty.GetHashCode();
                if (this.Axes != null)
                    hashCode = hashCode * 59 + this.Axes.GetHashCode();
                if (this.Legend != null)
                    hashCode = hashCode * 59 + this.Legend.GetHashCode();
                if (this.XColumn != null)
                    hashCode = hashCode * 59 + this.XColumn.GetHashCode();
                if (this.YColumn != null)
                    hashCode = hashCode * 59 + this.YColumn.GetHashCode();
                if (this.ShadeBelow != null)
                    hashCode = hashCode * 59 + this.ShadeBelow.GetHashCode();
                if (this.Geom != null)
                    hashCode = hashCode * 59 + this.Geom.GetHashCode();
                return hashCode;
            }
        }

    }

}
