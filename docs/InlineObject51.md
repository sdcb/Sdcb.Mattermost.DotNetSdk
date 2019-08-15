# Sdcb.Mattermost.DotNetSdk.Model.InlineObject51
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TeamId** | **string** | The ID of the team that the webhook watchs | 
**ChannelId** | **string** | The ID of a public channel that the webhook watchs | [optional] 
**Description** | **string** | The description for this outgoing webhook | [optional] 
**DisplayName** | **string** | The display name for this outgoing webhook | 
**TriggerWords** | **List&lt;string&gt;** | List of words for the webhook to trigger on | 
**TriggerWhen** | **int** | When to trigger the webhook, &#x60;0&#x60; when a trigger word is present at all and &#x60;1&#x60; if the message starts with a trigger word | [optional] 
**CallbackUrls** | **List&lt;string&gt;** | The URLs to POST the payloads to when the webhook is triggered | 
**ContentType** | **string** | The format to POST the data in, either &#x60;application/json&#x60; or &#x60;application/x-www-form-urlencoded&#x60; | [optional] [default to "application/x-www-form-urlencoded"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

