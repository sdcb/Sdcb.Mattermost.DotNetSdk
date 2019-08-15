/* 
 * Mattermost API Reference
 *
 * There is also a work-in-progress [Postman API reference](https://documenter.getpostman.com/view/4508214/RW8FERUn). 
 *
 * The version of the OpenAPI document: 4.0.0
 * Contact: feedback@mattermost.com
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
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Sdcb.Mattermost.DotNetSdk.Client.OpenAPIDateConverter;

namespace Sdcb.Mattermost.DotNetSdk.Model
{
    /// <summary>
    /// Book object used in OpenGraph metadata of a webpage, if type is book
    /// </summary>
    [DataContract]
    public partial class OpenGraphBook :  IEquatable<OpenGraphBook>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OpenGraphBook" /> class.
        /// </summary>
        /// <param name="isbn">isbn.</param>
        /// <param name="releaseDate">releaseDate.</param>
        /// <param name="tags">tags.</param>
        /// <param name="authors">authors.</param>
        public OpenGraphBook(string isbn = default(string), string releaseDate = default(string), List<string> tags = default(List<string>), List<OpenGraphArticleAuthors> authors = default(List<OpenGraphArticleAuthors>))
        {
            this.Isbn = isbn;
            this.ReleaseDate = releaseDate;
            this.Tags = tags;
            this.Authors = authors;
        }
        
        /// <summary>
        /// Gets or Sets Isbn
        /// </summary>
        [DataMember(Name="isbn", EmitDefaultValue=false)]
        public string Isbn { get; set; }

        /// <summary>
        /// Gets or Sets ReleaseDate
        /// </summary>
        [DataMember(Name="release_date", EmitDefaultValue=false)]
        public string ReleaseDate { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Gets or Sets Authors
        /// </summary>
        [DataMember(Name="authors", EmitDefaultValue=false)]
        public List<OpenGraphArticleAuthors> Authors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OpenGraphBook {\n");
            sb.Append("  Isbn: ").Append(Isbn).Append("\n");
            sb.Append("  ReleaseDate: ").Append(ReleaseDate).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Authors: ").Append(Authors).Append("\n");
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
            return this.Equals(input as OpenGraphBook);
        }

        /// <summary>
        /// Returns true if OpenGraphBook instances are equal
        /// </summary>
        /// <param name="input">Instance of OpenGraphBook to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OpenGraphBook input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Isbn == input.Isbn ||
                    (this.Isbn != null &&
                    this.Isbn.Equals(input.Isbn))
                ) && 
                (
                    this.ReleaseDate == input.ReleaseDate ||
                    (this.ReleaseDate != null &&
                    this.ReleaseDate.Equals(input.ReleaseDate))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.Authors == input.Authors ||
                    this.Authors != null &&
                    input.Authors != null &&
                    this.Authors.SequenceEqual(input.Authors)
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
                if (this.Isbn != null)
                    hashCode = hashCode * 59 + this.Isbn.GetHashCode();
                if (this.ReleaseDate != null)
                    hashCode = hashCode * 59 + this.ReleaseDate.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Authors != null)
                    hashCode = hashCode * 59 + this.Authors.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
