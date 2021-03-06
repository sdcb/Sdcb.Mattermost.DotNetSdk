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
    /// InlineObject51
    /// </summary>
    [DataContract]
    public partial class InlineObject51 :  IEquatable<InlineObject51>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject51" /> class.
        /// </summary>
        [JsonConstructor]
        protected InlineObject51() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject51" /> class.
        /// </summary>
        /// <param name="teamId">The ID of the team that the webhook watchs (required).</param>
        /// <param name="channelId">The ID of a public channel that the webhook watchs.</param>
        /// <param name="description">The description for this outgoing webhook.</param>
        /// <param name="displayName">The display name for this outgoing webhook (required).</param>
        /// <param name="triggerWords">List of words for the webhook to trigger on (required).</param>
        /// <param name="triggerWhen">When to trigger the webhook, &#x60;0&#x60; when a trigger word is present at all and &#x60;1&#x60; if the message starts with a trigger word.</param>
        /// <param name="callbackUrls">The URLs to POST the payloads to when the webhook is triggered (required).</param>
        /// <param name="contentType">The format to POST the data in, either &#x60;application/json&#x60; or &#x60;application/x-www-form-urlencoded&#x60; (default to &quot;application/x-www-form-urlencoded&quot;).</param>
        public InlineObject51(string teamId = default(string), string channelId = default(string), string description = default(string), string displayName = default(string), List<string> triggerWords = default(List<string>), int triggerWhen = default(int), List<string> callbackUrls = default(List<string>), string contentType = "application/x-www-form-urlencoded")
        {
            // to ensure "teamId" is required (not null)
            if (teamId == null)
            {
                throw new InvalidDataException("teamId is a required property for InlineObject51 and cannot be null");
            }
            else
            {
                this.TeamId = teamId;
            }

            // to ensure "displayName" is required (not null)
            if (displayName == null)
            {
                throw new InvalidDataException("displayName is a required property for InlineObject51 and cannot be null");
            }
            else
            {
                this.DisplayName = displayName;
            }

            // to ensure "triggerWords" is required (not null)
            if (triggerWords == null)
            {
                throw new InvalidDataException("triggerWords is a required property for InlineObject51 and cannot be null");
            }
            else
            {
                this.TriggerWords = triggerWords;
            }

            // to ensure "callbackUrls" is required (not null)
            if (callbackUrls == null)
            {
                throw new InvalidDataException("callbackUrls is a required property for InlineObject51 and cannot be null");
            }
            else
            {
                this.CallbackUrls = callbackUrls;
            }

            this.ChannelId = channelId;
            this.Description = description;
            this.TriggerWhen = triggerWhen;
            // use default value if no "contentType" provided
            if (contentType == null)
            {
                this.ContentType = "application/x-www-form-urlencoded";
            }
            else
            {
                this.ContentType = contentType;
            }
        }
        
        /// <summary>
        /// The ID of the team that the webhook watchs
        /// </summary>
        /// <value>The ID of the team that the webhook watchs</value>
        [DataMember(Name="team_id", EmitDefaultValue=false)]
        public string TeamId { get; set; }

        /// <summary>
        /// The ID of a public channel that the webhook watchs
        /// </summary>
        /// <value>The ID of a public channel that the webhook watchs</value>
        [DataMember(Name="channel_id", EmitDefaultValue=false)]
        public string ChannelId { get; set; }

        /// <summary>
        /// The description for this outgoing webhook
        /// </summary>
        /// <value>The description for this outgoing webhook</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The display name for this outgoing webhook
        /// </summary>
        /// <value>The display name for this outgoing webhook</value>
        [DataMember(Name="display_name", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// List of words for the webhook to trigger on
        /// </summary>
        /// <value>List of words for the webhook to trigger on</value>
        [DataMember(Name="trigger_words", EmitDefaultValue=false)]
        public List<string> TriggerWords { get; set; }

        /// <summary>
        /// When to trigger the webhook, &#x60;0&#x60; when a trigger word is present at all and &#x60;1&#x60; if the message starts with a trigger word
        /// </summary>
        /// <value>When to trigger the webhook, &#x60;0&#x60; when a trigger word is present at all and &#x60;1&#x60; if the message starts with a trigger word</value>
        [DataMember(Name="trigger_when", EmitDefaultValue=false)]
        public int TriggerWhen { get; set; }

        /// <summary>
        /// The URLs to POST the payloads to when the webhook is triggered
        /// </summary>
        /// <value>The URLs to POST the payloads to when the webhook is triggered</value>
        [DataMember(Name="callback_urls", EmitDefaultValue=false)]
        public List<string> CallbackUrls { get; set; }

        /// <summary>
        /// The format to POST the data in, either &#x60;application/json&#x60; or &#x60;application/x-www-form-urlencoded&#x60;
        /// </summary>
        /// <value>The format to POST the data in, either &#x60;application/json&#x60; or &#x60;application/x-www-form-urlencoded&#x60;</value>
        [DataMember(Name="content_type", EmitDefaultValue=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineObject51 {\n");
            sb.Append("  TeamId: ").Append(TeamId).Append("\n");
            sb.Append("  ChannelId: ").Append(ChannelId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  TriggerWords: ").Append(TriggerWords).Append("\n");
            sb.Append("  TriggerWhen: ").Append(TriggerWhen).Append("\n");
            sb.Append("  CallbackUrls: ").Append(CallbackUrls).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
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
            return this.Equals(input as InlineObject51);
        }

        /// <summary>
        /// Returns true if InlineObject51 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineObject51 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineObject51 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TeamId == input.TeamId ||
                    (this.TeamId != null &&
                    this.TeamId.Equals(input.TeamId))
                ) && 
                (
                    this.ChannelId == input.ChannelId ||
                    (this.ChannelId != null &&
                    this.ChannelId.Equals(input.ChannelId))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.TriggerWords == input.TriggerWords ||
                    this.TriggerWords != null &&
                    input.TriggerWords != null &&
                    this.TriggerWords.SequenceEqual(input.TriggerWords)
                ) && 
                (
                    this.TriggerWhen == input.TriggerWhen ||
                    this.TriggerWhen.Equals(input.TriggerWhen)
                ) && 
                (
                    this.CallbackUrls == input.CallbackUrls ||
                    this.CallbackUrls != null &&
                    input.CallbackUrls != null &&
                    this.CallbackUrls.SequenceEqual(input.CallbackUrls)
                ) && 
                (
                    this.ContentType == input.ContentType ||
                    (this.ContentType != null &&
                    this.ContentType.Equals(input.ContentType))
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
                if (this.TeamId != null)
                    hashCode = hashCode * 59 + this.TeamId.GetHashCode();
                if (this.ChannelId != null)
                    hashCode = hashCode * 59 + this.ChannelId.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.TriggerWords != null)
                    hashCode = hashCode * 59 + this.TriggerWords.GetHashCode();
                hashCode = hashCode * 59 + this.TriggerWhen.GetHashCode();
                if (this.CallbackUrls != null)
                    hashCode = hashCode * 59 + this.CallbackUrls.GetHashCode();
                if (this.ContentType != null)
                    hashCode = hashCode * 59 + this.ContentType.GetHashCode();
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
