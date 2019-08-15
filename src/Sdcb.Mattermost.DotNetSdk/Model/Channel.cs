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
    /// Channel
    /// </summary>
    [DataContract]
    public partial class Channel :  IEquatable<Channel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Channel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="createAt">The time in milliseconds a channel was created.</param>
        /// <param name="updateAt">The time in milliseconds a channel was last updated.</param>
        /// <param name="deleteAt">The time in milliseconds a channel was deleted.</param>
        /// <param name="teamId">teamId.</param>
        /// <param name="type">type.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="name">name.</param>
        /// <param name="header">header.</param>
        /// <param name="purpose">purpose.</param>
        /// <param name="lastPostAt">The time in milliseconds of the last post of a channel.</param>
        /// <param name="totalMsgCount">totalMsgCount.</param>
        /// <param name="extraUpdateAt">Deprecated in Mattermost 5.0 release.</param>
        /// <param name="creatorId">creatorId.</param>
        public Channel(string id = default(string), long createAt = default(long), long updateAt = default(long), long deleteAt = default(long), string teamId = default(string), string type = default(string), string displayName = default(string), string name = default(string), string header = default(string), string purpose = default(string), int lastPostAt = default(int), int totalMsgCount = default(int), long extraUpdateAt = default(long), string creatorId = default(string))
        {
            this.Id = id;
            this.CreateAt = createAt;
            this.UpdateAt = updateAt;
            this.DeleteAt = deleteAt;
            this.TeamId = teamId;
            this.Type = type;
            this.DisplayName = displayName;
            this.Name = name;
            this.Header = header;
            this.Purpose = purpose;
            this.LastPostAt = lastPostAt;
            this.TotalMsgCount = totalMsgCount;
            this.ExtraUpdateAt = extraUpdateAt;
            this.CreatorId = creatorId;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The time in milliseconds a channel was created
        /// </summary>
        /// <value>The time in milliseconds a channel was created</value>
        [DataMember(Name="create_at", EmitDefaultValue=false)]
        public long CreateAt { get; set; }

        /// <summary>
        /// The time in milliseconds a channel was last updated
        /// </summary>
        /// <value>The time in milliseconds a channel was last updated</value>
        [DataMember(Name="update_at", EmitDefaultValue=false)]
        public long UpdateAt { get; set; }

        /// <summary>
        /// The time in milliseconds a channel was deleted
        /// </summary>
        /// <value>The time in milliseconds a channel was deleted</value>
        [DataMember(Name="delete_at", EmitDefaultValue=false)]
        public long DeleteAt { get; set; }

        /// <summary>
        /// Gets or Sets TeamId
        /// </summary>
        [DataMember(Name="team_id", EmitDefaultValue=false)]
        public string TeamId { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name="display_name", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Header
        /// </summary>
        [DataMember(Name="header", EmitDefaultValue=false)]
        public string Header { get; set; }

        /// <summary>
        /// Gets or Sets Purpose
        /// </summary>
        [DataMember(Name="purpose", EmitDefaultValue=false)]
        public string Purpose { get; set; }

        /// <summary>
        /// The time in milliseconds of the last post of a channel
        /// </summary>
        /// <value>The time in milliseconds of the last post of a channel</value>
        [DataMember(Name="last_post_at", EmitDefaultValue=false)]
        public int LastPostAt { get; set; }

        /// <summary>
        /// Gets or Sets TotalMsgCount
        /// </summary>
        [DataMember(Name="total_msg_count", EmitDefaultValue=false)]
        public int TotalMsgCount { get; set; }

        /// <summary>
        /// Deprecated in Mattermost 5.0 release
        /// </summary>
        /// <value>Deprecated in Mattermost 5.0 release</value>
        [DataMember(Name="extra_update_at", EmitDefaultValue=false)]
        public long ExtraUpdateAt { get; set; }

        /// <summary>
        /// Gets or Sets CreatorId
        /// </summary>
        [DataMember(Name="creator_id", EmitDefaultValue=false)]
        public string CreatorId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Channel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreateAt: ").Append(CreateAt).Append("\n");
            sb.Append("  UpdateAt: ").Append(UpdateAt).Append("\n");
            sb.Append("  DeleteAt: ").Append(DeleteAt).Append("\n");
            sb.Append("  TeamId: ").Append(TeamId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Header: ").Append(Header).Append("\n");
            sb.Append("  Purpose: ").Append(Purpose).Append("\n");
            sb.Append("  LastPostAt: ").Append(LastPostAt).Append("\n");
            sb.Append("  TotalMsgCount: ").Append(TotalMsgCount).Append("\n");
            sb.Append("  ExtraUpdateAt: ").Append(ExtraUpdateAt).Append("\n");
            sb.Append("  CreatorId: ").Append(CreatorId).Append("\n");
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
            return this.Equals(input as Channel);
        }

        /// <summary>
        /// Returns true if Channel instances are equal
        /// </summary>
        /// <param name="input">Instance of Channel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Channel input)
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
                    this.UpdateAt == input.UpdateAt ||
                    this.UpdateAt.Equals(input.UpdateAt)
                ) && 
                (
                    this.DeleteAt == input.DeleteAt ||
                    this.DeleteAt.Equals(input.DeleteAt)
                ) && 
                (
                    this.TeamId == input.TeamId ||
                    (this.TeamId != null &&
                    this.TeamId.Equals(input.TeamId))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Header == input.Header ||
                    (this.Header != null &&
                    this.Header.Equals(input.Header))
                ) && 
                (
                    this.Purpose == input.Purpose ||
                    (this.Purpose != null &&
                    this.Purpose.Equals(input.Purpose))
                ) && 
                (
                    this.LastPostAt == input.LastPostAt ||
                    this.LastPostAt.Equals(input.LastPostAt)
                ) && 
                (
                    this.TotalMsgCount == input.TotalMsgCount ||
                    this.TotalMsgCount.Equals(input.TotalMsgCount)
                ) && 
                (
                    this.ExtraUpdateAt == input.ExtraUpdateAt ||
                    this.ExtraUpdateAt.Equals(input.ExtraUpdateAt)
                ) && 
                (
                    this.CreatorId == input.CreatorId ||
                    (this.CreatorId != null &&
                    this.CreatorId.Equals(input.CreatorId))
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
                hashCode = hashCode * 59 + this.UpdateAt.GetHashCode();
                hashCode = hashCode * 59 + this.DeleteAt.GetHashCode();
                if (this.TeamId != null)
                    hashCode = hashCode * 59 + this.TeamId.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Header != null)
                    hashCode = hashCode * 59 + this.Header.GetHashCode();
                if (this.Purpose != null)
                    hashCode = hashCode * 59 + this.Purpose.GetHashCode();
                hashCode = hashCode * 59 + this.LastPostAt.GetHashCode();
                hashCode = hashCode * 59 + this.TotalMsgCount.GetHashCode();
                hashCode = hashCode * 59 + this.ExtraUpdateAt.GetHashCode();
                if (this.CreatorId != null)
                    hashCode = hashCode * 59 + this.CreatorId.GetHashCode();
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
