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
    /// UserAutocompleteInTeam
    /// </summary>
    [DataContract]
    public partial class UserAutocompleteInTeam :  IEquatable<UserAutocompleteInTeam>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserAutocompleteInTeam" /> class.
        /// </summary>
        /// <param name="inTeam">A list of user objects in the team.</param>
        public UserAutocompleteInTeam(List<User> inTeam = default(List<User>))
        {
            this.InTeam = inTeam;
        }
        
        /// <summary>
        /// A list of user objects in the team
        /// </summary>
        /// <value>A list of user objects in the team</value>
        [DataMember(Name="in_team", EmitDefaultValue=false)]
        public List<User> InTeam { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserAutocompleteInTeam {\n");
            sb.Append("  InTeam: ").Append(InTeam).Append("\n");
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
            return this.Equals(input as UserAutocompleteInTeam);
        }

        /// <summary>
        /// Returns true if UserAutocompleteInTeam instances are equal
        /// </summary>
        /// <param name="input">Instance of UserAutocompleteInTeam to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserAutocompleteInTeam input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InTeam == input.InTeam ||
                    this.InTeam != null &&
                    input.InTeam != null &&
                    this.InTeam.SequenceEqual(input.InTeam)
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
                if (this.InTeam != null)
                    hashCode = hashCode * 59 + this.InTeam.GetHashCode();
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
