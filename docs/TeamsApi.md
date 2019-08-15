# Sdcb.Mattermost.DotNetSdk.Api.TeamsApi

All URIs are relative to *http://your-mattermost-url.com/api/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TeamsGet**](TeamsApi.md#teamsget) | **GET** /teams | Get teams
[**TeamsInviteInviteIdGet**](TeamsApi.md#teamsinviteinviteidget) | **GET** /teams/invite/{invite_id} | Get invite info for a team
[**TeamsInvitesEmailDelete**](TeamsApi.md#teamsinvitesemaildelete) | **DELETE** /teams/invites/email | Invalidate active email invitations
[**TeamsMembersInvitePost**](TeamsApi.md#teamsmembersinvitepost) | **POST** /teams/members/invite | Add user to team from invite
[**TeamsNameNameExistsGet**](TeamsApi.md#teamsnamenameexistsget) | **GET** /teams/name/{name}/exists | Check if team exists
[**TeamsNameNameGet**](TeamsApi.md#teamsnamenameget) | **GET** /teams/name/{name} | Get a team by name
[**TeamsPost**](TeamsApi.md#teamspost) | **POST** /teams | Create a team
[**TeamsSearchPost**](TeamsApi.md#teamssearchpost) | **POST** /teams/search | Search teams
[**TeamsTeamIdDelete**](TeamsApi.md#teamsteamiddelete) | **DELETE** /teams/{team_id} | Delete a team
[**TeamsTeamIdGet**](TeamsApi.md#teamsteamidget) | **GET** /teams/{team_id} | Get a team
[**TeamsTeamIdImageDelete**](TeamsApi.md#teamsteamidimagedelete) | **DELETE** /teams/{team_id}/image | Remove the team icon
[**TeamsTeamIdImageGet**](TeamsApi.md#teamsteamidimageget) | **GET** /teams/{team_id}/image | Get the team icon
[**TeamsTeamIdImagePost**](TeamsApi.md#teamsteamidimagepost) | **POST** /teams/{team_id}/image | Sets the team icon
[**TeamsTeamIdImportPost**](TeamsApi.md#teamsteamidimportpost) | **POST** /teams/{team_id}/import | Import a Team from other application
[**TeamsTeamIdInviteEmailPost**](TeamsApi.md#teamsteamidinviteemailpost) | **POST** /teams/{team_id}/invite/email | Invite users to the team by email
[**TeamsTeamIdMembersBatchPost**](TeamsApi.md#teamsteamidmembersbatchpost) | **POST** /teams/{team_id}/members/batch | Add multiple users to team
[**TeamsTeamIdMembersGet**](TeamsApi.md#teamsteamidmembersget) | **GET** /teams/{team_id}/members | Get team members
[**TeamsTeamIdMembersIdsPost**](TeamsApi.md#teamsteamidmembersidspost) | **POST** /teams/{team_id}/members/ids | Get team members by ids
[**TeamsTeamIdMembersMinusGroupMembersGet**](TeamsApi.md#teamsteamidmembersminusgroupmembersget) | **GET** /teams/{team_id}/members_minus_group_members | Team members minus group members.
[**TeamsTeamIdMembersPost**](TeamsApi.md#teamsteamidmemberspost) | **POST** /teams/{team_id}/members | Add user to team
[**TeamsTeamIdMembersUserIdDelete**](TeamsApi.md#teamsteamidmembersuseriddelete) | **DELETE** /teams/{team_id}/members/{user_id} | Remove user from team
[**TeamsTeamIdMembersUserIdGet**](TeamsApi.md#teamsteamidmembersuseridget) | **GET** /teams/{team_id}/members/{user_id} | Get a team member
[**TeamsTeamIdMembersUserIdRolesPut**](TeamsApi.md#teamsteamidmembersuseridrolesput) | **PUT** /teams/{team_id}/members/{user_id}/roles | Update a team member roles
[**TeamsTeamIdMembersUserIdSchemeRolesPut**](TeamsApi.md#teamsteamidmembersuseridschemerolesput) | **PUT** /teams/{team_id}/members/{user_id}/schemeRoles | Update the scheme-derived roles of a team member.
[**TeamsTeamIdPatchPut**](TeamsApi.md#teamsteamidpatchput) | **PUT** /teams/{team_id}/patch | Patch a team
[**TeamsTeamIdPut**](TeamsApi.md#teamsteamidput) | **PUT** /teams/{team_id} | Update a team
[**TeamsTeamIdRegenerateInviteIdPost**](TeamsApi.md#teamsteamidregenerateinviteidpost) | **POST** /teams/{team_id}/regenerate_invite_id | Regenerate the Invite ID from a Team
[**TeamsTeamIdSchemePut**](TeamsApi.md#teamsteamidschemeput) | **PUT** /teams/{team_id}/scheme | Set a team&#39;s scheme
[**TeamsTeamIdStatsGet**](TeamsApi.md#teamsteamidstatsget) | **GET** /teams/{team_id}/stats | Get a team stats
[**UsersUserIdTeamsGet**](TeamsApi.md#usersuseridteamsget) | **GET** /users/{user_id}/teams | Get a user&#39;s teams
[**UsersUserIdTeamsMembersGet**](TeamsApi.md#usersuseridteamsmembersget) | **GET** /users/{user_id}/teams/members | Get team members for a user
[**UsersUserIdTeamsTeamIdUnreadGet**](TeamsApi.md#usersuseridteamsteamidunreadget) | **GET** /users/{user_id}/teams/{team_id}/unread | Get unreads for a team
[**UsersUserIdTeamsUnreadGet**](TeamsApi.md#usersuseridteamsunreadget) | **GET** /users/{user_id}/teams/unread | Get team unreads for a user


<a name="teamsget"></a>
# **TeamsGet**
> List&lt;Team&gt; TeamsGet (string page = null, string perPage = null)

Get teams

For regular users only returns open teams. Users with the \"manage_system\" permission will return teams regardless of type. The result is based on query string parameters - page and per_page. ##### Permissions Must be authenticated. \"manage_system\" permission is required to show all teams. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class TeamsGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new TeamsApi(Configuration.Default);
            var page = page_example;  // string | The page to select. (optional)  (default to "0")
            var perPage = perPage_example;  // string | The number of teams per page. (optional)  (default to "60")

            try
            {
                // Get teams
                List<Team> result = apiInstance.TeamsGet(page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsGet: " + e.Message );
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
 **page** | **string**| The page to select. | [optional] [default to &quot;0&quot;]
 **perPage** | **string**| The number of teams per page. | [optional] [default to &quot;60&quot;]

### Return type

[**List&lt;Team&gt;**](Team.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Team list retrieval successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsinviteinviteidget"></a>
# **TeamsInviteInviteIdGet**
> InlineResponse2005 TeamsInviteInviteIdGet (string inviteId)

Get invite info for a team

Get the `name`, `display_name`, `description` and `id` for a team from the invite id.  __Minimum server version__: 4.0  ##### Permissions No authentication required. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class TeamsInviteInviteIdGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new TeamsApi(Configuration.Default);
            var inviteId = inviteId_example;  // string | Invite id for a team

            try
            {
                // Get invite info for a team
                InlineResponse2005 result = apiInstance.TeamsInviteInviteIdGet(inviteId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsInviteInviteIdGet: " + e.Message );
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
 **inviteId** | **string**| Invite id for a team | 

### Return type

[**InlineResponse2005**](InlineResponse2005.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Team invite info retrieval successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsinvitesemaildelete"></a>
# **TeamsInvitesEmailDelete**
> StatusOK TeamsInvitesEmailDelete ()

Invalidate active email invitations

Invalidate active email invitations that have not been accepted by the user. ##### Permissions Must have `manage_system` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class TeamsInvitesEmailDeleteExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new TeamsApi(Configuration.Default);

            try
            {
                // Invalidate active email invitations
                StatusOK result = apiInstance.TeamsInvitesEmailDelete();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsInvitesEmailDelete: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

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
| **200** | Email invites successfully revoked |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsmembersinvitepost"></a>
# **TeamsMembersInvitePost**
> TeamMember TeamsMembersInvitePost (string token)

Add user to team from invite

Using either an invite id or hash/data pair from an email invite link, add a user to a team. ##### Permissions Must be authenticated. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class TeamsMembersInvitePostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new TeamsApi(Configuration.Default);
            var token = token_example;  // string | Token id from the invitation

            try
            {
                // Add user to team from invite
                TeamMember result = apiInstance.TeamsMembersInvitePost(token);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsMembersInvitePost: " + e.Message );
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
 **token** | **string**| Token id from the invitation | 

### Return type

[**TeamMember**](TeamMember.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Team member creation successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsnamenameexistsget"></a>
# **TeamsNameNameExistsGet**
> TeamExists TeamsNameNameExistsGet (string name)

Check if team exists

Check if the team exists based on a team name. ##### Permissions Must be authenticated. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class TeamsNameNameExistsGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new TeamsApi(Configuration.Default);
            var name = name_example;  // string | Team Name

            try
            {
                // Check if team exists
                TeamExists result = apiInstance.TeamsNameNameExistsGet(name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsNameNameExistsGet: " + e.Message );
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
 **name** | **string**| Team Name | 

### Return type

[**TeamExists**](TeamExists.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Team retrieval successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsnamenameget"></a>
# **TeamsNameNameGet**
> Team TeamsNameNameGet (string name)

Get a team by name

Get a team based on provided name string ##### Permissions Must be authenticated, team type is open and have the `view_team` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class TeamsNameNameGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new TeamsApi(Configuration.Default);
            var name = name_example;  // string | Team Name

            try
            {
                // Get a team by name
                Team result = apiInstance.TeamsNameNameGet(name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsNameNameGet: " + e.Message );
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
 **name** | **string**| Team Name | 

### Return type

[**Team**](Team.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Team retrieval successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamspost"></a>
# **TeamsPost**
> Team TeamsPost (InlineObject23 body)

Create a team

Create a new team on the system. ##### Permissions Must be authenticated and have the `create_team` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class TeamsPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new TeamsApi(Configuration.Default);
            var body = new InlineObject23(); // InlineObject23 | 

            try
            {
                // Create a team
                Team result = apiInstance.TeamsPost(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsPost: " + e.Message );
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
 **body** | [**InlineObject23**](InlineObject23.md)|  | 

### Return type

[**Team**](Team.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Team creation successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamssearchpost"></a>
# **TeamsSearchPost**
> List&lt;Team&gt; TeamsSearchPost (InlineObject26 body)

Search teams

Search teams based on search term provided in the request body. ##### Permissions Logged in user only shows open teams Logged in user with \"manage_system\" permission shows all teams 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class TeamsSearchPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new TeamsApi(Configuration.Default);
            var body = new InlineObject26(); // InlineObject26 | 

            try
            {
                // Search teams
                List<Team> result = apiInstance.TeamsSearchPost(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsSearchPost: " + e.Message );
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
 **body** | [**InlineObject26**](InlineObject26.md)|  | 

### Return type

[**List&lt;Team&gt;**](Team.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Teams search successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsteamiddelete"></a>
# **TeamsTeamIdDelete**
> StatusOK TeamsTeamIdDelete (string teamId, bool? permanent = null)

Delete a team

Soft deletes a team, by marking the team as deleted in the database. Soft deleted teams will not be accessible in the user interface.  Optionally use the permanent query parameter to hard delete the team for compliance reasons. As of server version 5.0, to use this feature `ServiceSettings.EnableAPITeamDeletion` must be set to `true` in the server's configuration. ##### Permissions Must have the `manage_team` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class TeamsTeamIdDeleteExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new TeamsApi(Configuration.Default);
            var teamId = teamId_example;  // string | Team GUID
            var permanent = true;  // bool? | Permanently delete the team, to be used for compliance reasons only. As of server version 5.0, `ServiceSettings.EnableAPITeamDeletion` must be set to `true` in the server's configuration. (optional)  (default to false)

            try
            {
                // Delete a team
                StatusOK result = apiInstance.TeamsTeamIdDelete(teamId, permanent);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsTeamIdDelete: " + e.Message );
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
 **permanent** | **bool?**| Permanently delete the team, to be used for compliance reasons only. As of server version 5.0, &#x60;ServiceSettings.EnableAPITeamDeletion&#x60; must be set to &#x60;true&#x60; in the server&#39;s configuration. | [optional] [default to false]

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
| **200** | Team deletion successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsteamidget"></a>
# **TeamsTeamIdGet**
> Team TeamsTeamIdGet (string teamId)

Get a team

Get a team on the system. ##### Permissions Must be authenticated and have the `view_team` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class TeamsTeamIdGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new TeamsApi(Configuration.Default);
            var teamId = teamId_example;  // string | Team GUID

            try
            {
                // Get a team
                Team result = apiInstance.TeamsTeamIdGet(teamId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsTeamIdGet: " + e.Message );
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

### Return type

[**Team**](Team.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Team retrieval successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsteamidimagedelete"></a>
# **TeamsTeamIdImageDelete**
> StatusOK TeamsTeamIdImageDelete (string teamId)

Remove the team icon

Remove the team icon for the team.  __Minimum server version__: 4.10  ##### Permissions Must be authenticated and have the `manage_team` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class TeamsTeamIdImageDeleteExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new TeamsApi(Configuration.Default);
            var teamId = teamId_example;  // string | Team GUID

            try
            {
                // Remove the team icon
                StatusOK result = apiInstance.TeamsTeamIdImageDelete(teamId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsTeamIdImageDelete: " + e.Message );
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
| **200** | Team icon successfully remove |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **500** | Something went wrong with the server |  -  |
| **501** | Feature is disabled |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsteamidimageget"></a>
# **TeamsTeamIdImageGet**
> void TeamsTeamIdImageGet (string teamId)

Get the team icon

Get the team icon of the team.  __Minimum server version__: 4.9  ##### Permissions User must be authenticated. In addition, team must be open or the user must have the `view_team` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class TeamsTeamIdImageGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new TeamsApi(Configuration.Default);
            var teamId = teamId_example;  // string | Team GUID

            try
            {
                // Get the team icon
                apiInstance.TeamsTeamIdImageGet(teamId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsTeamIdImageGet: " + e.Message );
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
| **200** | Team icon retrieval successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |
| **501** | Feature is disabled |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsteamidimagepost"></a>
# **TeamsTeamIdImagePost**
> StatusOK TeamsTeamIdImagePost (string teamId, System.IO.Stream image)

Sets the team icon

Sets the team icon for the team.  __Minimum server version__: 4.9  ##### Permissions Must be authenticated and have the `manage_team` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class TeamsTeamIdImagePostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new TeamsApi(Configuration.Default);
            var teamId = teamId_example;  // string | Team GUID
            var image = BINARY_DATA_HERE;  // System.IO.Stream | The image to be uploaded

            try
            {
                // Sets the team icon
                StatusOK result = apiInstance.TeamsTeamIdImagePost(teamId, image);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsTeamIdImagePost: " + e.Message );
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
 **image** | **System.IO.Stream****System.IO.Stream**| The image to be uploaded | 

### Return type

[**StatusOK**](StatusOK.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Team icon successfully set |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **500** | Something went wrong with the server |  -  |
| **501** | Feature is disabled |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsteamidimportpost"></a>
# **TeamsTeamIdImportPost**
> InlineResponse2004 TeamsTeamIdImportPost (string teamId, System.IO.Stream file, int filesize, string importFrom)

Import a Team from other application

Import a team into a existing team. Import users, channels, posts, hooks. ##### Permissions Must have `permission_import_team` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class TeamsTeamIdImportPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new TeamsApi(Configuration.Default);
            var teamId = teamId_example;  // string | Team GUID
            var file = BINARY_DATA_HERE;  // System.IO.Stream | A file to be uploaded in zip format.
            var filesize = 56;  // int | The size of the zip file to be imported.
            var importFrom = importFrom_example;  // string | String that defines from which application the team was exported to be imported into Mattermost.

            try
            {
                // Import a Team from other application
                InlineResponse2004 result = apiInstance.TeamsTeamIdImportPost(teamId, file, filesize, importFrom);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsTeamIdImportPost: " + e.Message );
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
 **file** | **System.IO.Stream****System.IO.Stream**| A file to be uploaded in zip format. | 
 **filesize** | **int**| The size of the zip file to be imported. | 
 **importFrom** | **string**| String that defines from which application the team was exported to be imported into Mattermost. | 

### Return type

[**InlineResponse2004**](InlineResponse2004.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | JSON object containing a base64 encoded text file of the import logs in its &#x60;results&#x60; property. |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsteamidinviteemailpost"></a>
# **TeamsTeamIdInviteEmailPost**
> StatusOK TeamsTeamIdInviteEmailPost (string teamId, List<string> body)

Invite users to the team by email

Invite users to the existing team usign the user's email. ##### Permissions Must have `invite_to_team` permission for the team. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class TeamsTeamIdInviteEmailPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new TeamsApi(Configuration.Default);
            var teamId = teamId_example;  // string | Team GUID
            var body = new List<string>(); // List<string> | List of user's email

            try
            {
                // Invite users to the team by email
                StatusOK result = apiInstance.TeamsTeamIdInviteEmailPost(teamId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsTeamIdInviteEmailPost: " + e.Message );
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
 **body** | [**List&lt;string&gt;**](string.md)| List of user&#39;s email | 

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
| **200** | Users invite successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsteamidmembersbatchpost"></a>
# **TeamsTeamIdMembersBatchPost**
> List&lt;TeamMember&gt; TeamsTeamIdMembersBatchPost (string teamId, List<TeamMember> body)

Add multiple users to team

Add a number of users to the team by user_id. ##### Permissions Must be authenticated. Authenticated user must have the `add_user_to_team` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class TeamsTeamIdMembersBatchPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new TeamsApi(Configuration.Default);
            var teamId = teamId_example;  // string | Team GUID
            var body = new List<TeamMember>(); // List<TeamMember> | 

            try
            {
                // Add multiple users to team
                List<TeamMember> result = apiInstance.TeamsTeamIdMembersBatchPost(teamId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsTeamIdMembersBatchPost: " + e.Message );
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
 **body** | [**List&lt;TeamMember&gt;**](TeamMember.md)|  | 

### Return type

[**List&lt;TeamMember&gt;**](TeamMember.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Team members created successfully. |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsteamidmembersget"></a>
# **TeamsTeamIdMembersGet**
> List&lt;TeamMember&gt; TeamsTeamIdMembersGet (string teamId, string page = null, string perPage = null)

Get team members

Get a page team members list based on query string parameters - team id, page and per page. ##### Permissions Must be authenticated and have the `view_team` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class TeamsTeamIdMembersGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new TeamsApi(Configuration.Default);
            var teamId = teamId_example;  // string | Team GUID
            var page = page_example;  // string | The page to select. (optional)  (default to "0")
            var perPage = perPage_example;  // string | The number of users per page. (optional)  (default to "60")

            try
            {
                // Get team members
                List<TeamMember> result = apiInstance.TeamsTeamIdMembersGet(teamId, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsTeamIdMembersGet: " + e.Message );
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
 **perPage** | **string**| The number of users per page. | [optional] [default to &quot;60&quot;]

### Return type

[**List&lt;TeamMember&gt;**](TeamMember.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Team members retrieval successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsteamidmembersidspost"></a>
# **TeamsTeamIdMembersIdsPost**
> List&lt;TeamMember&gt; TeamsTeamIdMembersIdsPost (string teamId, List<string> body)

Get team members by ids

Get a list of team members based on a provided array of user ids. ##### Permissions Must have `view_team` permission for the team. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class TeamsTeamIdMembersIdsPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new TeamsApi(Configuration.Default);
            var teamId = teamId_example;  // string | Team GUID
            var body = new List<string>(); // List<string> | List of user ids

            try
            {
                // Get team members by ids
                List<TeamMember> result = apiInstance.TeamsTeamIdMembersIdsPost(teamId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsTeamIdMembersIdsPost: " + e.Message );
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
 **body** | [**List&lt;string&gt;**](string.md)| List of user ids | 

### Return type

[**List&lt;TeamMember&gt;**](TeamMember.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Team members retrieval successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsteamidmembersminusgroupmembersget"></a>
# **TeamsTeamIdMembersMinusGroupMembersGet**
> void TeamsTeamIdMembersMinusGroupMembersGet (string teamId, string groupIds, string page = null, string perPage = null)

Team members minus group members.

Get the set of users who are members of the team minus the set of users who are members of the given groups. Each user object contains an array of group objects representing the group memberships for that user. Each user object contains the boolean fields `scheme_guest`, `scheme_user`, and `scheme_admin` representing the roles that user has for the given team.  ##### Permissions Must have `manage_system` permission.  __Minimum server version__: 5.14 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class TeamsTeamIdMembersMinusGroupMembersGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new TeamsApi(Configuration.Default);
            var teamId = teamId_example;  // string | Team GUID
            var groupIds = groupIds_example;  // string | A comma-separated list of group ids.
            var page = page_example;  // string | The page to select. (optional)  (default to "0")
            var perPage = perPage_example;  // string | The number of users per page. (optional)  (default to "0")

            try
            {
                // Team members minus group members.
                apiInstance.TeamsTeamIdMembersMinusGroupMembersGet(teamId, groupIds, page, perPage);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsTeamIdMembersMinusGroupMembersGet: " + e.Message );
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

<a name="teamsteamidmemberspost"></a>
# **TeamsTeamIdMembersPost**
> TeamMember TeamsTeamIdMembersPost (string teamId, InlineObject27 body)

Add user to team

Add user to the team by user_id. ##### Permissions Must be authenticated and team be open to add self. For adding another user, authenticated user must have the `add_user_to_team` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class TeamsTeamIdMembersPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new TeamsApi(Configuration.Default);
            var teamId = teamId_example;  // string | Team GUID
            var body = new InlineObject27(); // InlineObject27 | 

            try
            {
                // Add user to team
                TeamMember result = apiInstance.TeamsTeamIdMembersPost(teamId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsTeamIdMembersPost: " + e.Message );
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
 **body** | [**InlineObject27**](InlineObject27.md)|  | 

### Return type

[**TeamMember**](TeamMember.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Team member creation successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsteamidmembersuseriddelete"></a>
# **TeamsTeamIdMembersUserIdDelete**
> StatusOK TeamsTeamIdMembersUserIdDelete (string teamId, string userId)

Remove user from team

Delete the team member object for a user, effectively removing them from a team. ##### Permissions Must be logged in as the user or have the `remove_user_from_team` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class TeamsTeamIdMembersUserIdDeleteExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new TeamsApi(Configuration.Default);
            var teamId = teamId_example;  // string | Team GUID
            var userId = userId_example;  // string | User GUID

            try
            {
                // Remove user from team
                StatusOK result = apiInstance.TeamsTeamIdMembersUserIdDelete(teamId, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsTeamIdMembersUserIdDelete: " + e.Message );
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
| **200** | Team member deletion successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsteamidmembersuseridget"></a>
# **TeamsTeamIdMembersUserIdGet**
> TeamMember TeamsTeamIdMembersUserIdGet (string teamId, string userId)

Get a team member

Get a team member on the system. ##### Permissions Must be authenticated and have the `view_team` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class TeamsTeamIdMembersUserIdGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new TeamsApi(Configuration.Default);
            var teamId = teamId_example;  // string | Team GUID
            var userId = userId_example;  // string | User GUID

            try
            {
                // Get a team member
                TeamMember result = apiInstance.TeamsTeamIdMembersUserIdGet(teamId, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsTeamIdMembersUserIdGet: " + e.Message );
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
 **userId** | **string**| User GUID | 

### Return type

[**TeamMember**](TeamMember.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Team member retrieval successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsteamidmembersuseridrolesput"></a>
# **TeamsTeamIdMembersUserIdRolesPut**
> StatusOK TeamsTeamIdMembersUserIdRolesPut (string teamId, string userId, InlineObject28 body)

Update a team member roles

Update a team member roles. Valid team roles are \"team_user\", \"team_admin\" or both of them. Overwrites any previously assigned team roles. ##### Permissions Must be authenticated and have the `manage_team_roles` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class TeamsTeamIdMembersUserIdRolesPutExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new TeamsApi(Configuration.Default);
            var teamId = teamId_example;  // string | Team GUID
            var userId = userId_example;  // string | User GUID
            var body = new InlineObject28(); // InlineObject28 | 

            try
            {
                // Update a team member roles
                StatusOK result = apiInstance.TeamsTeamIdMembersUserIdRolesPut(teamId, userId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsTeamIdMembersUserIdRolesPut: " + e.Message );
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
 **userId** | **string**| User GUID | 
 **body** | [**InlineObject28**](InlineObject28.md)|  | 

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
| **200** | Team member roles update successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsteamidmembersuseridschemerolesput"></a>
# **TeamsTeamIdMembersUserIdSchemeRolesPut**
> StatusOK TeamsTeamIdMembersUserIdSchemeRolesPut (string teamId, string userId, InlineObject29 body)

Update the scheme-derived roles of a team member.

Update a team member's scheme_admin/scheme_user properties. Typically this should either be `scheme_admin=false, scheme_user=true` for ordinary team member, or `scheme_admin=true, scheme_user=true` for a team admin.  __Minimum server version__: 5.0  ##### Permissions Must be authenticated and have the `manage_team_roles` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class TeamsTeamIdMembersUserIdSchemeRolesPutExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new TeamsApi(Configuration.Default);
            var teamId = teamId_example;  // string | Team GUID
            var userId = userId_example;  // string | User GUID
            var body = new InlineObject29(); // InlineObject29 | 

            try
            {
                // Update the scheme-derived roles of a team member.
                StatusOK result = apiInstance.TeamsTeamIdMembersUserIdSchemeRolesPut(teamId, userId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsTeamIdMembersUserIdSchemeRolesPut: " + e.Message );
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
 **userId** | **string**| User GUID | 
 **body** | [**InlineObject29**](InlineObject29.md)|  | 

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
| **200** | Team member&#39;s scheme-derived roles updated successfully. |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsteamidpatchput"></a>
# **TeamsTeamIdPatchPut**
> Team TeamsTeamIdPatchPut (string teamId, InlineObject25 body)

Patch a team

Partially update a team by providing only the fields you want to update. Omitted fields will not be updated. The fields that can be updated are defined in the request body, all other provided fields will be ignored. ##### Permissions Must have the `manage_team` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class TeamsTeamIdPatchPutExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new TeamsApi(Configuration.Default);
            var teamId = teamId_example;  // string | Team GUID
            var body = new InlineObject25(); // InlineObject25 | 

            try
            {
                // Patch a team
                Team result = apiInstance.TeamsTeamIdPatchPut(teamId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsTeamIdPatchPut: " + e.Message );
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
 **body** | [**InlineObject25**](InlineObject25.md)|  | 

### Return type

[**Team**](Team.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | team patch successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsteamidput"></a>
# **TeamsTeamIdPut**
> Team TeamsTeamIdPut (string teamId, InlineObject24 body)

Update a team

Update a team by providing the team object. The fields that can be updated are defined in the request body, all other provided fields will be ignored. ##### Permissions Must have the `manage_team` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class TeamsTeamIdPutExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new TeamsApi(Configuration.Default);
            var teamId = teamId_example;  // string | Team GUID
            var body = new InlineObject24(); // InlineObject24 | 

            try
            {
                // Update a team
                Team result = apiInstance.TeamsTeamIdPut(teamId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsTeamIdPut: " + e.Message );
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
 **body** | [**InlineObject24**](InlineObject24.md)|  | 

### Return type

[**Team**](Team.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Team update successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsteamidregenerateinviteidpost"></a>
# **TeamsTeamIdRegenerateInviteIdPost**
> Team TeamsTeamIdRegenerateInviteIdPost (string teamId)

Regenerate the Invite ID from a Team

Regenerates the invite ID used in invite links of a team ##### Permissions Must be authenticated and have the `manage_team` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class TeamsTeamIdRegenerateInviteIdPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new TeamsApi(Configuration.Default);
            var teamId = teamId_example;  // string | Team GUID

            try
            {
                // Regenerate the Invite ID from a Team
                Team result = apiInstance.TeamsTeamIdRegenerateInviteIdPost(teamId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsTeamIdRegenerateInviteIdPost: " + e.Message );
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

### Return type

[**Team**](Team.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Team Invite ID regenerated |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsteamidschemeput"></a>
# **TeamsTeamIdSchemePut**
> StatusOK TeamsTeamIdSchemePut (string teamId, InlineObject30 body)

Set a team's scheme

Set a team's scheme, more specifically sets the scheme_id value of a team record.  ##### Permissions Must have `manage_system` permission.  __Minimum server version__: 5.0 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class TeamsTeamIdSchemePutExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new TeamsApi(Configuration.Default);
            var teamId = teamId_example;  // string | Team GUID
            var body = new InlineObject30(); // InlineObject30 | 

            try
            {
                // Set a team's scheme
                StatusOK result = apiInstance.TeamsTeamIdSchemePut(teamId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsTeamIdSchemePut: " + e.Message );
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
 **body** | [**InlineObject30**](InlineObject30.md)|  | 

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
| **200** | Update team scheme successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **501** | Feature is disabled |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsteamidstatsget"></a>
# **TeamsTeamIdStatsGet**
> TeamStats TeamsTeamIdStatsGet (string teamId)

Get a team stats

Get a team stats on the system. ##### Permissions Must be authenticated and have the `view_team` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class TeamsTeamIdStatsGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new TeamsApi(Configuration.Default);
            var teamId = teamId_example;  // string | Team GUID

            try
            {
                // Get a team stats
                TeamStats result = apiInstance.TeamsTeamIdStatsGet(teamId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.TeamsTeamIdStatsGet: " + e.Message );
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

### Return type

[**TeamStats**](TeamStats.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Team stats retrieval successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersuseridteamsget"></a>
# **UsersUserIdTeamsGet**
> List&lt;Team&gt; UsersUserIdTeamsGet (string userId)

Get a user's teams

Get a list of teams that a user is on. ##### Permissions Must be authenticated as the user or have the `manage_system` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class UsersUserIdTeamsGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new TeamsApi(Configuration.Default);
            var userId = userId_example;  // string | User GUID

            try
            {
                // Get a user's teams
                List<Team> result = apiInstance.UsersUserIdTeamsGet(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.UsersUserIdTeamsGet: " + e.Message );
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

### Return type

[**List&lt;Team&gt;**](Team.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Team list retrieval successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersuseridteamsmembersget"></a>
# **UsersUserIdTeamsMembersGet**
> List&lt;TeamMember&gt; UsersUserIdTeamsMembersGet (string userId)

Get team members for a user

Get a list of team members for a user. Useful for getting the ids of teams the user is on and the roles they have in those teams. ##### Permissions Must be logged in as the user or have the `edit_other_users` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class UsersUserIdTeamsMembersGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new TeamsApi(Configuration.Default);
            var userId = userId_example;  // string | User GUID

            try
            {
                // Get team members for a user
                List<TeamMember> result = apiInstance.UsersUserIdTeamsMembersGet(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.UsersUserIdTeamsMembersGet: " + e.Message );
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

### Return type

[**List&lt;TeamMember&gt;**](TeamMember.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Team members retrieval successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersuseridteamsteamidunreadget"></a>
# **UsersUserIdTeamsTeamIdUnreadGet**
> TeamUnread UsersUserIdTeamsTeamIdUnreadGet (string userId, string teamId)

Get unreads for a team

Get the unread mention and message counts for a team for the specified user. ##### Permissions Must be the user or have `edit_other_users` permission and have `view_team` permission for the team. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class UsersUserIdTeamsTeamIdUnreadGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new TeamsApi(Configuration.Default);
            var userId = userId_example;  // string | User GUID
            var teamId = teamId_example;  // string | Team GUID

            try
            {
                // Get unreads for a team
                TeamUnread result = apiInstance.UsersUserIdTeamsTeamIdUnreadGet(userId, teamId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.UsersUserIdTeamsTeamIdUnreadGet: " + e.Message );
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

[**TeamUnread**](TeamUnread.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Team unread count retrieval successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersuseridteamsunreadget"></a>
# **UsersUserIdTeamsUnreadGet**
> List&lt;TeamUnread&gt; UsersUserIdTeamsUnreadGet (string userId, string excludeTeam)

Get team unreads for a user

Get the count for unread messages and mentions in the teams the user is a member of. ##### Permissions Must be logged in. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class UsersUserIdTeamsUnreadGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new TeamsApi(Configuration.Default);
            var userId = userId_example;  // string | User GUID
            var excludeTeam = excludeTeam_example;  // string | Optional team id to be excluded from the results

            try
            {
                // Get team unreads for a user
                List<TeamUnread> result = apiInstance.UsersUserIdTeamsUnreadGet(userId, excludeTeam);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.UsersUserIdTeamsUnreadGet: " + e.Message );
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
 **excludeTeam** | **string**| Optional team id to be excluded from the results | 

### Return type

[**List&lt;TeamUnread&gt;**](TeamUnread.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Team unreads retrieval successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

