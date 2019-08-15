# Sdcb.Mattermost.DotNetSdk.Api.WebhooksApi

All URIs are relative to *http://your-mattermost-url.com/api/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**HooksIncomingGet**](WebhooksApi.md#hooksincomingget) | **GET** /hooks/incoming | List incoming webhooks
[**HooksIncomingHookIdGet**](WebhooksApi.md#hooksincominghookidget) | **GET** /hooks/incoming/{hook_id} | Get an incoming webhook
[**HooksIncomingHookIdPut**](WebhooksApi.md#hooksincominghookidput) | **PUT** /hooks/incoming/{hook_id} | Update an incoming webhook
[**HooksIncomingPost**](WebhooksApi.md#hooksincomingpost) | **POST** /hooks/incoming | Create an incoming webhook
[**HooksOutgoingGet**](WebhooksApi.md#hooksoutgoingget) | **GET** /hooks/outgoing | List outgoing webhooks
[**HooksOutgoingHookIdDelete**](WebhooksApi.md#hooksoutgoinghookiddelete) | **DELETE** /hooks/outgoing/{hook_id} | Delete an outgoing webhook
[**HooksOutgoingHookIdGet**](WebhooksApi.md#hooksoutgoinghookidget) | **GET** /hooks/outgoing/{hook_id} | Get an outgoing webhook
[**HooksOutgoingHookIdPut**](WebhooksApi.md#hooksoutgoinghookidput) | **PUT** /hooks/outgoing/{hook_id} | Update an outgoing webhook
[**HooksOutgoingHookIdRegenTokenPost**](WebhooksApi.md#hooksoutgoinghookidregentokenpost) | **POST** /hooks/outgoing/{hook_id}/regen_token | Regenerate the token for the outgoing webhook.
[**HooksOutgoingPost**](WebhooksApi.md#hooksoutgoingpost) | **POST** /hooks/outgoing | Create an outgoing webhook


<a name="hooksincomingget"></a>
# **HooksIncomingGet**
> List&lt;IncomingWebhook&gt; HooksIncomingGet (string page = null, string perPage = null, string teamId = null)

List incoming webhooks

Get a page of a list of incoming webhooks. Optionally filter for a specific team using query parameters. ##### Permissions `manage_webhooks` for the system or `manage_webhooks` for the specific team. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class HooksIncomingGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new WebhooksApi(Configuration.Default);
            var page = page_example;  // string | The page to select. (optional)  (default to "0")
            var perPage = perPage_example;  // string | The number of hooks per page. (optional)  (default to "60")
            var teamId = teamId_example;  // string | The ID of the team to get hooks for. (optional) 

            try
            {
                // List incoming webhooks
                List<IncomingWebhook> result = apiInstance.HooksIncomingGet(page, perPage, teamId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.HooksIncomingGet: " + e.Message );
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
 **perPage** | **string**| The number of hooks per page. | [optional] [default to &quot;60&quot;]
 **teamId** | **string**| The ID of the team to get hooks for. | [optional] 

### Return type

[**List&lt;IncomingWebhook&gt;**](IncomingWebhook.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Incoming webhooks retrieval successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="hooksincominghookidget"></a>
# **HooksIncomingHookIdGet**
> IncomingWebhook HooksIncomingHookIdGet (string hookId)

Get an incoming webhook

Get an incoming webhook given the hook id. ##### Permissions `manage_webhooks` for system or `manage_webhooks` for the specific team or `manage_webhooks` for the channel. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class HooksIncomingHookIdGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new WebhooksApi(Configuration.Default);
            var hookId = hookId_example;  // string | Incoming Webhook GUID

            try
            {
                // Get an incoming webhook
                IncomingWebhook result = apiInstance.HooksIncomingHookIdGet(hookId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.HooksIncomingHookIdGet: " + e.Message );
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
 **hookId** | **string**| Incoming Webhook GUID | 

### Return type

[**IncomingWebhook**](IncomingWebhook.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Webhook retrieval successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="hooksincominghookidput"></a>
# **HooksIncomingHookIdPut**
> IncomingWebhook HooksIncomingHookIdPut (string hookId, InlineObject50 body)

Update an incoming webhook

Update an incoming webhook given the hook id. ##### Permissions `manage_webhooks` for system or `manage_webhooks` for the specific team or `manage_webhooks` for the channel. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class HooksIncomingHookIdPutExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new WebhooksApi(Configuration.Default);
            var hookId = hookId_example;  // string | Incoming Webhook GUID
            var body = new InlineObject50(); // InlineObject50 | 

            try
            {
                // Update an incoming webhook
                IncomingWebhook result = apiInstance.HooksIncomingHookIdPut(hookId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.HooksIncomingHookIdPut: " + e.Message );
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
 **hookId** | **string**| Incoming Webhook GUID | 
 **body** | [**InlineObject50**](InlineObject50.md)|  | 

### Return type

[**IncomingWebhook**](IncomingWebhook.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Webhook update successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="hooksincomingpost"></a>
# **HooksIncomingPost**
> IncomingWebhook HooksIncomingPost (InlineObject49 body)

Create an incoming webhook

Create an incoming webhook for a channel. ##### Permissions `manage_webhooks` for the channel the webhook is in. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class HooksIncomingPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new WebhooksApi(Configuration.Default);
            var body = new InlineObject49(); // InlineObject49 | 

            try
            {
                // Create an incoming webhook
                IncomingWebhook result = apiInstance.HooksIncomingPost(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.HooksIncomingPost: " + e.Message );
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
 **body** | [**InlineObject49**](InlineObject49.md)|  | 

### Return type

[**IncomingWebhook**](IncomingWebhook.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Incoming webhook creation successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="hooksoutgoingget"></a>
# **HooksOutgoingGet**
> List&lt;OutgoingWebhook&gt; HooksOutgoingGet (string page = null, string perPage = null, string teamId = null, string channelId = null)

List outgoing webhooks

Get a page of a list of outgoing webhooks. Optionally filter for a specific team or channel using query parameters. ##### Permissions `manage_webhooks` for the system or `manage_webhooks` for the specific team/channel. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class HooksOutgoingGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new WebhooksApi(Configuration.Default);
            var page = page_example;  // string | The page to select. (optional)  (default to "0")
            var perPage = perPage_example;  // string | The number of hooks per page. (optional)  (default to "60")
            var teamId = teamId_example;  // string | The ID of the team to get hooks for. (optional) 
            var channelId = channelId_example;  // string | The ID of the channel to get hooks for. (optional) 

            try
            {
                // List outgoing webhooks
                List<OutgoingWebhook> result = apiInstance.HooksOutgoingGet(page, perPage, teamId, channelId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.HooksOutgoingGet: " + e.Message );
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
 **perPage** | **string**| The number of hooks per page. | [optional] [default to &quot;60&quot;]
 **teamId** | **string**| The ID of the team to get hooks for. | [optional] 
 **channelId** | **string**| The ID of the channel to get hooks for. | [optional] 

### Return type

[**List&lt;OutgoingWebhook&gt;**](OutgoingWebhook.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Outgoing webhooks retrieval successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="hooksoutgoinghookiddelete"></a>
# **HooksOutgoingHookIdDelete**
> StatusOK HooksOutgoingHookIdDelete (string hookId)

Delete an outgoing webhook

Delete an outgoing webhook given the hook id. ##### Permissions `manage_webhooks` for system or `manage_webhooks` for the specific team or `manage_webhooks` for the channel. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class HooksOutgoingHookIdDeleteExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new WebhooksApi(Configuration.Default);
            var hookId = hookId_example;  // string | Outgoing webhook GUID

            try
            {
                // Delete an outgoing webhook
                StatusOK result = apiInstance.HooksOutgoingHookIdDelete(hookId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.HooksOutgoingHookIdDelete: " + e.Message );
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
 **hookId** | **string**| Outgoing webhook GUID | 

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
| **200** | Webhook deletion successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="hooksoutgoinghookidget"></a>
# **HooksOutgoingHookIdGet**
> OutgoingWebhook HooksOutgoingHookIdGet (string hookId)

Get an outgoing webhook

Get an outgoing webhook given the hook id. ##### Permissions `manage_webhooks` for system or `manage_webhooks` for the specific team or `manage_webhooks` for the channel. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class HooksOutgoingHookIdGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new WebhooksApi(Configuration.Default);
            var hookId = hookId_example;  // string | Outgoing webhook GUID

            try
            {
                // Get an outgoing webhook
                OutgoingWebhook result = apiInstance.HooksOutgoingHookIdGet(hookId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.HooksOutgoingHookIdGet: " + e.Message );
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
 **hookId** | **string**| Outgoing webhook GUID | 

### Return type

[**OutgoingWebhook**](OutgoingWebhook.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Outgoing webhook retrieval successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="hooksoutgoinghookidput"></a>
# **HooksOutgoingHookIdPut**
> OutgoingWebhook HooksOutgoingHookIdPut (string hookId, InlineObject52 body)

Update an outgoing webhook

Update an outgoing webhook given the hook id. ##### Permissions `manage_webhooks` for system or `manage_webhooks` for the specific team or `manage_webhooks` for the channel. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class HooksOutgoingHookIdPutExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new WebhooksApi(Configuration.Default);
            var hookId = hookId_example;  // string | outgoing Webhook GUID
            var body = new InlineObject52(); // InlineObject52 | 

            try
            {
                // Update an outgoing webhook
                OutgoingWebhook result = apiInstance.HooksOutgoingHookIdPut(hookId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.HooksOutgoingHookIdPut: " + e.Message );
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
 **hookId** | **string**| outgoing Webhook GUID | 
 **body** | [**InlineObject52**](InlineObject52.md)|  | 

### Return type

[**OutgoingWebhook**](OutgoingWebhook.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Webhook update successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="hooksoutgoinghookidregentokenpost"></a>
# **HooksOutgoingHookIdRegenTokenPost**
> StatusOK HooksOutgoingHookIdRegenTokenPost (string hookId)

Regenerate the token for the outgoing webhook.

Regenerate the token for the outgoing webhook. ##### Permissions `manage_webhooks` for system or `manage_webhooks` for the specific team or `manage_webhooks` for the channel. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class HooksOutgoingHookIdRegenTokenPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new WebhooksApi(Configuration.Default);
            var hookId = hookId_example;  // string | Outgoing webhook GUID

            try
            {
                // Regenerate the token for the outgoing webhook.
                StatusOK result = apiInstance.HooksOutgoingHookIdRegenTokenPost(hookId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.HooksOutgoingHookIdRegenTokenPost: " + e.Message );
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
 **hookId** | **string**| Outgoing webhook GUID | 

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
| **200** | Webhook token regenerate successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="hooksoutgoingpost"></a>
# **HooksOutgoingPost**
> OutgoingWebhook HooksOutgoingPost (InlineObject51 body)

Create an outgoing webhook

Create an outgoing webhook for a team. ##### Permissions `manage_webhooks` for the team the webhook is in. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class HooksOutgoingPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new WebhooksApi(Configuration.Default);
            var body = new InlineObject51(); // InlineObject51 | 

            try
            {
                // Create an outgoing webhook
                OutgoingWebhook result = apiInstance.HooksOutgoingPost(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.HooksOutgoingPost: " + e.Message );
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
 **body** | [**InlineObject51**](InlineObject51.md)|  | 

### Return type

[**OutgoingWebhook**](OutgoingWebhook.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Outgoing webhook creation successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

