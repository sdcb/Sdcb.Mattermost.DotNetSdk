# Sdcb.Mattermost.DotNetSdk.Api.ChannelsApi

All URIs are relative to *http://your-mattermost-url.com/api/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ChannelsChannelIdConvertPost**](ChannelsApi.md#channelschannelidconvertpost) | **POST** /channels/{channel_id}/convert | Convert a channel from public to private
[**ChannelsChannelIdDelete**](ChannelsApi.md#channelschanneliddelete) | **DELETE** /channels/{channel_id} | Delete a channel
[**ChannelsChannelIdGet**](ChannelsApi.md#channelschannelidget) | **GET** /channels/{channel_id} | Get a channel
[**ChannelsChannelIdMembersGet**](ChannelsApi.md#channelschannelidmembersget) | **GET** /channels/{channel_id}/members | Get channel members
[**ChannelsChannelIdMembersIdsPost**](ChannelsApi.md#channelschannelidmembersidspost) | **POST** /channels/{channel_id}/members/ids | Get channel members by ids
[**ChannelsChannelIdMembersMinusGroupMembersGet**](ChannelsApi.md#channelschannelidmembersminusgroupmembersget) | **GET** /channels/{channel_id}/members_minus_group_members | Channel members minus group members.
[**ChannelsChannelIdMembersPost**](ChannelsApi.md#channelschannelidmemberspost) | **POST** /channels/{channel_id}/members | Add user to channel
[**ChannelsChannelIdMembersUserIdDelete**](ChannelsApi.md#channelschannelidmembersuseriddelete) | **DELETE** /channels/{channel_id}/members/{user_id} | Remove user from channel
[**ChannelsChannelIdMembersUserIdGet**](ChannelsApi.md#channelschannelidmembersuseridget) | **GET** /channels/{channel_id}/members/{user_id} | Get channel member
[**ChannelsChannelIdMembersUserIdNotifyPropsPut**](ChannelsApi.md#channelschannelidmembersuseridnotifypropsput) | **PUT** /channels/{channel_id}/members/{user_id}/notify_props | Update channel notifications
[**ChannelsChannelIdMembersUserIdRolesPut**](ChannelsApi.md#channelschannelidmembersuseridrolesput) | **PUT** /channels/{channel_id}/members/{user_id}/roles | Update channel roles
[**ChannelsChannelIdMembersUserIdSchemeRolesPut**](ChannelsApi.md#channelschannelidmembersuseridschemerolesput) | **PUT** /channels/{channel_id}/members/{user_id}/schemeRoles | Update the scheme-derived roles of a channel member.
[**ChannelsChannelIdPatchPut**](ChannelsApi.md#channelschannelidpatchput) | **PUT** /channels/{channel_id}/patch | Patch a channel
[**ChannelsChannelIdPinnedGet**](ChannelsApi.md#channelschannelidpinnedget) | **GET** /channels/{channel_id}/pinned | Get a channel&#39;s pinned posts
[**ChannelsChannelIdPut**](ChannelsApi.md#channelschannelidput) | **PUT** /channels/{channel_id} | Update a channel
[**ChannelsChannelIdRestorePost**](ChannelsApi.md#channelschannelidrestorepost) | **POST** /channels/{channel_id}/restore | Restore a channel
[**ChannelsChannelIdSchemePut**](ChannelsApi.md#channelschannelidschemeput) | **PUT** /channels/{channel_id}/scheme | Set a channel&#39;s scheme
[**ChannelsChannelIdStatsGet**](ChannelsApi.md#channelschannelidstatsget) | **GET** /channels/{channel_id}/stats | Get channel statistics
[**ChannelsChannelIdTimezonesGet**](ChannelsApi.md#channelschannelidtimezonesget) | **GET** /channels/{channel_id}/timezones | Get timezones in a channel
[**ChannelsDirectPost**](ChannelsApi.md#channelsdirectpost) | **POST** /channels/direct | Create a direct message channel
[**ChannelsGroupPost**](ChannelsApi.md#channelsgrouppost) | **POST** /channels/group | Create a group message channel
[**ChannelsMembersUserIdViewPost**](ChannelsApi.md#channelsmembersuseridviewpost) | **POST** /channels/members/{user_id}/view | View channel
[**ChannelsPost**](ChannelsApi.md#channelspost) | **POST** /channels | Create a channel
[**GroupSearchPost**](ChannelsApi.md#groupsearchpost) | **POST** /group/search | Search Group Channels
[**TeamsNameTeamNameChannelsNameChannelNameGet**](ChannelsApi.md#teamsnameteamnamechannelsnamechannelnameget) | **GET** /teams/name/{team_name}/channels/name/{channel_name} | Get a channel by name and team name
[**TeamsTeamIdChannelsAutocompleteGet**](ChannelsApi.md#teamsteamidchannelsautocompleteget) | **GET** /teams/{team_id}/channels/autocomplete | Autocomplete channels
[**TeamsTeamIdChannelsDeletedGet**](ChannelsApi.md#teamsteamidchannelsdeletedget) | **GET** /teams/{team_id}/channels/deleted | Get deleted channels
[**TeamsTeamIdChannelsGet**](ChannelsApi.md#teamsteamidchannelsget) | **GET** /teams/{team_id}/channels | Get public channels
[**TeamsTeamIdChannelsIdsPost**](ChannelsApi.md#teamsteamidchannelsidspost) | **POST** /teams/{team_id}/channels/ids | Get a list of channels by ids
[**TeamsTeamIdChannelsNameChannelNameGet**](ChannelsApi.md#teamsteamidchannelsnamechannelnameget) | **GET** /teams/{team_id}/channels/name/{channel_name} | Get a channel by name
[**TeamsTeamIdChannelsSearchAutocompleteGet**](ChannelsApi.md#teamsteamidchannelssearchautocompleteget) | **GET** /teams/{team_id}/channels/search_autocomplete | Autocomplete channels for search
[**TeamsTeamIdChannelsSearchPost**](ChannelsApi.md#teamsteamidchannelssearchpost) | **POST** /teams/{team_id}/channels/search | Search channels
[**UsersUserIdChannelsChannelIdUnreadGet**](ChannelsApi.md#usersuseridchannelschannelidunreadget) | **GET** /users/{user_id}/channels/{channel_id}/unread | Get unread messages
[**UsersUserIdTeamsTeamIdChannelsGet**](ChannelsApi.md#usersuseridteamsteamidchannelsget) | **GET** /users/{user_id}/teams/{team_id}/channels | Get channels for user
[**UsersUserIdTeamsTeamIdChannelsMembersGet**](ChannelsApi.md#usersuseridteamsteamidchannelsmembersget) | **GET** /users/{user_id}/teams/{team_id}/channels/members | Get channel members for user


<a name="channelschannelidconvertpost"></a>
# **ChannelsChannelIdConvertPost**
> Channel ChannelsChannelIdConvertPost (string channelId)

Convert a channel from public to private

Convert into private channel from the provided channel id string.  __Minimum server version__: 4.10  ##### Permissions `manage_team` permission for the team of the channel. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class ChannelsChannelIdConvertPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new ChannelsApi(Configuration.Default);
            var channelId = channelId_example;  // string | Channel GUID

            try
            {
                // Convert a channel from public to private
                Channel result = apiInstance.ChannelsChannelIdConvertPost(channelId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsApi.ChannelsChannelIdConvertPost: " + e.Message );
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

### Return type

[**Channel**](Channel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Channel conversion successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="channelschanneliddelete"></a>
# **ChannelsChannelIdDelete**
> StatusOK ChannelsChannelIdDelete (string channelId)

Delete a channel

Soft deletes a channel, by marking the channel as deleted in the database. Soft deleted channels will not be accessible in the user interface. Direct and group message channels cannot be deleted. ##### Permissions `delete_public_channel` permission if the channel is public, `delete_private_channel` permission if the channel is private, or have `manage_system` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class ChannelsChannelIdDeleteExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new ChannelsApi(Configuration.Default);
            var channelId = channelId_example;  // string | Channel GUID

            try
            {
                // Delete a channel
                StatusOK result = apiInstance.ChannelsChannelIdDelete(channelId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsApi.ChannelsChannelIdDelete: " + e.Message );
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

### Return type

[**StatusOK**](StatusOK.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Channel deletion successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="channelschannelidget"></a>
# **ChannelsChannelIdGet**
> Channel ChannelsChannelIdGet (string channelId)

Get a channel

Get channel from the provided channel id string. ##### Permissions `read_channel` permission for the channel. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class ChannelsChannelIdGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new ChannelsApi(Configuration.Default);
            var channelId = channelId_example;  // string | Channel GUID

            try
            {
                // Get a channel
                Channel result = apiInstance.ChannelsChannelIdGet(channelId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsApi.ChannelsChannelIdGet: " + e.Message );
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

### Return type

[**Channel**](Channel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Channel retrieval successful |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="channelschannelidmembersget"></a>
# **ChannelsChannelIdMembersGet**
> List&lt;ChannelMember&gt; ChannelsChannelIdMembersGet (string channelId, string page = null, string perPage = null)

Get channel members

Get a page of members for a channel. ##### Permissions `read_channel` permission for the channel. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class ChannelsChannelIdMembersGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new ChannelsApi(Configuration.Default);
            var channelId = channelId_example;  // string | Channel GUID
            var page = page_example;  // string | The page to select. (optional)  (default to "0")
            var perPage = perPage_example;  // string | The number of members per page. (optional)  (default to "60")

            try
            {
                // Get channel members
                List<ChannelMember> result = apiInstance.ChannelsChannelIdMembersGet(channelId, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsApi.ChannelsChannelIdMembersGet: " + e.Message );
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
 **perPage** | **string**| The number of members per page. | [optional] [default to &quot;60&quot;]

### Return type

[**List&lt;ChannelMember&gt;**](ChannelMember.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Channel members retrieval successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="channelschannelidmembersidspost"></a>
# **ChannelsChannelIdMembersIdsPost**
> List&lt;ChannelMember&gt; ChannelsChannelIdMembersIdsPost (string channelId, List<string> userIds)

Get channel members by ids

Get a list of channel members based on the provided user ids. ##### Permissions Must have the `read_channel` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class ChannelsChannelIdMembersIdsPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new ChannelsApi(Configuration.Default);
            var channelId = channelId_example;  // string | Channel GUID
            var userIds = new List<string>(); // List<string> | List of user ids

            try
            {
                // Get channel members by ids
                List<ChannelMember> result = apiInstance.ChannelsChannelIdMembersIdsPost(channelId, userIds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsApi.ChannelsChannelIdMembersIdsPost: " + e.Message );
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
 **userIds** | [**List&lt;string&gt;**](string.md)| List of user ids | 

### Return type

[**List&lt;ChannelMember&gt;**](ChannelMember.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Channel member list retrieval successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="channelschannelidmembersminusgroupmembersget"></a>
# **ChannelsChannelIdMembersMinusGroupMembersGet**
> void ChannelsChannelIdMembersMinusGroupMembersGet (string channelId, string groupIds, string page = null, string perPage = null)

Channel members minus group members.

Get the set of users who are members of the channel minus the set of users who are members of the given groups. Each user object contains an array of group objects representing the group memberships for that user. Each user object contains the boolean fields `scheme_guest`, `scheme_user`, and `scheme_admin` representing the roles that user has for the given channel.  ##### Permissions Must have `manage_system` permission.  __Minimum server version__: 5.14 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class ChannelsChannelIdMembersMinusGroupMembersGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new ChannelsApi(Configuration.Default);
            var channelId = channelId_example;  // string | Channel GUID
            var groupIds = groupIds_example;  // string | A comma-separated list of group ids.
            var page = page_example;  // string | The page to select. (optional)  (default to "0")
            var perPage = perPage_example;  // string | The number of users per page. (optional)  (default to "0")

            try
            {
                // Channel members minus group members.
                apiInstance.ChannelsChannelIdMembersMinusGroupMembersGet(channelId, groupIds, page, perPage);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsApi.ChannelsChannelIdMembersMinusGroupMembersGet: " + e.Message );
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
 **groupIds** | **string**| A comma-separated list of group ids. | 
 **page** | **string**| The page to select. | [optional] [default to &quot;0&quot;]
 **perPage** | **string**| The number of users per page. | [optional] [default to &quot;0&quot;]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully returns users specified by the pagination, and the total_count. |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="channelschannelidmemberspost"></a>
# **ChannelsChannelIdMembersPost**
> ChannelMember ChannelsChannelIdMembersPost (string channelId, InlineObject36 body)

Add user to channel

Add a user to a channel by creating a channel member object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class ChannelsChannelIdMembersPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new ChannelsApi(Configuration.Default);
            var channelId = channelId_example;  // string | The channel ID
            var body = new InlineObject36(); // InlineObject36 | 

            try
            {
                // Add user to channel
                ChannelMember result = apiInstance.ChannelsChannelIdMembersPost(channelId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsApi.ChannelsChannelIdMembersPost: " + e.Message );
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
 **channelId** | **string**| The channel ID | 
 **body** | [**InlineObject36**](InlineObject36.md)|  | 

### Return type

[**ChannelMember**](ChannelMember.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Channel member creation successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="channelschannelidmembersuseriddelete"></a>
# **ChannelsChannelIdMembersUserIdDelete**
> StatusOK ChannelsChannelIdMembersUserIdDelete (string channelId, string userId)

Remove user from channel

Delete a channel member, effectively removing them from a channel.  In server version 5.3 and later, channel members can only be deleted from public or private channels. ##### Permissions `manage_public_channel_members` permission if the channel is public. `manage_private_channel_members` permission if the channel is private. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class ChannelsChannelIdMembersUserIdDeleteExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new ChannelsApi(Configuration.Default);
            var channelId = channelId_example;  // string | Channel GUID
            var userId = userId_example;  // string | User GUID

            try
            {
                // Remove user from channel
                StatusOK result = apiInstance.ChannelsChannelIdMembersUserIdDelete(channelId, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsApi.ChannelsChannelIdMembersUserIdDelete: " + e.Message );
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
 **userId** | **string**| User GUID | 

### Return type

[**StatusOK**](StatusOK.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Channel member deletion successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="channelschannelidmembersuseridget"></a>
# **ChannelsChannelIdMembersUserIdGet**
> ChannelMember ChannelsChannelIdMembersUserIdGet (string channelId, string userId)

Get channel member

Get a channel member. ##### Permissions `read_channel` permission for the channel. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class ChannelsChannelIdMembersUserIdGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new ChannelsApi(Configuration.Default);
            var channelId = channelId_example;  // string | Channel GUID
            var userId = userId_example;  // string | User GUID

            try
            {
                // Get channel member
                ChannelMember result = apiInstance.ChannelsChannelIdMembersUserIdGet(channelId, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsApi.ChannelsChannelIdMembersUserIdGet: " + e.Message );
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
 **userId** | **string**| User GUID | 

### Return type

[**ChannelMember**](ChannelMember.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Channel member retrieval successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="channelschannelidmembersuseridnotifypropsput"></a>
# **ChannelsChannelIdMembersUserIdNotifyPropsPut**
> StatusOK ChannelsChannelIdMembersUserIdNotifyPropsPut (string channelId, string userId, ChannelNotifyProps notifyProps)

Update channel notifications

Update a user's notification properties for a channel. Only the provided fields are updated. ##### Permissions Must be logged in as the user or have `edit_other_users` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class ChannelsChannelIdMembersUserIdNotifyPropsPutExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new ChannelsApi(Configuration.Default);
            var channelId = channelId_example;  // string | Channel GUID
            var userId = userId_example;  // string | User GUID
            var notifyProps = new ChannelNotifyProps(); // ChannelNotifyProps | 

            try
            {
                // Update channel notifications
                StatusOK result = apiInstance.ChannelsChannelIdMembersUserIdNotifyPropsPut(channelId, userId, notifyProps);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsApi.ChannelsChannelIdMembersUserIdNotifyPropsPut: " + e.Message );
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
 **userId** | **string**| User GUID | 
 **notifyProps** | [**ChannelNotifyProps**](ChannelNotifyProps.md)|  | 

### Return type

[**StatusOK**](StatusOK.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Channel notification properties update successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="channelschannelidmembersuseridrolesput"></a>
# **ChannelsChannelIdMembersUserIdRolesPut**
> StatusOK ChannelsChannelIdMembersUserIdRolesPut (string channelId, string userId, InlineObject37 roles)

Update channel roles

Update a user's roles for a channel. ##### Permissions Must have `manage_channel_roles` permission for the channel. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class ChannelsChannelIdMembersUserIdRolesPutExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new ChannelsApi(Configuration.Default);
            var channelId = channelId_example;  // string | Channel GUID
            var userId = userId_example;  // string | User GUID
            var roles = new InlineObject37(); // InlineObject37 | 

            try
            {
                // Update channel roles
                StatusOK result = apiInstance.ChannelsChannelIdMembersUserIdRolesPut(channelId, userId, roles);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsApi.ChannelsChannelIdMembersUserIdRolesPut: " + e.Message );
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
 **userId** | **string**| User GUID | 
 **roles** | [**InlineObject37**](InlineObject37.md)|  | 

### Return type

[**StatusOK**](StatusOK.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Channel roles update successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="channelschannelidmembersuseridschemerolesput"></a>
# **ChannelsChannelIdMembersUserIdSchemeRolesPut**
> StatusOK ChannelsChannelIdMembersUserIdSchemeRolesPut (string channelId, string userId, InlineObject38 body)

Update the scheme-derived roles of a channel member.

Update a channel member's scheme_admin/scheme_user properties. Typically this should either be `scheme_admin=false, scheme_user=true` for ordinary channel member, or `scheme_admin=true, scheme_user=true` for a channel admin. __Minimum server version__: 5.0 ##### Permissions Must be authenticated and have the `manage_channel_roles` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class ChannelsChannelIdMembersUserIdSchemeRolesPutExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new ChannelsApi(Configuration.Default);
            var channelId = channelId_example;  // string | Channel GUID
            var userId = userId_example;  // string | User GUID
            var body = new InlineObject38(); // InlineObject38 | 

            try
            {
                // Update the scheme-derived roles of a channel member.
                StatusOK result = apiInstance.ChannelsChannelIdMembersUserIdSchemeRolesPut(channelId, userId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsApi.ChannelsChannelIdMembersUserIdSchemeRolesPut: " + e.Message );
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
 **userId** | **string**| User GUID | 
 **body** | [**InlineObject38**](InlineObject38.md)|  | 

### Return type

[**StatusOK**](StatusOK.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Channel member&#39;s scheme-derived roles updated successfully. |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="channelschannelidpatchput"></a>
# **ChannelsChannelIdPatchPut**
> Channel ChannelsChannelIdPatchPut (string channelId, InlineObject34 body)

Patch a channel

Partially update a channel by providing only the fields you want to update. Omitted fields will not be updated. The fields that can be updated are defined in the request body, all other provided fields will be ignored. ##### Permissions If updating a public channel, `manage_public_channel_members` permission is required. If updating a private channel, `manage_private_channel_members` permission is required. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class ChannelsChannelIdPatchPutExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new ChannelsApi(Configuration.Default);
            var channelId = channelId_example;  // string | Channel GUID
            var body = new InlineObject34(); // InlineObject34 | 

            try
            {
                // Patch a channel
                Channel result = apiInstance.ChannelsChannelIdPatchPut(channelId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsApi.ChannelsChannelIdPatchPut: " + e.Message );
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
 **body** | [**InlineObject34**](InlineObject34.md)|  | 

### Return type

[**Channel**](Channel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Channel patch successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="channelschannelidpinnedget"></a>
# **ChannelsChannelIdPinnedGet**
> PostList ChannelsChannelIdPinnedGet (string channelId)

Get a channel's pinned posts

Get a list of pinned posts for channel.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class ChannelsChannelIdPinnedGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new ChannelsApi(Configuration.Default);
            var channelId = channelId_example;  // string | Channel GUID

            try
            {
                // Get a channel's pinned posts
                PostList result = apiInstance.ChannelsChannelIdPinnedGet(channelId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsApi.ChannelsChannelIdPinnedGet: " + e.Message );
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

### Return type

[**PostList**](PostList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The list of channel pinned posts |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="channelschannelidput"></a>
# **ChannelsChannelIdPut**
> Channel ChannelsChannelIdPut (string channelId, InlineObject33 body)

Update a channel

Update a channel. The fields that can be updated are listed as parameters. Omitted fields will be treated as blanks. ##### Permissions If updating a public channel, `manage_public_channel_members` permission is required. If updating a private channel, `manage_private_channel_members` permission is required. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class ChannelsChannelIdPutExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new ChannelsApi(Configuration.Default);
            var channelId = channelId_example;  // string | Channel GUID
            var body = new InlineObject33(); // InlineObject33 | 

            try
            {
                // Update a channel
                Channel result = apiInstance.ChannelsChannelIdPut(channelId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsApi.ChannelsChannelIdPut: " + e.Message );
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
 **body** | [**InlineObject33**](InlineObject33.md)|  | 

### Return type

[**Channel**](Channel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Channel update successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="channelschannelidrestorepost"></a>
# **ChannelsChannelIdRestorePost**
> Channel ChannelsChannelIdRestorePost (string channelId)

Restore a channel

Restore channel from the provided channel id string.  __Minimum server version__: 3.10  ##### Permissions `manage_team` permission for the team of the channel. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class ChannelsChannelIdRestorePostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new ChannelsApi(Configuration.Default);
            var channelId = channelId_example;  // string | Channel GUID

            try
            {
                // Restore a channel
                Channel result = apiInstance.ChannelsChannelIdRestorePost(channelId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsApi.ChannelsChannelIdRestorePost: " + e.Message );
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

### Return type

[**Channel**](Channel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Channel restore successful |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="channelschannelidschemeput"></a>
# **ChannelsChannelIdSchemePut**
> StatusOK ChannelsChannelIdSchemePut (string channelId, InlineObject40 body)

Set a channel's scheme

Set a channel's scheme, more specifically sets the scheme_id value of a channel record.  ##### Permissions Must have `manage_system` permission.  __Minimum server version__: 4.10 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class ChannelsChannelIdSchemePutExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new ChannelsApi(Configuration.Default);
            var channelId = channelId_example;  // string | Channel GUID
            var body = new InlineObject40(); // InlineObject40 | 

            try
            {
                // Set a channel's scheme
                StatusOK result = apiInstance.ChannelsChannelIdSchemePut(channelId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsApi.ChannelsChannelIdSchemePut: " + e.Message );
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
 **body** | [**InlineObject40**](InlineObject40.md)|  | 

### Return type

[**StatusOK**](StatusOK.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Update channel scheme successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **501** | Feature is disabled |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="channelschannelidstatsget"></a>
# **ChannelsChannelIdStatsGet**
> ChannelStats ChannelsChannelIdStatsGet (string channelId)

Get channel statistics

Get statistics for a channel. ##### Permissions Must have the `read_channel` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class ChannelsChannelIdStatsGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new ChannelsApi(Configuration.Default);
            var channelId = channelId_example;  // string | Channel GUID

            try
            {
                // Get channel statistics
                ChannelStats result = apiInstance.ChannelsChannelIdStatsGet(channelId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsApi.ChannelsChannelIdStatsGet: " + e.Message );
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

### Return type

[**ChannelStats**](ChannelStats.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Channel statistics retrieval successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="channelschannelidtimezonesget"></a>
# **ChannelsChannelIdTimezonesGet**
> List&lt;string&gt; ChannelsChannelIdTimezonesGet (string channelId)

Get timezones in a channel

Get a list of timezones for the users who are in this channel.  __Minimum server version__: 5.6  ##### Permissions Must have the `read_channel` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class ChannelsChannelIdTimezonesGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new ChannelsApi(Configuration.Default);
            var channelId = channelId_example;  // string | Channel GUID

            try
            {
                // Get timezones in a channel
                List<string> result = apiInstance.ChannelsChannelIdTimezonesGet(channelId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsApi.ChannelsChannelIdTimezonesGet: " + e.Message );
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

### Return type

**List<string>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Timezone retrieval successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="channelsdirectpost"></a>
# **ChannelsDirectPost**
> Channel ChannelsDirectPost (List<string> body)

Create a direct message channel

Create a new direct message channel between two users. ##### Permissions Must be one of the two users and have `create_direct_channel` permission. Having the `manage_system` permission voids the previous requirements. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class ChannelsDirectPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new ChannelsApi(Configuration.Default);
            var body = new List<string>(); // List<string> | The two user ids to be in the direct message

            try
            {
                // Create a direct message channel
                Channel result = apiInstance.ChannelsDirectPost(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsApi.ChannelsDirectPost: " + e.Message );
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
 **body** | [**List&lt;string&gt;**](string.md)| The two user ids to be in the direct message | 

### Return type

[**Channel**](Channel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Direct channel creation successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="channelsgrouppost"></a>
# **ChannelsGroupPost**
> Channel ChannelsGroupPost (List<string> body)

Create a group message channel

Create a new group message channel to group of users. If the logged in user's id is not included in the list, it will be appended to the end. ##### Permissions Must have `create_group_channel` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class ChannelsGroupPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new ChannelsApi(Configuration.Default);
            var body = new List<string>(); // List<string> | User ids to be in the group message channel

            try
            {
                // Create a group message channel
                Channel result = apiInstance.ChannelsGroupPost(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsApi.ChannelsGroupPost: " + e.Message );
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
 **body** | [**List&lt;string&gt;**](string.md)| User ids to be in the group message channel | 

### Return type

[**Channel**](Channel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Group channel creation successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="channelsmembersuseridviewpost"></a>
# **ChannelsMembersUserIdViewPost**
> InlineResponse2006 ChannelsMembersUserIdViewPost (string userId, InlineObject39 body)

View channel

Perform all the actions involved in viewing a channel. This includes marking channels as read, clearing push notifications, and updating the active channel. ##### Permissions Must be logged in as user or have `edit_other_users` permission.  __Response only includes `last_viewed_at_times` in Mattermost server 4.3 and newer.__ 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class ChannelsMembersUserIdViewPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new ChannelsApi(Configuration.Default);
            var userId = userId_example;  // string | User ID to perform the view action for
            var body = new InlineObject39(); // InlineObject39 | 

            try
            {
                // View channel
                InlineResponse2006 result = apiInstance.ChannelsMembersUserIdViewPost(userId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsApi.ChannelsMembersUserIdViewPost: " + e.Message );
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
 **userId** | **string**| User ID to perform the view action for | 
 **body** | [**InlineObject39**](InlineObject39.md)|  | 

### Return type

[**InlineResponse2006**](InlineResponse2006.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Channel view successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="channelspost"></a>
# **ChannelsPost**
> Channel ChannelsPost (InlineObject31 body)

Create a channel

Create a new channel. ##### Permissions If creating a public channel, `create_public_channel` permission is required. If creating a private channel, `create_private_channel` permission is required. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class ChannelsPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new ChannelsApi(Configuration.Default);
            var body = new InlineObject31(); // InlineObject31 | 

            try
            {
                // Create a channel
                Channel result = apiInstance.ChannelsPost(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsApi.ChannelsPost: " + e.Message );
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
 **body** | [**InlineObject31**](InlineObject31.md)|  | 

### Return type

[**Channel**](Channel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Channel creation successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="groupsearchpost"></a>
# **GroupSearchPost**
> List&lt;Channel&gt; GroupSearchPost (InlineObject32 body)

Search Group Channels

Get a list of group channels for a user which members' usernames match the search term.  __Minimum server version__: 5.14 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class GroupSearchPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new ChannelsApi(Configuration.Default);
            var body = new InlineObject32(); // InlineObject32 | 

            try
            {
                // Search Group Channels
                List<Channel> result = apiInstance.GroupSearchPost(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsApi.GroupSearchPost: " + e.Message );
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
 **body** | [**InlineObject32**](InlineObject32.md)|  | 

### Return type

[**List&lt;Channel&gt;**](Channel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Channels search successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsnameteamnamechannelsnamechannelnameget"></a>
# **TeamsNameTeamNameChannelsNameChannelNameGet**
> Channel TeamsNameTeamNameChannelsNameChannelNameGet (string teamName, string channelName, string includeDeleted = null)

Get a channel by name and team name

Gets a channel from the provided team name and channel name strings. ##### Permissions `read_channel` permission for the channel. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class TeamsNameTeamNameChannelsNameChannelNameGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new ChannelsApi(Configuration.Default);
            var teamName = teamName_example;  // string | Team Name
            var channelName = channelName_example;  // string | Channel Name
            var includeDeleted = includeDeleted_example;  // string | Defines if deleted channels should be returned or not (optional)  (default to false)

            try
            {
                // Get a channel by name and team name
                Channel result = apiInstance.TeamsNameTeamNameChannelsNameChannelNameGet(teamName, channelName, includeDeleted);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsApi.TeamsNameTeamNameChannelsNameChannelNameGet: " + e.Message );
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
 **teamName** | **string**| Team Name | 
 **channelName** | **string**| Channel Name | 
 **includeDeleted** | **string**| Defines if deleted channels should be returned or not | [optional] [default to false]

### Return type

[**Channel**](Channel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Channel retrieval successful |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsteamidchannelsautocompleteget"></a>
# **TeamsTeamIdChannelsAutocompleteGet**
> List&lt;Channel&gt; TeamsTeamIdChannelsAutocompleteGet (string teamId, string name)

Autocomplete channels

Autocomplete public channels on a team based on the search term provided in the request URL.  __Minimum server version__: 4.7  ##### Permissions Must have the `list_team_channels` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class TeamsTeamIdChannelsAutocompleteGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new ChannelsApi(Configuration.Default);
            var teamId = teamId_example;  // string | Team GUID
            var name = name_example;  // string | Name or display name

            try
            {
                // Autocomplete channels
                List<Channel> result = apiInstance.TeamsTeamIdChannelsAutocompleteGet(teamId, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsApi.TeamsTeamIdChannelsAutocompleteGet: " + e.Message );
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
 **name** | **string**| Name or display name | 

### Return type

[**List&lt;Channel&gt;**](Channel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Channels autocomplete successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsteamidchannelsdeletedget"></a>
# **TeamsTeamIdChannelsDeletedGet**
> List&lt;Channel&gt; TeamsTeamIdChannelsDeletedGet (string teamId, string page = null, string perPage = null)

Get deleted channels

Get a page of deleted channels on a team based on query string parameters - team_id, page and per_page.  __Minimum server version__: 3.10  ##### Permissions Must be authenticated and have the `manage_team` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class TeamsTeamIdChannelsDeletedGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new ChannelsApi(Configuration.Default);
            var teamId = teamId_example;  // string | Team GUID
            var page = page_example;  // string | The page to select. (optional)  (default to "0")
            var perPage = perPage_example;  // string | The number of public channels per page. (optional)  (default to "60")

            try
            {
                // Get deleted channels
                List<Channel> result = apiInstance.TeamsTeamIdChannelsDeletedGet(teamId, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsApi.TeamsTeamIdChannelsDeletedGet: " + e.Message );
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
 **perPage** | **string**| The number of public channels per page. | [optional] [default to &quot;60&quot;]

### Return type

[**List&lt;Channel&gt;**](Channel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Channels retrieval successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsteamidchannelsget"></a>
# **TeamsTeamIdChannelsGet**
> List&lt;Channel&gt; TeamsTeamIdChannelsGet (string teamId, string page = null, string perPage = null)

Get public channels

Get a page of public channels on a team based on query string parameters - page and per_page. ##### Permissions Must be authenticated and have the `list_team_channels` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class TeamsTeamIdChannelsGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new ChannelsApi(Configuration.Default);
            var teamId = teamId_example;  // string | Team GUID
            var page = page_example;  // string | The page to select. (optional)  (default to "0")
            var perPage = perPage_example;  // string | The number of public channels per page. (optional)  (default to "60")

            try
            {
                // Get public channels
                List<Channel> result = apiInstance.TeamsTeamIdChannelsGet(teamId, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsApi.TeamsTeamIdChannelsGet: " + e.Message );
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
 **perPage** | **string**| The number of public channels per page. | [optional] [default to &quot;60&quot;]

### Return type

[**List&lt;Channel&gt;**](Channel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Channels retrieval successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsteamidchannelsidspost"></a>
# **TeamsTeamIdChannelsIdsPost**
> List&lt;Channel&gt; TeamsTeamIdChannelsIdsPost (string teamId, List<string> body)

Get a list of channels by ids

Get a list of public channels on a team by id. ##### Permissions `view_team` for the team the channels are on. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class TeamsTeamIdChannelsIdsPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new ChannelsApi(Configuration.Default);
            var teamId = teamId_example;  // string | Team GUID
            var body = new List<string>(); // List<string> | List of channel ids

            try
            {
                // Get a list of channels by ids
                List<Channel> result = apiInstance.TeamsTeamIdChannelsIdsPost(teamId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsApi.TeamsTeamIdChannelsIdsPost: " + e.Message );
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
 **body** | [**List&lt;string&gt;**](string.md)| List of channel ids | 

### Return type

[**List&lt;Channel&gt;**](Channel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Channel list retrieval successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsteamidchannelsnamechannelnameget"></a>
# **TeamsTeamIdChannelsNameChannelNameGet**
> Channel TeamsTeamIdChannelsNameChannelNameGet (string teamId, string channelName, string includeDeleted = null)

Get a channel by name

Gets channel from the provided team id and channel name strings. ##### Permissions `read_channel` permission for the channel. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class TeamsTeamIdChannelsNameChannelNameGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new ChannelsApi(Configuration.Default);
            var teamId = teamId_example;  // string | Team GUID
            var channelName = channelName_example;  // string | Channel Name
            var includeDeleted = includeDeleted_example;  // string | Defines if deleted channels should be returned or not (optional)  (default to false)

            try
            {
                // Get a channel by name
                Channel result = apiInstance.TeamsTeamIdChannelsNameChannelNameGet(teamId, channelName, includeDeleted);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsApi.TeamsTeamIdChannelsNameChannelNameGet: " + e.Message );
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
 **channelName** | **string**| Channel Name | 
 **includeDeleted** | **string**| Defines if deleted channels should be returned or not | [optional] [default to false]

### Return type

[**Channel**](Channel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Channel retrieval successful |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsteamidchannelssearchautocompleteget"></a>
# **TeamsTeamIdChannelsSearchAutocompleteGet**
> List&lt;Channel&gt; TeamsTeamIdChannelsSearchAutocompleteGet (string teamId, string name)

Autocomplete channels for search

Autocomplete your channels on a team based on the search term provided in the request URL.  __Minimum server version__: 5.4  ##### Permissions Must have the `list_team_channels` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class TeamsTeamIdChannelsSearchAutocompleteGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new ChannelsApi(Configuration.Default);
            var teamId = teamId_example;  // string | Team GUID
            var name = name_example;  // string | Name or display name

            try
            {
                // Autocomplete channels for search
                List<Channel> result = apiInstance.TeamsTeamIdChannelsSearchAutocompleteGet(teamId, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsApi.TeamsTeamIdChannelsSearchAutocompleteGet: " + e.Message );
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
 **name** | **string**| Name or display name | 

### Return type

[**List&lt;Channel&gt;**](Channel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Channels autocomplete successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsteamidchannelssearchpost"></a>
# **TeamsTeamIdChannelsSearchPost**
> List&lt;Channel&gt; TeamsTeamIdChannelsSearchPost (string teamId, InlineObject35 body)

Search channels

Search public channels on a team based on the search term provided in the request body. ##### Permissions Must have the `list_team_channels` permission.  In server version 5.16 and later, a user without the `list_team_channels` permission will be able to use this endpoint, with the search results limited to the channels that the user is a member of. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class TeamsTeamIdChannelsSearchPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new ChannelsApi(Configuration.Default);
            var teamId = teamId_example;  // string | Team GUID
            var body = new InlineObject35(); // InlineObject35 | 

            try
            {
                // Search channels
                List<Channel> result = apiInstance.TeamsTeamIdChannelsSearchPost(teamId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsApi.TeamsTeamIdChannelsSearchPost: " + e.Message );
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
 **body** | [**InlineObject35**](InlineObject35.md)|  | 

### Return type

[**List&lt;Channel&gt;**](Channel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Channels search successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersuseridchannelschannelidunreadget"></a>
# **UsersUserIdChannelsChannelIdUnreadGet**
> ChannelUnread UsersUserIdChannelsChannelIdUnreadGet (string userId, string channelId)

Get unread messages

Get the total unread messages and mentions for a channel for a user. ##### Permissions Must be logged in as user and have the `read_channel` permission, or have `edit_other_usrs` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class UsersUserIdChannelsChannelIdUnreadGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new ChannelsApi(Configuration.Default);
            var userId = userId_example;  // string | User GUID
            var channelId = channelId_example;  // string | Channel GUID

            try
            {
                // Get unread messages
                ChannelUnread result = apiInstance.UsersUserIdChannelsChannelIdUnreadGet(userId, channelId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsApi.UsersUserIdChannelsChannelIdUnreadGet: " + e.Message );
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
 **userId** | **string**| User GUID | 
 **channelId** | **string**| Channel GUID | 

### Return type

[**ChannelUnread**](ChannelUnread.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Channel unreads retrieval successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersuseridteamsteamidchannelsget"></a>
# **UsersUserIdTeamsTeamIdChannelsGet**
> List&lt;Channel&gt; UsersUserIdTeamsTeamIdChannelsGet (string userId, string teamId)

Get channels for user

Get all the channels on a team for a user. ##### Permissions Logged in as the user, or have `edit_other_users` permission, and `view_team` permission for the team. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class UsersUserIdTeamsTeamIdChannelsGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new ChannelsApi(Configuration.Default);
            var userId = userId_example;  // string | User GUID
            var teamId = teamId_example;  // string | Team GUID

            try
            {
                // Get channels for user
                List<Channel> result = apiInstance.UsersUserIdTeamsTeamIdChannelsGet(userId, teamId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsApi.UsersUserIdTeamsTeamIdChannelsGet: " + e.Message );
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
 **userId** | **string**| User GUID | 
 **teamId** | **string**| Team GUID | 

### Return type

[**List&lt;Channel&gt;**](Channel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Channels retrieval successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersuseridteamsteamidchannelsmembersget"></a>
# **UsersUserIdTeamsTeamIdChannelsMembersGet**
> List&lt;ChannelMember&gt; UsersUserIdTeamsTeamIdChannelsMembersGet (string userId, string teamId)

Get channel members for user

Get all channel members on a team for a user. ##### Permissions Logged in as the user and `view_team` permission for the team. Having `manage_system` permission voids the previous requirements. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class UsersUserIdTeamsTeamIdChannelsMembersGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new ChannelsApi(Configuration.Default);
            var userId = userId_example;  // string | User GUID
            var teamId = teamId_example;  // string | Team GUID

            try
            {
                // Get channel members for user
                List<ChannelMember> result = apiInstance.UsersUserIdTeamsTeamIdChannelsMembersGet(userId, teamId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChannelsApi.UsersUserIdTeamsTeamIdChannelsMembersGet: " + e.Message );
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
 **userId** | **string**| User GUID | 
 **teamId** | **string**| Team GUID | 

### Return type

[**List&lt;ChannelMember&gt;**](ChannelMember.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Channel members retrieval successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

