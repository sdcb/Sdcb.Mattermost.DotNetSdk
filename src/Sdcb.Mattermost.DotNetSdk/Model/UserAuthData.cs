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
    /// UserAuthData
    /// </summary>
    [DataContract]
    public partial class UserAuthData :  IEquatable<UserAuthData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserAuthData" /> class.
        /// </summary>
        /// <param name="authData">Service-specific authentication data.</param>
        /// <param name="authService">The authentication service such as \&quot;email\&quot;, \&quot;gitlab\&quot;, or \&quot;ldap\&quot;.</param>
        /// <param name="password">The password used for email authentication.</param>
        public UserAuthData(string authData = default(string), string authService = default(string), string password = default(string))
        {
            this.AuthData = authData;
            this.AuthService = authService;
            this.Password = password;
        }
        
        /// <summary>
        /// Service-specific authentication data
        /// </summary>
        /// <value>Service-specific authentication data</value>
        [DataMember(Name="auth_data", EmitDefaultValue=false)]
        public string AuthData { get; set; }

        /// <summary>
        /// The authentication service such as \&quot;email\&quot;, \&quot;gitlab\&quot;, or \&quot;ldap\&quot;
        /// </summary>
        /// <value>The authentication service such as \&quot;email\&quot;, \&quot;gitlab\&quot;, or \&quot;ldap\&quot;</value>
        [DataMember(Name="auth_service", EmitDefaultValue=false)]
        public string AuthService { get; set; }

        /// <summary>
        /// The password used for email authentication
        /// </summary>
        /// <value>The password used for email authentication</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserAuthData {\n");
            sb.Append("  AuthData: ").Append(AuthData).Append("\n");
            sb.Append("  AuthService: ").Append(AuthService).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
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
            return this.Equals(input as UserAuthData);
        }

        /// <summary>
        /// Returns true if UserAuthData instances are equal
        /// </summary>
        /// <param name="input">Instance of UserAuthData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserAuthData input)
        {
            if (input == null)
                return false;

            return 
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
                if (this.AuthData != null)
                    hashCode = hashCode * 59 + this.AuthData.GetHashCode();
                if (this.AuthService != null)
                    hashCode = hashCode * 59 + this.AuthService.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
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
