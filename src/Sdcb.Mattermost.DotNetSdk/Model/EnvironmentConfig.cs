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
    /// EnvironmentConfig
    /// </summary>
    [DataContract]
    public partial class EnvironmentConfig :  IEquatable<EnvironmentConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentConfig" /> class.
        /// </summary>
        /// <param name="serviceSettings">serviceSettings.</param>
        /// <param name="teamSettings">teamSettings.</param>
        /// <param name="sqlSettings">sqlSettings.</param>
        /// <param name="logSettings">logSettings.</param>
        /// <param name="passwordSettings">passwordSettings.</param>
        /// <param name="fileSettings">fileSettings.</param>
        /// <param name="emailSettings">emailSettings.</param>
        /// <param name="rateLimitSettings">rateLimitSettings.</param>
        /// <param name="privacySettings">privacySettings.</param>
        /// <param name="supportSettings">supportSettings.</param>
        /// <param name="gitLabSettings">gitLabSettings.</param>
        /// <param name="googleSettings">googleSettings.</param>
        /// <param name="office365Settings">office365Settings.</param>
        /// <param name="ldapSettings">ldapSettings.</param>
        /// <param name="complianceSettings">complianceSettings.</param>
        /// <param name="localizationSettings">localizationSettings.</param>
        /// <param name="samlSettings">samlSettings.</param>
        /// <param name="nativeAppSettings">nativeAppSettings.</param>
        /// <param name="clusterSettings">clusterSettings.</param>
        /// <param name="metricsSettings">metricsSettings.</param>
        /// <param name="analyticsSettings">analyticsSettings.</param>
        public EnvironmentConfig(EnvironmentConfigServiceSettings serviceSettings = default(EnvironmentConfigServiceSettings), EnvironmentConfigTeamSettings teamSettings = default(EnvironmentConfigTeamSettings), EnvironmentConfigSqlSettings sqlSettings = default(EnvironmentConfigSqlSettings), EnvironmentConfigLogSettings logSettings = default(EnvironmentConfigLogSettings), EnvironmentConfigPasswordSettings passwordSettings = default(EnvironmentConfigPasswordSettings), EnvironmentConfigFileSettings fileSettings = default(EnvironmentConfigFileSettings), EnvironmentConfigEmailSettings emailSettings = default(EnvironmentConfigEmailSettings), EnvironmentConfigRateLimitSettings rateLimitSettings = default(EnvironmentConfigRateLimitSettings), ConfigPrivacySettings privacySettings = default(ConfigPrivacySettings), EnvironmentConfigSupportSettings supportSettings = default(EnvironmentConfigSupportSettings), EnvironmentConfigGitLabSettings gitLabSettings = default(EnvironmentConfigGitLabSettings), EnvironmentConfigGitLabSettings googleSettings = default(EnvironmentConfigGitLabSettings), EnvironmentConfigGitLabSettings office365Settings = default(EnvironmentConfigGitLabSettings), EnvironmentConfigLdapSettings ldapSettings = default(EnvironmentConfigLdapSettings), EnvironmentConfigComplianceSettings complianceSettings = default(EnvironmentConfigComplianceSettings), EnvironmentConfigLocalizationSettings localizationSettings = default(EnvironmentConfigLocalizationSettings), EnvironmentConfigSamlSettings samlSettings = default(EnvironmentConfigSamlSettings), EnvironmentConfigNativeAppSettings nativeAppSettings = default(EnvironmentConfigNativeAppSettings), EnvironmentConfigClusterSettings clusterSettings = default(EnvironmentConfigClusterSettings), EnvironmentConfigMetricsSettings metricsSettings = default(EnvironmentConfigMetricsSettings), EnvironmentConfigAnalyticsSettings analyticsSettings = default(EnvironmentConfigAnalyticsSettings))
        {
            this.ServiceSettings = serviceSettings;
            this.TeamSettings = teamSettings;
            this.SqlSettings = sqlSettings;
            this.LogSettings = logSettings;
            this.PasswordSettings = passwordSettings;
            this.FileSettings = fileSettings;
            this.EmailSettings = emailSettings;
            this.RateLimitSettings = rateLimitSettings;
            this.PrivacySettings = privacySettings;
            this.SupportSettings = supportSettings;
            this.GitLabSettings = gitLabSettings;
            this.GoogleSettings = googleSettings;
            this.Office365Settings = office365Settings;
            this.LdapSettings = ldapSettings;
            this.ComplianceSettings = complianceSettings;
            this.LocalizationSettings = localizationSettings;
            this.SamlSettings = samlSettings;
            this.NativeAppSettings = nativeAppSettings;
            this.ClusterSettings = clusterSettings;
            this.MetricsSettings = metricsSettings;
            this.AnalyticsSettings = analyticsSettings;
        }
        
        /// <summary>
        /// Gets or Sets ServiceSettings
        /// </summary>
        [DataMember(Name="ServiceSettings", EmitDefaultValue=false)]
        public EnvironmentConfigServiceSettings ServiceSettings { get; set; }

        /// <summary>
        /// Gets or Sets TeamSettings
        /// </summary>
        [DataMember(Name="TeamSettings", EmitDefaultValue=false)]
        public EnvironmentConfigTeamSettings TeamSettings { get; set; }

        /// <summary>
        /// Gets or Sets SqlSettings
        /// </summary>
        [DataMember(Name="SqlSettings", EmitDefaultValue=false)]
        public EnvironmentConfigSqlSettings SqlSettings { get; set; }

        /// <summary>
        /// Gets or Sets LogSettings
        /// </summary>
        [DataMember(Name="LogSettings", EmitDefaultValue=false)]
        public EnvironmentConfigLogSettings LogSettings { get; set; }

        /// <summary>
        /// Gets or Sets PasswordSettings
        /// </summary>
        [DataMember(Name="PasswordSettings", EmitDefaultValue=false)]
        public EnvironmentConfigPasswordSettings PasswordSettings { get; set; }

        /// <summary>
        /// Gets or Sets FileSettings
        /// </summary>
        [DataMember(Name="FileSettings", EmitDefaultValue=false)]
        public EnvironmentConfigFileSettings FileSettings { get; set; }

        /// <summary>
        /// Gets or Sets EmailSettings
        /// </summary>
        [DataMember(Name="EmailSettings", EmitDefaultValue=false)]
        public EnvironmentConfigEmailSettings EmailSettings { get; set; }

        /// <summary>
        /// Gets or Sets RateLimitSettings
        /// </summary>
        [DataMember(Name="RateLimitSettings", EmitDefaultValue=false)]
        public EnvironmentConfigRateLimitSettings RateLimitSettings { get; set; }

        /// <summary>
        /// Gets or Sets PrivacySettings
        /// </summary>
        [DataMember(Name="PrivacySettings", EmitDefaultValue=false)]
        public ConfigPrivacySettings PrivacySettings { get; set; }

        /// <summary>
        /// Gets or Sets SupportSettings
        /// </summary>
        [DataMember(Name="SupportSettings", EmitDefaultValue=false)]
        public EnvironmentConfigSupportSettings SupportSettings { get; set; }

        /// <summary>
        /// Gets or Sets GitLabSettings
        /// </summary>
        [DataMember(Name="GitLabSettings", EmitDefaultValue=false)]
        public EnvironmentConfigGitLabSettings GitLabSettings { get; set; }

        /// <summary>
        /// Gets or Sets GoogleSettings
        /// </summary>
        [DataMember(Name="GoogleSettings", EmitDefaultValue=false)]
        public EnvironmentConfigGitLabSettings GoogleSettings { get; set; }

        /// <summary>
        /// Gets or Sets Office365Settings
        /// </summary>
        [DataMember(Name="Office365Settings", EmitDefaultValue=false)]
        public EnvironmentConfigGitLabSettings Office365Settings { get; set; }

        /// <summary>
        /// Gets or Sets LdapSettings
        /// </summary>
        [DataMember(Name="LdapSettings", EmitDefaultValue=false)]
        public EnvironmentConfigLdapSettings LdapSettings { get; set; }

        /// <summary>
        /// Gets or Sets ComplianceSettings
        /// </summary>
        [DataMember(Name="ComplianceSettings", EmitDefaultValue=false)]
        public EnvironmentConfigComplianceSettings ComplianceSettings { get; set; }

        /// <summary>
        /// Gets or Sets LocalizationSettings
        /// </summary>
        [DataMember(Name="LocalizationSettings", EmitDefaultValue=false)]
        public EnvironmentConfigLocalizationSettings LocalizationSettings { get; set; }

        /// <summary>
        /// Gets or Sets SamlSettings
        /// </summary>
        [DataMember(Name="SamlSettings", EmitDefaultValue=false)]
        public EnvironmentConfigSamlSettings SamlSettings { get; set; }

        /// <summary>
        /// Gets or Sets NativeAppSettings
        /// </summary>
        [DataMember(Name="NativeAppSettings", EmitDefaultValue=false)]
        public EnvironmentConfigNativeAppSettings NativeAppSettings { get; set; }

        /// <summary>
        /// Gets or Sets ClusterSettings
        /// </summary>
        [DataMember(Name="ClusterSettings", EmitDefaultValue=false)]
        public EnvironmentConfigClusterSettings ClusterSettings { get; set; }

        /// <summary>
        /// Gets or Sets MetricsSettings
        /// </summary>
        [DataMember(Name="MetricsSettings", EmitDefaultValue=false)]
        public EnvironmentConfigMetricsSettings MetricsSettings { get; set; }

        /// <summary>
        /// Gets or Sets AnalyticsSettings
        /// </summary>
        [DataMember(Name="AnalyticsSettings", EmitDefaultValue=false)]
        public EnvironmentConfigAnalyticsSettings AnalyticsSettings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnvironmentConfig {\n");
            sb.Append("  ServiceSettings: ").Append(ServiceSettings).Append("\n");
            sb.Append("  TeamSettings: ").Append(TeamSettings).Append("\n");
            sb.Append("  SqlSettings: ").Append(SqlSettings).Append("\n");
            sb.Append("  LogSettings: ").Append(LogSettings).Append("\n");
            sb.Append("  PasswordSettings: ").Append(PasswordSettings).Append("\n");
            sb.Append("  FileSettings: ").Append(FileSettings).Append("\n");
            sb.Append("  EmailSettings: ").Append(EmailSettings).Append("\n");
            sb.Append("  RateLimitSettings: ").Append(RateLimitSettings).Append("\n");
            sb.Append("  PrivacySettings: ").Append(PrivacySettings).Append("\n");
            sb.Append("  SupportSettings: ").Append(SupportSettings).Append("\n");
            sb.Append("  GitLabSettings: ").Append(GitLabSettings).Append("\n");
            sb.Append("  GoogleSettings: ").Append(GoogleSettings).Append("\n");
            sb.Append("  Office365Settings: ").Append(Office365Settings).Append("\n");
            sb.Append("  LdapSettings: ").Append(LdapSettings).Append("\n");
            sb.Append("  ComplianceSettings: ").Append(ComplianceSettings).Append("\n");
            sb.Append("  LocalizationSettings: ").Append(LocalizationSettings).Append("\n");
            sb.Append("  SamlSettings: ").Append(SamlSettings).Append("\n");
            sb.Append("  NativeAppSettings: ").Append(NativeAppSettings).Append("\n");
            sb.Append("  ClusterSettings: ").Append(ClusterSettings).Append("\n");
            sb.Append("  MetricsSettings: ").Append(MetricsSettings).Append("\n");
            sb.Append("  AnalyticsSettings: ").Append(AnalyticsSettings).Append("\n");
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
            return this.Equals(input as EnvironmentConfig);
        }

        /// <summary>
        /// Returns true if EnvironmentConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of EnvironmentConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnvironmentConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ServiceSettings == input.ServiceSettings ||
                    (this.ServiceSettings != null &&
                    this.ServiceSettings.Equals(input.ServiceSettings))
                ) && 
                (
                    this.TeamSettings == input.TeamSettings ||
                    (this.TeamSettings != null &&
                    this.TeamSettings.Equals(input.TeamSettings))
                ) && 
                (
                    this.SqlSettings == input.SqlSettings ||
                    (this.SqlSettings != null &&
                    this.SqlSettings.Equals(input.SqlSettings))
                ) && 
                (
                    this.LogSettings == input.LogSettings ||
                    (this.LogSettings != null &&
                    this.LogSettings.Equals(input.LogSettings))
                ) && 
                (
                    this.PasswordSettings == input.PasswordSettings ||
                    (this.PasswordSettings != null &&
                    this.PasswordSettings.Equals(input.PasswordSettings))
                ) && 
                (
                    this.FileSettings == input.FileSettings ||
                    (this.FileSettings != null &&
                    this.FileSettings.Equals(input.FileSettings))
                ) && 
                (
                    this.EmailSettings == input.EmailSettings ||
                    (this.EmailSettings != null &&
                    this.EmailSettings.Equals(input.EmailSettings))
                ) && 
                (
                    this.RateLimitSettings == input.RateLimitSettings ||
                    (this.RateLimitSettings != null &&
                    this.RateLimitSettings.Equals(input.RateLimitSettings))
                ) && 
                (
                    this.PrivacySettings == input.PrivacySettings ||
                    (this.PrivacySettings != null &&
                    this.PrivacySettings.Equals(input.PrivacySettings))
                ) && 
                (
                    this.SupportSettings == input.SupportSettings ||
                    (this.SupportSettings != null &&
                    this.SupportSettings.Equals(input.SupportSettings))
                ) && 
                (
                    this.GitLabSettings == input.GitLabSettings ||
                    (this.GitLabSettings != null &&
                    this.GitLabSettings.Equals(input.GitLabSettings))
                ) && 
                (
                    this.GoogleSettings == input.GoogleSettings ||
                    (this.GoogleSettings != null &&
                    this.GoogleSettings.Equals(input.GoogleSettings))
                ) && 
                (
                    this.Office365Settings == input.Office365Settings ||
                    (this.Office365Settings != null &&
                    this.Office365Settings.Equals(input.Office365Settings))
                ) && 
                (
                    this.LdapSettings == input.LdapSettings ||
                    (this.LdapSettings != null &&
                    this.LdapSettings.Equals(input.LdapSettings))
                ) && 
                (
                    this.ComplianceSettings == input.ComplianceSettings ||
                    (this.ComplianceSettings != null &&
                    this.ComplianceSettings.Equals(input.ComplianceSettings))
                ) && 
                (
                    this.LocalizationSettings == input.LocalizationSettings ||
                    (this.LocalizationSettings != null &&
                    this.LocalizationSettings.Equals(input.LocalizationSettings))
                ) && 
                (
                    this.SamlSettings == input.SamlSettings ||
                    (this.SamlSettings != null &&
                    this.SamlSettings.Equals(input.SamlSettings))
                ) && 
                (
                    this.NativeAppSettings == input.NativeAppSettings ||
                    (this.NativeAppSettings != null &&
                    this.NativeAppSettings.Equals(input.NativeAppSettings))
                ) && 
                (
                    this.ClusterSettings == input.ClusterSettings ||
                    (this.ClusterSettings != null &&
                    this.ClusterSettings.Equals(input.ClusterSettings))
                ) && 
                (
                    this.MetricsSettings == input.MetricsSettings ||
                    (this.MetricsSettings != null &&
                    this.MetricsSettings.Equals(input.MetricsSettings))
                ) && 
                (
                    this.AnalyticsSettings == input.AnalyticsSettings ||
                    (this.AnalyticsSettings != null &&
                    this.AnalyticsSettings.Equals(input.AnalyticsSettings))
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
                if (this.ServiceSettings != null)
                    hashCode = hashCode * 59 + this.ServiceSettings.GetHashCode();
                if (this.TeamSettings != null)
                    hashCode = hashCode * 59 + this.TeamSettings.GetHashCode();
                if (this.SqlSettings != null)
                    hashCode = hashCode * 59 + this.SqlSettings.GetHashCode();
                if (this.LogSettings != null)
                    hashCode = hashCode * 59 + this.LogSettings.GetHashCode();
                if (this.PasswordSettings != null)
                    hashCode = hashCode * 59 + this.PasswordSettings.GetHashCode();
                if (this.FileSettings != null)
                    hashCode = hashCode * 59 + this.FileSettings.GetHashCode();
                if (this.EmailSettings != null)
                    hashCode = hashCode * 59 + this.EmailSettings.GetHashCode();
                if (this.RateLimitSettings != null)
                    hashCode = hashCode * 59 + this.RateLimitSettings.GetHashCode();
                if (this.PrivacySettings != null)
                    hashCode = hashCode * 59 + this.PrivacySettings.GetHashCode();
                if (this.SupportSettings != null)
                    hashCode = hashCode * 59 + this.SupportSettings.GetHashCode();
                if (this.GitLabSettings != null)
                    hashCode = hashCode * 59 + this.GitLabSettings.GetHashCode();
                if (this.GoogleSettings != null)
                    hashCode = hashCode * 59 + this.GoogleSettings.GetHashCode();
                if (this.Office365Settings != null)
                    hashCode = hashCode * 59 + this.Office365Settings.GetHashCode();
                if (this.LdapSettings != null)
                    hashCode = hashCode * 59 + this.LdapSettings.GetHashCode();
                if (this.ComplianceSettings != null)
                    hashCode = hashCode * 59 + this.ComplianceSettings.GetHashCode();
                if (this.LocalizationSettings != null)
                    hashCode = hashCode * 59 + this.LocalizationSettings.GetHashCode();
                if (this.SamlSettings != null)
                    hashCode = hashCode * 59 + this.SamlSettings.GetHashCode();
                if (this.NativeAppSettings != null)
                    hashCode = hashCode * 59 + this.NativeAppSettings.GetHashCode();
                if (this.ClusterSettings != null)
                    hashCode = hashCode * 59 + this.ClusterSettings.GetHashCode();
                if (this.MetricsSettings != null)
                    hashCode = hashCode * 59 + this.MetricsSettings.GetHashCode();
                if (this.AnalyticsSettings != null)
                    hashCode = hashCode * 59 + this.AnalyticsSettings.GetHashCode();
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
