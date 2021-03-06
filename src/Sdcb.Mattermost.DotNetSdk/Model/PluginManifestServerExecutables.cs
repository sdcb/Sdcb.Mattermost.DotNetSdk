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
    /// Paths to executable binaries, specifying multiple entry points for different platforms when bundled together in a single plugin.
    /// </summary>
    [DataContract]
    public partial class PluginManifestServerExecutables :  IEquatable<PluginManifestServerExecutables>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PluginManifestServerExecutables" /> class.
        /// </summary>
        /// <param name="linuxAmd64">linuxAmd64.</param>
        /// <param name="darwinAmd64">darwinAmd64.</param>
        /// <param name="windowsAmd64">windowsAmd64.</param>
        public PluginManifestServerExecutables(string linuxAmd64 = default(string), string darwinAmd64 = default(string), string windowsAmd64 = default(string))
        {
            this.LinuxAmd64 = linuxAmd64;
            this.DarwinAmd64 = darwinAmd64;
            this.WindowsAmd64 = windowsAmd64;
        }
        
        /// <summary>
        /// Gets or Sets LinuxAmd64
        /// </summary>
        [DataMember(Name="linux-amd64", EmitDefaultValue=false)]
        public string LinuxAmd64 { get; set; }

        /// <summary>
        /// Gets or Sets DarwinAmd64
        /// </summary>
        [DataMember(Name="darwin-amd64", EmitDefaultValue=false)]
        public string DarwinAmd64 { get; set; }

        /// <summary>
        /// Gets or Sets WindowsAmd64
        /// </summary>
        [DataMember(Name="windows-amd64", EmitDefaultValue=false)]
        public string WindowsAmd64 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PluginManifestServerExecutables {\n");
            sb.Append("  LinuxAmd64: ").Append(LinuxAmd64).Append("\n");
            sb.Append("  DarwinAmd64: ").Append(DarwinAmd64).Append("\n");
            sb.Append("  WindowsAmd64: ").Append(WindowsAmd64).Append("\n");
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
            return this.Equals(input as PluginManifestServerExecutables);
        }

        /// <summary>
        /// Returns true if PluginManifestServerExecutables instances are equal
        /// </summary>
        /// <param name="input">Instance of PluginManifestServerExecutables to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PluginManifestServerExecutables input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LinuxAmd64 == input.LinuxAmd64 ||
                    (this.LinuxAmd64 != null &&
                    this.LinuxAmd64.Equals(input.LinuxAmd64))
                ) && 
                (
                    this.DarwinAmd64 == input.DarwinAmd64 ||
                    (this.DarwinAmd64 != null &&
                    this.DarwinAmd64.Equals(input.DarwinAmd64))
                ) && 
                (
                    this.WindowsAmd64 == input.WindowsAmd64 ||
                    (this.WindowsAmd64 != null &&
                    this.WindowsAmd64.Equals(input.WindowsAmd64))
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
                if (this.LinuxAmd64 != null)
                    hashCode = hashCode * 59 + this.LinuxAmd64.GetHashCode();
                if (this.DarwinAmd64 != null)
                    hashCode = hashCode * 59 + this.DarwinAmd64.GetHashCode();
                if (this.WindowsAmd64 != null)
                    hashCode = hashCode * 59 + this.WindowsAmd64.GetHashCode();
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
