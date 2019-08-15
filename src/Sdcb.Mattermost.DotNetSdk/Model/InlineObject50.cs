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
    /// InlineObject50
    /// </summary>
    [DataContract]
    public partial class InlineObject50 :  IEquatable<InlineObject50>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject50" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InlineObject50() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject50" /> class.
        /// </summary>
        /// <param name="hookId">Incoming webhook GUID (required).</param>
        /// <param name="channelId">The ID of a public channel or private group that receives the webhook payloads. (required).</param>
        /// <param name="displayName">The display name for this incoming webhook (required).</param>
        /// <param name="description">The description for this incoming webhook (required).</param>
        /// <param name="username">The username this incoming webhook will post as..</param>
        /// <param name="iconUrl">The profile picture this incoming webhook will use when posting..</param>
        public InlineObject50(string hookId = default(string), string channelId = default(string), string displayName = default(string), string description = default(string), string username = default(string), string iconUrl = default(string))
        {
            // to ensure "hookId" is required (not null)
            if (hookId == null)
            {
                throw new InvalidDataException("hookId is a required property for InlineObject50 and cannot be null");
            }
            else
            {
                this.HookId = hookId;
            }

            // to ensure "channelId" is required (not null)
            if (channelId == null)
            {
                throw new InvalidDataException("channelId is a required property for InlineObject50 and cannot be null");
            }
            else
            {
                this.ChannelId = channelId;
            }

            // to ensure "displayName" is required (not null)
            if (displayName == null)
            {
                throw new InvalidDataException("displayName is a required property for InlineObject50 and cannot be null");
            }
            else
            {
                this.DisplayName = displayName;
            }

            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new InvalidDataException("description is a required property for InlineObject50 and cannot be null");
            }
            else
            {
                this.Description = description;
            }

            this.Username = username;
            this.IconUrl = iconUrl;
        }
        
        /// <summary>
        /// Incoming webhook GUID
        /// </summary>
        /// <value>Incoming webhook GUID</value>
        [DataMember(Name="hook_id", EmitDefaultValue=false)]
        public string HookId { get; set; }

        /// <summary>
        /// The ID of a public channel or private group that receives the webhook payloads.
        /// </summary>
        /// <value>The ID of a public channel or private group that receives the webhook payloads.</value>
        [DataMember(Name="channel_id", EmitDefaultValue=false)]
        public string ChannelId { get; set; }

        /// <summary>
        /// The display name for this incoming webhook
        /// </summary>
        /// <value>The display name for this incoming webhook</value>
        [DataMember(Name="display_name", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The description for this incoming webhook
        /// </summary>
        /// <value>The description for this incoming webhook</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The username this incoming webhook will post as.
        /// </summary>
        /// <value>The username this incoming webhook will post as.</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// The profile picture this incoming webhook will use when posting.
        /// </summary>
        /// <value>The profile picture this incoming webhook will use when posting.</value>
        [DataMember(Name="icon_url", EmitDefaultValue=false)]
        public string IconUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineObject50 {\n");
            sb.Append("  HookId: ").Append(HookId).Append("\n");
            sb.Append("  ChannelId: ").Append(ChannelId).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  IconUrl: ").Append(IconUrl).Append("\n");
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
            return this.Equals(input as InlineObject50);
        }

        /// <summary>
        /// Returns true if InlineObject50 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineObject50 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineObject50 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HookId == input.HookId ||
                    (this.HookId != null &&
                    this.HookId.Equals(input.HookId))
                ) && 
                (
                    this.ChannelId == input.ChannelId ||
                    (this.ChannelId != null &&
                    this.ChannelId.Equals(input.ChannelId))
                ) && 
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
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.IconUrl == input.IconUrl ||
                    (this.IconUrl != null &&
                    this.IconUrl.Equals(input.IconUrl))
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
                if (this.HookId != null)
                    hashCode = hashCode * 59 + this.HookId.GetHashCode();
                if (this.ChannelId != null)
                    hashCode = hashCode * 59 + this.ChannelId.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.IconUrl != null)
                    hashCode = hashCode * 59 + this.IconUrl.GetHashCode();
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