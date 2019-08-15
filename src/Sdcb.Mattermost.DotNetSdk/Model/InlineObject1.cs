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
    /// InlineObject1
    /// </summary>
    [DataContract]
    public partial class InlineObject1 :  IEquatable<InlineObject1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject1" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InlineObject1() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject1" /> class.
        /// </summary>
        /// <param name="term">The term to match against username, full name, nickname and email (required).</param>
        /// <param name="teamId">If provided, only search users on this team.</param>
        /// <param name="notInTeamId">If provided, only search users not on this team.</param>
        /// <param name="inChannelId">If provided, only search users in this channel.</param>
        /// <param name="notInChannelId">If provided, only search users not in this channel. Must specifiy &#x60;team_id&#x60; when using this option.</param>
        /// <param name="groupConstrained">When used with &#x60;not_in_channel_id&#x60; or &#x60;not_in_team_id&#x60;, returns only the users that are allowed to join the channel or team based on its group constrains..</param>
        /// <param name="allowInactive">When &#x60;true&#x60;, include deactivated users in the results.</param>
        /// <param name="withoutTeam">Set this to &#x60;true&#x60; if you would like to search for users that are not on a team. This option takes precendence over &#x60;team_id&#x60;, &#x60;in_channel_id&#x60;, and &#x60;not_in_channel_id&#x60;..</param>
        /// <param name="limit">The maximum number of users to return in the results  __Available as of server version 5.6. Defaults to &#x60;100&#x60; if not provided or on an earlier server version.__ .</param>
        public InlineObject1(string term = default(string), string teamId = default(string), string notInTeamId = default(string), string inChannelId = default(string), string notInChannelId = default(string), bool groupConstrained = default(bool), bool allowInactive = default(bool), bool withoutTeam = default(bool), int limit = default(int))
        {
            // to ensure "term" is required (not null)
            if (term == null)
            {
                throw new InvalidDataException("term is a required property for InlineObject1 and cannot be null");
            }
            else
            {
                this.Term = term;
            }

            this.TeamId = teamId;
            this.NotInTeamId = notInTeamId;
            this.InChannelId = inChannelId;
            this.NotInChannelId = notInChannelId;
            this.GroupConstrained = groupConstrained;
            this.AllowInactive = allowInactive;
            this.WithoutTeam = withoutTeam;
            this.Limit = limit;
        }
        
        /// <summary>
        /// The term to match against username, full name, nickname and email
        /// </summary>
        /// <value>The term to match against username, full name, nickname and email</value>
        [DataMember(Name="term", EmitDefaultValue=false)]
        public string Term { get; set; }

        /// <summary>
        /// If provided, only search users on this team
        /// </summary>
        /// <value>If provided, only search users on this team</value>
        [DataMember(Name="team_id", EmitDefaultValue=false)]
        public string TeamId { get; set; }

        /// <summary>
        /// If provided, only search users not on this team
        /// </summary>
        /// <value>If provided, only search users not on this team</value>
        [DataMember(Name="not_in_team_id", EmitDefaultValue=false)]
        public string NotInTeamId { get; set; }

        /// <summary>
        /// If provided, only search users in this channel
        /// </summary>
        /// <value>If provided, only search users in this channel</value>
        [DataMember(Name="in_channel_id", EmitDefaultValue=false)]
        public string InChannelId { get; set; }

        /// <summary>
        /// If provided, only search users not in this channel. Must specifiy &#x60;team_id&#x60; when using this option
        /// </summary>
        /// <value>If provided, only search users not in this channel. Must specifiy &#x60;team_id&#x60; when using this option</value>
        [DataMember(Name="not_in_channel_id", EmitDefaultValue=false)]
        public string NotInChannelId { get; set; }

        /// <summary>
        /// When used with &#x60;not_in_channel_id&#x60; or &#x60;not_in_team_id&#x60;, returns only the users that are allowed to join the channel or team based on its group constrains.
        /// </summary>
        /// <value>When used with &#x60;not_in_channel_id&#x60; or &#x60;not_in_team_id&#x60;, returns only the users that are allowed to join the channel or team based on its group constrains.</value>
        [DataMember(Name="group_constrained", EmitDefaultValue=false)]
        public bool GroupConstrained { get; set; }

        /// <summary>
        /// When &#x60;true&#x60;, include deactivated users in the results
        /// </summary>
        /// <value>When &#x60;true&#x60;, include deactivated users in the results</value>
        [DataMember(Name="allow_inactive", EmitDefaultValue=false)]
        public bool AllowInactive { get; set; }

        /// <summary>
        /// Set this to &#x60;true&#x60; if you would like to search for users that are not on a team. This option takes precendence over &#x60;team_id&#x60;, &#x60;in_channel_id&#x60;, and &#x60;not_in_channel_id&#x60;.
        /// </summary>
        /// <value>Set this to &#x60;true&#x60; if you would like to search for users that are not on a team. This option takes precendence over &#x60;team_id&#x60;, &#x60;in_channel_id&#x60;, and &#x60;not_in_channel_id&#x60;.</value>
        [DataMember(Name="without_team", EmitDefaultValue=false)]
        public bool WithoutTeam { get; set; }

        /// <summary>
        /// The maximum number of users to return in the results  __Available as of server version 5.6. Defaults to &#x60;100&#x60; if not provided or on an earlier server version.__ 
        /// </summary>
        /// <value>The maximum number of users to return in the results  __Available as of server version 5.6. Defaults to &#x60;100&#x60; if not provided or on an earlier server version.__ </value>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public int Limit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineObject1 {\n");
            sb.Append("  Term: ").Append(Term).Append("\n");
            sb.Append("  TeamId: ").Append(TeamId).Append("\n");
            sb.Append("  NotInTeamId: ").Append(NotInTeamId).Append("\n");
            sb.Append("  InChannelId: ").Append(InChannelId).Append("\n");
            sb.Append("  NotInChannelId: ").Append(NotInChannelId).Append("\n");
            sb.Append("  GroupConstrained: ").Append(GroupConstrained).Append("\n");
            sb.Append("  AllowInactive: ").Append(AllowInactive).Append("\n");
            sb.Append("  WithoutTeam: ").Append(WithoutTeam).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
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
            return this.Equals(input as InlineObject1);
        }

        /// <summary>
        /// Returns true if InlineObject1 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineObject1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineObject1 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Term == input.Term ||
                    (this.Term != null &&
                    this.Term.Equals(input.Term))
                ) && 
                (
                    this.TeamId == input.TeamId ||
                    (this.TeamId != null &&
                    this.TeamId.Equals(input.TeamId))
                ) && 
                (
                    this.NotInTeamId == input.NotInTeamId ||
                    (this.NotInTeamId != null &&
                    this.NotInTeamId.Equals(input.NotInTeamId))
                ) && 
                (
                    this.InChannelId == input.InChannelId ||
                    (this.InChannelId != null &&
                    this.InChannelId.Equals(input.InChannelId))
                ) && 
                (
                    this.NotInChannelId == input.NotInChannelId ||
                    (this.NotInChannelId != null &&
                    this.NotInChannelId.Equals(input.NotInChannelId))
                ) && 
                (
                    this.GroupConstrained == input.GroupConstrained ||
                    this.GroupConstrained.Equals(input.GroupConstrained)
                ) && 
                (
                    this.AllowInactive == input.AllowInactive ||
                    this.AllowInactive.Equals(input.AllowInactive)
                ) && 
                (
                    this.WithoutTeam == input.WithoutTeam ||
                    this.WithoutTeam.Equals(input.WithoutTeam)
                ) && 
                (
                    this.Limit == input.Limit ||
                    this.Limit.Equals(input.Limit)
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
                if (this.Term != null)
                    hashCode = hashCode * 59 + this.Term.GetHashCode();
                if (this.TeamId != null)
                    hashCode = hashCode * 59 + this.TeamId.GetHashCode();
                if (this.NotInTeamId != null)
                    hashCode = hashCode * 59 + this.NotInTeamId.GetHashCode();
                if (this.InChannelId != null)
                    hashCode = hashCode * 59 + this.InChannelId.GetHashCode();
                if (this.NotInChannelId != null)
                    hashCode = hashCode * 59 + this.NotInChannelId.GetHashCode();
                hashCode = hashCode * 59 + this.GroupConstrained.GetHashCode();
                hashCode = hashCode * 59 + this.AllowInactive.GetHashCode();
                hashCode = hashCode * 59 + this.WithoutTeam.GetHashCode();
                hashCode = hashCode * 59 + this.Limit.GetHashCode();
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