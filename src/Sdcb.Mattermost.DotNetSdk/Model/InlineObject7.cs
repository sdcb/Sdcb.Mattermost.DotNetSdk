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
    /// InlineObject7
    /// </summary>
    [DataContract]
    public partial class InlineObject7 :  IEquatable<InlineObject7>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject7" /> class.
        /// </summary>
        [JsonConstructor]
        protected InlineObject7() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject7" /> class.
        /// </summary>
        /// <param name="activate">Use &#x60;true&#x60; to activate, &#x60;false&#x60; to deactivate (required).</param>
        /// <param name="code">The code produced by your MFA client. Required if &#x60;activate&#x60; is true.</param>
        public InlineObject7(bool activate = default(bool), string code = default(string))
        {
            // to ensure "activate" is required (not null)
            if (activate == null)
            {
                throw new InvalidDataException("activate is a required property for InlineObject7 and cannot be null");
            }
            else
            {
                this.Activate = activate;
            }

            this.Code = code;
        }
        
        /// <summary>
        /// Use &#x60;true&#x60; to activate, &#x60;false&#x60; to deactivate
        /// </summary>
        /// <value>Use &#x60;true&#x60; to activate, &#x60;false&#x60; to deactivate</value>
        [DataMember(Name="activate", EmitDefaultValue=false)]
        public bool Activate { get; set; }

        /// <summary>
        /// The code produced by your MFA client. Required if &#x60;activate&#x60; is true
        /// </summary>
        /// <value>The code produced by your MFA client. Required if &#x60;activate&#x60; is true</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineObject7 {\n");
            sb.Append("  Activate: ").Append(Activate).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
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
            return this.Equals(input as InlineObject7);
        }

        /// <summary>
        /// Returns true if InlineObject7 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineObject7 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineObject7 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Activate == input.Activate ||
                    this.Activate.Equals(input.Activate)
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
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
                hashCode = hashCode * 59 + this.Activate.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
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
