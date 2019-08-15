# Sdcb.Mattermost.DotNetSdk.Model.PostListWithSearchMatches
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Order** | **List&lt;string&gt;** |  | [optional] 
**Posts** | [**Dictionary&lt;string, Post&gt;**](Post.md) |  | [optional] 
**Matches** | **Dictionary&lt;string, List&lt;string&gt;&gt;** | A mapping of post IDs to a list of matched terms within the post. This field will only be populated on servers running version 5.1 or greater with Elasticsearch enabled. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

