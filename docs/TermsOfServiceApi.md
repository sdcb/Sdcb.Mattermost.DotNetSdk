# Sdcb.Mattermost.DotNetSdk.Api.TermsOfServiceApi

All URIs are relative to *http://your-mattermost-url.com/api/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UsersUserIdTermsOfServiceGet**](TermsOfServiceApi.md#usersuseridtermsofserviceget) | **GET** /users/{user_id}/terms_of_service | Fetches user&#39;s latest terms of service action if the latest action was for acceptance.
[**UsersUserIdTermsOfServicePost**](TermsOfServiceApi.md#usersuseridtermsofservicepost) | **POST** /users/{user_id}/terms_of_service | Records user action when they accept or decline custom terms of service


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
            var apiInstance = new TermsOfServiceApi(Configuration.Default);
            var userId = userId_example;  // string | User GUID

            try
            {
                // Fetches user's latest terms of service action if the latest action was for acceptance.
                UserTermsOfService result = apiInstance.UsersUserIdTermsOfServiceGet(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TermsOfServiceApi.UsersUserIdTermsOfServiceGet: " + e.Message );
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
            var apiInstance = new TermsOfServiceApi(Configuration.Default);
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
                Debug.Print("Exception when calling TermsOfServiceApi.UsersUserIdTermsOfServicePost: " + e.Message );
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

