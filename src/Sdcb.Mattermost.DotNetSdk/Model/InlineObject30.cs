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
    /// InlineObject30
    /// </summary>
    [DataContract]
    public partial class InlineObject30 :  IEquatable<InlineObject30>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject30" /> class.
        /// </summary>
        [JsonConstructor]
        protected InlineObject30() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject30" /> class.
        /// </summary>
        /// <param name="schemeId">The ID of the scheme. (required).</param>
        public InlineObject30(string schemeId = default(string))
        {
            // to ensure "schemeId" is required (not null)
            if (schemeId == null)
            {
                throw new InvalidDataException("schemeId is a required property for InlineObject30 and cannot be null");
            }
            else
            {
                this.SchemeId = schemeId;
            }

        }
        
        /// <summary>
        /// The ID of the scheme.
        /// </summary>
        /// <value>The ID of the scheme.</value>
        [DataMember(Name="scheme_id", EmitDefaultValue=false)]
        public string SchemeId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineObject30 {\n");
            sb.Append("  SchemeId: ").Append(SchemeId).Append("\n");
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
            return this.Equals(input as InlineObject30);
        }

        /// <summary>
        /// Returns true if InlineObject30 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineObject30 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineObject30 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SchemeId == input.SchemeId ||
                    (this.SchemeId != null &&
                    this.SchemeId.Equals(input.SchemeId))
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
                if (this.SchemeId != null)
                    hashCode = hashCode * 59 + this.SchemeId.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
