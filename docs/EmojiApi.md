# Sdcb.Mattermost.DotNetSdk.Api.EmojiApi

All URIs are relative to *http://your-mattermost-url.com/api/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EmojiAutocompleteGet**](EmojiApi.md#emojiautocompleteget) | **GET** /emoji/autocomplete | Autocomplete custom emoji
[**EmojiEmojiIdDelete**](EmojiApi.md#emojiemojiiddelete) | **DELETE** /emoji/{emoji_id} | Delete a custom emoji
[**EmojiEmojiIdGet**](EmojiApi.md#emojiemojiidget) | **GET** /emoji/{emoji_id} | Get a custom emoji
[**EmojiEmojiIdImageGet**](EmojiApi.md#emojiemojiidimageget) | **GET** /emoji/{emoji_id}/image | Get custom emoji image
[**EmojiGet**](EmojiApi.md#emojiget) | **GET** /emoji | Get a list of custom emoji
[**EmojiNameEmojiNameGet**](EmojiApi.md#emojinameemojinameget) | **GET** /emoji/name/{emoji_name} | Get a custom emoji by name
[**EmojiPost**](EmojiApi.md#emojipost) | **POST** /emoji | Create a custom emoji
[**EmojiSearchPost**](EmojiApi.md#emojisearchpost) | **POST** /emoji/search | Search custom emoji


<a name="emojiautocompleteget"></a>
# **EmojiAutocompleteGet**
> Emoji EmojiAutocompleteGet (string name)

Autocomplete custom emoji

Get a list of custom emoji with names starting with or matching the provided name. Returns a maximum of 100 results. ##### Permissions Must be authenticated.  __Minimum server version__: 4.7 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class EmojiAutocompleteGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new EmojiApi(Configuration.Default);
            var name = name_example;  // string | The emoji name to search.

            try
            {
                // Autocomplete custom emoji
                Emoji result = apiInstance.EmojiAutocompleteGet(name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmojiApi.EmojiAutocompleteGet: " + e.Message );
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
 **name** | **string**| The emoji name to search. | 

### Return type

[**Emoji**](Emoji.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Emoji list retrieval successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **501** | Feature is disabled |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="emojiemojiiddelete"></a>
# **EmojiEmojiIdDelete**
> Emoji EmojiEmojiIdDelete (string emojiId)

Delete a custom emoji

Delete a custom emoji. ##### Permissions Must have the `manage_team` or `manage_system` permissions or be the user who created the emoji. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class EmojiEmojiIdDeleteExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new EmojiApi(Configuration.Default);
            var emojiId = emojiId_example;  // string | Emoji GUID

            try
            {
                // Delete a custom emoji
                Emoji result = apiInstance.EmojiEmojiIdDelete(emojiId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmojiApi.EmojiEmojiIdDelete: " + e.Message );
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
 **emojiId** | **string**| Emoji GUID | 

### Return type

[**Emoji**](Emoji.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Emoji delete successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **501** | Feature is disabled |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="emojiemojiidget"></a>
# **EmojiEmojiIdGet**
> Emoji EmojiEmojiIdGet (string emojiId)

Get a custom emoji

Get some metadata for a custom emoji. ##### Permissions Must be authenticated. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class EmojiEmojiIdGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new EmojiApi(Configuration.Default);
            var emojiId = emojiId_example;  // string | Emoji GUID

            try
            {
                // Get a custom emoji
                Emoji result = apiInstance.EmojiEmojiIdGet(emojiId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmojiApi.EmojiEmojiIdGet: " + e.Message );
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
 **emojiId** | **string**| Emoji GUID | 

### Return type

[**Emoji**](Emoji.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Emoji retrieval successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **404** | Resource not found |  -  |
| **501** | Feature is disabled |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="emojiemojiidimageget"></a>
# **EmojiEmojiIdImageGet**
> void EmojiEmojiIdImageGet (string emojiId)

Get custom emoji image

Get the image for a custom emoji. ##### Permissions Must be authenticated. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class EmojiEmojiIdImageGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new EmojiApi(Configuration.Default);
            var emojiId = emojiId_example;  // string | Emoji GUID

            try
            {
                // Get custom emoji image
                apiInstance.EmojiEmojiIdImageGet(emojiId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmojiApi.EmojiEmojiIdImageGet: " + e.Message );
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
 **emojiId** | **string**| Emoji GUID | 

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
| **200** | Emoji image retrieval successful |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |
| **500** | Something went wrong with the server |  -  |
| **501** | Feature is disabled |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="emojiget"></a>
# **EmojiGet**
> Emoji EmojiGet (string page = null, string perPage = null, string sort = null)

Get a list of custom emoji

Get a page of metadata for custom emoji on the system. Since server version 4.7, sort using the `sort` query parameter. ##### Permissions Must be authenticated. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class EmojiGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new EmojiApi(Configuration.Default);
            var page = page_example;  // string | The page to select. (optional)  (default to "0")
            var perPage = perPage_example;  // string | The number of users per page. (optional)  (default to "60")
            var sort = sort_example;  // string | Either blank for no sorting or \"name\" to sort by emoji names. Minimum server version for sorting is 4.7. (optional) 

            try
            {
                // Get a list of custom emoji
                Emoji result = apiInstance.EmojiGet(page, perPage, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmojiApi.EmojiGet: " + e.Message );
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
 **perPage** | **string**| The number of users per page. | [optional] [default to &quot;60&quot;]
 **sort** | **string**| Either blank for no sorting or \&quot;name\&quot; to sort by emoji names. Minimum server version for sorting is 4.7. | [optional] 

### Return type

[**Emoji**](Emoji.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Emoji list retrieval successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **501** | Feature is disabled |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="emojinameemojinameget"></a>
# **EmojiNameEmojiNameGet**
> Emoji EmojiNameEmojiNameGet (string emojiName)

Get a custom emoji by name

Get some metadata for a custom emoji using its name. ##### Permissions Must be authenticated.  __Minimum server version__: 4.7 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class EmojiNameEmojiNameGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new EmojiApi(Configuration.Default);
            var emojiName = emojiName_example;  // string | Emoji name

            try
            {
                // Get a custom emoji by name
                Emoji result = apiInstance.EmojiNameEmojiNameGet(emojiName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmojiApi.EmojiNameEmojiNameGet: " + e.Message );
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
 **emojiName** | **string**| Emoji name | 

### Return type

[**Emoji**](Emoji.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Emoji retrieval successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **404** | Resource not found |  -  |
| **501** | Feature is disabled |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="emojipost"></a>
# **EmojiPost**
> Emoji EmojiPost (System.IO.Stream image, string emoji)

Create a custom emoji

Create a custom emoji for the team. ##### Permissions Must be authenticated. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class EmojiPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new EmojiApi(Configuration.Default);
            var image = BINARY_DATA_HERE;  // System.IO.Stream | A file to be uploaded
            var emoji = emoji_example;  // string | A JSON object containing a `name` field with the name of the emoji and a `creator_id` field with the id of the authenticated user.

            try
            {
                // Create a custom emoji
                Emoji result = apiInstance.EmojiPost(image, emoji);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmojiApi.EmojiPost: " + e.Message );
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
 **image** | **System.IO.Stream****System.IO.Stream**| A file to be uploaded | 
 **emoji** | **string**| A JSON object containing a &#x60;name&#x60; field with the name of the emoji and a &#x60;creator_id&#x60; field with the id of the authenticated user. | 

### Return type

[**Emoji**](Emoji.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Emoji creation successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **413** | Content too large |  -  |
| **501** | Feature is disabled |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="emojisearchpost"></a>
# **EmojiSearchPost**
> List&lt;Emoji&gt; EmojiSearchPost (InlineObject48 body)

Search custom emoji

Search for custom emoji by name based on search criteria provided in the request body. A maximum of 200 results are returned. ##### Permissions Must be authenticated.  __Minimum server version__: 4.7 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class EmojiSearchPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new EmojiApi(Configuration.Default);
            var body = new InlineObject48(); // InlineObject48 | 

            try
            {
                // Search custom emoji
                List<Emoji> result = apiInstance.EmojiSearchPost(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmojiApi.EmojiSearchPost: " + e.Message );
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
 **body** | [**InlineObject48**](InlineObject48.md)|  | 

### Return type

[**List&lt;Emoji&gt;**](Emoji.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Emoji list retrieval successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **501** | Feature is disabled |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

