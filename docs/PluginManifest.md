# Sdcb.Mattermost.DotNetSdk.Model.PluginManifest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Globally unique identifier that represents the plugin. | [optional] 
**Name** | **string** | Name of the plugin. | [optional] 
**Description** | **string** | Description of what the plugin is and does. | [optional] 
**Version** | **string** | Version number of the plugin. | [optional] 
**MinServerVersion** | **string** | The minimum Mattermost server version required for the plugin.  Available as server version 5.6.  | [optional] 
**Backend** | [**PluginManifestBackend**](PluginManifestBackend.md) |  | [optional] 
**Server** | [**PluginManifestServer**](PluginManifestServer.md) |  | [optional] 
**Webapp** | [**PluginManifestWebapp**](PluginManifestWebapp.md) |  | [optional] 
**SettingsSchema** | [**Object**](.md) | Settings schema used to define the System Console UI for the plugin. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

