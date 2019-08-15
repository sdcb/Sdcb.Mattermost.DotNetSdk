# Sdcb.Mattermost.DotNetSdk.Model.InlineObject45
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Terms** | **string** | The search terms as inputed by the user. To search for posts from a user include &#x60;from:someusername&#x60;, using a user&#39;s username. To search in a specific channel include &#x60;in:somechannel&#x60;, using the channel name (not the display name). | 
**IsOrSearch** | **bool** | Set to true if an Or search should be performed vs an And search. | 
**TimeZoneOffset** | **int** | Offset from UTC of user timezone for date searches. | [optional] 
**IncludeDeletedChannels** | **bool** | Set to true if deleted channels should be included in the search. (archived channels) | [optional] 
**Page** | **int** | The page to select. (Only works with Elasticsearch) | [optional] 
**PerPage** | **int** | The number of posts per page. (Only works with Elasticsearch) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

