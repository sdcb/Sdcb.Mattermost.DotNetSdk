# Sdcb.Mattermost.DotNetSdk.Api.OAuthApi

All URIs are relative to *http://your-mattermost-url.com/api/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**OauthAppsAppIdDelete**](OAuthApi.md#oauthappsappiddelete) | **DELETE** /oauth/apps/{app_id} | Delete an OAuth app
[**OauthAppsAppIdGet**](OAuthApi.md#oauthappsappidget) | **GET** /oauth/apps/{app_id} | Get an OAuth app
[**OauthAppsAppIdInfoGet**](OAuthApi.md#oauthappsappidinfoget) | **GET** /oauth/apps/{app_id}/info | Get info on an OAuth app
[**OauthAppsAppIdPut**](OAuthApi.md#oauthappsappidput) | **PUT** /oauth/apps/{app_id} | Update an OAuth app
[**OauthAppsAppIdRegenSecretPost**](OAuthApi.md#oauthappsappidregensecretpost) | **POST** /oauth/apps/{app_id}/regen_secret | Regenerate OAuth app secret
[**OauthAppsGet**](OAuthApi.md#oauthappsget) | **GET** /oauth/apps | Get OAuth apps
[**OauthAppsPost**](OAuthApi.md#oauthappspost) | **POST** /oauth/apps | Register OAuth app
[**UsersUserIdOauthAppsAuthorizedGet**](OAuthApi.md#usersuseridoauthappsauthorizedget) | **GET** /users/{user_id}/oauth/apps/authorized | Get authorized OAuth apps


<a name="oauthappsappiddelete"></a>
# **OauthAppsAppIdDelete**
> StatusOK OauthAppsAppIdDelete (string appId)

Delete an OAuth app

Delete and unregister an OAuth 2.0 client application  ##### Permissions If app creator, must have `mange_oauth` permission otherwise `manage_system_wide_oauth` permission is required. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class OauthAppsAppIdDeleteExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new OAuthApi(Configuration.Default);
            var appId = appId_example;  // string | Application client id

            try
            {
                // Delete an OAuth app
                StatusOK result = apiInstance.OauthAppsAppIdDelete(appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OAuthApi.OauthAppsAppIdDelete: " + e.Message );
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
 **appId** | **string**| Application client id | 

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
| **200** | App deletion successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |
| **501** | Feature is disabled |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="oauthappsappidget"></a>
# **OauthAppsAppIdGet**
> OAuthApp OauthAppsAppIdGet (string appId)

Get an OAuth app

Get an OAuth 2.0 client application registered with Mattermost. ##### Permissions If app creator, must have `mange_oauth` permission otherwise `manage_system_wide_oauth` permission is required. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class OauthAppsAppIdGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new OAuthApi(Configuration.Default);
            var appId = appId_example;  // string | Application client id

            try
            {
                // Get an OAuth app
                OAuthApp result = apiInstance.OauthAppsAppIdGet(appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OAuthApi.OauthAppsAppIdGet: " + e.Message );
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
 **appId** | **string**| Application client id | 

### Return type

[**OAuthApp**](OAuthApp.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | App retrieval successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |
| **501** | Feature is disabled |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="oauthappsappidinfoget"></a>
# **OauthAppsAppIdInfoGet**
> OAuthApp OauthAppsAppIdInfoGet (string appId)

Get info on an OAuth app

Get public information about an OAuth 2.0 client application registered with Mattermost. The application's client secret will be blanked out. ##### Permissions Must be authenticated. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class OauthAppsAppIdInfoGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new OAuthApi(Configuration.Default);
            var appId = appId_example;  // string | Application client id

            try
            {
                // Get info on an OAuth app
                OAuthApp result = apiInstance.OauthAppsAppIdInfoGet(appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OAuthApi.OauthAppsAppIdInfoGet: " + e.Message );
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
 **appId** | **string**| Application client id | 

### Return type

[**OAuthApp**](OAuthApp.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | App retrieval successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **404** | Resource not found |  -  |
| **501** | Feature is disabled |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="oauthappsappidput"></a>
# **OauthAppsAppIdPut**
> OAuthApp OauthAppsAppIdPut (string appId, InlineObject56 body)

Update an OAuth app

Update an OAuth 2.0 client application based on OAuth struct. ##### Permissions If app creator, must have `mange_oauth` permission otherwise `manage_system_wide_oauth` permission is required. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class OauthAppsAppIdPutExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new OAuthApi(Configuration.Default);
            var appId = appId_example;  // string | Application client id
            var body = new InlineObject56(); // InlineObject56 | 

            try
            {
                // Update an OAuth app
                OAuthApp result = apiInstance.OauthAppsAppIdPut(appId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OAuthApi.OauthAppsAppIdPut: " + e.Message );
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
 **appId** | **string**| Application client id | 
 **body** | [**InlineObject56**](InlineObject56.md)|  | 

### Return type

[**OAuthApp**](OAuthApp.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | App update successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |
| **501** | Feature is disabled |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="oauthappsappidregensecretpost"></a>
# **OauthAppsAppIdRegenSecretPost**
> OAuthApp OauthAppsAppIdRegenSecretPost (string appId)

Regenerate OAuth app secret

Regenerate the client secret for an OAuth 2.0 client application registered with Mattermost. ##### Permissions If app creator, must have `mange_oauth` permission otherwise `manage_system_wide_oauth` permission is required. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class OauthAppsAppIdRegenSecretPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new OAuthApi(Configuration.Default);
            var appId = appId_example;  // string | Application client id

            try
            {
                // Regenerate OAuth app secret
                OAuthApp result = apiInstance.OauthAppsAppIdRegenSecretPost(appId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OAuthApi.OauthAppsAppIdRegenSecretPost: " + e.Message );
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
 **appId** | **string**| Application client id | 

### Return type

[**OAuthApp**](OAuthApp.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Secret regeneration successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |
| **501** | Feature is disabled |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="oauthappsget"></a>
# **OauthAppsGet**
> List&lt;OAuthApp&gt; OauthAppsGet (string page = null, string perPage = null)

Get OAuth apps

Get a page of OAuth 2.0 client applications registered with Mattermost. ##### Permissions With `manage_oauth` permission, the apps registered by the logged in user are returned. With `manage_system_wide_oauth` permission, all apps regardless of creator are returned. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class OauthAppsGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new OAuthApi(Configuration.Default);
            var page = page_example;  // string | The page to select. (optional)  (default to "0")
            var perPage = perPage_example;  // string | The number of apps per page. (optional)  (default to "60")

            try
            {
                // Get OAuth apps
                List<OAuthApp> result = apiInstance.OauthAppsGet(page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OAuthApi.OauthAppsGet: " + e.Message );
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
 **perPage** | **string**| The number of apps per page. | [optional] [default to &quot;60&quot;]

### Return type

[**List&lt;OAuthApp&gt;**](OAuthApp.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OAuthApp list retrieval successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **501** | Feature is disabled |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="oauthappspost"></a>
# **OauthAppsPost**
> OAuthApp OauthAppsPost (InlineObject55 body)

Register OAuth app

Register an OAuth 2.0 client application with Mattermost as the service provider. ##### Permissions Must have `manage_oauth` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class OauthAppsPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new OAuthApi(Configuration.Default);
            var body = new InlineObject55(); // InlineObject55 | 

            try
            {
                // Register OAuth app
                OAuthApp result = apiInstance.OauthAppsPost(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OAuthApi.OauthAppsPost: " + e.Message );
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
 **body** | [**InlineObject55**](InlineObject55.md)|  | 

### Return type

[**OAuthApp**](OAuthApp.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | App registration successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **501** | Feature is disabled |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersuseridoauthappsauthorizedget"></a>
# **UsersUserIdOauthAppsAuthorizedGet**
> List&lt;OAuthApp&gt; UsersUserIdOauthAppsAuthorizedGet (string userId, string page = null, string perPage = null)

Get authorized OAuth apps

Get a page of OAuth 2.0 client applications authorized to access a user's account. ##### Permissions Must be authenticated as the user or have `edit_other_users` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class UsersUserIdOauthAppsAuthorizedGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new OAuthApi(Configuration.Default);
            var userId = userId_example;  // string | User GUID
            var page = page_example;  // string | The page to select. (optional)  (default to "0")
            var perPage = perPage_example;  // string | The number of apps per page. (optional)  (default to "60")

            try
            {
                // Get authorized OAuth apps
                List<OAuthApp> result = apiInstance.UsersUserIdOauthAppsAuthorizedGet(userId, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OAuthApi.UsersUserIdOauthAppsAuthorizedGet: " + e.Message );
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
 **perPage** | **string**| The number of apps per page. | [optional] [default to &quot;60&quot;]

### Return type

[**List&lt;OAuthApp&gt;**](OAuthApp.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OAuthApp list retrieval successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **501** | Feature is disabled |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

