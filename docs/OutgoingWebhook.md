# Sdcb.Mattermost.DotNetSdk.Model.OutgoingWebhook
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique identifier for this outgoing webhook | [optional] 
**CreateAt** | **long** | The time in milliseconds a outgoing webhook was created | [optional] 
**UpdateAt** | **long** | The time in milliseconds a outgoing webhook was last updated | [optional] 
**DeleteAt** | **long** | The time in milliseconds a outgoing webhook was deleted | [optional] 
**CreatorId** | **string** | The Id of the user who created the webhook | [optional] 
**TeamId** | **string** | The ID of the team that the webhook watchs | [optional] 
**ChannelId** | **string** | The ID of a public channel that the webhook watchs | [optional] 
**Description** | **string** | The description for this outgoing webhook | [optional] 
**DisplayName** | **string** | The display name for this outgoing webhook | [optional] 
**TriggerWords** | **List&lt;string&gt;** | List of words for the webhook to trigger on | [optional] 
**TriggerWhen** | **int** | When to trigger the webhook, &#x60;0&#x60; when a trigger word is present at all and &#x60;1&#x60; if the message starts with a trigger word | [optional] 
**CallbackUrls** | **List&lt;string&gt;** | The URLs to POST the payloads to when the webhook is triggered | [optional] 
**ContentType** | **string** | The format to POST the data in, either &#x60;application/json&#x60; or &#x60;application/x-www-form-urlencoded&#x60; | [optional] [default to "application/x-www-form-urlencoded"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

