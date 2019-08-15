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
    /// OAuthApp
    /// </summary>
    [DataContract]
    public partial class OAuthApp :  IEquatable<OAuthApp>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthApp" /> class.
        /// </summary>
        /// <param name="id">The client id of the application.</param>
        /// <param name="clientSecret">The client secret of the application.</param>
        /// <param name="name">The name of the client application.</param>
        /// <param name="description">A short description of the application.</param>
        /// <param name="iconUrl">A URL to an icon to display with the application.</param>
        /// <param name="callbackUrls">A list of callback URLs for the appliation.</param>
        /// <param name="homepage">A link to the website of the application.</param>
        /// <param name="isTrusted">Set this to &#x60;true&#x60; to skip asking users for permission.</param>
        /// <param name="createAt">The time of registration for the application.</param>
        /// <param name="updateAt">The last time of update for the application.</param>
        public OAuthApp(string id = default(string), string clientSecret = default(string), string name = default(string), string description = default(string), string iconUrl = default(string), List<string> callbackUrls = default(List<string>), string homepage = default(string), bool isTrusted = default(bool), long createAt = default(long), long updateAt = default(long))
        {
            this.Id = id;
            this.ClientSecret = clientSecret;
            this.Name = name;
            this.Description = description;
            this.IconUrl = iconUrl;
            this.CallbackUrls = callbackUrls;
            this.Homepage = homepage;
            this.IsTrusted = isTrusted;
            this.CreateAt = createAt;
            this.UpdateAt = updateAt;
        }
        
        /// <summary>
        /// The client id of the application
        /// </summary>
        /// <value>The client id of the application</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The client secret of the application
        /// </summary>
        /// <value>The client secret of the application</value>
        [DataMember(Name="client_secret", EmitDefaultValue=false)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// The name of the client application
        /// </summary>
        /// <value>The name of the client application</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// A short description of the application
        /// </summary>
        /// <value>A short description of the application</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// A URL to an icon to display with the application
        /// </summary>
        /// <value>A URL to an icon to display with the application</value>
        [DataMember(Name="icon_url", EmitDefaultValue=false)]
        public string IconUrl { get; set; }

        /// <summary>
        /// A list of callback URLs for the appliation
        /// </summary>
        /// <value>A list of callback URLs for the appliation</value>
        [DataMember(Name="callback_urls", EmitDefaultValue=false)]
        public List<string> CallbackUrls { get; set; }

        /// <summary>
        /// A link to the website of the application
        /// </summary>
        /// <value>A link to the website of the application</value>
        [DataMember(Name="homepage", EmitDefaultValue=false)]
        public string Homepage { get; set; }

        /// <summary>
        /// Set this to &#x60;true&#x60; to skip asking users for permission
        /// </summary>
        /// <value>Set this to &#x60;true&#x60; to skip asking users for permission</value>
        [DataMember(Name="is_trusted", EmitDefaultValue=false)]
        public bool IsTrusted { get; set; }

        /// <summary>
        /// The time of registration for the application
        /// </summary>
        /// <value>The time of registration for the application</value>
        [DataMember(Name="create_at", EmitDefaultValue=false)]
        public long CreateAt { get; set; }

        /// <summary>
        /// The last time of update for the application
        /// </summary>
        /// <value>The last time of update for the application</value>
        [DataMember(Name="update_at", EmitDefaultValue=false)]
        public long UpdateAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OAuthApp {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ClientSecret: ").Append(ClientSecret).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IconUrl: ").Append(IconUrl).Append("\n");
            sb.Append("  CallbackUrls: ").Append(CallbackUrls).Append("\n");
            sb.Append("  Homepage: ").Append(Homepage).Append("\n");
            sb.Append("  IsTrusted: ").Append(IsTrusted).Append("\n");
            sb.Append("  CreateAt: ").Append(CreateAt).Append("\n");
            sb.Append("  UpdateAt: ").Append(UpdateAt).Append("\n");
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
            return this.Equals(input as OAuthApp);
        }

        /// <summary>
        /// Returns true if OAuthApp instances are equal
        /// </summary>
        /// <param name="input">Instance of OAuthApp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OAuthApp input)
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
                    this.ClientSecret == input.ClientSecret ||
                    (this.ClientSecret != null &&
                    this.ClientSecret.Equals(input.ClientSecret))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.IconUrl == input.IconUrl ||
                    (this.IconUrl != null &&
                    this.IconUrl.Equals(input.IconUrl))
                ) && 
                (
                    this.CallbackUrls == input.CallbackUrls ||
                    this.CallbackUrls != null &&
                    input.CallbackUrls != null &&
                    this.CallbackUrls.SequenceEqual(input.CallbackUrls)
                ) && 
                (
                    this.Homepage == input.Homepage ||
                    (this.Homepage != null &&
                    this.Homepage.Equals(input.Homepage))
                ) && 
                (
                    this.IsTrusted == input.IsTrusted ||
                    this.IsTrusted.Equals(input.IsTrusted)
                ) && 
                (
                    this.CreateAt == input.CreateAt ||
                    this.CreateAt.Equals(input.CreateAt)
                ) && 
                (
                    this.UpdateAt == input.UpdateAt ||
                    this.UpdateAt.Equals(input.UpdateAt)
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
                if (this.ClientSecret != null)
                    hashCode = hashCode * 59 + this.ClientSecret.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.IconUrl != null)
                    hashCode = hashCode * 59 + this.IconUrl.GetHashCode();
                if (this.CallbackUrls != null)
                    hashCode = hashCode * 59 + this.CallbackUrls.GetHashCode();
                if (this.Homepage != null)
                    hashCode = hashCode * 59 + this.Homepage.GetHashCode();
                hashCode = hashCode * 59 + this.IsTrusted.GetHashCode();
                hashCode = hashCode * 59 + this.CreateAt.GetHashCode();
                hashCode = hashCode * 59 + this.UpdateAt.GetHashCode();
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
