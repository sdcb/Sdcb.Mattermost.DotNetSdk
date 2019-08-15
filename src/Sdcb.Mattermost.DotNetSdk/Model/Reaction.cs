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
    /// Reaction
    /// </summary>
    [DataContract]
    public partial class Reaction :  IEquatable<Reaction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Reaction" /> class.
        /// </summary>
        /// <param name="userId">The ID of the user that made this reaction.</param>
        /// <param name="postId">The ID of the post to which this reaction was made.</param>
        /// <param name="emojiName">The name of the emoji that was used for this reaction.</param>
        /// <param name="createAt">The time in milliseconds this reaction was made.</param>
        public Reaction(string userId = default(string), string postId = default(string), string emojiName = default(string), long createAt = default(long))
        {
            this.UserId = userId;
            this.PostId = postId;
            this.EmojiName = emojiName;
            this.CreateAt = createAt;
        }
        
        /// <summary>
        /// The ID of the user that made this reaction
        /// </summary>
        /// <value>The ID of the user that made this reaction</value>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public string UserId { get; set; }

        /// <summary>
        /// The ID of the post to which this reaction was made
        /// </summary>
        /// <value>The ID of the post to which this reaction was made</value>
        [DataMember(Name="post_id", EmitDefaultValue=false)]
        public string PostId { get; set; }

        /// <summary>
        /// The name of the emoji that was used for this reaction
        /// </summary>
        /// <value>The name of the emoji that was used for this reaction</value>
        [DataMember(Name="emoji_name", EmitDefaultValue=false)]
        public string EmojiName { get; set; }

        /// <summary>
        /// The time in milliseconds this reaction was made
        /// </summary>
        /// <value>The time in milliseconds this reaction was made</value>
        [DataMember(Name="create_at", EmitDefaultValue=false)]
        public long CreateAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Reaction {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  PostId: ").Append(PostId).Append("\n");
            sb.Append("  EmojiName: ").Append(EmojiName).Append("\n");
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
            return this.Equals(input as Reaction);
        }

        /// <summary>
        /// Returns true if Reaction instances are equal
        /// </summary>
        /// <param name="input">Instance of Reaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Reaction input)
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
                    this.PostId == input.PostId ||
                    (this.PostId != null &&
                    this.PostId.Equals(input.PostId))
                ) && 
                (
                    this.EmojiName == input.EmojiName ||
                    (this.EmojiName != null &&
                    this.EmojiName.Equals(input.EmojiName))
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
                if (this.PostId != null)
                    hashCode = hashCode * 59 + this.PostId.GetHashCode();
                if (this.EmojiName != null)
                    hashCode = hashCode * 59 + this.EmojiName.GetHashCode();
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