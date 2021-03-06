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
    /// UsersStats
    /// </summary>
    [DataContract]
    public partial class UsersStats :  IEquatable<UsersStats>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersStats" /> class.
        /// </summary>
        /// <param name="totalUsersCount">totalUsersCount.</param>
        public UsersStats(int totalUsersCount = default(int))
        {
            this.TotalUsersCount = totalUsersCount;
        }
        
        /// <summary>
        /// Gets or Sets TotalUsersCount
        /// </summary>
        [DataMember(Name="total_users_count", EmitDefaultValue=false)]
        public int TotalUsersCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UsersStats {\n");
            sb.Append("  TotalUsersCount: ").Append(TotalUsersCount).Append("\n");
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
            return this.Equals(input as UsersStats);
        }

        /// <summary>
        /// Returns true if UsersStats instances are equal
        /// </summary>
        /// <param name="input">Instance of UsersStats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UsersStats input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TotalUsersCount == input.TotalUsersCount ||
                    this.TotalUsersCount.Equals(input.TotalUsersCount)
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
                hashCode = hashCode * 59 + this.TotalUsersCount.GetHashCode();
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
