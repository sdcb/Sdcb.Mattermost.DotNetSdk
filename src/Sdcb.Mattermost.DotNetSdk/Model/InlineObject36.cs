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
    /// InlineObject36
    /// </summary>
    [DataContract]
    public partial class InlineObject36 :  IEquatable<InlineObject36>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject36" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InlineObject36() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject36" /> class.
        /// </summary>
        /// <param name="userId">The ID of user to add into the channel (required).</param>
        /// <param name="postRootId">The ID of root post where link to add channel member originates.</param>
        public InlineObject36(string userId = default(string), string postRootId = default(string))
        {
            // to ensure "userId" is required (not null)
            if (userId == null)
            {
                throw new InvalidDataException("userId is a required property for InlineObject36 and cannot be null");
            }
            else
            {
                this.UserId = userId;
            }

            this.PostRootId = postRootId;
        }
        
        /// <summary>
        /// The ID of user to add into the channel
        /// </summary>
        /// <value>The ID of user to add into the channel</value>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public string UserId { get; set; }

        /// <summary>
        /// The ID of root post where link to add channel member originates
        /// </summary>
        /// <value>The ID of root post where link to add channel member originates</value>
        [DataMember(Name="post_root_id", EmitDefaultValue=false)]
        public string PostRootId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineObject36 {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  PostRootId: ").Append(PostRootId).Append("\n");
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
            return this.Equals(input as InlineObject36);
        }

        /// <summary>
        /// Returns true if InlineObject36 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineObject36 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineObject36 input)
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
                    this.PostRootId == input.PostRootId ||
                    (this.PostRootId != null &&
                    this.PostRootId.Equals(input.PostRootId))
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
                if (this.PostRootId != null)
                    hashCode = hashCode * 59 + this.PostRootId.GetHashCode();
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