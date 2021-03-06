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
    /// ConfigClusterSettings
    /// </summary>
    [DataContract]
    public partial class ConfigClusterSettings :  IEquatable<ConfigClusterSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigClusterSettings" /> class.
        /// </summary>
        /// <param name="enable">enable.</param>
        /// <param name="interNodeListenAddress">interNodeListenAddress.</param>
        /// <param name="interNodeUrls">interNodeUrls.</param>
        public ConfigClusterSettings(bool enable = default(bool), string interNodeListenAddress = default(string), List<string> interNodeUrls = default(List<string>))
        {
            this.Enable = enable;
            this.InterNodeListenAddress = interNodeListenAddress;
            this.InterNodeUrls = interNodeUrls;
        }
        
        /// <summary>
        /// Gets or Sets Enable
        /// </summary>
        [DataMember(Name="Enable", EmitDefaultValue=false)]
        public bool Enable { get; set; }

        /// <summary>
        /// Gets or Sets InterNodeListenAddress
        /// </summary>
        [DataMember(Name="InterNodeListenAddress", EmitDefaultValue=false)]
        public string InterNodeListenAddress { get; set; }

        /// <summary>
        /// Gets or Sets InterNodeUrls
        /// </summary>
        [DataMember(Name="InterNodeUrls", EmitDefaultValue=false)]
        public List<string> InterNodeUrls { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfigClusterSettings {\n");
            sb.Append("  Enable: ").Append(Enable).Append("\n");
            sb.Append("  InterNodeListenAddress: ").Append(InterNodeListenAddress).Append("\n");
            sb.Append("  InterNodeUrls: ").Append(InterNodeUrls).Append("\n");
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
            return this.Equals(input as ConfigClusterSettings);
        }

        /// <summary>
        /// Returns true if ConfigClusterSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of ConfigClusterSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfigClusterSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Enable == input.Enable ||
                    this.Enable.Equals(input.Enable)
                ) && 
                (
                    this.InterNodeListenAddress == input.InterNodeListenAddress ||
                    (this.InterNodeListenAddress != null &&
                    this.InterNodeListenAddress.Equals(input.InterNodeListenAddress))
                ) && 
                (
                    this.InterNodeUrls == input.InterNodeUrls ||
                    this.InterNodeUrls != null &&
                    input.InterNodeUrls != null &&
                    this.InterNodeUrls.SequenceEqual(input.InterNodeUrls)
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
                if (this.InterNodeListenAddress != null)
                    hashCode = hashCode * 59 + this.InterNodeListenAddress.GetHashCode();
                if (this.InterNodeUrls != null)
                    hashCode = hashCode * 59 + this.InterNodeUrls.GetHashCode();
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
