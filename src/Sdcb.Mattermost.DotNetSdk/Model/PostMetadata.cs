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
    /// Additional information used to display a post.
    /// </summary>
    [DataContract]
    public partial class PostMetadata :  IEquatable<PostMetadata>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostMetadata" /> class.
        /// </summary>
        /// <param name="embeds">Information about content embedded in the post including OpenGraph previews, image link previews, and message attachments. This field will be null if the post does not contain embedded content. .</param>
        /// <param name="emojis">The custom emojis that appear in this point or have been used in reactions to this post. This field will be null if the post does not contain custom emojis. .</param>
        /// <param name="files">The FileInfo objects for any files attached to the post. This field will be null if the post does not have any file attachments. .</param>
        /// <param name="images">An object mapping the URL of an external image to an object containing the dimensions of that image. This field will be null if the post or its embedded content does not reference any external images. .</param>
        /// <param name="reactions">Any reactions made to this point. This field will be null if no reactions have been made to this post. .</param>
        public PostMetadata(List<PostMetadataEmbeds> embeds = default(List<PostMetadataEmbeds>), List<Emoji> emojis = default(List<Emoji>), List<FileInfo> files = default(List<FileInfo>), Object images = default(Object), List<Reaction> reactions = default(List<Reaction>))
        {
            this.Embeds = embeds;
            this.Emojis = emojis;
            this.Files = files;
            this.Images = images;
            this.Reactions = reactions;
        }
        
        /// <summary>
        /// Information about content embedded in the post including OpenGraph previews, image link previews, and message attachments. This field will be null if the post does not contain embedded content. 
        /// </summary>
        /// <value>Information about content embedded in the post including OpenGraph previews, image link previews, and message attachments. This field will be null if the post does not contain embedded content. </value>
        [DataMember(Name="embeds", EmitDefaultValue=false)]
        public List<PostMetadataEmbeds> Embeds { get; set; }

        /// <summary>
        /// The custom emojis that appear in this point or have been used in reactions to this post. This field will be null if the post does not contain custom emojis. 
        /// </summary>
        /// <value>The custom emojis that appear in this point or have been used in reactions to this post. This field will be null if the post does not contain custom emojis. </value>
        [DataMember(Name="emojis", EmitDefaultValue=false)]
        public List<Emoji> Emojis { get; set; }

        /// <summary>
        /// The FileInfo objects for any files attached to the post. This field will be null if the post does not have any file attachments. 
        /// </summary>
        /// <value>The FileInfo objects for any files attached to the post. This field will be null if the post does not have any file attachments. </value>
        [DataMember(Name="files", EmitDefaultValue=false)]
        public List<FileInfo> Files { get; set; }

        /// <summary>
        /// An object mapping the URL of an external image to an object containing the dimensions of that image. This field will be null if the post or its embedded content does not reference any external images. 
        /// </summary>
        /// <value>An object mapping the URL of an external image to an object containing the dimensions of that image. This field will be null if the post or its embedded content does not reference any external images. </value>
        [DataMember(Name="images", EmitDefaultValue=false)]
        public Object Images { get; set; }

        /// <summary>
        /// Any reactions made to this point. This field will be null if no reactions have been made to this post. 
        /// </summary>
        /// <value>Any reactions made to this point. This field will be null if no reactions have been made to this post. </value>
        [DataMember(Name="reactions", EmitDefaultValue=false)]
        public List<Reaction> Reactions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostMetadata {\n");
            sb.Append("  Embeds: ").Append(Embeds).Append("\n");
            sb.Append("  Emojis: ").Append(Emojis).Append("\n");
            sb.Append("  Files: ").Append(Files).Append("\n");
            sb.Append("  Images: ").Append(Images).Append("\n");
            sb.Append("  Reactions: ").Append(Reactions).Append("\n");
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
            return this.Equals(input as PostMetadata);
        }

        /// <summary>
        /// Returns true if PostMetadata instances are equal
        /// </summary>
        /// <param name="input">Instance of PostMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostMetadata input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Embeds == input.Embeds ||
                    this.Embeds != null &&
                    input.Embeds != null &&
                    this.Embeds.SequenceEqual(input.Embeds)
                ) && 
                (
                    this.Emojis == input.Emojis ||
                    this.Emojis != null &&
                    input.Emojis != null &&
                    this.Emojis.SequenceEqual(input.Emojis)
                ) && 
                (
                    this.Files == input.Files ||
                    this.Files != null &&
                    input.Files != null &&
                    this.Files.SequenceEqual(input.Files)
                ) && 
                (
                    this.Images == input.Images ||
                    (this.Images != null &&
                    this.Images.Equals(input.Images))
                ) && 
                (
                    this.Reactions == input.Reactions ||
                    this.Reactions != null &&
                    input.Reactions != null &&
                    this.Reactions.SequenceEqual(input.Reactions)
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
                if (this.Embeds != null)
                    hashCode = hashCode * 59 + this.Embeds.GetHashCode();
                if (this.Emojis != null)
                    hashCode = hashCode * 59 + this.Emojis.GetHashCode();
                if (this.Files != null)
                    hashCode = hashCode * 59 + this.Files.GetHashCode();
                if (this.Images != null)
                    hashCode = hashCode * 59 + this.Images.GetHashCode();
                if (this.Reactions != null)
                    hashCode = hashCode * 59 + this.Reactions.GetHashCode();
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
