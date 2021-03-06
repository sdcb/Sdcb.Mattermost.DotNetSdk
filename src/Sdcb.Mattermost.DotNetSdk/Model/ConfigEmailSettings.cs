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
    /// ConfigEmailSettings
    /// </summary>
    [DataContract]
    public partial class ConfigEmailSettings :  IEquatable<ConfigEmailSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigEmailSettings" /> class.
        /// </summary>
        /// <param name="enableSignUpWithEmail">enableSignUpWithEmail.</param>
        /// <param name="enableSignInWithEmail">enableSignInWithEmail.</param>
        /// <param name="enableSignInWithUsername">enableSignInWithUsername.</param>
        /// <param name="sendEmailNotifications">sendEmailNotifications.</param>
        /// <param name="requireEmailVerification">requireEmailVerification.</param>
        /// <param name="feedbackName">feedbackName.</param>
        /// <param name="feedbackEmail">feedbackEmail.</param>
        /// <param name="feedbackOrganization">feedbackOrganization.</param>
        /// <param name="sMTPUsername">sMTPUsername.</param>
        /// <param name="sMTPPassword">sMTPPassword.</param>
        /// <param name="sMTPServer">sMTPServer.</param>
        /// <param name="sMTPPort">sMTPPort.</param>
        /// <param name="connectionSecurity">connectionSecurity.</param>
        /// <param name="inviteSalt">inviteSalt.</param>
        /// <param name="passwordResetSalt">passwordResetSalt.</param>
        /// <param name="sendPushNotifications">sendPushNotifications.</param>
        /// <param name="pushNotificationServer">pushNotificationServer.</param>
        /// <param name="pushNotificationContents">pushNotificationContents.</param>
        /// <param name="enableEmailBatching">enableEmailBatching.</param>
        /// <param name="emailBatchingBufferSize">emailBatchingBufferSize.</param>
        /// <param name="emailBatchingInterval">emailBatchingInterval.</param>
        public ConfigEmailSettings(bool enableSignUpWithEmail = default(bool), bool enableSignInWithEmail = default(bool), bool enableSignInWithUsername = default(bool), bool sendEmailNotifications = default(bool), bool requireEmailVerification = default(bool), string feedbackName = default(string), string feedbackEmail = default(string), string feedbackOrganization = default(string), string sMTPUsername = default(string), string sMTPPassword = default(string), string sMTPServer = default(string), string sMTPPort = default(string), string connectionSecurity = default(string), string inviteSalt = default(string), string passwordResetSalt = default(string), bool sendPushNotifications = default(bool), string pushNotificationServer = default(string), string pushNotificationContents = default(string), bool enableEmailBatching = default(bool), int emailBatchingBufferSize = default(int), int emailBatchingInterval = default(int))
        {
            this.EnableSignUpWithEmail = enableSignUpWithEmail;
            this.EnableSignInWithEmail = enableSignInWithEmail;
            this.EnableSignInWithUsername = enableSignInWithUsername;
            this.SendEmailNotifications = sendEmailNotifications;
            this.RequireEmailVerification = requireEmailVerification;
            this.FeedbackName = feedbackName;
            this.FeedbackEmail = feedbackEmail;
            this.FeedbackOrganization = feedbackOrganization;
            this.SMTPUsername = sMTPUsername;
            this.SMTPPassword = sMTPPassword;
            this.SMTPServer = sMTPServer;
            this.SMTPPort = sMTPPort;
            this.ConnectionSecurity = connectionSecurity;
            this.InviteSalt = inviteSalt;
            this.PasswordResetSalt = passwordResetSalt;
            this.SendPushNotifications = sendPushNotifications;
            this.PushNotificationServer = pushNotificationServer;
            this.PushNotificationContents = pushNotificationContents;
            this.EnableEmailBatching = enableEmailBatching;
            this.EmailBatchingBufferSize = emailBatchingBufferSize;
            this.EmailBatchingInterval = emailBatchingInterval;
        }
        
        /// <summary>
        /// Gets or Sets EnableSignUpWithEmail
        /// </summary>
        [DataMember(Name="EnableSignUpWithEmail", EmitDefaultValue=false)]
        public bool EnableSignUpWithEmail { get; set; }

        /// <summary>
        /// Gets or Sets EnableSignInWithEmail
        /// </summary>
        [DataMember(Name="EnableSignInWithEmail", EmitDefaultValue=false)]
        public bool EnableSignInWithEmail { get; set; }

        /// <summary>
        /// Gets or Sets EnableSignInWithUsername
        /// </summary>
        [DataMember(Name="EnableSignInWithUsername", EmitDefaultValue=false)]
        public bool EnableSignInWithUsername { get; set; }

        /// <summary>
        /// Gets or Sets SendEmailNotifications
        /// </summary>
        [DataMember(Name="SendEmailNotifications", EmitDefaultValue=false)]
        public bool SendEmailNotifications { get; set; }

        /// <summary>
        /// Gets or Sets RequireEmailVerification
        /// </summary>
        [DataMember(Name="RequireEmailVerification", EmitDefaultValue=false)]
        public bool RequireEmailVerification { get; set; }

        /// <summary>
        /// Gets or Sets FeedbackName
        /// </summary>
        [DataMember(Name="FeedbackName", EmitDefaultValue=false)]
        public string FeedbackName { get; set; }

        /// <summary>
        /// Gets or Sets FeedbackEmail
        /// </summary>
        [DataMember(Name="FeedbackEmail", EmitDefaultValue=false)]
        public string FeedbackEmail { get; set; }

        /// <summary>
        /// Gets or Sets FeedbackOrganization
        /// </summary>
        [DataMember(Name="FeedbackOrganization", EmitDefaultValue=false)]
        public string FeedbackOrganization { get; set; }

        /// <summary>
        /// Gets or Sets SMTPUsername
        /// </summary>
        [DataMember(Name="SMTPUsername", EmitDefaultValue=false)]
        public string SMTPUsername { get; set; }

        /// <summary>
        /// Gets or Sets SMTPPassword
        /// </summary>
        [DataMember(Name="SMTPPassword", EmitDefaultValue=false)]
        public string SMTPPassword { get; set; }

        /// <summary>
        /// Gets or Sets SMTPServer
        /// </summary>
        [DataMember(Name="SMTPServer", EmitDefaultValue=false)]
        public string SMTPServer { get; set; }

        /// <summary>
        /// Gets or Sets SMTPPort
        /// </summary>
        [DataMember(Name="SMTPPort", EmitDefaultValue=false)]
        public string SMTPPort { get; set; }

        /// <summary>
        /// Gets or Sets ConnectionSecurity
        /// </summary>
        [DataMember(Name="ConnectionSecurity", EmitDefaultValue=false)]
        public string ConnectionSecurity { get; set; }

        /// <summary>
        /// Gets or Sets InviteSalt
        /// </summary>
        [DataMember(Name="InviteSalt", EmitDefaultValue=false)]
        public string InviteSalt { get; set; }

        /// <summary>
        /// Gets or Sets PasswordResetSalt
        /// </summary>
        [DataMember(Name="PasswordResetSalt", EmitDefaultValue=false)]
        public string PasswordResetSalt { get; set; }

        /// <summary>
        /// Gets or Sets SendPushNotifications
        /// </summary>
        [DataMember(Name="SendPushNotifications", EmitDefaultValue=false)]
        public bool SendPushNotifications { get; set; }

        /// <summary>
        /// Gets or Sets PushNotificationServer
        /// </summary>
        [DataMember(Name="PushNotificationServer", EmitDefaultValue=false)]
        public string PushNotificationServer { get; set; }

        /// <summary>
        /// Gets or Sets PushNotificationContents
        /// </summary>
        [DataMember(Name="PushNotificationContents", EmitDefaultValue=false)]
        public string PushNotificationContents { get; set; }

        /// <summary>
        /// Gets or Sets EnableEmailBatching
        /// </summary>
        [DataMember(Name="EnableEmailBatching", EmitDefaultValue=false)]
        public bool EnableEmailBatching { get; set; }

        /// <summary>
        /// Gets or Sets EmailBatchingBufferSize
        /// </summary>
        [DataMember(Name="EmailBatchingBufferSize", EmitDefaultValue=false)]
        public int EmailBatchingBufferSize { get; set; }

        /// <summary>
        /// Gets or Sets EmailBatchingInterval
        /// </summary>
        [DataMember(Name="EmailBatchingInterval", EmitDefaultValue=false)]
        public int EmailBatchingInterval { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfigEmailSettings {\n");
            sb.Append("  EnableSignUpWithEmail: ").Append(EnableSignUpWithEmail).Append("\n");
            sb.Append("  EnableSignInWithEmail: ").Append(EnableSignInWithEmail).Append("\n");
            sb.Append("  EnableSignInWithUsername: ").Append(EnableSignInWithUsername).Append("\n");
            sb.Append("  SendEmailNotifications: ").Append(SendEmailNotifications).Append("\n");
            sb.Append("  RequireEmailVerification: ").Append(RequireEmailVerification).Append("\n");
            sb.Append("  FeedbackName: ").Append(FeedbackName).Append("\n");
            sb.Append("  FeedbackEmail: ").Append(FeedbackEmail).Append("\n");
            sb.Append("  FeedbackOrganization: ").Append(FeedbackOrganization).Append("\n");
            sb.Append("  SMTPUsername: ").Append(SMTPUsername).Append("\n");
            sb.Append("  SMTPPassword: ").Append(SMTPPassword).Append("\n");
            sb.Append("  SMTPServer: ").Append(SMTPServer).Append("\n");
            sb.Append("  SMTPPort: ").Append(SMTPPort).Append("\n");
            sb.Append("  ConnectionSecurity: ").Append(ConnectionSecurity).Append("\n");
            sb.Append("  InviteSalt: ").Append(InviteSalt).Append("\n");
            sb.Append("  PasswordResetSalt: ").Append(PasswordResetSalt).Append("\n");
            sb.Append("  SendPushNotifications: ").Append(SendPushNotifications).Append("\n");
            sb.Append("  PushNotificationServer: ").Append(PushNotificationServer).Append("\n");
            sb.Append("  PushNotificationContents: ").Append(PushNotificationContents).Append("\n");
            sb.Append("  EnableEmailBatching: ").Append(EnableEmailBatching).Append("\n");
            sb.Append("  EmailBatchingBufferSize: ").Append(EmailBatchingBufferSize).Append("\n");
            sb.Append("  EmailBatchingInterval: ").Append(EmailBatchingInterval).Append("\n");
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
            return this.Equals(input as ConfigEmailSettings);
        }

        /// <summary>
        /// Returns true if ConfigEmailSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of ConfigEmailSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfigEmailSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EnableSignUpWithEmail == input.EnableSignUpWithEmail ||
                    this.EnableSignUpWithEmail.Equals(input.EnableSignUpWithEmail)
                ) && 
                (
                    this.EnableSignInWithEmail == input.EnableSignInWithEmail ||
                    this.EnableSignInWithEmail.Equals(input.EnableSignInWithEmail)
                ) && 
                (
                    this.EnableSignInWithUsername == input.EnableSignInWithUsername ||
                    this.EnableSignInWithUsername.Equals(input.EnableSignInWithUsername)
                ) && 
                (
                    this.SendEmailNotifications == input.SendEmailNotifications ||
                    this.SendEmailNotifications.Equals(input.SendEmailNotifications)
                ) && 
                (
                    this.RequireEmailVerification == input.RequireEmailVerification ||
                    this.RequireEmailVerification.Equals(input.RequireEmailVerification)
                ) && 
                (
                    this.FeedbackName == input.FeedbackName ||
                    (this.FeedbackName != null &&
                    this.FeedbackName.Equals(input.FeedbackName))
                ) && 
                (
                    this.FeedbackEmail == input.FeedbackEmail ||
                    (this.FeedbackEmail != null &&
                    this.FeedbackEmail.Equals(input.FeedbackEmail))
                ) && 
                (
                    this.FeedbackOrganization == input.FeedbackOrganization ||
                    (this.FeedbackOrganization != null &&
                    this.FeedbackOrganization.Equals(input.FeedbackOrganization))
                ) && 
                (
                    this.SMTPUsername == input.SMTPUsername ||
                    (this.SMTPUsername != null &&
                    this.SMTPUsername.Equals(input.SMTPUsername))
                ) && 
                (
                    this.SMTPPassword == input.SMTPPassword ||
                    (this.SMTPPassword != null &&
                    this.SMTPPassword.Equals(input.SMTPPassword))
                ) && 
                (
                    this.SMTPServer == input.SMTPServer ||
                    (this.SMTPServer != null &&
                    this.SMTPServer.Equals(input.SMTPServer))
                ) && 
                (
                    this.SMTPPort == input.SMTPPort ||
                    (this.SMTPPort != null &&
                    this.SMTPPort.Equals(input.SMTPPort))
                ) && 
                (
                    this.ConnectionSecurity == input.ConnectionSecurity ||
                    (this.ConnectionSecurity != null &&
                    this.ConnectionSecurity.Equals(input.ConnectionSecurity))
                ) && 
                (
                    this.InviteSalt == input.InviteSalt ||
                    (this.InviteSalt != null &&
                    this.InviteSalt.Equals(input.InviteSalt))
                ) && 
                (
                    this.PasswordResetSalt == input.PasswordResetSalt ||
                    (this.PasswordResetSalt != null &&
                    this.PasswordResetSalt.Equals(input.PasswordResetSalt))
                ) && 
                (
                    this.SendPushNotifications == input.SendPushNotifications ||
                    this.SendPushNotifications.Equals(input.SendPushNotifications)
                ) && 
                (
                    this.PushNotificationServer == input.PushNotificationServer ||
                    (this.PushNotificationServer != null &&
                    this.PushNotificationServer.Equals(input.PushNotificationServer))
                ) && 
                (
                    this.PushNotificationContents == input.PushNotificationContents ||
                    (this.PushNotificationContents != null &&
                    this.PushNotificationContents.Equals(input.PushNotificationContents))
                ) && 
                (
                    this.EnableEmailBatching == input.EnableEmailBatching ||
                    this.EnableEmailBatching.Equals(input.EnableEmailBatching)
                ) && 
                (
                    this.EmailBatchingBufferSize == input.EmailBatchingBufferSize ||
                    this.EmailBatchingBufferSize.Equals(input.EmailBatchingBufferSize)
                ) && 
                (
                    this.EmailBatchingInterval == input.EmailBatchingInterval ||
                    this.EmailBatchingInterval.Equals(input.EmailBatchingInterval)
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
                hashCode = hashCode * 59 + this.EnableSignUpWithEmail.GetHashCode();
                hashCode = hashCode * 59 + this.EnableSignInWithEmail.GetHashCode();
                hashCode = hashCode * 59 + this.EnableSignInWithUsername.GetHashCode();
                hashCode = hashCode * 59 + this.SendEmailNotifications.GetHashCode();
                hashCode = hashCode * 59 + this.RequireEmailVerification.GetHashCode();
                if (this.FeedbackName != null)
                    hashCode = hashCode * 59 + this.FeedbackName.GetHashCode();
                if (this.FeedbackEmail != null)
                    hashCode = hashCode * 59 + this.FeedbackEmail.GetHashCode();
                if (this.FeedbackOrganization != null)
                    hashCode = hashCode * 59 + this.FeedbackOrganization.GetHashCode();
                if (this.SMTPUsername != null)
                    hashCode = hashCode * 59 + this.SMTPUsername.GetHashCode();
                if (this.SMTPPassword != null)
                    hashCode = hashCode * 59 + this.SMTPPassword.GetHashCode();
                if (this.SMTPServer != null)
                    hashCode = hashCode * 59 + this.SMTPServer.GetHashCode();
                if (this.SMTPPort != null)
                    hashCode = hashCode * 59 + this.SMTPPort.GetHashCode();
                if (this.ConnectionSecurity != null)
                    hashCode = hashCode * 59 + this.ConnectionSecurity.GetHashCode();
                if (this.InviteSalt != null)
                    hashCode = hashCode * 59 + this.InviteSalt.GetHashCode();
                if (this.PasswordResetSalt != null)
                    hashCode = hashCode * 59 + this.PasswordResetSalt.GetHashCode();
                hashCode = hashCode * 59 + this.SendPushNotifications.GetHashCode();
                if (this.PushNotificationServer != null)
                    hashCode = hashCode * 59 + this.PushNotificationServer.GetHashCode();
                if (this.PushNotificationContents != null)
                    hashCode = hashCode * 59 + this.PushNotificationContents.GetHashCode();
                hashCode = hashCode * 59 + this.EnableEmailBatching.GetHashCode();
                hashCode = hashCode * 59 + this.EmailBatchingBufferSize.GetHashCode();
                hashCode = hashCode * 59 + this.EmailBatchingInterval.GetHashCode();
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
