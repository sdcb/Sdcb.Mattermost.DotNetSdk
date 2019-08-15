# Sdcb.Mattermost.DotNetSdk.Api.FilesApi

All URIs are relative to *http://your-mattermost-url.com/api/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FilesFileIdGet**](FilesApi.md#filesfileidget) | **GET** /files/{file_id} | Get a file
[**FilesFileIdInfoGet**](FilesApi.md#filesfileidinfoget) | **GET** /files/{file_id}/info | Get metadata for a file
[**FilesFileIdLinkGet**](FilesApi.md#filesfileidlinkget) | **GET** /files/{file_id}/link | Get a public file link
[**FilesFileIdPreviewGet**](FilesApi.md#filesfileidpreviewget) | **GET** /files/{file_id}/preview | Get a file&#39;s preview
[**FilesFileIdThumbnailGet**](FilesApi.md#filesfileidthumbnailget) | **GET** /files/{file_id}/thumbnail | Get a file&#39;s thumbnail
[**FilesPost**](FilesApi.md#filespost) | **POST** /files | Upload a file


<a name="filesfileidget"></a>
# **FilesFileIdGet**
> void FilesFileIdGet (string fileId)

Get a file

Gets a file that has been uploaded previously. ##### Permissions Must have `read_channel` permission or be uploader of the file. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class FilesFileIdGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new FilesApi(Configuration.Default);
            var fileId = fileId_example;  // string | The ID of the file to get

            try
            {
                // Get a file
                apiInstance.FilesFileIdGet(fileId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesApi.FilesFileIdGet: " + e.Message );
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
 **fileId** | **string**| The ID of the file to get | 

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
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |
| **501** | Feature is disabled |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="filesfileidinfoget"></a>
# **FilesFileIdInfoGet**
> FileInfo FilesFileIdInfoGet (string fileId)

Get metadata for a file

Gets a file's info. ##### Permissions Must have `read_channel` permission or be uploader of the file. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class FilesFileIdInfoGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new FilesApi(Configuration.Default);
            var fileId = fileId_example;  // string | The ID of the file info to get

            try
            {
                // Get metadata for a file
                FileInfo result = apiInstance.FilesFileIdInfoGet(fileId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesApi.FilesFileIdInfoGet: " + e.Message );
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
 **fileId** | **string**| The ID of the file info to get | 

### Return type

[**FileInfo**](FileInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The stored metadata for the given file |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |
| **501** | Feature is disabled |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="filesfileidlinkget"></a>
# **FilesFileIdLinkGet**
> InlineResponse2007 FilesFileIdLinkGet (string fileId)

Get a public file link

Gets a public link for a file that can be accessed without logging into Mattermost. ##### Permissions Must have `read_channel` permission or be uploader of the file. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class FilesFileIdLinkGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new FilesApi(Configuration.Default);
            var fileId = fileId_example;  // string | The ID of the file to get a link for

            try
            {
                // Get a public file link
                InlineResponse2007 result = apiInstance.FilesFileIdLinkGet(fileId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesApi.FilesFileIdLinkGet: " + e.Message );
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
 **fileId** | **string**| The ID of the file to get a link for | 

### Return type

[**InlineResponse2007**](InlineResponse2007.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A publicly accessible link to the given file |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |
| **501** | Feature is disabled |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="filesfileidpreviewget"></a>
# **FilesFileIdPreviewGet**
> void FilesFileIdPreviewGet (string fileId)

Get a file's preview

Gets a file's preview. ##### Permissions Must have `read_channel` permission or be uploader of the file. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class FilesFileIdPreviewGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new FilesApi(Configuration.Default);
            var fileId = fileId_example;  // string | The ID of the file to get

            try
            {
                // Get a file's preview
                apiInstance.FilesFileIdPreviewGet(fileId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesApi.FilesFileIdPreviewGet: " + e.Message );
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
 **fileId** | **string**| The ID of the file to get | 

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
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |
| **501** | Feature is disabled |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="filesfileidthumbnailget"></a>
# **FilesFileIdThumbnailGet**
> void FilesFileIdThumbnailGet (string fileId)

Get a file's thumbnail

Gets a file's thumbnail. ##### Permissions Must have `read_channel` permission or be uploader of the file. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class FilesFileIdThumbnailGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new FilesApi(Configuration.Default);
            var fileId = fileId_example;  // string | The ID of the file to get

            try
            {
                // Get a file's thumbnail
                apiInstance.FilesFileIdThumbnailGet(fileId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesApi.FilesFileIdThumbnailGet: " + e.Message );
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
 **fileId** | **string**| The ID of the file to get | 

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
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |
| **501** | Feature is disabled |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="filespost"></a>
# **FilesPost**
> InlineResponse201 FilesPost (string channelId = null, string filename = null, System.IO.Stream files = null, string channelId = null, string clientIds = null)

Upload a file

Uploads a file that can later be attached to a post.  This request can either be a multipart/form-data request with a channel_id, files and optional client_ids defined in the FormData, or it can be a request with the channel_id and filename defined as query parameters with the contents of a single file in the body of the request.  Only multipart/form-data requests are supported by server versions up to and including 4.7. Server versions 4.8 and higher support both types of requests.  ##### Permissions Must have `upload_file` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class FilesPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new FilesApi(Configuration.Default);
            var channelId = channelId_example;  // string | The ID of the channel that this file will be uploaded to (optional) 
            var filename = filename_example;  // string | The name of the file to be uploaded (optional) 
            var files = BINARY_DATA_HERE;  // System.IO.Stream | A file to be uploaded (optional) 
            var channelId = channelId_example;  // string | The ID of the channel that this file will be uploaded to (optional) 
            var clientIds = clientIds_example;  // string | A unique identifier for the file that will be returned in the response (optional) 

            try
            {
                // Upload a file
                InlineResponse201 result = apiInstance.FilesPost(channelId, filename, files, channelId, clientIds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FilesApi.FilesPost: " + e.Message );
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
 **channelId** | **string**| The ID of the channel that this file will be uploaded to | [optional] 
 **filename** | **string**| The name of the file to be uploaded | [optional] 
 **files** | **System.IO.Stream****System.IO.Stream**| A file to be uploaded | [optional] 
 **channelId** | **string**| The ID of the channel that this file will be uploaded to | [optional] 
 **clientIds** | **string**| A unique identifier for the file that will be returned in the response | [optional] 

### Return type

[**InlineResponse201**](InlineResponse201.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data, 
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Corresponding lists of the provided client_ids and the metadata that has been stored in the database for each one |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **413** | Content too large |  -  |
| **501** | Feature is disabled |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

