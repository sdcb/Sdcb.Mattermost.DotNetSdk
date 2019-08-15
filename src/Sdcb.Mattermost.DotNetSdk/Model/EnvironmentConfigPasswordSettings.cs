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
    /// EnvironmentConfigPasswordSettings
    /// </summary>
    [DataContract]
    public partial class EnvironmentConfigPasswordSettings :  IEquatable<EnvironmentConfigPasswordSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentConfigPasswordSettings" /> class.
        /// </summary>
        /// <param name="minimumLength">minimumLength.</param>
        /// <param name="lowercase">lowercase.</param>
        /// <param name="number">number.</param>
        /// <param name="uppercase">uppercase.</param>
        /// <param name="symbol">symbol.</param>
        public EnvironmentConfigPasswordSettings(bool minimumLength = default(bool), bool lowercase = default(bool), bool number = default(bool), bool uppercase = default(bool), bool symbol = default(bool))
        {
            this.MinimumLength = minimumLength;
            this.Lowercase = lowercase;
            this.Number = number;
            this.Uppercase = uppercase;
            this.Symbol = symbol;
        }
        
        /// <summary>
        /// Gets or Sets MinimumLength
        /// </summary>
        [DataMember(Name="MinimumLength", EmitDefaultValue=false)]
        public bool MinimumLength { get; set; }

        /// <summary>
        /// Gets or Sets Lowercase
        /// </summary>
        [DataMember(Name="Lowercase", EmitDefaultValue=false)]
        public bool Lowercase { get; set; }

        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [DataMember(Name="Number", EmitDefaultValue=false)]
        public bool Number { get; set; }

        /// <summary>
        /// Gets or Sets Uppercase
        /// </summary>
        [DataMember(Name="Uppercase", EmitDefaultValue=false)]
        public bool Uppercase { get; set; }

        /// <summary>
        /// Gets or Sets Symbol
        /// </summary>
        [DataMember(Name="Symbol", EmitDefaultValue=false)]
        public bool Symbol { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnvironmentConfigPasswordSettings {\n");
            sb.Append("  MinimumLength: ").Append(MinimumLength).Append("\n");
            sb.Append("  Lowercase: ").Append(Lowercase).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Uppercase: ").Append(Uppercase).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
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
            return this.Equals(input as EnvironmentConfigPasswordSettings);
        }

        /// <summary>
        /// Returns true if EnvironmentConfigPasswordSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of EnvironmentConfigPasswordSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnvironmentConfigPasswordSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MinimumLength == input.MinimumLength ||
                    this.MinimumLength.Equals(input.MinimumLength)
                ) && 
                (
                    this.Lowercase == input.Lowercase ||
                    this.Lowercase.Equals(input.Lowercase)
                ) && 
                (
                    this.Number == input.Number ||
                    this.Number.Equals(input.Number)
                ) && 
                (
                    this.Uppercase == input.Uppercase ||
                    this.Uppercase.Equals(input.Uppercase)
                ) && 
                (
                    this.Symbol == input.Symbol ||
                    this.Symbol.Equals(input.Symbol)
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
                hashCode = hashCode * 59 + this.MinimumLength.GetHashCode();
                hashCode = hashCode * 59 + this.Lowercase.GetHashCode();
                hashCode = hashCode * 59 + this.Number.GetHashCode();
                hashCode = hashCode * 59 + this.Uppercase.GetHashCode();
                hashCode = hashCode * 59 + this.Symbol.GetHashCode();
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
