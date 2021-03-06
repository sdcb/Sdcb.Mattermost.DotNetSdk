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
    /// Role
    /// </summary>
    [DataContract]
    public partial class Role :  IEquatable<Role>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Role" /> class.
        /// </summary>
        /// <param name="id">The unique identifier of the role..</param>
        /// <param name="name">The unique name of the role, used when assigning roles to users/groups in contexts..</param>
        /// <param name="displayName">The human readable name for the role..</param>
        /// <param name="description">A human readable description of the role..</param>
        /// <param name="permissions">A list of the unique names of the permissions this role grants..</param>
        /// <param name="schemeManaged">indicates if this role is managed by a scheme (true), or is a custom stand-alone role (false)..</param>
        public Role(string id = default(string), string name = default(string), string displayName = default(string), string description = default(string), List<string> permissions = default(List<string>), bool schemeManaged = default(bool))
        {
            this.Id = id;
            this.Name = name;
            this.DisplayName = displayName;
            this.Description = description;
            this.Permissions = permissions;
            this.SchemeManaged = schemeManaged;
        }
        
        /// <summary>
        /// The unique identifier of the role.
        /// </summary>
        /// <value>The unique identifier of the role.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The unique name of the role, used when assigning roles to users/groups in contexts.
        /// </summary>
        /// <value>The unique name of the role, used when assigning roles to users/groups in contexts.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The human readable name for the role.
        /// </summary>
        /// <value>The human readable name for the role.</value>
        [DataMember(Name="display_name", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// A human readable description of the role.
        /// </summary>
        /// <value>A human readable description of the role.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// A list of the unique names of the permissions this role grants.
        /// </summary>
        /// <value>A list of the unique names of the permissions this role grants.</value>
        [DataMember(Name="permissions", EmitDefaultValue=false)]
        public List<string> Permissions { get; set; }

        /// <summary>
        /// indicates if this role is managed by a scheme (true), or is a custom stand-alone role (false).
        /// </summary>
        /// <value>indicates if this role is managed by a scheme (true), or is a custom stand-alone role (false).</value>
        [DataMember(Name="scheme_managed", EmitDefaultValue=false)]
        public bool SchemeManaged { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Role {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  SchemeManaged: ").Append(SchemeManaged).Append("\n");
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
            return this.Equals(input as Role);
        }

        /// <summary>
        /// Returns true if Role instances are equal
        /// </summary>
        /// <param name="input">Instance of Role to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Role input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Permissions == input.Permissions ||
                    this.Permissions != null &&
                    input.Permissions != null &&
                    this.Permissions.SequenceEqual(input.Permissions)
                ) && 
                (
                    this.SchemeManaged == input.SchemeManaged ||
                    this.SchemeManaged.Equals(input.SchemeManaged)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Permissions != null)
                    hashCode = hashCode * 59 + this.Permissions.GetHashCode();
                hashCode = hashCode * 59 + this.SchemeManaged.GetHashCode();
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
