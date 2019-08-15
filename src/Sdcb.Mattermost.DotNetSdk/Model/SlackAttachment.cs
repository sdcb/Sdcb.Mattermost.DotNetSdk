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
    /// SlackAttachment
    /// </summary>
    [DataContract]
    public partial class SlackAttachment :  IEquatable<SlackAttachment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SlackAttachment" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="fallback">fallback.</param>
        /// <param name="color">color.</param>
        /// <param name="pretext">pretext.</param>
        /// <param name="authorName">authorName.</param>
        /// <param name="authorLink">authorLink.</param>
        /// <param name="authorIcon">authorIcon.</param>
        /// <param name="title">title.</param>
        /// <param name="titleLink">titleLink.</param>
        /// <param name="text">text.</param>
        /// <param name="fields">fields.</param>
        /// <param name="imageURL">imageURL.</param>
        /// <param name="thumbURL">thumbURL.</param>
        /// <param name="footer">footer.</param>
        /// <param name="footerIcon">footerIcon.</param>
        /// <param name="timestamp">The timestamp of the slack attachment, either type of string or integer.</param>
        public SlackAttachment(string id = default(string), string fallback = default(string), string color = default(string), string pretext = default(string), string authorName = default(string), string authorLink = default(string), string authorIcon = default(string), string title = default(string), string titleLink = default(string), string text = default(string), List<SlackAttachmentField> fields = default(List<SlackAttachmentField>), string imageURL = default(string), string thumbURL = default(string), string footer = default(string), string footerIcon = default(string), string timestamp = default(string))
        {
            this.Id = id;
            this.Fallback = fallback;
            this.Color = color;
            this.Pretext = pretext;
            this.AuthorName = authorName;
            this.AuthorLink = authorLink;
            this.AuthorIcon = authorIcon;
            this.Title = title;
            this.TitleLink = titleLink;
            this.Text = text;
            this.Fields = fields;
            this.ImageURL = imageURL;
            this.ThumbURL = thumbURL;
            this.Footer = footer;
            this.FooterIcon = footerIcon;
            this.Timestamp = timestamp;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Fallback
        /// </summary>
        [DataMember(Name="Fallback", EmitDefaultValue=false)]
        public string Fallback { get; set; }

        /// <summary>
        /// Gets or Sets Color
        /// </summary>
        [DataMember(Name="Color", EmitDefaultValue=false)]
        public string Color { get; set; }

        /// <summary>
        /// Gets or Sets Pretext
        /// </summary>
        [DataMember(Name="Pretext", EmitDefaultValue=false)]
        public string Pretext { get; set; }

        /// <summary>
        /// Gets or Sets AuthorName
        /// </summary>
        [DataMember(Name="AuthorName", EmitDefaultValue=false)]
        public string AuthorName { get; set; }

        /// <summary>
        /// Gets or Sets AuthorLink
        /// </summary>
        [DataMember(Name="AuthorLink", EmitDefaultValue=false)]
        public string AuthorLink { get; set; }

        /// <summary>
        /// Gets or Sets AuthorIcon
        /// </summary>
        [DataMember(Name="AuthorIcon", EmitDefaultValue=false)]
        public string AuthorIcon { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="Title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets TitleLink
        /// </summary>
        [DataMember(Name="TitleLink", EmitDefaultValue=false)]
        public string TitleLink { get; set; }

        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name="Text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// Gets or Sets Fields
        /// </summary>
        [DataMember(Name="Fields", EmitDefaultValue=false)]
        public List<SlackAttachmentField> Fields { get; set; }

        /// <summary>
        /// Gets or Sets ImageURL
        /// </summary>
        [DataMember(Name="ImageURL", EmitDefaultValue=false)]
        public string ImageURL { get; set; }

        /// <summary>
        /// Gets or Sets ThumbURL
        /// </summary>
        [DataMember(Name="ThumbURL", EmitDefaultValue=false)]
        public string ThumbURL { get; set; }

        /// <summary>
        /// Gets or Sets Footer
        /// </summary>
        [DataMember(Name="Footer", EmitDefaultValue=false)]
        public string Footer { get; set; }

        /// <summary>
        /// Gets or Sets FooterIcon
        /// </summary>
        [DataMember(Name="FooterIcon", EmitDefaultValue=false)]
        public string FooterIcon { get; set; }

        /// <summary>
        /// The timestamp of the slack attachment, either type of string or integer
        /// </summary>
        /// <value>The timestamp of the slack attachment, either type of string or integer</value>
        [DataMember(Name="Timestamp", EmitDefaultValue=false)]
        public string Timestamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SlackAttachment {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Fallback: ").Append(Fallback).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  Pretext: ").Append(Pretext).Append("\n");
            sb.Append("  AuthorName: ").Append(AuthorName).Append("\n");
            sb.Append("  AuthorLink: ").Append(AuthorLink).Append("\n");
            sb.Append("  AuthorIcon: ").Append(AuthorIcon).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  TitleLink: ").Append(TitleLink).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            sb.Append("  ImageURL: ").Append(ImageURL).Append("\n");
            sb.Append("  ThumbURL: ").Append(ThumbURL).Append("\n");
            sb.Append("  Footer: ").Append(Footer).Append("\n");
            sb.Append("  FooterIcon: ").Append(FooterIcon).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
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
            return this.Equals(input as SlackAttachment);
        }

        /// <summary>
        /// Returns true if SlackAttachment instances are equal
        /// </summary>
        /// <param name="input">Instance of SlackAttachment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SlackAttachment input)
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
                    this.Fallback == input.Fallback ||
                    (this.Fallback != null &&
                    this.Fallback.Equals(input.Fallback))
                ) && 
                (
                    this.Color == input.Color ||
                    (this.Color != null &&
                    this.Color.Equals(input.Color))
                ) && 
                (
                    this.Pretext == input.Pretext ||
                    (this.Pretext != null &&
                    this.Pretext.Equals(input.Pretext))
                ) && 
                (
                    this.AuthorName == input.AuthorName ||
                    (this.AuthorName != null &&
                    this.AuthorName.Equals(input.AuthorName))
                ) && 
                (
                    this.AuthorLink == input.AuthorLink ||
                    (this.AuthorLink != null &&
                    this.AuthorLink.Equals(input.AuthorLink))
                ) && 
                (
                    this.AuthorIcon == input.AuthorIcon ||
                    (this.AuthorIcon != null &&
                    this.AuthorIcon.Equals(input.AuthorIcon))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.TitleLink == input.TitleLink ||
                    (this.TitleLink != null &&
                    this.TitleLink.Equals(input.TitleLink))
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
                (
                    this.Fields == input.Fields ||
                    this.Fields != null &&
                    input.Fields != null &&
                    this.Fields.SequenceEqual(input.Fields)
                ) && 
                (
                    this.ImageURL == input.ImageURL ||
                    (this.ImageURL != null &&
                    this.ImageURL.Equals(input.ImageURL))
                ) && 
                (
                    this.ThumbURL == input.ThumbURL ||
                    (this.ThumbURL != null &&
                    this.ThumbURL.Equals(input.ThumbURL))
                ) && 
                (
                    this.Footer == input.Footer ||
                    (this.Footer != null &&
                    this.Footer.Equals(input.Footer))
                ) && 
                (
                    this.FooterIcon == input.FooterIcon ||
                    (this.FooterIcon != null &&
                    this.FooterIcon.Equals(input.FooterIcon))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
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
                if (this.Fallback != null)
                    hashCode = hashCode * 59 + this.Fallback.GetHashCode();
                if (this.Color != null)
                    hashCode = hashCode * 59 + this.Color.GetHashCode();
                if (this.Pretext != null)
                    hashCode = hashCode * 59 + this.Pretext.GetHashCode();
                if (this.AuthorName != null)
                    hashCode = hashCode * 59 + this.AuthorName.GetHashCode();
                if (this.AuthorLink != null)
                    hashCode = hashCode * 59 + this.AuthorLink.GetHashCode();
                if (this.AuthorIcon != null)
                    hashCode = hashCode * 59 + this.AuthorIcon.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.TitleLink != null)
                    hashCode = hashCode * 59 + this.TitleLink.GetHashCode();
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
                if (this.Fields != null)
                    hashCode = hashCode * 59 + this.Fields.GetHashCode();
                if (this.ImageURL != null)
                    hashCode = hashCode * 59 + this.ImageURL.GetHashCode();
                if (this.ThumbURL != null)
                    hashCode = hashCode * 59 + this.ThumbURL.GetHashCode();
                if (this.Footer != null)
                    hashCode = hashCode * 59 + this.Footer.GetHashCode();
                if (this.FooterIcon != null)
                    hashCode = hashCode * 59 + this.FooterIcon.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
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
