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
    /// InlineObject25
    /// </summary>
    [DataContract]
    public partial class InlineObject25 :  IEquatable<InlineObject25>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject25" /> class.
        /// </summary>
        /// <param name="displayName">displayName.</param>
        /// <param name="description">description.</param>
        /// <param name="companyName">companyName.</param>
        /// <param name="inviteId">inviteId.</param>
        /// <param name="allowOpenInvite">allowOpenInvite.</param>
        public InlineObject25(string displayName = default(string), string description = default(string), string companyName = default(string), string inviteId = default(string), bool allowOpenInvite = default(bool))
        {
            this.DisplayName = displayName;
            this.Description = description;
            this.CompanyName = companyName;
            this.InviteId = inviteId;
            this.AllowOpenInvite = allowOpenInvite;
        }
        
        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name="display_name", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets CompanyName
        /// </summary>
        [DataMember(Name="company_name", EmitDefaultValue=false)]
        public string CompanyName { get; set; }

        /// <summary>
        /// Gets or Sets InviteId
        /// </summary>
        [DataMember(Name="invite_id", EmitDefaultValue=false)]
        public string InviteId { get; set; }

        /// <summary>
        /// Gets or Sets AllowOpenInvite
        /// </summary>
        [DataMember(Name="allow_open_invite", EmitDefaultValue=false)]
        public bool AllowOpenInvite { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineObject25 {\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  InviteId: ").Append(InviteId).Append("\n");
            sb.Append("  AllowOpenInvite: ").Append(AllowOpenInvite).Append("\n");
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
            return this.Equals(input as InlineObject25);
        }

        /// <summary>
        /// Returns true if InlineObject25 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineObject25 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineObject25 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.CompanyName == input.CompanyName ||
                    (this.CompanyName != null &&
                    this.CompanyName.Equals(input.CompanyName))
                ) && 
                (
                    this.InviteId == input.InviteId ||
                    (this.InviteId != null &&
                    this.InviteId.Equals(input.InviteId))
                ) && 
                (
                    this.AllowOpenInvite == input.AllowOpenInvite ||
                    this.AllowOpenInvite.Equals(input.AllowOpenInvite)
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
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.CompanyName != null)
                    hashCode = hashCode * 59 + this.CompanyName.GetHashCode();
                if (this.InviteId != null)
                    hashCode = hashCode * 59 + this.InviteId.GetHashCode();
                hashCode = hashCode * 59 + this.AllowOpenInvite.GetHashCode();
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