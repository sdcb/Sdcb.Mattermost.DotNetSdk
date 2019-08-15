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
    /// ConfigRateLimitSettings
    /// </summary>
    [DataContract]
    public partial class ConfigRateLimitSettings :  IEquatable<ConfigRateLimitSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigRateLimitSettings" /> class.
        /// </summary>
        /// <param name="enable">enable.</param>
        /// <param name="perSec">perSec.</param>
        /// <param name="maxBurst">maxBurst.</param>
        /// <param name="memoryStoreSize">memoryStoreSize.</param>
        /// <param name="varyByRemoteAddr">varyByRemoteAddr.</param>
        /// <param name="varyByHeader">varyByHeader.</param>
        public ConfigRateLimitSettings(bool enable = default(bool), int perSec = default(int), int maxBurst = default(int), int memoryStoreSize = default(int), bool varyByRemoteAddr = default(bool), string varyByHeader = default(string))
        {
            this.Enable = enable;
            this.PerSec = perSec;
            this.MaxBurst = maxBurst;
            this.MemoryStoreSize = memoryStoreSize;
            this.VaryByRemoteAddr = varyByRemoteAddr;
            this.VaryByHeader = varyByHeader;
        }
        
        /// <summary>
        /// Gets or Sets Enable
        /// </summary>
        [DataMember(Name="Enable", EmitDefaultValue=false)]
        public bool Enable { get; set; }

        /// <summary>
        /// Gets or Sets PerSec
        /// </summary>
        [DataMember(Name="PerSec", EmitDefaultValue=false)]
        public int PerSec { get; set; }

        /// <summary>
        /// Gets or Sets MaxBurst
        /// </summary>
        [DataMember(Name="MaxBurst", EmitDefaultValue=false)]
        public int MaxBurst { get; set; }

        /// <summary>
        /// Gets or Sets MemoryStoreSize
        /// </summary>
        [DataMember(Name="MemoryStoreSize", EmitDefaultValue=false)]
        public int MemoryStoreSize { get; set; }

        /// <summary>
        /// Gets or Sets VaryByRemoteAddr
        /// </summary>
        [DataMember(Name="VaryByRemoteAddr", EmitDefaultValue=false)]
        public bool VaryByRemoteAddr { get; set; }

        /// <summary>
        /// Gets or Sets VaryByHeader
        /// </summary>
        [DataMember(Name="VaryByHeader", EmitDefaultValue=false)]
        public string VaryByHeader { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfigRateLimitSettings {\n");
            sb.Append("  Enable: ").Append(Enable).Append("\n");
            sb.Append("  PerSec: ").Append(PerSec).Append("\n");
            sb.Append("  MaxBurst: ").Append(MaxBurst).Append("\n");
            sb.Append("  MemoryStoreSize: ").Append(MemoryStoreSize).Append("\n");
            sb.Append("  VaryByRemoteAddr: ").Append(VaryByRemoteAddr).Append("\n");
            sb.Append("  VaryByHeader: ").Append(VaryByHeader).Append("\n");
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
            return this.Equals(input as ConfigRateLimitSettings);
        }

        /// <summary>
        /// Returns true if ConfigRateLimitSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of ConfigRateLimitSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfigRateLimitSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Enable == input.Enable ||
                    this.Enable.Equals(input.Enable)
                ) && 
                (
                    this.PerSec == input.PerSec ||
                    this.PerSec.Equals(input.PerSec)
                ) && 
                (
                    this.MaxBurst == input.MaxBurst ||
                    this.MaxBurst.Equals(input.MaxBurst)
                ) && 
                (
                    this.MemoryStoreSize == input.MemoryStoreSize ||
                    this.MemoryStoreSize.Equals(input.MemoryStoreSize)
                ) && 
                (
                    this.VaryByRemoteAddr == input.VaryByRemoteAddr ||
                    this.VaryByRemoteAddr.Equals(input.VaryByRemoteAddr)
                ) && 
                (
                    this.VaryByHeader == input.VaryByHeader ||
                    (this.VaryByHeader != null &&
                    this.VaryByHeader.Equals(input.VaryByHeader))
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
                hashCode = hashCode * 59 + this.PerSec.GetHashCode();
                hashCode = hashCode * 59 + this.MaxBurst.GetHashCode();
                hashCode = hashCode * 59 + this.MemoryStoreSize.GetHashCode();
                hashCode = hashCode * 59 + this.VaryByRemoteAddr.GetHashCode();
                if (this.VaryByHeader != null)
                    hashCode = hashCode * 59 + this.VaryByHeader.GetHashCode();
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