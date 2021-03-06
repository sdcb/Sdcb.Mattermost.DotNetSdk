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
    /// ConfigSamlSettings
    /// </summary>
    [DataContract]
    public partial class ConfigSamlSettings :  IEquatable<ConfigSamlSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigSamlSettings" /> class.
        /// </summary>
        /// <param name="enable">enable.</param>
        /// <param name="verify">verify.</param>
        /// <param name="encrypt">encrypt.</param>
        /// <param name="idpUrl">idpUrl.</param>
        /// <param name="idpDescriptorUrl">idpDescriptorUrl.</param>
        /// <param name="assertionConsumerServiceURL">assertionConsumerServiceURL.</param>
        /// <param name="idpCertificateFile">idpCertificateFile.</param>
        /// <param name="publicCertificateFile">publicCertificateFile.</param>
        /// <param name="privateKeyFile">privateKeyFile.</param>
        /// <param name="firstNameAttribute">firstNameAttribute.</param>
        /// <param name="lastNameAttribute">lastNameAttribute.</param>
        /// <param name="emailAttribute">emailAttribute.</param>
        /// <param name="usernameAttribute">usernameAttribute.</param>
        /// <param name="nicknameAttribute">nicknameAttribute.</param>
        /// <param name="localeAttribute">localeAttribute.</param>
        /// <param name="positionAttribute">positionAttribute.</param>
        /// <param name="loginButtonText">loginButtonText.</param>
        public ConfigSamlSettings(bool enable = default(bool), bool verify = default(bool), bool encrypt = default(bool), string idpUrl = default(string), string idpDescriptorUrl = default(string), string assertionConsumerServiceURL = default(string), string idpCertificateFile = default(string), string publicCertificateFile = default(string), string privateKeyFile = default(string), string firstNameAttribute = default(string), string lastNameAttribute = default(string), string emailAttribute = default(string), string usernameAttribute = default(string), string nicknameAttribute = default(string), string localeAttribute = default(string), string positionAttribute = default(string), string loginButtonText = default(string))
        {
            this.Enable = enable;
            this.Verify = verify;
            this.Encrypt = encrypt;
            this.IdpUrl = idpUrl;
            this.IdpDescriptorUrl = idpDescriptorUrl;
            this.AssertionConsumerServiceURL = assertionConsumerServiceURL;
            this.IdpCertificateFile = idpCertificateFile;
            this.PublicCertificateFile = publicCertificateFile;
            this.PrivateKeyFile = privateKeyFile;
            this.FirstNameAttribute = firstNameAttribute;
            this.LastNameAttribute = lastNameAttribute;
            this.EmailAttribute = emailAttribute;
            this.UsernameAttribute = usernameAttribute;
            this.NicknameAttribute = nicknameAttribute;
            this.LocaleAttribute = localeAttribute;
            this.PositionAttribute = positionAttribute;
            this.LoginButtonText = loginButtonText;
        }
        
        /// <summary>
        /// Gets or Sets Enable
        /// </summary>
        [DataMember(Name="Enable", EmitDefaultValue=false)]
        public bool Enable { get; set; }

        /// <summary>
        /// Gets or Sets Verify
        /// </summary>
        [DataMember(Name="Verify", EmitDefaultValue=false)]
        public bool Verify { get; set; }

        /// <summary>
        /// Gets or Sets Encrypt
        /// </summary>
        [DataMember(Name="Encrypt", EmitDefaultValue=false)]
        public bool Encrypt { get; set; }

        /// <summary>
        /// Gets or Sets IdpUrl
        /// </summary>
        [DataMember(Name="IdpUrl", EmitDefaultValue=false)]
        public string IdpUrl { get; set; }

        /// <summary>
        /// Gets or Sets IdpDescriptorUrl
        /// </summary>
        [DataMember(Name="IdpDescriptorUrl", EmitDefaultValue=false)]
        public string IdpDescriptorUrl { get; set; }

        /// <summary>
        /// Gets or Sets AssertionConsumerServiceURL
        /// </summary>
        [DataMember(Name="AssertionConsumerServiceURL", EmitDefaultValue=false)]
        public string AssertionConsumerServiceURL { get; set; }

        /// <summary>
        /// Gets or Sets IdpCertificateFile
        /// </summary>
        [DataMember(Name="IdpCertificateFile", EmitDefaultValue=false)]
        public string IdpCertificateFile { get; set; }

        /// <summary>
        /// Gets or Sets PublicCertificateFile
        /// </summary>
        [DataMember(Name="PublicCertificateFile", EmitDefaultValue=false)]
        public string PublicCertificateFile { get; set; }

        /// <summary>
        /// Gets or Sets PrivateKeyFile
        /// </summary>
        [DataMember(Name="PrivateKeyFile", EmitDefaultValue=false)]
        public string PrivateKeyFile { get; set; }

        /// <summary>
        /// Gets or Sets FirstNameAttribute
        /// </summary>
        [DataMember(Name="FirstNameAttribute", EmitDefaultValue=false)]
        public string FirstNameAttribute { get; set; }

        /// <summary>
        /// Gets or Sets LastNameAttribute
        /// </summary>
        [DataMember(Name="LastNameAttribute", EmitDefaultValue=false)]
        public string LastNameAttribute { get; set; }

        /// <summary>
        /// Gets or Sets EmailAttribute
        /// </summary>
        [DataMember(Name="EmailAttribute", EmitDefaultValue=false)]
        public string EmailAttribute { get; set; }

        /// <summary>
        /// Gets or Sets UsernameAttribute
        /// </summary>
        [DataMember(Name="UsernameAttribute", EmitDefaultValue=false)]
        public string UsernameAttribute { get; set; }

        /// <summary>
        /// Gets or Sets NicknameAttribute
        /// </summary>
        [DataMember(Name="NicknameAttribute", EmitDefaultValue=false)]
        public string NicknameAttribute { get; set; }

        /// <summary>
        /// Gets or Sets LocaleAttribute
        /// </summary>
        [DataMember(Name="LocaleAttribute", EmitDefaultValue=false)]
        public string LocaleAttribute { get; set; }

        /// <summary>
        /// Gets or Sets PositionAttribute
        /// </summary>
        [DataMember(Name="PositionAttribute", EmitDefaultValue=false)]
        public string PositionAttribute { get; set; }

        /// <summary>
        /// Gets or Sets LoginButtonText
        /// </summary>
        [DataMember(Name="LoginButtonText", EmitDefaultValue=false)]
        public string LoginButtonText { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfigSamlSettings {\n");
            sb.Append("  Enable: ").Append(Enable).Append("\n");
            sb.Append("  Verify: ").Append(Verify).Append("\n");
            sb.Append("  Encrypt: ").Append(Encrypt).Append("\n");
            sb.Append("  IdpUrl: ").Append(IdpUrl).Append("\n");
            sb.Append("  IdpDescriptorUrl: ").Append(IdpDescriptorUrl).Append("\n");
            sb.Append("  AssertionConsumerServiceURL: ").Append(AssertionConsumerServiceURL).Append("\n");
            sb.Append("  IdpCertificateFile: ").Append(IdpCertificateFile).Append("\n");
            sb.Append("  PublicCertificateFile: ").Append(PublicCertificateFile).Append("\n");
            sb.Append("  PrivateKeyFile: ").Append(PrivateKeyFile).Append("\n");
            sb.Append("  FirstNameAttribute: ").Append(FirstNameAttribute).Append("\n");
            sb.Append("  LastNameAttribute: ").Append(LastNameAttribute).Append("\n");
            sb.Append("  EmailAttribute: ").Append(EmailAttribute).Append("\n");
            sb.Append("  UsernameAttribute: ").Append(UsernameAttribute).Append("\n");
            sb.Append("  NicknameAttribute: ").Append(NicknameAttribute).Append("\n");
            sb.Append("  LocaleAttribute: ").Append(LocaleAttribute).Append("\n");
            sb.Append("  PositionAttribute: ").Append(PositionAttribute).Append("\n");
            sb.Append("  LoginButtonText: ").Append(LoginButtonText).Append("\n");
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
            return this.Equals(input as ConfigSamlSettings);
        }

        /// <summary>
        /// Returns true if ConfigSamlSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of ConfigSamlSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfigSamlSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Enable == input.Enable ||
                    this.Enable.Equals(input.Enable)
                ) && 
                (
                    this.Verify == input.Verify ||
                    this.Verify.Equals(input.Verify)
                ) && 
                (
                    this.Encrypt == input.Encrypt ||
                    this.Encrypt.Equals(input.Encrypt)
                ) && 
                (
                    this.IdpUrl == input.IdpUrl ||
                    (this.IdpUrl != null &&
                    this.IdpUrl.Equals(input.IdpUrl))
                ) && 
                (
                    this.IdpDescriptorUrl == input.IdpDescriptorUrl ||
                    (this.IdpDescriptorUrl != null &&
                    this.IdpDescriptorUrl.Equals(input.IdpDescriptorUrl))
                ) && 
                (
                    this.AssertionConsumerServiceURL == input.AssertionConsumerServiceURL ||
                    (this.AssertionConsumerServiceURL != null &&
                    this.AssertionConsumerServiceURL.Equals(input.AssertionConsumerServiceURL))
                ) && 
                (
                    this.IdpCertificateFile == input.IdpCertificateFile ||
                    (this.IdpCertificateFile != null &&
                    this.IdpCertificateFile.Equals(input.IdpCertificateFile))
                ) && 
                (
                    this.PublicCertificateFile == input.PublicCertificateFile ||
                    (this.PublicCertificateFile != null &&
                    this.PublicCertificateFile.Equals(input.PublicCertificateFile))
                ) && 
                (
                    this.PrivateKeyFile == input.PrivateKeyFile ||
                    (this.PrivateKeyFile != null &&
                    this.PrivateKeyFile.Equals(input.PrivateKeyFile))
                ) && 
                (
                    this.FirstNameAttribute == input.FirstNameAttribute ||
                    (this.FirstNameAttribute != null &&
                    this.FirstNameAttribute.Equals(input.FirstNameAttribute))
                ) && 
                (
                    this.LastNameAttribute == input.LastNameAttribute ||
                    (this.LastNameAttribute != null &&
                    this.LastNameAttribute.Equals(input.LastNameAttribute))
                ) && 
                (
                    this.EmailAttribute == input.EmailAttribute ||
                    (this.EmailAttribute != null &&
                    this.EmailAttribute.Equals(input.EmailAttribute))
                ) && 
                (
                    this.UsernameAttribute == input.UsernameAttribute ||
                    (this.UsernameAttribute != null &&
                    this.UsernameAttribute.Equals(input.UsernameAttribute))
                ) && 
                (
                    this.NicknameAttribute == input.NicknameAttribute ||
                    (this.NicknameAttribute != null &&
                    this.NicknameAttribute.Equals(input.NicknameAttribute))
                ) && 
                (
                    this.LocaleAttribute == input.LocaleAttribute ||
                    (this.LocaleAttribute != null &&
                    this.LocaleAttribute.Equals(input.LocaleAttribute))
                ) && 
                (
                    this.PositionAttribute == input.PositionAttribute ||
                    (this.PositionAttribute != null &&
                    this.PositionAttribute.Equals(input.PositionAttribute))
                ) && 
                (
                    this.LoginButtonText == input.LoginButtonText ||
                    (this.LoginButtonText != null &&
                    this.LoginButtonText.Equals(input.LoginButtonText))
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
                hashCode = hashCode * 59 + this.Enable.GetHashCode();
                hashCode = hashCode * 59 + this.Verify.GetHashCode();
                hashCode = hashCode * 59 + this.Encrypt.GetHashCode();
                if (this.IdpUrl != null)
                    hashCode = hashCode * 59 + this.IdpUrl.GetHashCode();
                if (this.IdpDescriptorUrl != null)
                    hashCode = hashCode * 59 + this.IdpDescriptorUrl.GetHashCode();
                if (this.AssertionConsumerServiceURL != null)
                    hashCode = hashCode * 59 + this.AssertionConsumerServiceURL.GetHashCode();
                if (this.IdpCertificateFile != null)
                    hashCode = hashCode * 59 + this.IdpCertificateFile.GetHashCode();
                if (this.PublicCertificateFile != null)
                    hashCode = hashCode * 59 + this.PublicCertificateFile.GetHashCode();
                if (this.PrivateKeyFile != null)
                    hashCode = hashCode * 59 + this.PrivateKeyFile.GetHashCode();
                if (this.FirstNameAttribute != null)
                    hashCode = hashCode * 59 + this.FirstNameAttribute.GetHashCode();
                if (this.LastNameAttribute != null)
                    hashCode = hashCode * 59 + this.LastNameAttribute.GetHashCode();
                if (this.EmailAttribute != null)
                    hashCode = hashCode * 59 + this.EmailAttribute.GetHashCode();
                if (this.UsernameAttribute != null)
                    hashCode = hashCode * 59 + this.UsernameAttribute.GetHashCode();
                if (this.NicknameAttribute != null)
                    hashCode = hashCode * 59 + this.NicknameAttribute.GetHashCode();
                if (this.LocaleAttribute != null)
                    hashCode = hashCode * 59 + this.LocaleAttribute.GetHashCode();
                if (this.PositionAttribute != null)
                    hashCode = hashCode * 59 + this.PositionAttribute.GetHashCode();
                if (this.LoginButtonText != null)
                    hashCode = hashCode * 59 + this.LoginButtonText.GetHashCode();
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
