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
    /// ChannelNotifyProps
    /// </summary>
    [DataContract]
    public partial class ChannelNotifyProps :  IEquatable<ChannelNotifyProps>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelNotifyProps" /> class.
        /// </summary>
        /// <param name="email">Set to \&quot;true\&quot; to enable email notifications, \&quot;false\&quot; to disable, or \&quot;default\&quot; to use the global user notification setting..</param>
        /// <param name="push">Set to \&quot;all\&quot; to receive push notifications for all activity, \&quot;mention\&quot; for mentions and direct messages only, \&quot;none\&quot; to disable, or \&quot;default\&quot; to use the global user notification setting..</param>
        /// <param name="desktop">Set to \&quot;all\&quot; to receive desktop notifications for all activity, \&quot;mention\&quot; for mentions and direct messages only, \&quot;none\&quot; to disable, or \&quot;default\&quot; to use the global user notification setting..</param>
        /// <param name="markUnread">Set to \&quot;all\&quot; to mark the channel unread for any new message, \&quot;mention\&quot; to mark unread for new mentions only. Defaults to \&quot;all\&quot;..</param>
        public ChannelNotifyProps(string email = default(string), string push = default(string), string desktop = default(string), string markUnread = default(string))
        {
            this.Email = email;
            this.Push = push;
            this.Desktop = desktop;
            this.MarkUnread = markUnread;
        }
        
        /// <summary>
        /// Set to \&quot;true\&quot; to enable email notifications, \&quot;false\&quot; to disable, or \&quot;default\&quot; to use the global user notification setting.
        /// </summary>
        /// <value>Set to \&quot;true\&quot; to enable email notifications, \&quot;false\&quot; to disable, or \&quot;default\&quot; to use the global user notification setting.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Set to \&quot;all\&quot; to receive push notifications for all activity, \&quot;mention\&quot; for mentions and direct messages only, \&quot;none\&quot; to disable, or \&quot;default\&quot; to use the global user notification setting.
        /// </summary>
        /// <value>Set to \&quot;all\&quot; to receive push notifications for all activity, \&quot;mention\&quot; for mentions and direct messages only, \&quot;none\&quot; to disable, or \&quot;default\&quot; to use the global user notification setting.</value>
        [DataMember(Name="push", EmitDefaultValue=false)]
        public string Push { get; set; }

        /// <summary>
        /// Set to \&quot;all\&quot; to receive desktop notifications for all activity, \&quot;mention\&quot; for mentions and direct messages only, \&quot;none\&quot; to disable, or \&quot;default\&quot; to use the global user notification setting.
        /// </summary>
        /// <value>Set to \&quot;all\&quot; to receive desktop notifications for all activity, \&quot;mention\&quot; for mentions and direct messages only, \&quot;none\&quot; to disable, or \&quot;default\&quot; to use the global user notification setting.</value>
        [DataMember(Name="desktop", EmitDefaultValue=false)]
        public string Desktop { get; set; }

        /// <summary>
        /// Set to \&quot;all\&quot; to mark the channel unread for any new message, \&quot;mention\&quot; to mark unread for new mentions only. Defaults to \&quot;all\&quot;.
        /// </summary>
        /// <value>Set to \&quot;all\&quot; to mark the channel unread for any new message, \&quot;mention\&quot; to mark unread for new mentions only. Defaults to \&quot;all\&quot;.</value>
        [DataMember(Name="mark_unread", EmitDefaultValue=false)]
        public string MarkUnread { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChannelNotifyProps {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Push: ").Append(Push).Append("\n");
            sb.Append("  Desktop: ").Append(Desktop).Append("\n");
            sb.Append("  MarkUnread: ").Append(MarkUnread).Append("\n");
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
            return this.Equals(input as ChannelNotifyProps);
        }

        /// <summary>
        /// Returns true if ChannelNotifyProps instances are equal
        /// </summary>
        /// <param name="input">Instance of ChannelNotifyProps to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChannelNotifyProps input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Push == input.Push ||
                    (this.Push != null &&
                    this.Push.Equals(input.Push))
                ) && 
                (
                    this.Desktop == input.Desktop ||
                    (this.Desktop != null &&
                    this.Desktop.Equals(input.Desktop))
                ) && 
                (
                    this.MarkUnread == input.MarkUnread ||
                    (this.MarkUnread != null &&
                    this.MarkUnread.Equals(input.MarkUnread))
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
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Push != null)
                    hashCode = hashCode * 59 + this.Push.GetHashCode();
                if (this.Desktop != null)
                    hashCode = hashCode * 59 + this.Desktop.GetHashCode();
                if (this.MarkUnread != null)
                    hashCode = hashCode * 59 + this.MarkUnread.GetHashCode();
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
