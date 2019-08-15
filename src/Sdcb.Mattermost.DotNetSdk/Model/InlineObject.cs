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
    /// InlineObject
    /// </summary>
    [DataContract]
    public partial class InlineObject :  IEquatable<InlineObject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InlineObject() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject" /> class.
        /// </summary>
        /// <param name="email">email (required).</param>
        /// <param name="username">username (required).</param>
        /// <param name="firstName">firstName.</param>
        /// <param name="lastName">lastName.</param>
        /// <param name="nickname">nickname.</param>
        /// <param name="authData">Service-specific authentication data, such as email address..</param>
        /// <param name="authService">The authentication service, one of \&quot;email\&quot;, \&quot;gitlab\&quot;, \&quot;ldap\&quot;, \&quot;saml\&quot;, \&quot;office365\&quot;, \&quot;google\&quot;, and \&quot;\&quot;..</param>
        /// <param name="password">The password used for email authentication..</param>
        /// <param name="locale">locale.</param>
        /// <param name="props">props.</param>
        /// <param name="notifyProps">notifyProps.</param>
        public InlineObject(string email = default(string), string username = default(string), string firstName = default(string), string lastName = default(string), string nickname = default(string), string authData = default(string), string authService = default(string), string password = default(string), string locale = default(string), Object props = default(Object), UserNotifyProps notifyProps = default(UserNotifyProps))
        {
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new InvalidDataException("email is a required property for InlineObject and cannot be null");
            }
            else
            {
                this.Email = email;
            }

            // to ensure "username" is required (not null)
            if (username == null)
            {
                throw new InvalidDataException("username is a required property for InlineObject and cannot be null");
            }
            else
            {
                this.Username = username;
            }

            this.FirstName = firstName;
            this.LastName = lastName;
            this.Nickname = nickname;
            this.AuthData = authData;
            this.AuthService = authService;
            this.Password = password;
            this.Locale = locale;
            this.Props = props;
            this.NotifyProps = notifyProps;
        }
        
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name="first_name", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name="last_name", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets Nickname
        /// </summary>
        [DataMember(Name="nickname", EmitDefaultValue=false)]
        public string Nickname { get; set; }

        /// <summary>
        /// Service-specific authentication data, such as email address.
        /// </summary>
        /// <value>Service-specific authentication data, such as email address.</value>
        [DataMember(Name="auth_data", EmitDefaultValue=false)]
        public string AuthData { get; set; }

        /// <summary>
        /// The authentication service, one of \&quot;email\&quot;, \&quot;gitlab\&quot;, \&quot;ldap\&quot;, \&quot;saml\&quot;, \&quot;office365\&quot;, \&quot;google\&quot;, and \&quot;\&quot;.
        /// </summary>
        /// <value>The authentication service, one of \&quot;email\&quot;, \&quot;gitlab\&quot;, \&quot;ldap\&quot;, \&quot;saml\&quot;, \&quot;office365\&quot;, \&quot;google\&quot;, and \&quot;\&quot;.</value>
        [DataMember(Name="auth_service", EmitDefaultValue=false)]
        public string AuthService { get; set; }

        /// <summary>
        /// The password used for email authentication.
        /// </summary>
        /// <value>The password used for email authentication.</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Gets or Sets Locale
        /// </summary>
        [DataMember(Name="locale", EmitDefaultValue=false)]
        public string Locale { get; set; }

        /// <summary>
        /// Gets or Sets Props
        /// </summary>
        [DataMember(Name="props", EmitDefaultValue=false)]
        public Object Props { get; set; }

        /// <summary>
        /// Gets or Sets NotifyProps
        /// </summary>
        [DataMember(Name="notify_props", EmitDefaultValue=false)]
        public UserNotifyProps NotifyProps { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineObject {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Nickname: ").Append(Nickname).Append("\n");
            sb.Append("  AuthData: ").Append(AuthData).Append("\n");
            sb.Append("  AuthService: ").Append(AuthService).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Locale: ").Append(Locale).Append("\n");
            sb.Append("  Props: ").Append(Props).Append("\n");
            sb.Append("  NotifyProps: ").Append(NotifyProps).Append("\n");
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
            return this.Equals(input as InlineObject);
        }

        /// <summary>
        /// Returns true if InlineObject instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.Nickname == input.Nickname ||
                    (this.Nickname != null &&
                    this.Nickname.Equals(input.Nickname))
                ) && 
                (
                    this.AuthData == input.AuthData ||
                    (this.AuthData != null &&
                    this.AuthData.Equals(input.AuthData))
                ) && 
                (
                    this.AuthService == input.AuthService ||
                    (this.AuthService != null &&
                    this.AuthService.Equals(input.AuthService))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.Locale == input.Locale ||
                    (this.Locale != null &&
                    this.Locale.Equals(input.Locale))
                ) && 
                (
                    this.Props == input.Props ||
                    (this.Props != null &&
                    this.Props.Equals(input.Props))
                ) && 
                (
                    this.NotifyProps == input.NotifyProps ||
                    (this.NotifyProps != null &&
                    this.NotifyProps.Equals(input.NotifyProps))
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
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.Nickname != null)
                    hashCode = hashCode * 59 + this.Nickname.GetHashCode();
                if (this.AuthData != null)
                    hashCode = hashCode * 59 + this.AuthData.GetHashCode();
                if (this.AuthService != null)
                    hashCode = hashCode * 59 + this.AuthService.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.Locale != null)
                    hashCode = hashCode * 59 + this.Locale.GetHashCode();
                if (this.Props != null)
                    hashCode = hashCode * 59 + this.Props.GetHashCode();
                if (this.NotifyProps != null)
                    hashCode = hashCode * 59 + this.NotifyProps.GetHashCode();
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
