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
    /// InlineObject44
    /// </summary>
    [DataContract]
    public partial class InlineObject44 :  IEquatable<InlineObject44>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject44" /> class.
        /// </summary>
        /// <param name="isPinned">Set to &#x60;true&#x60; to pin the post to the channel it is in.</param>
        /// <param name="message">The message text of the post.</param>
        /// <param name="fileIds">The list of files attached to this post.</param>
        /// <param name="hasReactions">Set to &#x60;true&#x60; if the post has reactions to it.</param>
        /// <param name="props">A general JSON property bag to attach to the post.</param>
        public InlineObject44(bool isPinned = default(bool), string message = default(string), List<string> fileIds = default(List<string>), bool hasReactions = default(bool), string props = default(string))
        {
            this.IsPinned = isPinned;
            this.Message = message;
            this.FileIds = fileIds;
            this.HasReactions = hasReactions;
            this.Props = props;
        }
        
        /// <summary>
        /// Set to &#x60;true&#x60; to pin the post to the channel it is in
        /// </summary>
        /// <value>Set to &#x60;true&#x60; to pin the post to the channel it is in</value>
        [DataMember(Name="is_pinned", EmitDefaultValue=false)]
        public bool IsPinned { get; set; }

        /// <summary>
        /// The message text of the post
        /// </summary>
        /// <value>The message text of the post</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// The list of files attached to this post
        /// </summary>
        /// <value>The list of files attached to this post</value>
        [DataMember(Name="file_ids", EmitDefaultValue=false)]
        public List<string> FileIds { get; set; }

        /// <summary>
        /// Set to &#x60;true&#x60; if the post has reactions to it
        /// </summary>
        /// <value>Set to &#x60;true&#x60; if the post has reactions to it</value>
        [DataMember(Name="has_reactions", EmitDefaultValue=false)]
        public bool HasReactions { get; set; }

        /// <summary>
        /// A general JSON property bag to attach to the post
        /// </summary>
        /// <value>A general JSON property bag to attach to the post</value>
        [DataMember(Name="props", EmitDefaultValue=false)]
        public string Props { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineObject44 {\n");
            sb.Append("  IsPinned: ").Append(IsPinned).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  FileIds: ").Append(FileIds).Append("\n");
            sb.Append("  HasReactions: ").Append(HasReactions).Append("\n");
            sb.Append("  Props: ").Append(Props).Append("\n");
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
            return this.Equals(input as InlineObject44);
        }

        /// <summary>
        /// Returns true if InlineObject44 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineObject44 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineObject44 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsPinned == input.IsPinned ||
                    this.IsPinned.Equals(input.IsPinned)
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.FileIds == input.FileIds ||
                    this.FileIds != null &&
                    input.FileIds != null &&
                    this.FileIds.SequenceEqual(input.FileIds)
                ) && 
                (
                    this.HasReactions == input.HasReactions ||
                    this.HasReactions.Equals(input.HasReactions)
                ) && 
                (
                    this.Props == input.Props ||
                    (this.Props != null &&
                    this.Props.Equals(input.Props))
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
                hashCode = hashCode * 59 + this.IsPinned.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.FileIds != null)
                    hashCode = hashCode * 59 + this.FileIds.GetHashCode();
                hashCode = hashCode * 59 + this.HasReactions.GetHashCode();
                if (this.Props != null)
                    hashCode = hashCode * 59 + this.Props.GetHashCode();
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
