# Sdcb.Mattermost.DotNetSdk.Api.GroupsApi

All URIs are relative to *http://your-mattermost-url.com/api/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ChannelsChannelIdGroupsGet**](GroupsApi.md#channelschannelidgroupsget) | **GET** /channels/{channel_id}/groups | Get channel groups
[**TeamsTeamIdGroupsGet**](GroupsApi.md#teamsteamidgroupsget) | **GET** /teams/{team_id}/groups | Get team groups


<a name="channelschannelidgroupsget"></a>
# **ChannelsChannelIdGroupsGet**
> List&lt;Group&gt; ChannelsChannelIdGroupsGet (string channelId, string page = null, string perPage = null)

Get channel groups

Retrieve the list of groups associated with a given channel.  ##### Permissions Must have `manage_system` permission.  __Minimum server version__: 5.11 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class ChannelsChannelIdGroupsGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new GroupsApi(Configuration.Default);
            var channelId = channelId_example;  // string | Channel GUID
            var page = page_example;  // string | The page to select. (optional)  (default to "0")
            var perPage = perPage_example;  // string | The number of groups per page. (optional)  (default to "60")

            try
            {
                // Get channel groups
                List<Group> result = apiInstance.ChannelsChannelIdGroupsGet(channelId, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.ChannelsChannelIdGroupsGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **channelId** | **string**| Channel GUID | 
 **page** | **string**| The page to select. | [optional] [default to &quot;0&quot;]
 **perPage** | **string**| The number of groups per page. | [optional] [default to &quot;60&quot;]

### Return type

[**List&lt;Group&gt;**](Group.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Group list retrieval successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsteamidgroupsget"></a>
# **TeamsTeamIdGroupsGet**
> List&lt;Group&gt; TeamsTeamIdGroupsGet (string teamId, string page = null, string perPage = null)

Get team groups

Retrieve the list of groups associated with a given team.  ##### Permissions Must have `manage_system` permission.  __Minimum server version__: 5.11 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class TeamsTeamIdGroupsGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new GroupsApi(Configuration.Default);
            var teamId = teamId_example;  // string | Team GUID
            var page = page_example;  // string | The page to select. (optional)  (default to "0")
            var perPage = perPage_example;  // string | The number of groups per page. (optional)  (default to "60")

            try
            {
                // Get team groups
                List<Group> result = apiInstance.TeamsTeamIdGroupsGet(teamId, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.TeamsTeamIdGroupsGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **string**| Team GUID | 
 **page** | **string**| The page to select. | [optional] [default to &quot;0&quot;]
 **perPage** | **string**| The number of groups per page. | [optional] [default to &quot;60&quot;]

### Return type

[**List&lt;Group&gt;**](Group.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Group list retrieval successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

