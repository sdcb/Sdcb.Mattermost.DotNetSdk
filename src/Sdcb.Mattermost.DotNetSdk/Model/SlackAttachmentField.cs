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
    /// SlackAttachmentField
    /// </summary>
    [DataContract]
    public partial class SlackAttachmentField :  IEquatable<SlackAttachmentField>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SlackAttachmentField" /> class.
        /// </summary>
        /// <param name="title">title.</param>
        /// <param name="value">The value of the attachment, set as string but capable with golang interface.</param>
        /// <param name="_short">_short.</param>
        public SlackAttachmentField(string title = default(string), string value = default(string), bool _short = default(bool))
        {
            this.Title = title;
            this.Value = value;
            this.Short = _short;
        }
        
        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="Title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// The value of the attachment, set as string but capable with golang interface
        /// </summary>
        /// <value>The value of the attachment, set as string but capable with golang interface</value>
        [DataMember(Name="Value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Gets or Sets Short
        /// </summary>
        [DataMember(Name="Short", EmitDefaultValue=false)]
        public bool Short { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SlackAttachmentField {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Short: ").Append(Short).Append("\n");
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
            return this.Equals(input as SlackAttachmentField);
        }

        /// <summary>
        /// Returns true if SlackAttachmentField instances are equal
        /// </summary>
        /// <param name="input">Instance of SlackAttachmentField to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SlackAttachmentField input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Short == input.Short ||
                    this.Short.Equals(input.Short)
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
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                hashCode = hashCode * 59 + this.Short.GetHashCode();
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
