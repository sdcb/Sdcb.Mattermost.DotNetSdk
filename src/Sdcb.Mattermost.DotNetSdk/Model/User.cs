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
    /// User
    /// </summary>
    [DataContract]
    public partial class User :  IEquatable<User>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="createAt">The time in milliseconds a user was created.</param>
        /// <param name="updateAt">The time in milliseconds a user was last updated.</param>
        /// <param name="deleteAt">The time in milliseconds a user was deleted.</param>
        /// <param name="username">username.</param>
        /// <param name="firstName">firstName.</param>
        /// <param name="lastName">lastName.</param>
        /// <param name="nickname">nickname.</param>
        /// <param name="email">email.</param>
        /// <param name="emailVerified">emailVerified.</param>
        /// <param name="authService">authService.</param>
        /// <param name="roles">roles.</param>
        /// <param name="locale">locale.</param>
        /// <param name="notifyProps">notifyProps.</param>
        /// <param name="props">props.</param>
        /// <param name="lastPasswordUpdate">lastPasswordUpdate.</param>
        /// <param name="lastPictureUpdate">lastPictureUpdate.</param>
        /// <param name="failedAttempts">failedAttempts.</param>
        /// <param name="mfaActive">mfaActive.</param>
        /// <param name="timezone">timezone.</param>
        /// <param name="termsOfServiceId">ID of accepted terms of service, if any. This field is not present if empty..</param>
        /// <param name="termsOfServiceCreateAt">The time in milliseconds the user accepted the terms of service.</param>
        public User(string id = default(string), long createAt = default(long), long updateAt = default(long), long deleteAt = default(long), string username = default(string), string firstName = default(string), string lastName = default(string), string nickname = default(string), string email = default(string), bool emailVerified = default(bool), string authService = default(string), string roles = default(string), string locale = default(string), UserNotifyProps notifyProps = default(UserNotifyProps), object props = default(object), int lastPasswordUpdate = default(int), int lastPictureUpdate = default(int), int failedAttempts = default(int), bool mfaActive = default(bool), Timezone timezone = default(Timezone), string termsOfServiceId = default(string), long termsOfServiceCreateAt = default(long))
        {
            this.Id = id;
            this.CreateAt = createAt;
            this.UpdateAt = updateAt;
            this.DeleteAt = deleteAt;
            this.Username = username;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Nickname = nickname;
            this.Email = email;
            this.EmailVerified = emailVerified;
            this.AuthService = authService;
            this.Roles = roles;
            this.Locale = locale;
            this.NotifyProps = notifyProps;
            this.Props = props;
            this.LastPasswordUpdate = lastPasswordUpdate;
            this.LastPictureUpdate = lastPictureUpdate;
            this.FailedAttempts = failedAttempts;
            this.MfaActive = mfaActive;
            this.Timezone = timezone;
            this.TermsOfServiceId = termsOfServiceId;
            this.TermsOfServiceCreateAt = termsOfServiceCreateAt;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The time in milliseconds a user was created
        /// </summary>
        /// <value>The time in milliseconds a user was created</value>
        [DataMember(Name="create_at", EmitDefaultValue=false)]
        public long CreateAt { get; set; }

        /// <summary>
        /// The time in milliseconds a user was last updated
        /// </summary>
        /// <value>The time in milliseconds a user was last updated</value>
        [DataMember(Name="update_at", EmitDefaultValue=false)]
        public long UpdateAt { get; set; }

        /// <summary>
        /// The time in milliseconds a user was deleted
        /// </summary>
        /// <value>The time in milliseconds a user was deleted</value>
        [DataMember(Name="delete_at", EmitDefaultValue=false)]
        public long DeleteAt { get; set; }

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
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets EmailVerified
        /// </summary>
        [DataMember(Name="email_verified", EmitDefaultValue=false)]
        public bool EmailVerified { get; set; }

        /// <summary>
        /// Gets or Sets AuthService
        /// </summary>
        [DataMember(Name="auth_service", EmitDefaultValue=false)]
        public string AuthService { get; set; }

        /// <summary>
        /// Gets or Sets Roles
        /// </summary>
        [DataMember(Name="roles", EmitDefaultValue=false)]
        public string Roles { get; set; }

        /// <summary>
        /// Gets or Sets Locale
        /// </summary>
        [DataMember(Name="locale", EmitDefaultValue=false)]
        public string Locale { get; set; }

        /// <summary>
        /// Gets or Sets NotifyProps
        /// </summary>
        [DataMember(Name="notify_props", EmitDefaultValue=false)]
        public UserNotifyProps NotifyProps { get; set; }

        /// <summary>
        /// Gets or Sets Props
        /// </summary>
        [DataMember(Name="props", EmitDefaultValue=false)]
        public object Props { get; set; }

        /// <summary>
        /// Gets or Sets LastPasswordUpdate
        /// </summary>
        [DataMember(Name="last_password_update", EmitDefaultValue=false)]
        public int LastPasswordUpdate { get; set; }

        /// <summary>
        /// Gets or Sets LastPictureUpdate
        /// </summary>
        [DataMember(Name="last_picture_update", EmitDefaultValue=false)]
        public int LastPictureUpdate { get; set; }

        /// <summary>
        /// Gets or Sets FailedAttempts
        /// </summary>
        [DataMember(Name="failed_attempts", EmitDefaultValue=false)]
        public int FailedAttempts { get; set; }

        /// <summary>
        /// Gets or Sets MfaActive
        /// </summary>
        [DataMember(Name="mfa_active", EmitDefaultValue=false)]
        public bool MfaActive { get; set; }

        /// <summary>
        /// Gets or Sets Timezone
        /// </summary>
        [DataMember(Name="timezone", EmitDefaultValue=false)]
        public Timezone Timezone { get; set; }

        /// <summary>
        /// ID of accepted terms of service, if any. This field is not present if empty.
        /// </summary>
        /// <value>ID of accepted terms of service, if any. This field is not present if empty.</value>
        [DataMember(Name="terms_of_service_id", EmitDefaultValue=false)]
        public string TermsOfServiceId { get; set; }

        /// <summary>
        /// The time in milliseconds the user accepted the terms of service
        /// </summary>
        /// <value>The time in milliseconds the user accepted the terms of service</value>
        [DataMember(Name="terms_of_service_create_at", EmitDefaultValue=false)]
        public long TermsOfServiceCreateAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class User {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreateAt: ").Append(CreateAt).Append("\n");
            sb.Append("  UpdateAt: ").Append(UpdateAt).Append("\n");
            sb.Append("  DeleteAt: ").Append(DeleteAt).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Nickname: ").Append(Nickname).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  EmailVerified: ").Append(EmailVerified).Append("\n");
            sb.Append("  AuthService: ").Append(AuthService).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
            sb.Append("  Locale: ").Append(Locale).Append("\n");
            sb.Append("  NotifyProps: ").Append(NotifyProps).Append("\n");
            sb.Append("  Props: ").Append(Props).Append("\n");
            sb.Append("  LastPasswordUpdate: ").Append(LastPasswordUpdate).Append("\n");
            sb.Append("  LastPictureUpdate: ").Append(LastPictureUpdate).Append("\n");
            sb.Append("  FailedAttempts: ").Append(FailedAttempts).Append("\n");
            sb.Append("  MfaActive: ").Append(MfaActive).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
            sb.Append("  TermsOfServiceId: ").Append(TermsOfServiceId).Append("\n");
            sb.Append("  TermsOfServiceCreateAt: ").Append(TermsOfServiceCreateAt).Append("\n");
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
            return this.Equals(input as User);
        }

        /// <summary>
        /// Returns true if User instances are equal
        /// </summary>
        /// <param name="input">Instance of User to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(User input)
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
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.EmailVerified == input.EmailVerified ||
                    this.EmailVerified.Equals(input.EmailVerified)
                ) && 
                (
                    this.AuthService == input.AuthService ||
                    (this.AuthService != null &&
                    this.AuthService.Equals(input.AuthService))
                ) && 
                (
                    this.Roles == input.Roles ||
                    (this.Roles != null &&
                    this.Roles.Equals(input.Roles))
                ) && 
                (
                    this.Locale == input.Locale ||
                    (this.Locale != null &&
                    this.Locale.Equals(input.Locale))
                ) && 
                (
                    this.NotifyProps == input.NotifyProps ||
                    (this.NotifyProps != null &&
                    this.NotifyProps.Equals(input.NotifyProps))
                ) && 
                (
                    this.Props == input.Props ||
                    (this.Props != null &&
                    this.Props.Equals(input.Props))
                ) && 
                (
                    this.LastPasswordUpdate == input.LastPasswordUpdate ||
                    this.LastPasswordUpdate.Equals(input.LastPasswordUpdate)
                ) && 
                (
                    this.LastPictureUpdate == input.LastPictureUpdate ||
                    this.LastPictureUpdate.Equals(input.LastPictureUpdate)
                ) && 
                (
                    this.FailedAttempts == input.FailedAttempts ||
                    this.FailedAttempts.Equals(input.FailedAttempts)
                ) && 
                (
                    this.MfaActive == input.MfaActive ||
                    this.MfaActive.Equals(input.MfaActive)
                ) && 
                (
                    this.Timezone == input.Timezone ||
                    (this.Timezone != null &&
                    this.Timezone.Equals(input.Timezone))
                ) && 
                (
                    this.TermsOfServiceId == input.TermsOfServiceId ||
                    (this.TermsOfServiceId != null &&
                    this.TermsOfServiceId.Equals(input.TermsOfServiceId))
                ) && 
                (
                    this.TermsOfServiceCreateAt == input.TermsOfServiceCreateAt ||
                    this.TermsOfServiceCreateAt.Equals(input.TermsOfServiceCreateAt)
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
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.Nickname != null)
                    hashCode = hashCode * 59 + this.Nickname.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                hashCode = hashCode * 59 + this.EmailVerified.GetHashCode();
                if (this.AuthService != null)
                    hashCode = hashCode * 59 + this.AuthService.GetHashCode();
                if (this.Roles != null)
                    hashCode = hashCode * 59 + this.Roles.GetHashCode();
                if (this.Locale != null)
                    hashCode = hashCode * 59 + this.Locale.GetHashCode();
                if (this.NotifyProps != null)
                    hashCode = hashCode * 59 + this.NotifyProps.GetHashCode();
                if (this.Props != null)
                    hashCode = hashCode * 59 + this.Props.GetHashCode();
                hashCode = hashCode * 59 + this.LastPasswordUpdate.GetHashCode();
                hashCode = hashCode * 59 + this.LastPictureUpdate.GetHashCode();
                hashCode = hashCode * 59 + this.FailedAttempts.GetHashCode();
                hashCode = hashCode * 59 + this.MfaActive.GetHashCode();
                if (this.Timezone != null)
                    hashCode = hashCode * 59 + this.Timezone.GetHashCode();
                if (this.TermsOfServiceId != null)
                    hashCode = hashCode * 59 + this.TermsOfServiceId.GetHashCode();
                hashCode = hashCode * 59 + this.TermsOfServiceCreateAt.GetHashCode();
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
