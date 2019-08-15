# Sdcb.Mattermost.DotNetSdk.Api.PreferencesApi

All URIs are relative to *http://your-mattermost-url.com/api/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UsersUserIdPreferencesCategoryGet**](PreferencesApi.md#usersuseridpreferencescategoryget) | **GET** /users/{user_id}/preferences/{category} | List a user&#39;s preferences by category
[**UsersUserIdPreferencesCategoryNamePreferenceNameGet**](PreferencesApi.md#usersuseridpreferencescategorynamepreferencenameget) | **GET** /users/{user_id}/preferences/{category}/name/{preference_name} | Get a specific user preference
[**UsersUserIdPreferencesDeletePost**](PreferencesApi.md#usersuseridpreferencesdeletepost) | **POST** /users/{user_id}/preferences/delete | Delete user&#39;s preferences
[**UsersUserIdPreferencesGet**](PreferencesApi.md#usersuseridpreferencesget) | **GET** /users/{user_id}/preferences | Get the user&#39;s preferences
[**UsersUserIdPreferencesPut**](PreferencesApi.md#usersuseridpreferencesput) | **PUT** /users/{user_id}/preferences | Save the user&#39;s preferences


<a name="usersuseridpreferencescategoryget"></a>
# **UsersUserIdPreferencesCategoryGet**
> List&lt;Preference&gt; UsersUserIdPreferencesCategoryGet (string userId, string category)

List a user's preferences by category

Lists the current user's stored preferences in the given category. ##### Permissions Must be logged in as the user being updated or have the `edit_other_users` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class UsersUserIdPreferencesCategoryGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new PreferencesApi(Configuration.Default);
            var userId = userId_example;  // string | User GUID
            var category = category_example;  // string | The category of a group of preferences

            try
            {
                // List a user's preferences by category
                List<Preference> result = apiInstance.UsersUserIdPreferencesCategoryGet(userId, category);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PreferencesApi.UsersUserIdPreferencesCategoryGet: " + e.Message );
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
 **category** | **string**| The category of a group of preferences | 

### Return type

[**List&lt;Preference&gt;**](Preference.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of all of the current user&#39;s preferences in the given category |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersuseridpreferencescategorynamepreferencenameget"></a>
# **UsersUserIdPreferencesCategoryNamePreferenceNameGet**
> Preference UsersUserIdPreferencesCategoryNamePreferenceNameGet (string userId, string category, string preferenceName)

Get a specific user preference

Gets a single preference for the current user with the given category and name. ##### Permissions Must be logged in as the user being updated or have the `edit_other_users` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class UsersUserIdPreferencesCategoryNamePreferenceNameGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new PreferencesApi(Configuration.Default);
            var userId = userId_example;  // string | User GUID
            var category = category_example;  // string | The category of a group of preferences
            var preferenceName = preferenceName_example;  // string | The name of the preference

            try
            {
                // Get a specific user preference
                Preference result = apiInstance.UsersUserIdPreferencesCategoryNamePreferenceNameGet(userId, category, preferenceName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PreferencesApi.UsersUserIdPreferencesCategoryNamePreferenceNameGet: " + e.Message );
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
 **category** | **string**| The category of a group of preferences | 
 **preferenceName** | **string**| The name of the preference | 

### Return type

[**Preference**](Preference.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A single preference for the current user in the current categorylist of all of the current user&#39;s preferences in the given category.  |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersuseridpreferencesdeletepost"></a>
# **UsersUserIdPreferencesDeletePost**
> StatusOK UsersUserIdPreferencesDeletePost (string userId, List<Preference> body)

Delete user's preferences

Delete a list of the user's preferences. ##### Permissions Must be logged in as the user being updated or have the `edit_other_users` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class UsersUserIdPreferencesDeletePostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new PreferencesApi(Configuration.Default);
            var userId = userId_example;  // string | User GUID
            var body = new List<Preference>(); // List<Preference> | List of preference object

            try
            {
                // Delete user's preferences
                StatusOK result = apiInstance.UsersUserIdPreferencesDeletePost(userId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PreferencesApi.UsersUserIdPreferencesDeletePost: " + e.Message );
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
 **body** | [**List&lt;Preference&gt;**](Preference.md)| List of preference object | 

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
| **200** | User preferences saved successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersuseridpreferencesget"></a>
# **UsersUserIdPreferencesGet**
> List&lt;Preference&gt; UsersUserIdPreferencesGet (string userId)

Get the user's preferences

Get a list of the user's preferences. ##### Permissions Must be logged in as the user being updated or have the `edit_other_users` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class UsersUserIdPreferencesGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new PreferencesApi(Configuration.Default);
            var userId = userId_example;  // string | User GUID

            try
            {
                // Get the user's preferences
                List<Preference> result = apiInstance.UsersUserIdPreferencesGet(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PreferencesApi.UsersUserIdPreferencesGet: " + e.Message );
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

[**List&lt;Preference&gt;**](Preference.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | User preferences retrieval successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersuseridpreferencesput"></a>
# **UsersUserIdPreferencesPut**
> StatusOK UsersUserIdPreferencesPut (string userId, List<Preference> body)

Save the user's preferences

Save a list of the user's preferences. ##### Permissions Must be logged in as the user being updated or have the `edit_other_users` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class UsersUserIdPreferencesPutExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new PreferencesApi(Configuration.Default);
            var userId = userId_example;  // string | User GUID
            var body = new List<Preference>(); // List<Preference> | List of preference object

            try
            {
                // Save the user's preferences
                StatusOK result = apiInstance.UsersUserIdPreferencesPut(userId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PreferencesApi.UsersUserIdPreferencesPut: " + e.Message );
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
 **body** | [**List&lt;Preference&gt;**](Preference.md)| List of preference object | 

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
| **200** | User preferences saved successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |
| **404** | Resource not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

