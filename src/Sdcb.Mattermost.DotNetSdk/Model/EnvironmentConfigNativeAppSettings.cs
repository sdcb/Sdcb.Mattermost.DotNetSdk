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
    /// EnvironmentConfigNativeAppSettings
    /// </summary>
    [DataContract]
    public partial class EnvironmentConfigNativeAppSettings :  IEquatable<EnvironmentConfigNativeAppSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentConfigNativeAppSettings" /> class.
        /// </summary>
        /// <param name="appDownloadLink">appDownloadLink.</param>
        /// <param name="androidAppDownloadLink">androidAppDownloadLink.</param>
        /// <param name="iosAppDownloadLink">iosAppDownloadLink.</param>
        public EnvironmentConfigNativeAppSettings(bool appDownloadLink = default(bool), bool androidAppDownloadLink = default(bool), bool iosAppDownloadLink = default(bool))
        {
            this.AppDownloadLink = appDownloadLink;
            this.AndroidAppDownloadLink = androidAppDownloadLink;
            this.IosAppDownloadLink = iosAppDownloadLink;
        }
        
        /// <summary>
        /// Gets or Sets AppDownloadLink
        /// </summary>
        [DataMember(Name="AppDownloadLink", EmitDefaultValue=false)]
        public bool AppDownloadLink { get; set; }

        /// <summary>
        /// Gets or Sets AndroidAppDownloadLink
        /// </summary>
        [DataMember(Name="AndroidAppDownloadLink", EmitDefaultValue=false)]
        public bool AndroidAppDownloadLink { get; set; }

        /// <summary>
        /// Gets or Sets IosAppDownloadLink
        /// </summary>
        [DataMember(Name="IosAppDownloadLink", EmitDefaultValue=false)]
        public bool IosAppDownloadLink { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnvironmentConfigNativeAppSettings {\n");
            sb.Append("  AppDownloadLink: ").Append(AppDownloadLink).Append("\n");
            sb.Append("  AndroidAppDownloadLink: ").Append(AndroidAppDownloadLink).Append("\n");
            sb.Append("  IosAppDownloadLink: ").Append(IosAppDownloadLink).Append("\n");
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
            return this.Equals(input as EnvironmentConfigNativeAppSettings);
        }

        /// <summary>
        /// Returns true if EnvironmentConfigNativeAppSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of EnvironmentConfigNativeAppSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnvironmentConfigNativeAppSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AppDownloadLink == input.AppDownloadLink ||
                    this.AppDownloadLink.Equals(input.AppDownloadLink)
                ) && 
                (
                    this.AndroidAppDownloadLink == input.AndroidAppDownloadLink ||
                    this.AndroidAppDownloadLink.Equals(input.AndroidAppDownloadLink)
                ) && 
                (
                    this.IosAppDownloadLink == input.IosAppDownloadLink ||
                    this.IosAppDownloadLink.Equals(input.IosAppDownloadLink)
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
                hashCode = hashCode * 59 + this.AppDownloadLink.GetHashCode();
                hashCode = hashCode * 59 + this.AndroidAppDownloadLink.GetHashCode();
                hashCode = hashCode * 59 + this.IosAppDownloadLink.GetHashCode();
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