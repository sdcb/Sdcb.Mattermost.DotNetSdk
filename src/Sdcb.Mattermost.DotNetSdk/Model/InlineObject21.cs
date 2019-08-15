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
    /// InlineObject21
    /// </summary>
    [DataContract]
    public partial class InlineObject21 :  IEquatable<InlineObject21>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject21" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InlineObject21() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject21" /> class.
        /// </summary>
        /// <param name="serviceTermsId">terms of service ID on which the user is acting on (required).</param>
        /// <param name="accepted">true or false, indicates whether the user accepted or rejected the terms of service. (required).</param>
        public InlineObject21(string serviceTermsId = default(string), string accepted = default(string))
        {
            // to ensure "serviceTermsId" is required (not null)
            if (serviceTermsId == null)
            {
                throw new InvalidDataException("serviceTermsId is a required property for InlineObject21 and cannot be null");
            }
            else
            {
                this.ServiceTermsId = serviceTermsId;
            }

            // to ensure "accepted" is required (not null)
            if (accepted == null)
            {
                throw new InvalidDataException("accepted is a required property for InlineObject21 and cannot be null");
            }
            else
            {
                this.Accepted = accepted;
            }

        }
        
        /// <summary>
        /// terms of service ID on which the user is acting on
        /// </summary>
        /// <value>terms of service ID on which the user is acting on</value>
        [DataMember(Name="serviceTermsId", EmitDefaultValue=false)]
        public string ServiceTermsId { get; set; }

        /// <summary>
        /// true or false, indicates whether the user accepted or rejected the terms of service.
        /// </summary>
        /// <value>true or false, indicates whether the user accepted or rejected the terms of service.</value>
        [DataMember(Name="accepted", EmitDefaultValue=false)]
        public string Accepted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineObject21 {\n");
            sb.Append("  ServiceTermsId: ").Append(ServiceTermsId).Append("\n");
            sb.Append("  Accepted: ").Append(Accepted).Append("\n");
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
            return this.Equals(input as InlineObject21);
        }

        /// <summary>
        /// Returns true if InlineObject21 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineObject21 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineObject21 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ServiceTermsId == input.ServiceTermsId ||
                    (this.ServiceTermsId != null &&
                    this.ServiceTermsId.Equals(input.ServiceTermsId))
                ) && 
                (
                    this.Accepted == input.Accepted ||
                    (this.Accepted != null &&
                    this.Accepted.Equals(input.Accepted))
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
                if (this.ServiceTermsId != null)
                    hashCode = hashCode * 59 + this.ServiceTermsId.GetHashCode();
                if (this.Accepted != null)
                    hashCode = hashCode * 59 + this.Accepted.GetHashCode();
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