# Sdcb.Mattermost.DotNetSdk.Model.Command
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The ID of the slash command | [optional] 
**Token** | **string** | The token which is used to verify the source of the payload | [optional] 
**CreateAt** | **int** | The time in milliseconds the command was created | [optional] 
**UpdateAt** | **long** | The time in milliseconds the command was last updated | [optional] 
**DeletedAt** | **long** | The time in milliseconds the command was deleted, 0 if never deleted | [optional] 
**CreatorId** | **string** | The user id for the commands creator | [optional] 
**TeamId** | **string** | The team id for which this command is configured | [optional] 
**Trigger** | **string** | The string that triggers this command | [optional] 
**Method** | **string** | Is the trigger done with HTTP Get (&#39;G&#39;) or HTTP Post (&#39;P&#39;) | [optional] 
**Username** | **string** | What is the username for the response post | [optional] 
**IconUrl** | **string** | The url to find the icon for this users avatar | [optional] 
**AutoComplete** | **bool** | Use auto complete for this command | [optional] 
**AutoCompleteDesc** | **string** | The description for this command shown when selecting the command | [optional] 
**AutoCompleteHint** | **string** | The hint for this command | [optional] 
**DisplayName** | **string** | Display name for the command | [optional] 
**Description** | **string** | Description for this command | [optional] 
**Url** | **string** | The URL that is triggered | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

