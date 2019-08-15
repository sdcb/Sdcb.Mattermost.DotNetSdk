# Sdcb.Mattermost.DotNetSdk.Api.BotsApi

All URIs are relative to *http://your-mattermost-url.com/api/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BotsBotUserIdAssignUserIdPost**](BotsApi.md#botsbotuseridassignuseridpost) | **POST** /bots/{bot_user_id}/assign/{user_id} | Assign a bot to a user
[**BotsBotUserIdDisablePost**](BotsApi.md#botsbotuseriddisablepost) | **POST** /bots/{bot_user_id}/disable | Disable a bot
[**BotsBotUserIdEnablePost**](BotsApi.md#botsbotuseridenablepost) | **POST** /bots/{bot_user_id}/enable | Enable a bot
[**BotsBotUserIdGet**](BotsApi.md#botsbotuseridget) | **GET** /bots/{bot_user_id} | Get a bot
[**BotsBotUserIdIconDelete**](BotsApi.md#botsbotuseridicondelete) | **DELETE** /bots/{bot_user_id}/icon | Delete bot&#39;s LHS icon image
[**BotsBotUserIdIconGet**](BotsApi.md#botsbotuseridiconget) | **GET** /bots/{bot_user_id}/icon | Get bot&#39;s LHS icon
[**BotsBotUserIdIconPost**](BotsApi.md#botsbotuseridiconpost) | **POST** /bots/{bot_user_id}/icon | Set bot&#39;s LHS icon image
[**BotsBotUserIdPut**](BotsApi.md#botsbotuseridput) | **PUT** /bots/{bot_user_id} | Patch a bot
[**BotsGet**](BotsApi.md#botsget) | **GET** /bots | Get bots
[**BotsPost**](BotsApi.md#botspost) | **POST** /bots | Create a bot


<a name="botsbotuseridassignuseridpost"></a>
# **BotsBotUserIdAssignUserIdPost**
> Bot BotsBotUserIdAssignUserIdPost (string botUserId, string userId)

Assign a bot to a user

Assign a bot to a specified user. ##### Permissions Must have `manage_bots` permission.  __Minimum server version__: 5.10 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class BotsBotUserIdAssignUserIdPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new BotsApi(Configuration.Default);
            var botUserId = botUserId_example;  // string | Bot user ID
            var userId = userId_example;  // string | The user ID to assign the bot to.

            try
            {
                // Assign a bot to a user
                Bot result = apiInstance.BotsBotUserIdAssignUserIdPost(botUserId, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BotsApi.BotsBotUserIdAssignUserIdPost: " + e.Message );
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
 **botUserId** | **string**| Bot user ID | 
 **userId** | **string**| The user ID to assign the bot to. | 

### Return type

[**Bot**](Bot.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Bot successfully assigned. |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="botsbotuseriddisablepost"></a>
# **BotsBotUserIdDisablePost**
> Bot BotsBotUserIdDisablePost (string botUserId)

Disable a bot

Disable a bot. ##### Permissions Must have `manage_bots` permission.  __Minimum server version__: 5.10 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class BotsBotUserIdDisablePostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new BotsApi(Configuration.Default);
            var botUserId = botUserId_example;  // string | Bot user ID

            try
            {
                // Disable a bot
                Bot result = apiInstance.BotsBotUserIdDisablePost(botUserId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BotsApi.BotsBotUserIdDisablePost: " + e.Message );
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
 **botUserId** | **string**| Bot user ID | 

### Return type

[**Bot**](Bot.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Bot successfully disabled. |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="botsbotuseridenablepost"></a>
# **BotsBotUserIdEnablePost**
> Bot BotsBotUserIdEnablePost (string botUserId)

Enable a bot

Enable a bot. ##### Permissions Must have `manage_bots` permission.  __Minimum server version__: 5.10 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class BotsBotUserIdEnablePostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new BotsApi(Configuration.Default);
            var botUserId = botUserId_example;  // string | Bot user ID

            try
            {
                // Enable a bot
                Bot result = apiInstance.BotsBotUserIdEnablePost(botUserId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BotsApi.BotsBotUserIdEnablePost: " + e.Message );
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
 **botUserId** | **string**| Bot user ID | 

### Return type

[**Bot**](Bot.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Bot successfully enabled. |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="botsbotuseridget"></a>
# **BotsBotUserIdGet**
> Bot BotsBotUserIdGet (string botUserId, bool? includeDeleted = null)

Get a bot

Get a bot specified by its bot id. ##### Permissions Must have `read_bots` permission for bots you are managing, and `read_others_bots` permission for bots others are managing. __Minimum server version__: 5.10 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class BotsBotUserIdGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new BotsApi(Configuration.Default);
            var botUserId = botUserId_example;  // string | Bot user ID
            var includeDeleted = true;  // bool? | If deleted bots should be returned. (optional) 

            try
            {
                // Get a bot
                Bot result = apiInstance.BotsBotUserIdGet(botUserId, includeDeleted);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BotsApi.BotsBotUserIdGet: " + e.Message );
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
 **botUserId** | **string**| Bot user ID | 
 **includeDeleted** | **bool?**| If deleted bots should be returned. | [optional] 

### Return type

[**Bot**](Bot.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Bot successfully retrieved. |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="botsbotuseridicondelete"></a>
# **BotsBotUserIdIconDelete**
> StatusOK BotsBotUserIdIconDelete (string botUserId)

Delete bot's LHS icon image

Delete bot's LHS icon image based on bot_user_id string parameter. ##### Permissions Must have `manage_bots` permission. __Minimum server version__: 5.14 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class BotsBotUserIdIconDeleteExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new BotsApi(Configuration.Default);
            var botUserId = botUserId_example;  // string | Bot user ID

            try
            {
                // Delete bot's LHS icon image
                StatusOK result = apiInstance.BotsBotUserIdIconDelete(botUserId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BotsApi.BotsBotUserIdIconDelete: " + e.Message );
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
 **botUserId** | **string**| Bot user ID | 

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
| **200** | Icon image deletion successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |
| **500** | Something went wrong with the server |  -  |
| **501** | Feature is disabled |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="botsbotuseridiconget"></a>
# **BotsBotUserIdIconGet**
> void BotsBotUserIdIconGet (string botUserId)

Get bot's LHS icon

Get a bot's LHS icon image based on bot_user_id string parameter. ##### Permissions Must be logged in. __Minimum server version__: 5.14 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class BotsBotUserIdIconGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new BotsApi(Configuration.Default);
            var botUserId = botUserId_example;  // string | Bot user ID

            try
            {
                // Get bot's LHS icon
                apiInstance.BotsBotUserIdIconGet(botUserId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BotsApi.BotsBotUserIdIconGet: " + e.Message );
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
 **botUserId** | **string**| Bot user ID | 

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
| **200** | Bot&#39;s LHS icon image |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |
| **500** | Something went wrong with the server |  -  |
| **501** | Feature is disabled |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="botsbotuseridiconpost"></a>
# **BotsBotUserIdIconPost**
> StatusOK BotsBotUserIdIconPost (string botUserId, System.IO.Stream image)

Set bot's LHS icon image

Set a bot's LHS icon image based on bot_user_id string parameter. Icon image must be SVG format, all other formats are rejected. ##### Permissions Must have `manage_bots` permission. __Minimum server version__: 5.14 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class BotsBotUserIdIconPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new BotsApi(Configuration.Default);
            var botUserId = botUserId_example;  // string | Bot user ID
            var image = BINARY_DATA_HERE;  // System.IO.Stream | SVG icon image to be uploaded

            try
            {
                // Set bot's LHS icon image
                StatusOK result = apiInstance.BotsBotUserIdIconPost(botUserId, image);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BotsApi.BotsBotUserIdIconPost: " + e.Message );
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
 **botUserId** | **string**| Bot user ID | 
 **image** | **System.IO.Stream****System.IO.Stream**| SVG icon image to be uploaded | 

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
| **200** | SVG icon image set successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **413** | Content too large |  -  |
| **500** | Something went wrong with the server |  -  |
| **501** | Feature is disabled |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="botsbotuseridput"></a>
# **BotsBotUserIdPut**
> Bot BotsBotUserIdPut (string botUserId, InlineObject64 body)

Patch a bot

Partially update a bot by providing only the fields you want to update. Omitted fields will not be updated. The fields that can be updated are defined in the request body, all other provided fields will be ignored. ##### Permissions Must have `manage_bots` permission.  __Minimum server version__: 5.10 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class BotsBotUserIdPutExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new BotsApi(Configuration.Default);
            var botUserId = botUserId_example;  // string | Bot user ID
            var body = new InlineObject64(); // InlineObject64 | 

            try
            {
                // Patch a bot
                Bot result = apiInstance.BotsBotUserIdPut(botUserId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BotsApi.BotsBotUserIdPut: " + e.Message );
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
 **botUserId** | **string**| Bot user ID | 
 **body** | [**InlineObject64**](InlineObject64.md)|  | 

### Return type

[**Bot**](Bot.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Bot patch successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="botsget"></a>
# **BotsGet**
> List&lt;Bot&gt; BotsGet (string page = null, string perPage = null, bool? includeDeleted = null, bool? onlyOrphaned = null)

Get bots

Get a page of a list of bots. ##### Permissions Must have `read_bots` permission for bots you are managing, and `read_others_bots` permission for bots others are managing. __Minimum server version__: 5.10 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class BotsGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new BotsApi(Configuration.Default);
            var page = page_example;  // string | The page to select. (optional)  (default to "0")
            var perPage = perPage_example;  // string | The number of users per page. There is a maximum limit of 200 users per page. (optional)  (default to "60")
            var includeDeleted = true;  // bool? | If deleted bots should be returned. (optional) 
            var onlyOrphaned = true;  // bool? | When true, only orphaned bots will be returned. A bot is consitered orphaned if it's owner has been deactivated. (optional) 

            try
            {
                // Get bots
                List<Bot> result = apiInstance.BotsGet(page, perPage, includeDeleted, onlyOrphaned);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BotsApi.BotsGet: " + e.Message );
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
 **includeDeleted** | **bool?**| If deleted bots should be returned. | [optional] 
 **onlyOrphaned** | **bool?**| When true, only orphaned bots will be returned. A bot is consitered orphaned if it&#39;s owner has been deactivated. | [optional] 

### Return type

[**List&lt;Bot&gt;**](Bot.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Bot page retrieval successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="botspost"></a>
# **BotsPost**
> Bot BotsPost (InlineObject63 body)

Create a bot

Create a new bot account on the system. Username is required. ##### Permissions Must have `create_bot` permission. __Minimum server version__: 5.10 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class BotsPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new BotsApi(Configuration.Default);
            var body = new InlineObject63(); // InlineObject63 | 

            try
            {
                // Create a bot
                Bot result = apiInstance.BotsPost(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BotsApi.BotsPost: " + e.Message );
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
 **body** | [**InlineObject63**](InlineObject63.md)|  | 

### Return type

[**Bot**](Bot.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Bot creation successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

