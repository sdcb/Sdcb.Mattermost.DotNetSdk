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
    /// InlineObject38
    /// </summary>
    [DataContract]
    public partial class InlineObject38 :  IEquatable<InlineObject38>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject38" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InlineObject38() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject38" /> class.
        /// </summary>
        /// <param name="schemeAdmin">schemeAdmin (required).</param>
        /// <param name="schemeUser">schemeUser (required).</param>
        public InlineObject38(bool schemeAdmin = default(bool), bool schemeUser = default(bool))
        {
            // to ensure "schemeAdmin" is required (not null)
            if (schemeAdmin == null)
            {
                throw new InvalidDataException("schemeAdmin is a required property for InlineObject38 and cannot be null");
            }
            else
            {
                this.SchemeAdmin = schemeAdmin;
            }

            // to ensure "schemeUser" is required (not null)
            if (schemeUser == null)
            {
                throw new InvalidDataException("schemeUser is a required property for InlineObject38 and cannot be null");
            }
            else
            {
                this.SchemeUser = schemeUser;
            }

        }
        
        /// <summary>
        /// Gets or Sets SchemeAdmin
        /// </summary>
        [DataMember(Name="scheme_admin", EmitDefaultValue=false)]
        public bool SchemeAdmin { get; set; }

        /// <summary>
        /// Gets or Sets SchemeUser
        /// </summary>
        [DataMember(Name="scheme_user", EmitDefaultValue=false)]
        public bool SchemeUser { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineObject38 {\n");
            sb.Append("  SchemeAdmin: ").Append(SchemeAdmin).Append("\n");
            sb.Append("  SchemeUser: ").Append(SchemeUser).Append("\n");
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
            return this.Equals(input as InlineObject38);
        }

        /// <summary>
        /// Returns true if InlineObject38 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineObject38 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineObject38 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SchemeAdmin == input.SchemeAdmin ||
                    this.SchemeAdmin.Equals(input.SchemeAdmin)
                ) && 
                (
                    this.SchemeUser == input.SchemeUser ||
                    this.SchemeUser.Equals(input.SchemeUser)
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
                hashCode = hashCode * 59 + this.SchemeAdmin.GetHashCode();
                hashCode = hashCode * 59 + this.SchemeUser.GetHashCode();
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