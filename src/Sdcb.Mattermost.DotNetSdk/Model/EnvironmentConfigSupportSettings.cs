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
    /// EnvironmentConfigSupportSettings
    /// </summary>
    [DataContract]
    public partial class EnvironmentConfigSupportSettings :  IEquatable<EnvironmentConfigSupportSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentConfigSupportSettings" /> class.
        /// </summary>
        /// <param name="termsOfServiceLink">termsOfServiceLink.</param>
        /// <param name="privacyPolicyLink">privacyPolicyLink.</param>
        /// <param name="aboutLink">aboutLink.</param>
        /// <param name="helpLink">helpLink.</param>
        /// <param name="reportAProblemLink">reportAProblemLink.</param>
        /// <param name="supportEmail">supportEmail.</param>
        public EnvironmentConfigSupportSettings(bool termsOfServiceLink = default(bool), bool privacyPolicyLink = default(bool), bool aboutLink = default(bool), bool helpLink = default(bool), bool reportAProblemLink = default(bool), bool supportEmail = default(bool))
        {
            this.TermsOfServiceLink = termsOfServiceLink;
            this.PrivacyPolicyLink = privacyPolicyLink;
            this.AboutLink = aboutLink;
            this.HelpLink = helpLink;
            this.ReportAProblemLink = reportAProblemLink;
            this.SupportEmail = supportEmail;
        }
        
        /// <summary>
        /// Gets or Sets TermsOfServiceLink
        /// </summary>
        [DataMember(Name="TermsOfServiceLink", EmitDefaultValue=false)]
        public bool TermsOfServiceLink { get; set; }

        /// <summary>
        /// Gets or Sets PrivacyPolicyLink
        /// </summary>
        [DataMember(Name="PrivacyPolicyLink", EmitDefaultValue=false)]
        public bool PrivacyPolicyLink { get; set; }

        /// <summary>
        /// Gets or Sets AboutLink
        /// </summary>
        [DataMember(Name="AboutLink", EmitDefaultValue=false)]
        public bool AboutLink { get; set; }

        /// <summary>
        /// Gets or Sets HelpLink
        /// </summary>
        [DataMember(Name="HelpLink", EmitDefaultValue=false)]
        public bool HelpLink { get; set; }

        /// <summary>
        /// Gets or Sets ReportAProblemLink
        /// </summary>
        [DataMember(Name="ReportAProblemLink", EmitDefaultValue=false)]
        public bool ReportAProblemLink { get; set; }

        /// <summary>
        /// Gets or Sets SupportEmail
        /// </summary>
        [DataMember(Name="SupportEmail", EmitDefaultValue=false)]
        public bool SupportEmail { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnvironmentConfigSupportSettings {\n");
            sb.Append("  TermsOfServiceLink: ").Append(TermsOfServiceLink).Append("\n");
            sb.Append("  PrivacyPolicyLink: ").Append(PrivacyPolicyLink).Append("\n");
            sb.Append("  AboutLink: ").Append(AboutLink).Append("\n");
            sb.Append("  HelpLink: ").Append(HelpLink).Append("\n");
            sb.Append("  ReportAProblemLink: ").Append(ReportAProblemLink).Append("\n");
            sb.Append("  SupportEmail: ").Append(SupportEmail).Append("\n");
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
            return this.Equals(input as EnvironmentConfigSupportSettings);
        }

        /// <summary>
        /// Returns true if EnvironmentConfigSupportSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of EnvironmentConfigSupportSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnvironmentConfigSupportSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TermsOfServiceLink == input.TermsOfServiceLink ||
                    this.TermsOfServiceLink.Equals(input.TermsOfServiceLink)
                ) && 
                (
                    this.PrivacyPolicyLink == input.PrivacyPolicyLink ||
                    this.PrivacyPolicyLink.Equals(input.PrivacyPolicyLink)
                ) && 
                (
                    this.AboutLink == input.AboutLink ||
                    this.AboutLink.Equals(input.AboutLink)
                ) && 
                (
                    this.HelpLink == input.HelpLink ||
                    this.HelpLink.Equals(input.HelpLink)
                ) && 
                (
                    this.ReportAProblemLink == input.ReportAProblemLink ||
                    this.ReportAProblemLink.Equals(input.ReportAProblemLink)
                ) && 
                (
                    this.SupportEmail == input.SupportEmail ||
                    this.SupportEmail.Equals(input.SupportEmail)
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
                hashCode = hashCode * 59 + this.TermsOfServiceLink.GetHashCode();
                hashCode = hashCode * 59 + this.PrivacyPolicyLink.GetHashCode();
                hashCode = hashCode * 59 + this.AboutLink.GetHashCode();
                hashCode = hashCode * 59 + this.HelpLink.GetHashCode();
                hashCode = hashCode * 59 + this.ReportAProblemLink.GetHashCode();
                hashCode = hashCode * 59 + this.SupportEmail.GetHashCode();
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
