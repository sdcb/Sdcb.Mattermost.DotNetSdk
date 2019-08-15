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
    /// InlineObject12
    /// </summary>
    [DataContract]
    public partial class InlineObject12 :  IEquatable<InlineObject12>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject12" /> class.
        /// </summary>
        [JsonConstructor]
        protected InlineObject12() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject12" /> class.
        /// </summary>
        /// <param name="deviceId">Mobile device id. For Android prefix the id with &#x60;android:&#x60; and Apple with &#x60;apple:&#x60; (required).</param>
        public InlineObject12(string deviceId = default(string))
        {
            // to ensure "deviceId" is required (not null)
            if (deviceId == null)
            {
                throw new InvalidDataException("deviceId is a required property for InlineObject12 and cannot be null");
            }
            else
            {
                this.DeviceId = deviceId;
            }

        }
        
        /// <summary>
        /// Mobile device id. For Android prefix the id with &#x60;android:&#x60; and Apple with &#x60;apple:&#x60;
        /// </summary>
        /// <value>Mobile device id. For Android prefix the id with &#x60;android:&#x60; and Apple with &#x60;apple:&#x60;</value>
        [DataMember(Name="device_id", EmitDefaultValue=false)]
        public string DeviceId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineObject12 {\n");
            sb.Append("  DeviceId: ").Append(DeviceId).Append("\n");
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
            return this.Equals(input as InlineObject12);
        }

        /// <summary>
        /// Returns true if InlineObject12 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineObject12 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineObject12 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DeviceId == input.DeviceId ||
                    (this.DeviceId != null &&
                    this.DeviceId.Equals(input.DeviceId))
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
                if (this.DeviceId != null)
                    hashCode = hashCode * 59 + this.DeviceId.GetHashCode();
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
