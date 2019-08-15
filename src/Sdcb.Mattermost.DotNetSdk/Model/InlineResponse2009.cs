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
    /// InlineResponse2009
    /// </summary>
    [DataContract]
    public partial class InlineResponse2009 :  IEquatable<InlineResponse2009>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2009" /> class.
        /// </summary>
        /// <param name="active">active.</param>
        /// <param name="inactive">inactive.</param>
        public InlineResponse2009(List<PluginManifest> active = default(List<PluginManifest>), List<PluginManifest> inactive = default(List<PluginManifest>))
        {
            this.Active = active;
            this.Inactive = inactive;
        }
        
        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public List<PluginManifest> Active { get; set; }

        /// <summary>
        /// Gets or Sets Inactive
        /// </summary>
        [DataMember(Name="inactive", EmitDefaultValue=false)]
        public List<PluginManifest> Inactive { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2009 {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Inactive: ").Append(Inactive).Append("\n");
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
            return this.Equals(input as InlineResponse2009);
        }

        /// <summary>
        /// Returns true if InlineResponse2009 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse2009 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2009 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Active == input.Active ||
                    this.Active != null &&
                    input.Active != null &&
                    this.Active.SequenceEqual(input.Active)
                ) && 
                (
                    this.Inactive == input.Inactive ||
                    this.Inactive != null &&
                    input.Inactive != null &&
                    this.Inactive.SequenceEqual(input.Inactive)
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
                if (this.Active != null)
                    hashCode = hashCode * 59 + this.Active.GetHashCode();
                if (this.Inactive != null)
                    hashCode = hashCode * 59 + this.Inactive.GetHashCode();
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