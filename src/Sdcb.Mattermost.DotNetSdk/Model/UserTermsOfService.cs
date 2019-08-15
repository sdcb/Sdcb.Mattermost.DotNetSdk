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
    /// UserTermsOfService
    /// </summary>
    [DataContract]
    public partial class UserTermsOfService :  IEquatable<UserTermsOfService>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserTermsOfService" /> class.
        /// </summary>
        /// <param name="userId">The unique identifier of the user who performed this terms of service action..</param>
        /// <param name="termsOfServiceId">The unique identifier of the terms of service the action was performed on..</param>
        /// <param name="createAt">The time in milliseconds that this action was performed..</param>
        public UserTermsOfService(string userId = default(string), string termsOfServiceId = default(string), long createAt = default(long))
        {
            this.UserId = userId;
            this.TermsOfServiceId = termsOfServiceId;
            this.CreateAt = createAt;
        }
        
        /// <summary>
        /// The unique identifier of the user who performed this terms of service action.
        /// </summary>
        /// <value>The unique identifier of the user who performed this terms of service action.</value>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public string UserId { get; set; }

        /// <summary>
        /// The unique identifier of the terms of service the action was performed on.
        /// </summary>
        /// <value>The unique identifier of the terms of service the action was performed on.</value>
        [DataMember(Name="terms_of_service_id", EmitDefaultValue=false)]
        public string TermsOfServiceId { get; set; }

        /// <summary>
        /// The time in milliseconds that this action was performed.
        /// </summary>
        /// <value>The time in milliseconds that this action was performed.</value>
        [DataMember(Name="create_at", EmitDefaultValue=false)]
        public long CreateAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserTermsOfService {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  TermsOfServiceId: ").Append(TermsOfServiceId).Append("\n");
            sb.Append("  CreateAt: ").Append(CreateAt).Append("\n");
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
            return this.Equals(input as UserTermsOfService);
        }

        /// <summary>
        /// Returns true if UserTermsOfService instances are equal
        /// </summary>
        /// <param name="input">Instance of UserTermsOfService to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserTermsOfService input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.TermsOfServiceId == input.TermsOfServiceId ||
                    (this.TermsOfServiceId != null &&
                    this.TermsOfServiceId.Equals(input.TermsOfServiceId))
                ) && 
                (
                    this.CreateAt == input.CreateAt ||
                    this.CreateAt.Equals(input.CreateAt)
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
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.TermsOfServiceId != null)
                    hashCode = hashCode * 59 + this.TermsOfServiceId.GetHashCode();
                hashCode = hashCode * 59 + this.CreateAt.GetHashCode();
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