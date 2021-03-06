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
    /// PluginManifestWebapp
    /// </summary>
    [DataContract]
    public partial class PluginManifestWebapp :  IEquatable<PluginManifestWebapp>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PluginManifestWebapp" /> class.
        /// </summary>
        /// <param name="bundlePath">Path to the webapp JavaScript bundle..</param>
        public PluginManifestWebapp(string bundlePath = default(string))
        {
            this.BundlePath = bundlePath;
        }
        
        /// <summary>
        /// Path to the webapp JavaScript bundle.
        /// </summary>
        /// <value>Path to the webapp JavaScript bundle.</value>
        [DataMember(Name="bundle_path", EmitDefaultValue=false)]
        public string BundlePath { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PluginManifestWebapp {\n");
            sb.Append("  BundlePath: ").Append(BundlePath).Append("\n");
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
            return this.Equals(input as PluginManifestWebapp);
        }

        /// <summary>
        /// Returns true if PluginManifestWebapp instances are equal
        /// </summary>
        /// <param name="input">Instance of PluginManifestWebapp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PluginManifestWebapp input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BundlePath == input.BundlePath ||
                    (this.BundlePath != null &&
                    this.BundlePath.Equals(input.BundlePath))
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
                if (this.BundlePath != null)
                    hashCode = hashCode * 59 + this.BundlePath.GetHashCode();
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
