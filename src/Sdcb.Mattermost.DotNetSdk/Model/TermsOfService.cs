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
    /// TermsOfService
    /// </summary>
    [DataContract]
    public partial class TermsOfService :  IEquatable<TermsOfService>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TermsOfService" /> class.
        /// </summary>
        /// <param name="id">The unique identifier of the terms of service..</param>
        /// <param name="createAt">The time at which the terms of service was created..</param>
        /// <param name="userId">The unique identifier of the user who created these terms of service..</param>
        /// <param name="text">The text of terms of service. Supports Markdown..</param>
        public TermsOfService(string id = default(string), long createAt = default(long), string userId = default(string), string text = default(string))
        {
            this.Id = id;
            this.CreateAt = createAt;
            this.UserId = userId;
            this.Text = text;
        }
        
        /// <summary>
        /// The unique identifier of the terms of service.
        /// </summary>
        /// <value>The unique identifier of the terms of service.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The time at which the terms of service was created.
        /// </summary>
        /// <value>The time at which the terms of service was created.</value>
        [DataMember(Name="create_at", EmitDefaultValue=false)]
        public long CreateAt { get; set; }

        /// <summary>
        /// The unique identifier of the user who created these terms of service.
        /// </summary>
        /// <value>The unique identifier of the user who created these terms of service.</value>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public string UserId { get; set; }

        /// <summary>
        /// The text of terms of service. Supports Markdown.
        /// </summary>
        /// <value>The text of terms of service. Supports Markdown.</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TermsOfService {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreateAt: ").Append(CreateAt).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
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
            return this.Equals(input as TermsOfService);
        }

        /// <summary>
        /// Returns true if TermsOfService instances are equal
        /// </summary>
        /// <param name="input">Instance of TermsOfService to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TermsOfService input)
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
                    this.CreateAt == input.CreateAt ||
                    this.CreateAt.Equals(input.CreateAt)
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
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
                hashCode = hashCode * 59 + this.CreateAt.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
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