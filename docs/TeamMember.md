# Sdcb.Mattermost.DotNetSdk.Model.TeamMember
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TeamId** | **string** | The ID of the team this member belongs to. | [optional] 
**UserId** | **string** | The ID of the user this member relates to. | [optional] 
**Roles** | **string** | The complete list of roles assigned to this team member, as a space-separated list of role names, including any roles granted implicitly through permissions schemes. | [optional] 
**DeleteAt** | **int** | The time in milliseconds that this team member was deleted. | [optional] 
**SchemeUser** | **bool** | Whether this team member holds the default user role defined by the team&#39;s permissions scheme. | [optional] 
**SchemeAdmin** | **bool** | Whether this team member holds the default admin role defined by the team&#39;s permissions scheme. | [optional] 
**ExplicitRoles** | **string** | The list of roles explicitly assigned to this team member, as a space separated list of role names. This list does *not* include any roles granted implicitly through permissions schemes. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

