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
    /// ClusterInfo
    /// </summary>
    [DataContract]
    public partial class ClusterInfo :  IEquatable<ClusterInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterInfo" /> class.
        /// </summary>
        /// <param name="id">The unique ID for the node.</param>
        /// <param name="version">The server version the node is on.</param>
        /// <param name="configHash">The hash of the configuartion file the node is using.</param>
        /// <param name="internodeUrl">The URL used to communicate with those node from other nodes.</param>
        /// <param name="hostname">The hostname for this node.</param>
        /// <param name="lastPing">The time of the last ping to this node.</param>
        /// <param name="isAlive">Whether or not the node is alive and well.</param>
        public ClusterInfo(string id = default(string), string version = default(string), string configHash = default(string), string internodeUrl = default(string), string hostname = default(string), int lastPing = default(int), bool isAlive = default(bool))
        {
            this.Id = id;
            this.Version = version;
            this.ConfigHash = configHash;
            this.InternodeUrl = internodeUrl;
            this.Hostname = hostname;
            this.LastPing = lastPing;
            this.IsAlive = isAlive;
        }
        
        /// <summary>
        /// The unique ID for the node
        /// </summary>
        /// <value>The unique ID for the node</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The server version the node is on
        /// </summary>
        /// <value>The server version the node is on</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }

        /// <summary>
        /// The hash of the configuartion file the node is using
        /// </summary>
        /// <value>The hash of the configuartion file the node is using</value>
        [DataMember(Name="config_hash", EmitDefaultValue=false)]
        public string ConfigHash { get; set; }

        /// <summary>
        /// The URL used to communicate with those node from other nodes
        /// </summary>
        /// <value>The URL used to communicate with those node from other nodes</value>
        [DataMember(Name="internode_url", EmitDefaultValue=false)]
        public string InternodeUrl { get; set; }

        /// <summary>
        /// The hostname for this node
        /// </summary>
        /// <value>The hostname for this node</value>
        [DataMember(Name="hostname", EmitDefaultValue=false)]
        public string Hostname { get; set; }

        /// <summary>
        /// The time of the last ping to this node
        /// </summary>
        /// <value>The time of the last ping to this node</value>
        [DataMember(Name="last_ping", EmitDefaultValue=false)]
        public int LastPing { get; set; }

        /// <summary>
        /// Whether or not the node is alive and well
        /// </summary>
        /// <value>Whether or not the node is alive and well</value>
        [DataMember(Name="is_alive", EmitDefaultValue=false)]
        public bool IsAlive { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClusterInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  ConfigHash: ").Append(ConfigHash).Append("\n");
            sb.Append("  InternodeUrl: ").Append(InternodeUrl).Append("\n");
            sb.Append("  Hostname: ").Append(Hostname).Append("\n");
            sb.Append("  LastPing: ").Append(LastPing).Append("\n");
            sb.Append("  IsAlive: ").Append(IsAlive).Append("\n");
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
            return this.Equals(input as ClusterInfo);
        }

        /// <summary>
        /// Returns true if ClusterInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ClusterInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClusterInfo input)
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
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.ConfigHash == input.ConfigHash ||
                    (this.ConfigHash != null &&
                    this.ConfigHash.Equals(input.ConfigHash))
                ) && 
                (
                    this.InternodeUrl == input.InternodeUrl ||
                    (this.InternodeUrl != null &&
                    this.InternodeUrl.Equals(input.InternodeUrl))
                ) && 
                (
                    this.Hostname == input.Hostname ||
                    (this.Hostname != null &&
                    this.Hostname.Equals(input.Hostname))
                ) && 
                (
                    this.LastPing == input.LastPing ||
                    this.LastPing.Equals(input.LastPing)
                ) && 
                (
                    this.IsAlive == input.IsAlive ||
                    this.IsAlive.Equals(input.IsAlive)
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
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.ConfigHash != null)
                    hashCode = hashCode * 59 + this.ConfigHash.GetHashCode();
                if (this.InternodeUrl != null)
                    hashCode = hashCode * 59 + this.InternodeUrl.GetHashCode();
                if (this.Hostname != null)
                    hashCode = hashCode * 59 + this.Hostname.GetHashCode();
                hashCode = hashCode * 59 + this.LastPing.GetHashCode();
                hashCode = hashCode * 59 + this.IsAlive.GetHashCode();
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
