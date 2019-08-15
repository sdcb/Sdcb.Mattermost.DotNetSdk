# Sdcb.Mattermost.DotNetSdk.Api.UsersApi

All URIs are relative to *http://your-mattermost-url.com/api/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UsersAutocompleteGet**](UsersApi.md#usersautocompleteget) | **GET** /users/autocomplete | Autocomplete users
[**UsersEmailEmailGet**](UsersApi.md#usersemailemailget) | **GET** /users/email/{email} | Get a user by email
[**UsersEmailVerifyPost**](UsersApi.md#usersemailverifypost) | **POST** /users/email/verify | Verify user email
[**UsersEmailVerifySendPost**](UsersApi.md#usersemailverifysendpost) | **POST** /users/email/verify/send | Send verification email
[**UsersGet**](UsersApi.md#usersget) | **GET** /users | Get users
[**UsersGroupChannelsPost**](UsersApi.md#usersgroupchannelspost) | **POST** /users/group_channels | Get users by group channels ids
[**UsersIdsPost**](UsersApi.md#usersidspost) | **POST** /users/ids | Get users by ids
[**UsersLoginSwitchPost**](UsersApi.md#usersloginswitchpost) | **POST** /users/login/switch | Switch login method
[**UsersMfaPost**](UsersApi.md#usersmfapost) | **POST** /users/mfa | Check MFA
[**UsersPasswordResetPost**](UsersApi.md#userspasswordresetpost) | **POST** /users/password/reset | Reset password
[**UsersPasswordResetSendPost**](UsersApi.md#userspasswordresetsendpost) | **POST** /users/password/reset/send | Send password reset email
[**UsersPost**](UsersApi.md#userspost) | **POST** /users | Create a user
[**UsersSearchPost**](UsersApi.md#userssearchpost) | **POST** /users/search | Search users
[**UsersSessionsDevicePut**](UsersApi.md#userssessionsdeviceput) | **PUT** /users/sessions/device | Attach mobile device
[**UsersStatsGet**](UsersApi.md#usersstatsget) | **GET** /users/stats | Get total count of users in the system
[**UsersTokensDisablePost**](UsersApi.md#userstokensdisablepost) | **POST** /users/tokens/disable | Disable personal access token
[**UsersTokensEnablePost**](UsersApi.md#userstokensenablepost) | **POST** /users/tokens/enable | Enable personal access token
[**UsersTokensGet**](UsersApi.md#userstokensget) | **GET** /users/tokens | Get user access tokens
[**UsersTokensRevokePost**](UsersApi.md#userstokensrevokepost) | **POST** /users/tokens/revoke | Revoke a user access token
[**UsersTokensSearchPost**](UsersApi.md#userstokenssearchpost) | **POST** /users/tokens/search | Search tokens
[**UsersTokensTokenIdGet**](UsersApi.md#userstokenstokenidget) | **GET** /users/tokens/{token_id} | Get a user access token
[**UsersUserIdActivePut**](UsersApi.md#usersuseridactiveput) | **PUT** /users/{user_id}/active | Update user active status
[**UsersUserIdAuditsGet**](UsersApi.md#usersuseridauditsget) | **GET** /users/{user_id}/audits | Get user&#39;s audits
[**UsersUserIdAuthPut**](UsersApi.md#usersuseridauthput) | **PUT** /users/{user_id}/auth | Update a user&#39;s authentication method
[**UsersUserIdDelete**](UsersApi.md#usersuseriddelete) | **DELETE** /users/{user_id} | Deactivate a user account.
[**UsersUserIdGet**](UsersApi.md#usersuseridget) | **GET** /users/{user_id} | Get a user
[**UsersUserIdImageDefaultGet**](UsersApi.md#usersuseridimagedefaultget) | **GET** /users/{user_id}/image/default | Return user&#39;s default (generated) profile image
[**UsersUserIdImageDelete**](UsersApi.md#usersuseridimagedelete) | **DELETE** /users/{user_id}/image | Delete user&#39;s profile image
[**UsersUserIdImageGet**](UsersApi.md#usersuseridimageget) | **GET** /users/{user_id}/image | Get user&#39;s profile image
[**UsersUserIdImagePost**](UsersApi.md#usersuseridimagepost) | **POST** /users/{user_id}/image | Set user&#39;s profile image
[**UsersUserIdMfaGeneratePost**](UsersApi.md#usersuseridmfageneratepost) | **POST** /users/{user_id}/mfa/generate | Generate MFA secret
[**UsersUserIdMfaPut**](UsersApi.md#usersuseridmfaput) | **PUT** /users/{user_id}/mfa | Update a user&#39;s MFA
[**UsersUserIdPasswordPut**](UsersApi.md#usersuseridpasswordput) | **PUT** /users/{user_id}/password | Update a user&#39;s password
[**UsersUserIdPatchPut**](UsersApi.md#usersuseridpatchput) | **PUT** /users/{user_id}/patch | Patch a user
[**UsersUserIdPut**](UsersApi.md#usersuseridput) | **PUT** /users/{user_id} | Update a user
[**UsersUserIdRolesPut**](UsersApi.md#usersuseridrolesput) | **PUT** /users/{user_id}/roles | Update a user&#39;s roles
[**UsersUserIdSessionsGet**](UsersApi.md#usersuseridsessionsget) | **GET** /users/{user_id}/sessions | Get user&#39;s sessions
[**UsersUserIdSessionsRevokeAllPost**](UsersApi.md#usersuseridsessionsrevokeallpost) | **POST** /users/{user_id}/sessions/revoke/all | Revoke all active sessions for a user
[**UsersUserIdSessionsRevokePost**](UsersApi.md#usersuseridsessionsrevokepost) | **POST** /users/{user_id}/sessions/revoke | Revoke a user session
[**UsersUserIdTermsOfServiceGet**](UsersApi.md#usersuseridtermsofserviceget) | **GET** /users/{user_id}/terms_of_service | Fetches user&#39;s latest terms of service action if the latest action was for acceptance.
[**UsersUserIdTermsOfServicePost**](UsersApi.md#usersuseridtermsofservicepost) | **POST** /users/{user_id}/terms_of_service | Records user action when they accept or decline custom terms of service
[**UsersUserIdTokensGet**](UsersApi.md#usersuseridtokensget) | **GET** /users/{user_id}/tokens | Get user access tokens
[**UsersUserIdTokensPost**](UsersApi.md#usersuseridtokenspost) | **POST** /users/{user_id}/tokens | Create a user access token
[**UsersUsernameUsernameGet**](UsersApi.md#usersusernameusernameget) | **GET** /users/username/{username} | Get a user by username
[**UsersUsernamesPost**](UsersApi.md#usersusernamespost) | **POST** /users/usernames | Get users by usernames


<a name="usersautocompleteget"></a>
# **UsersAutocompleteGet**
> UserAutocomplete UsersAutocompleteGet (string name, string teamId = null, string channelId = null, int? limit = null)

Autocomplete users

Get a list of users for the purpose of autocompleting based on the provided search term. Specify a combination of `team_id` and `channel_id` to filter results further. ##### Permissions Requires an active session and `view_team` and `read_channel` on any teams or channels used to filter the results further. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class UsersAutocompleteGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new UsersApi(Configuration.Default);
            var name = name_example;  // string | Username, nickname first name or last name
            var teamId = teamId_example;  // string | Team ID (optional) 
            var channelId = channelId_example;  // string | Channel ID (optional) 
            var limit = 56;  // int? | The maximum number of users to return in each subresult  __Available as of server version 5.6. Defaults to `100` if not provided or on an earlier server version.__  (optional)  (default to 100)

            try
            {
                // Autocomplete users
                UserAutocomplete result = apiInstance.UsersAutocompleteGet(name, teamId, channelId, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UsersAutocompleteGet: " + e.Message );
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
 **name** | **string**| Username, nickname first name or last name | 
 **teamId** | **string**| Team ID | [optional] 
 **channelId** | **string**| Channel ID | [optional] 
 **limit** | **int?**| The maximum number of users to return in each subresult  __Available as of server version 5.6. Defaults to &#x60;100&#x60; if not provided or on an earlier server version.__  | [optional] [default to 100]

### Return type

[**UserAutocomplete**](UserAutocomplete.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | User autocomplete successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersemailemailget"></a>
# **UsersEmailEmailGet**
> User UsersEmailEmailGet (string email)

Get a user by email

Get a user object by providing a user email. Sensitive information will be sanitized out. ##### Permissions Requires an active session and for the current session to be able to view another user's email based on the server's privacy settings. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class UsersEmailEmailGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new UsersApi(Configuration.Default);
            var email = email_example;  // string | User Email

            try
            {
                // Get a user by email
                User result = apiInstance.UsersEmailEmailGet(email);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UsersEmailEmailGet: " + e.Message );
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
 **email** | **string**| User Email | 

### Return type

[**User**](User.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | User retrieval successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersemailverifypost"></a>
# **UsersEmailVerifyPost**
> StatusOK UsersEmailVerifyPost (InlineObject13 body)

Verify user email

Verify the email used by a user to sign-up their account with. ##### Permissions No permissions required. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class UsersEmailVerifyPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new UsersApi(Configuration.Default);
            var body = new InlineObject13(); // InlineObject13 | 

            try
            {
                // Verify user email
                StatusOK result = apiInstance.UsersEmailVerifyPost(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UsersEmailVerifyPost: " + e.Message );
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
 **body** | [**InlineObject13**](InlineObject13.md)|  | 

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
| **200** | User email verification successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersemailverifysendpost"></a>
# **UsersEmailVerifySendPost**
> StatusOK UsersEmailVerifySendPost (InlineObject14 body)

Send verification email

Send an email with a verification link to a user that has an email matching the one in the request body. This endpoint will return success even if the email does not match any users on the system. ##### Permissions No permissions required. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class UsersEmailVerifySendPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new UsersApi(Configuration.Default);
            var body = new InlineObject14(); // InlineObject14 | 

            try
            {
                // Send verification email
                StatusOK result = apiInstance.UsersEmailVerifySendPost(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UsersEmailVerifySendPost: " + e.Message );
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
 **body** | [**InlineObject14**](InlineObject14.md)|  | 

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
| **200** | Email send successful if email exists |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersget"></a>
# **UsersGet**
> List&lt;User&gt; UsersGet (string page = null, string perPage = null, string inTeam = null, string notInTeam = null, string inChannel = null, string notInChannel = null, bool? groupConstrained = null, bool? withoutTeam = null, string sort = null)

Get users

Get a page of a list of users. Based on query string parameters, select users from a team, channel, or select users not in a specific channel.  Since server version 4.0, some basic sorting is available using the `sort` query parameter. Sorting is currently only supported when selecting users on a team. ##### Permissions Requires an active session and (if specified) membership to the channel or team being selected from. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class UsersGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new UsersApi(Configuration.Default);
            var page = page_example;  // string | The page to select. (optional)  (default to "0")
            var perPage = perPage_example;  // string | The number of users per page. There is a maximum limit of 200 users per page. (optional)  (default to "60")
            var inTeam = inTeam_example;  // string | The ID of the team to get users for. (optional) 
            var notInTeam = notInTeam_example;  // string | The ID of the team to exclude users for. Must not be used with \"in_team\" query parameter. (optional) 
            var inChannel = inChannel_example;  // string | The ID of the channel to get users for. (optional) 
            var notInChannel = notInChannel_example;  // string | The ID of the channel to exclude users for. Must be used with \"in_channel\" query parameter. (optional) 
            var groupConstrained = true;  // bool? | When used with `not_in_channel` or `not_in_team`, returns only the users that are allowed to join the channel or team based on its group constrains. (optional) 
            var withoutTeam = true;  // bool? | Whether or not to list users that are not on any team. This option takes precendence over `in_team`, `in_channel`, and `not_in_channel`. (optional) 
            var sort = sort_example;  // string | Sort is only available in conjunction with certain options below. The paging parameter is also always available.  ##### `in_team` Can be \"\", \"last_activity_at\" or \"create_at\". When left blank, sorting is done by username. __Minimum server version__: 4.0 ##### `in_channel` Can be \"\", \"status\". When left blank, sorting is done by username. `status` will sort by User's current status (Online, Away, DND, Offline), then by Username. __Minimum server version__: 4.7  (optional) 

            try
            {
                // Get users
                List<User> result = apiInstance.UsersGet(page, perPage, inTeam, notInTeam, inChannel, notInChannel, groupConstrained, withoutTeam, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UsersGet: " + e.Message );
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
 **perPage** | **string**| The number of users per page. There is a maximum limit of 200 users per page. | [optional] [default to &quot;60&quot;]
 **inTeam** | **string**| The ID of the team to get users for. | [optional] 
 **notInTeam** | **string**| The ID of the team to exclude users for. Must not be used with \&quot;in_team\&quot; query parameter. | [optional] 
 **inChannel** | **string**| The ID of the channel to get users for. | [optional] 
 **notInChannel** | **string**| The ID of the channel to exclude users for. Must be used with \&quot;in_channel\&quot; query parameter. | [optional] 
 **groupConstrained** | **bool?**| When used with &#x60;not_in_channel&#x60; or &#x60;not_in_team&#x60;, returns only the users that are allowed to join the channel or team based on its group constrains. | [optional] 
 **withoutTeam** | **bool?**| Whether or not to list users that are not on any team. This option takes precendence over &#x60;in_team&#x60;, &#x60;in_channel&#x60;, and &#x60;not_in_channel&#x60;. | [optional] 
 **sort** | **string**| Sort is only available in conjunction with certain options below. The paging parameter is also always available.  ##### &#x60;in_team&#x60; Can be \&quot;\&quot;, \&quot;last_activity_at\&quot; or \&quot;create_at\&quot;. When left blank, sorting is done by username. __Minimum server version__: 4.0 ##### &#x60;in_channel&#x60; Can be \&quot;\&quot;, \&quot;status\&quot;. When left blank, sorting is done by username. &#x60;status&#x60; will sort by User&#39;s current status (Online, Away, DND, Offline), then by Username. __Minimum server version__: 4.7  | [optional] 

### Return type

[**List&lt;User&gt;**](User.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | User page retrieval successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersgroupchannelspost"></a>
# **UsersGroupChannelsPost**
> InlineResponse200 UsersGroupChannelsPost (List<string> body)

Get users by group channels ids

Get an object containing a key per group channel id in the query and its value as a list of users members of that group channel.  The user must be a member of the group ids in the query, or they will be omitted from the response. ##### Permissions Requires an active session but no other permissions.  __Minimum server version__: 5.14 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class UsersGroupChannelsPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new UsersApi(Configuration.Default);
            var body = new List<string>(); // List<string> | List of group channel ids

            try
            {
                // Get users by group channels ids
                InlineResponse200 result = apiInstance.UsersGroupChannelsPost(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UsersGroupChannelsPost: " + e.Message );
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
 **body** | [**List&lt;string&gt;**](string.md)| List of group channel ids | 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | User list retrieval successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersidspost"></a>
# **UsersIdsPost**
> List&lt;User&gt; UsersIdsPost (List<string> body, int? since = null)

Get users by ids

Get a list of users based on a provided list of user ids. ##### Permissions Requires an active session but no other permissions. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class UsersIdsPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new UsersApi(Configuration.Default);
            var body = new List<string>(); // List<string> | List of user ids
            var since = 56;  // int? | Only return users that have been modified since the given Unix timestamp (in milliseconds).  __Minimum server version__: 5.14  (optional) 

            try
            {
                // Get users by ids
                List<User> result = apiInstance.UsersIdsPost(body, since);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UsersIdsPost: " + e.Message );
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
 **body** | [**List&lt;string&gt;**](string.md)| List of user ids | 
 **since** | **int?**| Only return users that have been modified since the given Unix timestamp (in milliseconds).  __Minimum server version__: 5.14  | [optional] 

### Return type

[**List&lt;User&gt;**](User.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | User list retrieval successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersloginswitchpost"></a>
# **UsersLoginSwitchPost**
> InlineResponse2003 UsersLoginSwitchPost (InlineObject15 body)

Switch login method

Switch a user's login method from using email to OAuth2/SAML/LDAP or back to email. When switching to OAuth2/SAML, account switching is not complete until the user follows the returned link and completes any steps on the OAuth2/SAML service provider.  To switch from email to OAuth2/SAML, specify `current_service`, `new_service`, `email` and `password`.  To switch from OAuth2/SAML to email, specify `current_service`, `new_service`, `email` and `new_password`.  To switch from email to LDAP/AD, specify `current_service`, `new_service`, `email`, `password`, `ldap_ip` and `new_password` (this is the user's LDAP password).  To switch from LDAP/AD to email, specify `current_service`, `new_service`, `ldap_ip`, `password` (this is the user's LDAP password), `email`  and `new_password`.  Additionally, specify `mfa_code` when trying to switch an account on LDAP/AD or email that has MFA activated.  ##### Permissions No current authentication required except when switching from OAuth2/SAML to email. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class UsersLoginSwitchPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new UsersApi(Configuration.Default);
            var body = new InlineObject15(); // InlineObject15 | 

            try
            {
                // Switch login method
                InlineResponse2003 result = apiInstance.UsersLoginSwitchPost(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UsersLoginSwitchPost: " + e.Message );
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
 **body** | [**InlineObject15**](InlineObject15.md)|  | 

### Return type

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Login method switch or request successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |
| **501** | Feature is disabled |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersmfapost"></a>
# **UsersMfaPost**
> InlineResponse2002 UsersMfaPost (InlineObject8 body)

Check MFA

Check if a user has multi-factor authentication active on their account by providing a login id. Used to check whether an MFA code needs to be provided when logging in. ##### Permissions No permission required. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class UsersMfaPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new UsersApi(Configuration.Default);
            var body = new InlineObject8(); // InlineObject8 | 

            try
            {
                // Check MFA
                InlineResponse2002 result = apiInstance.UsersMfaPost(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UsersMfaPost: " + e.Message );
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
 **body** | [**InlineObject8**](InlineObject8.md)|  | 

### Return type

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | MFA check successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userspasswordresetpost"></a>
# **UsersPasswordResetPost**
> StatusOK UsersPasswordResetPost (InlineObject6 body)

Reset password

Update the password for a user using a one-use, timed recovery code tied to the user's account. Only works for non-SSO users. ##### Permissions No permissions required. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class UsersPasswordResetPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new UsersApi(Configuration.Default);
            var body = new InlineObject6(); // InlineObject6 | 

            try
            {
                // Reset password
                StatusOK result = apiInstance.UsersPasswordResetPost(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UsersPasswordResetPost: " + e.Message );
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
 **body** | [**InlineObject6**](InlineObject6.md)|  | 

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
| **200** | User password update successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userspasswordresetsendpost"></a>
# **UsersPasswordResetSendPost**
> StatusOK UsersPasswordResetSendPost (InlineObject10 body)

Send password reset email

Send an email containing a link for resetting the user's password. The link will contain a one-use, timed recovery code tied to the user's account. Only works for non-SSO users. ##### Permissions No permissions required. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class UsersPasswordResetSendPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new UsersApi(Configuration.Default);
            var body = new InlineObject10(); // InlineObject10 | 

            try
            {
                // Send password reset email
                StatusOK result = apiInstance.UsersPasswordResetSendPost(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UsersPasswordResetSendPost: " + e.Message );
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
 **body** | [**InlineObject10**](InlineObject10.md)|  | 

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
| **200** | Email sent if account exists |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userspost"></a>
# **UsersPost**
> User UsersPost (InlineObject body, string t = null, string iid = null)

Create a user

Create a new user on the system. Password is required for email login. For other authentication types such as LDAP or SAML, auth_data and auth_service fields are required. ##### Permissions No permission required but user creation can be controlled by server configuration. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class UsersPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new UsersApi(Configuration.Default);
            var body = new InlineObject(); // InlineObject | 
            var t = t_example;  // string | Token id from an email invitation (optional) 
            var iid = iid_example;  // string | Token id from an invitation link (optional) 

            try
            {
                // Create a user
                User result = apiInstance.UsersPost(body, t, iid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UsersPost: " + e.Message );
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
 **body** | [**InlineObject**](InlineObject.md)|  | 
 **t** | **string**| Token id from an email invitation | [optional] 
 **iid** | **string**| Token id from an invitation link | [optional] 

### Return type

[**User**](User.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | User creation successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userssearchpost"></a>
# **UsersSearchPost**
> List&lt;User&gt; UsersSearchPost (InlineObject1 body)

Search users

Get a list of users based on search criteria provided in the request body. Searches are typically done against username, full name, nickname and email unless otherwise configured by the server. ##### Permissions Requires an active session and `read_channel` and/or `view_team` permissions for any channels or teams specified in the request body. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class UsersSearchPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new UsersApi(Configuration.Default);
            var body = new InlineObject1(); // InlineObject1 | 

            try
            {
                // Search users
                List<User> result = apiInstance.UsersSearchPost(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UsersSearchPost: " + e.Message );
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
 **body** | [**InlineObject1**](InlineObject1.md)|  | 

### Return type

[**List&lt;User&gt;**](User.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | User list retrieval successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userssessionsdeviceput"></a>
# **UsersSessionsDevicePut**
> StatusOK UsersSessionsDevicePut (InlineObject12 body)

Attach mobile device

Attach a mobile device id to the currently logged in session. This will enable push notifications for a user, if configured by the server. ##### Permissions Must be authenticated. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class UsersSessionsDevicePutExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new UsersApi(Configuration.Default);
            var body = new InlineObject12(); // InlineObject12 | 

            try
            {
                // Attach mobile device
                StatusOK result = apiInstance.UsersSessionsDevicePut(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UsersSessionsDevicePut: " + e.Message );
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
 **body** | [**InlineObject12**](InlineObject12.md)|  | 

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
| **200** | Device id attach successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersstatsget"></a>
# **UsersStatsGet**
> UsersStats UsersStatsGet ()

Get total count of users in the system

Get a total count of users in the system. ##### Permissions Must be authenticated. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class UsersStatsGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new UsersApi(Configuration.Default);

            try
            {
                // Get total count of users in the system
                UsersStats result = apiInstance.UsersStatsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UsersStatsGet: " + e.Message );
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

[**UsersStats**](UsersStats.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | User stats retrieval successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userstokensdisablepost"></a>
# **UsersTokensDisablePost**
> StatusOK UsersTokensDisablePost (InlineObject18 tokenId)

Disable personal access token

Disable a personal access token and delete any sessions using the token. The token can be re-enabled using `/users/tokens/enable`.  __Minimum server version__: 4.4  ##### Permissions Must have `revoke_user_access_token` permission. For non-self requests, must also have the `edit_other_users` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class UsersTokensDisablePostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new UsersApi(Configuration.Default);
            var tokenId = new InlineObject18(); // InlineObject18 | 

            try
            {
                // Disable personal access token
                StatusOK result = apiInstance.UsersTokensDisablePost(tokenId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UsersTokensDisablePost: " + e.Message );
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
 **tokenId** | [**InlineObject18**](InlineObject18.md)|  | 

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
| **200** | Personal access token disable successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userstokensenablepost"></a>
# **UsersTokensEnablePost**
> StatusOK UsersTokensEnablePost (InlineObject19 tokenId)

Enable personal access token

Re-enable a personal access token that has been disabled.  __Minimum server version__: 4.4  ##### Permissions Must have `create_user_access_token` permission. For non-self requests, must also have the `edit_other_users` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class UsersTokensEnablePostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new UsersApi(Configuration.Default);
            var tokenId = new InlineObject19(); // InlineObject19 | 

            try
            {
                // Enable personal access token
                StatusOK result = apiInstance.UsersTokensEnablePost(tokenId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UsersTokensEnablePost: " + e.Message );
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
 **tokenId** | [**InlineObject19**](InlineObject19.md)|  | 

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
| **200** | Personal access token enable successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userstokensget"></a>
# **UsersTokensGet**
> List&lt;UserAccessTokenSanitized&gt; UsersTokensGet (string page = null, string perPage = null)

Get user access tokens

Get a page of user access tokens for users on the system. Does not include the actual authentication tokens. Use query parameters for paging.  __Minimum server version__: 4.7  ##### Permissions Must have `manage_system` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class UsersTokensGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new UsersApi(Configuration.Default);
            var page = page_example;  // string | The page to select. (optional)  (default to "0")
            var perPage = perPage_example;  // string | The number of tokens per page. (optional)  (default to "60")

            try
            {
                // Get user access tokens
                List<UserAccessTokenSanitized> result = apiInstance.UsersTokensGet(page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UsersTokensGet: " + e.Message );
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
 **perPage** | **string**| The number of tokens per page. | [optional] [default to &quot;60&quot;]

### Return type

[**List&lt;UserAccessTokenSanitized&gt;**](UserAccessTokenSanitized.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | User access tokens retrieval successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userstokensrevokepost"></a>
# **UsersTokensRevokePost**
> StatusOK UsersTokensRevokePost (InlineObject17 tokenId)

Revoke a user access token

Revoke a user access token and delete any sessions using the token.  __Minimum server version__: 4.1  ##### Permissions Must have `revoke_user_access_token` permission. For non-self requests, must also have the `edit_other_users` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class UsersTokensRevokePostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new UsersApi(Configuration.Default);
            var tokenId = new InlineObject17(); // InlineObject17 | 

            try
            {
                // Revoke a user access token
                StatusOK result = apiInstance.UsersTokensRevokePost(tokenId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UsersTokensRevokePost: " + e.Message );
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
 **tokenId** | [**InlineObject17**](InlineObject17.md)|  | 

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
| **200** | User access token revoke successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userstokenssearchpost"></a>
# **UsersTokensSearchPost**
> List&lt;UserAccessTokenSanitized&gt; UsersTokensSearchPost (InlineObject20 body)

Search tokens

Get a list of tokens based on search criteria provided in the request body. Searches are done against the token id, user id and username.  __Minimum server version__: 4.7  ##### Permissions Must have `manage_system` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class UsersTokensSearchPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new UsersApi(Configuration.Default);
            var body = new InlineObject20(); // InlineObject20 | 

            try
            {
                // Search tokens
                List<UserAccessTokenSanitized> result = apiInstance.UsersTokensSearchPost(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UsersTokensSearchPost: " + e.Message );
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
 **body** | [**InlineObject20**](InlineObject20.md)|  | 

### Return type

[**List&lt;UserAccessTokenSanitized&gt;**](UserAccessTokenSanitized.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Personal access token search successful |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userstokenstokenidget"></a>
# **UsersTokensTokenIdGet**
> UserAccessTokenSanitized UsersTokensTokenIdGet (string tokenId)

Get a user access token

Get a user access token. Does not include the actual authentication token.  __Minimum server version__: 4.1  ##### Permissions Must have `read_user_access_token` permission. For non-self requests, must also have the `edit_other_users` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class UsersTokensTokenIdGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new UsersApi(Configuration.Default);
            var tokenId = tokenId_example;  // string | User access token GUID

            try
            {
                // Get a user access token
                UserAccessTokenSanitized result = apiInstance.UsersTokensTokenIdGet(tokenId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UsersTokensTokenIdGet: " + e.Message );
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
 **tokenId** | **string**| User access token GUID | 

### Return type

[**UserAccessTokenSanitized**](UserAccessTokenSanitized.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | User access token retrieval successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersuseridactiveput"></a>
# **UsersUserIdActivePut**
> StatusOK UsersUserIdActivePut (string userId, InlineObject5 body)

Update user active status

Update user active or inactive status.  __Since server version 4.6, users using a SSO provider to login can be activated or deactivated with this endpoint. However, if their activation status in Mattermost does not reflect their status in the SSO provider, the next synchronization or login by that user will reset the activation status to that of their account in the SSO provider. Server versions 4.5 and before do not allow activation or deactivation of SSO users from this endpoint.__ ##### Permissions User can deactivate themselves. User with `manage_system` permission can activate or deactivate a user. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class UsersUserIdActivePutExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new UsersApi(Configuration.Default);
            var userId = userId_example;  // string | User GUID
            var body = new InlineObject5(); // InlineObject5 | 

            try
            {
                // Update user active status
                StatusOK result = apiInstance.UsersUserIdActivePut(userId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UsersUserIdActivePut: " + e.Message );
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
 **body** | [**InlineObject5**](InlineObject5.md)|  | 

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
| **200** | User active status update successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersuseridauditsget"></a>
# **UsersUserIdAuditsGet**
> List&lt;Audit&gt; UsersUserIdAuditsGet (string userId)

Get user's audits

Get a list of audit by providing the user GUID. ##### Permissions Must be logged in as the user or have the `edit_other_users` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class UsersUserIdAuditsGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new UsersApi(Configuration.Default);
            var userId = userId_example;  // string | User GUID

            try
            {
                // Get user's audits
                List<Audit> result = apiInstance.UsersUserIdAuditsGet(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UsersUserIdAuditsGet: " + e.Message );
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

[**List&lt;Audit&gt;**](Audit.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | User audits retrieval successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersuseridauthput"></a>
# **UsersUserIdAuthPut**
> UserAuthData UsersUserIdAuthPut (string userId, UserAuthData body)

Update a user's authentication method

Updates a user's authentication method. This can be used to change them to/from LDAP authentication for example.  __Minimum server version__: 4.6 ##### Permissions Must have the `edit_other_users` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class UsersUserIdAuthPutExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new UsersApi(Configuration.Default);
            var userId = userId_example;  // string | User GUID
            var body = new UserAuthData(); // UserAuthData | 

            try
            {
                // Update a user's authentication method
                UserAuthData result = apiInstance.UsersUserIdAuthPut(userId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UsersUserIdAuthPut: " + e.Message );
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
 **body** | [**UserAuthData**](UserAuthData.md)|  | 

### Return type

[**UserAuthData**](UserAuthData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | User auth update successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **501** | Feature is disabled |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersuseriddelete"></a>
# **UsersUserIdDelete**
> StatusOK UsersUserIdDelete (string userId)

Deactivate a user account.

Deactivates the user and revokes all its sessions by archiving its user object. ##### Permissions Must be logged in as the user being deactivated or have the `edit_other_users` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class UsersUserIdDeleteExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new UsersApi(Configuration.Default);
            var userId = userId_example;  // string | User GUID

            try
            {
                // Deactivate a user account.
                StatusOK result = apiInstance.UsersUserIdDelete(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UsersUserIdDelete: " + e.Message );
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

[**StatusOK**](StatusOK.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | User deactivation successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersuseridget"></a>
# **UsersUserIdGet**
> User UsersUserIdGet (string userId)

Get a user

Get a user a object. Sensitive information will be sanitized out. ##### Permissions Requires an active session but no other permissions. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class UsersUserIdGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new UsersApi(Configuration.Default);
            var userId = userId_example;  // string | User GUID

            try
            {
                // Get a user
                User result = apiInstance.UsersUserIdGet(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UsersUserIdGet: " + e.Message );
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

[**User**](User.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | User retrieval successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersuseridimagedefaultget"></a>
# **UsersUserIdImageDefaultGet**
> void UsersUserIdImageDefaultGet (string userId)

Return user's default (generated) profile image

Returns the default (generated) user profile image based on user_id string parameter. ##### Permissions Must be logged in. __Minimum server version__: 5.5 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class UsersUserIdImageDefaultGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new UsersApi(Configuration.Default);
            var userId = userId_example;  // string | User GUID

            try
            {
                // Return user's default (generated) profile image
                apiInstance.UsersUserIdImageDefaultGet(userId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UsersUserIdImageDefaultGet: " + e.Message );
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

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Default profile image |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |
| **501** | Feature is disabled |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersuseridimagedelete"></a>
# **UsersUserIdImageDelete**
> StatusOK UsersUserIdImageDelete (string userId)

Delete user's profile image

Delete user's profile image and reset to default image based on user_id string parameter. ##### Permissions Must be logged in as the user being updated or have the `edit_other_users` permission. __Minimum server version__: 5.5 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class UsersUserIdImageDeleteExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new UsersApi(Configuration.Default);
            var userId = userId_example;  // string | User GUID

            try
            {
                // Delete user's profile image
                StatusOK result = apiInstance.UsersUserIdImageDelete(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UsersUserIdImageDelete: " + e.Message );
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

[**StatusOK**](StatusOK.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Profile image reset successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |
| **501** | Feature is disabled |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersuseridimageget"></a>
# **UsersUserIdImageGet**
> void UsersUserIdImageGet (string userId)

Get user's profile image

Get a user's profile image based on user_id string parameter. ##### Permissions Must be logged in. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class UsersUserIdImageGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new UsersApi(Configuration.Default);
            var userId = userId_example;  // string | User GUID

            try
            {
                // Get user's profile image
                apiInstance.UsersUserIdImageGet(userId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UsersUserIdImageGet: " + e.Message );
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

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | User&#39;s profile image |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |
| **501** | Feature is disabled |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersuseridimagepost"></a>
# **UsersUserIdImagePost**
> StatusOK UsersUserIdImagePost (string userId, System.IO.Stream image)

Set user's profile image

Set a user's profile image based on user_id string parameter. ##### Permissions Must be logged in as the user being updated or have the `edit_other_users` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class UsersUserIdImagePostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new UsersApi(Configuration.Default);
            var userId = userId_example;  // string | User GUID
            var image = BINARY_DATA_HERE;  // System.IO.Stream | The image to be uploaded

            try
            {
                // Set user's profile image
                StatusOK result = apiInstance.UsersUserIdImagePost(userId, image);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UsersUserIdImagePost: " + e.Message );
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
| **200** | Profile image set successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |
| **501** | Feature is disabled |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersuseridmfageneratepost"></a>
# **UsersUserIdMfaGeneratePost**
> InlineResponse2001 UsersUserIdMfaGeneratePost (string userId)

Generate MFA secret

Generates an multi-factor authentication secret for a user and returns it as a string and as base64 encoded QR code image. ##### Permissions Must be logged in as the user or have the `edit_other_users` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class UsersUserIdMfaGeneratePostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new UsersApi(Configuration.Default);
            var userId = userId_example;  // string | User GUID

            try
            {
                // Generate MFA secret
                InlineResponse2001 result = apiInstance.UsersUserIdMfaGeneratePost(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UsersUserIdMfaGeneratePost: " + e.Message );
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

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | MFA secret generation successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |
| **501** | Feature is disabled |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersuseridmfaput"></a>
# **UsersUserIdMfaPut**
> StatusOK UsersUserIdMfaPut (string userId, InlineObject7 body)

Update a user's MFA

Activates multi-factor authentication for the user if `activate` is true and a valid `code` is provided. If activate is false, then `code` is not required and multi-factor authentication is disabled for the user. ##### Permissions Must be logged in as the user being updated or have the `edit_other_users` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class UsersUserIdMfaPutExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new UsersApi(Configuration.Default);
            var userId = userId_example;  // string | User GUID
            var body = new InlineObject7(); // InlineObject7 | 

            try
            {
                // Update a user's MFA
                StatusOK result = apiInstance.UsersUserIdMfaPut(userId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UsersUserIdMfaPut: " + e.Message );
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
 **body** | [**InlineObject7**](InlineObject7.md)|  | 

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
| **200** | User MFA update successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **501** | Feature is disabled |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersuseridpasswordput"></a>
# **UsersUserIdPasswordPut**
> StatusOK UsersUserIdPasswordPut (string userId, InlineObject9 body)

Update a user's password

Update a user's password. New password must meet password policy set by server configuration. Current password is required if you're updating your own password. ##### Permissions Must be logged in as the user the password is being changed for or have `manage_system` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class UsersUserIdPasswordPutExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new UsersApi(Configuration.Default);
            var userId = userId_example;  // string | User GUID
            var body = new InlineObject9(); // InlineObject9 | 

            try
            {
                // Update a user's password
                StatusOK result = apiInstance.UsersUserIdPasswordPut(userId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UsersUserIdPasswordPut: " + e.Message );
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
 **body** | [**InlineObject9**](InlineObject9.md)|  | 

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
| **200** | User password update successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersuseridpatchput"></a>
# **UsersUserIdPatchPut**
> User UsersUserIdPatchPut (string userId, InlineObject3 body)

Patch a user

Partially update a user by providing only the fields you want to update. Omitted fields will not be updated. The fields that can be updated are defined in the request body, all other provided fields will be ignored. ##### Permissions Must be logged in as the user being updated or have the `edit_other_users` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class UsersUserIdPatchPutExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new UsersApi(Configuration.Default);
            var userId = userId_example;  // string | User GUID
            var body = new InlineObject3(); // InlineObject3 | 

            try
            {
                // Patch a user
                User result = apiInstance.UsersUserIdPatchPut(userId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UsersUserIdPatchPut: " + e.Message );
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
 **body** | [**InlineObject3**](InlineObject3.md)|  | 

### Return type

[**User**](User.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | User patch successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersuseridput"></a>
# **UsersUserIdPut**
> User UsersUserIdPut (string userId, InlineObject2 body)

Update a user

Update a user by providing the user object. The fields that can be updated are defined in the request body, all other provided fields will be ignored. Any fields not included in the request body will be set to null or reverted to default values. ##### Permissions Must be logged in as the user being updated or have the `edit_other_users` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class UsersUserIdPutExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new UsersApi(Configuration.Default);
            var userId = userId_example;  // string | User GUID
            var body = new InlineObject2(); // InlineObject2 | 

            try
            {
                // Update a user
                User result = apiInstance.UsersUserIdPut(userId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UsersUserIdPut: " + e.Message );
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
 **body** | [**InlineObject2**](InlineObject2.md)|  | 

### Return type

[**User**](User.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | User update successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersuseridrolesput"></a>
# **UsersUserIdRolesPut**
> StatusOK UsersUserIdRolesPut (string userId, InlineObject4 roles)

Update a user's roles

Update a user's system-level roles. Valid user roles are \"system_user\", \"system_admin\" or both of them. Overwrites any previously assigned system-level roles. ##### Permissions Must have the `manage_roles` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class UsersUserIdRolesPutExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new UsersApi(Configuration.Default);
            var userId = userId_example;  // string | User GUID
            var roles = new InlineObject4(); // InlineObject4 | 

            try
            {
                // Update a user's roles
                StatusOK result = apiInstance.UsersUserIdRolesPut(userId, roles);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UsersUserIdRolesPut: " + e.Message );
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
 **roles** | [**InlineObject4**](InlineObject4.md)|  | 

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
| **200** | User roles update successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersuseridsessionsget"></a>
# **UsersUserIdSessionsGet**
> List&lt;Session&gt; UsersUserIdSessionsGet (string userId)

Get user's sessions

Get a list of sessions by providing the user GUID. Sensitive information will be sanitized out. ##### Permissions Must be logged in as the user being updated or have the `edit_other_users` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class UsersUserIdSessionsGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new UsersApi(Configuration.Default);
            var userId = userId_example;  // string | User GUID

            try
            {
                // Get user's sessions
                List<Session> result = apiInstance.UsersUserIdSessionsGet(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UsersUserIdSessionsGet: " + e.Message );
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

[**List&lt;Session&gt;**](Session.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | User session retrieval successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersuseridsessionsrevokeallpost"></a>
# **UsersUserIdSessionsRevokeAllPost**
> StatusOK UsersUserIdSessionsRevokeAllPost (string userId)

Revoke all active sessions for a user

Revokes all user sessions from the provided user id and session id strings. ##### Permissions Must be logged in as the user being updated or have the `edit_other_users` permission. __Minimum server version__: 4.4 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class UsersUserIdSessionsRevokeAllPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new UsersApi(Configuration.Default);
            var userId = userId_example;  // string | User GUID

            try
            {
                // Revoke all active sessions for a user
                StatusOK result = apiInstance.UsersUserIdSessionsRevokeAllPost(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UsersUserIdSessionsRevokeAllPost: " + e.Message );
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

[**StatusOK**](StatusOK.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | User sessions revoked successfully |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersuseridsessionsrevokepost"></a>
# **UsersUserIdSessionsRevokePost**
> StatusOK UsersUserIdSessionsRevokePost (string userId, InlineObject11 body)

Revoke a user session

Revokes a user session from the provided user id and session id strings. ##### Permissions Must be logged in as the user being updated or have the `edit_other_users` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class UsersUserIdSessionsRevokePostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new UsersApi(Configuration.Default);
            var userId = userId_example;  // string | User GUID
            var body = new InlineObject11(); // InlineObject11 | 

            try
            {
                // Revoke a user session
                StatusOK result = apiInstance.UsersUserIdSessionsRevokePost(userId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UsersUserIdSessionsRevokePost: " + e.Message );
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
 **body** | [**InlineObject11**](InlineObject11.md)|  | 

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
| **200** | User session revoked successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersuseridtermsofserviceget"></a>
# **UsersUserIdTermsOfServiceGet**
> UserTermsOfService UsersUserIdTermsOfServiceGet (string userId)

Fetches user's latest terms of service action if the latest action was for acceptance.

Will be deprecated in v6.0 Fetches user's latest terms of service action if the latest action was for acceptance.  __Minimum server version__: 5.6 ##### Permissions Must be logged in as the user being acted on. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class UsersUserIdTermsOfServiceGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new UsersApi(Configuration.Default);
            var userId = userId_example;  // string | User GUID

            try
            {
                // Fetches user's latest terms of service action if the latest action was for acceptance.
                UserTermsOfService result = apiInstance.UsersUserIdTermsOfServiceGet(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UsersUserIdTermsOfServiceGet: " + e.Message );
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

[**UserTermsOfService**](UserTermsOfService.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | User&#39;s accepted terms of service action |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **404** | User hasn&#39;t performed an action or the latest action was a rejection. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersuseridtermsofservicepost"></a>
# **UsersUserIdTermsOfServicePost**
> StatusOK UsersUserIdTermsOfServicePost (string userId, InlineObject21 body)

Records user action when they accept or decline custom terms of service

Records user action when they accept or decline custom terms of service. Records the action in audit table. Updates user's last accepted terms of service ID if they accepted it.  __Minimum server version__: 5.4 ##### Permissions Must be logged in as the user being acted on. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class UsersUserIdTermsOfServicePostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new UsersApi(Configuration.Default);
            var userId = userId_example;  // string | User GUID
            var body = new InlineObject21(); // InlineObject21 | 

            try
            {
                // Records user action when they accept or decline custom terms of service
                StatusOK result = apiInstance.UsersUserIdTermsOfServicePost(userId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UsersUserIdTermsOfServicePost: " + e.Message );
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
 **body** | [**InlineObject21**](InlineObject21.md)|  | 

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
| **200** | Terms of service action recorded successfully |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersuseridtokensget"></a>
# **UsersUserIdTokensGet**
> List&lt;UserAccessTokenSanitized&gt; UsersUserIdTokensGet (string userId, string page = null, string perPage = null)

Get user access tokens

Get a list of user access tokens for a user. Does not include the actual authentication tokens. Use query parameters for paging.  __Minimum server version__: 4.1  ##### Permissions Must have `read_user_access_token` permission. For non-self requests, must also have the `edit_other_users` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class UsersUserIdTokensGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new UsersApi(Configuration.Default);
            var userId = userId_example;  // string | User GUID
            var page = page_example;  // string | The page to select. (optional)  (default to "0")
            var perPage = perPage_example;  // string | The number of tokens per page. (optional)  (default to "60")

            try
            {
                // Get user access tokens
                List<UserAccessTokenSanitized> result = apiInstance.UsersUserIdTokensGet(userId, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UsersUserIdTokensGet: " + e.Message );
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
 **page** | **string**| The page to select. | [optional] [default to &quot;0&quot;]
 **perPage** | **string**| The number of tokens per page. | [optional] [default to &quot;60&quot;]

### Return type

[**List&lt;UserAccessTokenSanitized&gt;**](UserAccessTokenSanitized.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | User access tokens retrieval successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersuseridtokenspost"></a>
# **UsersUserIdTokensPost**
> UserAccessToken UsersUserIdTokensPost (string userId, InlineObject16 token)

Create a user access token

Generate a user access token that can be used to authenticate with the Mattermost REST API.  __Minimum server version__: 4.1  ##### Permissions Must have `create_user_access_token` permission. For non-self requests, must also have the `edit_other_users` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class UsersUserIdTokensPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new UsersApi(Configuration.Default);
            var userId = userId_example;  // string | User GUID
            var token = new InlineObject16(); // InlineObject16 | 

            try
            {
                // Create a user access token
                UserAccessToken result = apiInstance.UsersUserIdTokensPost(userId, token);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UsersUserIdTokensPost: " + e.Message );
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
 **token** | [**InlineObject16**](InlineObject16.md)|  | 

### Return type

[**UserAccessToken**](UserAccessToken.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | User access token creation successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersusernameusernameget"></a>
# **UsersUsernameUsernameGet**
> User UsersUsernameUsernameGet (string username)

Get a user by username

Get a user object by providing a username. Sensitive information will be sanitized out. ##### Permissions Requires an active session but no other permissions. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class UsersUsernameUsernameGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new UsersApi(Configuration.Default);
            var username = username_example;  // string | Username

            try
            {
                // Get a user by username
                User result = apiInstance.UsersUsernameUsernameGet(username);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UsersUsernameUsernameGet: " + e.Message );
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
 **username** | **string**| Username | 

### Return type

[**User**](User.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | User retrieval successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersusernamespost"></a>
# **UsersUsernamesPost**
> List&lt;User&gt; UsersUsernamesPost (List<string> body)

Get users by usernames

Get a list of users based on a provided list of usernames. ##### Permissions Requires an active session but no other permissions. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class UsersUsernamesPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new UsersApi(Configuration.Default);
            var body = new List<string>(); // List<string> | List of usernames

            try
            {
                // Get users by usernames
                List<User> result = apiInstance.UsersUsernamesPost(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UsersUsernamesPost: " + e.Message );
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
 **body** | [**List&lt;string&gt;**](string.md)| List of usernames | 

### Return type

[**List&lt;User&gt;**](User.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | User list retrieval successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

