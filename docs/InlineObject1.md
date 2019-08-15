# Sdcb.Mattermost.DotNetSdk.Model.InlineObject1
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Term** | **string** | The term to match against username, full name, nickname and email | 
**TeamId** | **string** | If provided, only search users on this team | [optional] 
**NotInTeamId** | **string** | If provided, only search users not on this team | [optional] 
**InChannelId** | **string** | If provided, only search users in this channel | [optional] 
**NotInChannelId** | **string** | If provided, only search users not in this channel. Must specifiy &#x60;team_id&#x60; when using this option | [optional] 
**GroupConstrained** | **bool** | When used with &#x60;not_in_channel_id&#x60; or &#x60;not_in_team_id&#x60;, returns only the users that are allowed to join the channel or team based on its group constrains. | [optional] 
**AllowInactive** | **bool** | When &#x60;true&#x60;, include deactivated users in the results | [optional] 
**WithoutTeam** | **bool** | Set this to &#x60;true&#x60; if you would like to search for users that are not on a team. This option takes precendence over &#x60;team_id&#x60;, &#x60;in_channel_id&#x60;, and &#x60;not_in_channel_id&#x60;. | [optional] 
**Limit** | **int** | The maximum number of users to return in the results  __Available as of server version 5.6. Defaults to &#x60;100&#x60; if not provided or on an earlier server version.__  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

