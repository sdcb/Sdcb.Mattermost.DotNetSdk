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
    /// InlineObject33
    /// </summary>
    [DataContract]
    public partial class InlineObject33 :  IEquatable<InlineObject33>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject33" /> class.
        /// </summary>
        [JsonConstructor]
        protected InlineObject33() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject33" /> class.
        /// </summary>
        /// <param name="id">The channel&#39;s id, not updatable (required).</param>
        /// <param name="name">The unique handle for the channel, will be present in the channel URL.</param>
        /// <param name="displayName">The non-unique UI name for the channel.</param>
        /// <param name="purpose">A short description of the purpose of the channel.</param>
        /// <param name="header">Markdown-formatted text to display in the header of the channel.</param>
        /// <param name="type">&#39;O&#39; for a public channel, &#39;P&#39; for a private channel.</param>
        public InlineObject33(string id = default(string), string name = default(string), string displayName = default(string), string purpose = default(string), string header = default(string), string type = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for InlineObject33 and cannot be null");
            }
            else
            {
                this.Id = id;
            }

            this.Name = name;
            this.DisplayName = displayName;
            this.Purpose = purpose;
            this.Header = header;
            this.Type = type;
        }
        
        /// <summary>
        /// The channel&#39;s id, not updatable
        /// </summary>
        /// <value>The channel&#39;s id, not updatable</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The unique handle for the channel, will be present in the channel URL
        /// </summary>
        /// <value>The unique handle for the channel, will be present in the channel URL</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The non-unique UI name for the channel
        /// </summary>
        /// <value>The non-unique UI name for the channel</value>
        [DataMember(Name="display_name", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// A short description of the purpose of the channel
        /// </summary>
        /// <value>A short description of the purpose of the channel</value>
        [DataMember(Name="purpose", EmitDefaultValue=false)]
        public string Purpose { get; set; }

        /// <summary>
        /// Markdown-formatted text to display in the header of the channel
        /// </summary>
        /// <value>Markdown-formatted text to display in the header of the channel</value>
        [DataMember(Name="header", EmitDefaultValue=false)]
        public string Header { get; set; }

        /// <summary>
        /// &#39;O&#39; for a public channel, &#39;P&#39; for a private channel
        /// </summary>
        /// <value>&#39;O&#39; for a public channel, &#39;P&#39; for a private channel</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineObject33 {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Purpose: ").Append(Purpose).Append("\n");
            sb.Append("  Header: ").Append(Header).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as InlineObject33);
        }

        /// <summary>
        /// Returns true if InlineObject33 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineObject33 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineObject33 input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Purpose == input.Purpose ||
                    (this.Purpose != null &&
                    this.Purpose.Equals(input.Purpose))
                ) && 
                (
                    this.Header == input.Header ||
                    (this.Header != null &&
                    this.Header.Equals(input.Header))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Purpose != null)
                    hashCode = hashCode * 59 + this.Purpose.GetHashCode();
                if (this.Header != null)
                    hashCode = hashCode * 59 + this.Header.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
