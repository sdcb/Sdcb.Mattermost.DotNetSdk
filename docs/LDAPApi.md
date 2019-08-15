# Sdcb.Mattermost.DotNetSdk.Api.LDAPApi

All URIs are relative to *http://your-mattermost-url.com/api/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**LdapSyncPost**](LDAPApi.md#ldapsyncpost) | **POST** /ldap/sync | Sync with LDAP
[**LdapTestPost**](LDAPApi.md#ldaptestpost) | **POST** /ldap/test | Test LDAP configuration


<a name="ldapsyncpost"></a>
# **LdapSyncPost**
> StatusOK LdapSyncPost ()

Sync with LDAP

Synchronize any user attribute changes in the configured AD/LDAP server with Mattermost. ##### Permissions Must have `manage_system` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class LdapSyncPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new LDAPApi(Configuration.Default);

            try
            {
                // Sync with LDAP
                StatusOK result = apiInstance.LdapSyncPost();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LDAPApi.LdapSyncPost: " + e.Message );
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
| **200** | LDAP sync successful |  -  |
| **501** | Feature is disabled |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ldaptestpost"></a>
# **LdapTestPost**
> StatusOK LdapTestPost ()

Test LDAP configuration

Test the current AD/LDAP configuration to see if the AD/LDAP server can be contacted successfully. ##### Permissions Must have `manage_system` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class LdapTestPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new LDAPApi(Configuration.Default);

            try
            {
                // Test LDAP configuration
                StatusOK result = apiInstance.LdapTestPost();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LDAPApi.LdapTestPost: " + e.Message );
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
| **200** | LDAP test successful |  -  |
| **500** | Something went wrong with the server |  -  |
| **501** | Feature is disabled |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

