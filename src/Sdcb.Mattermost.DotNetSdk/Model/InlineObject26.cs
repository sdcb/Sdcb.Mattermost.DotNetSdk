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
    /// InlineObject26
    /// </summary>
    [DataContract]
    public partial class InlineObject26 :  IEquatable<InlineObject26>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject26" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InlineObject26() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject26" /> class.
        /// </summary>
        /// <param name="term">The search term to match against the name or display name of teams (required).</param>
        public InlineObject26(string term = default(string))
        {
            // to ensure "term" is required (not null)
            if (term == null)
            {
                throw new InvalidDataException("term is a required property for InlineObject26 and cannot be null");
            }
            else
            {
                this.Term = term;
            }

        }
        
        /// <summary>
        /// The search term to match against the name or display name of teams
        /// </summary>
        /// <value>The search term to match against the name or display name of teams</value>
        [DataMember(Name="term", EmitDefaultValue=false)]
        public string Term { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineObject26 {\n");
            sb.Append("  Term: ").Append(Term).Append("\n");
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
            return this.Equals(input as InlineObject26);
        }

        /// <summary>
        /// Returns true if InlineObject26 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineObject26 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineObject26 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Term == input.Term ||
                    (this.Term != null &&
                    this.Term.Equals(input.Term))
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
                if (this.Term != null)
                    hashCode = hashCode * 59 + this.Term.GetHashCode();
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
