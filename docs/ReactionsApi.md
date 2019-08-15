# Sdcb.Mattermost.DotNetSdk.Api.ReactionsApi

All URIs are relative to *http://your-mattermost-url.com/api/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PostsIdsReactionsPost**](ReactionsApi.md#postsidsreactionspost) | **POST** /posts/ids/reactions | Bulk get the reaction for posts
[**PostsPostIdReactionsGet**](ReactionsApi.md#postspostidreactionsget) | **GET** /posts/{post_id}/reactions | Get a list of reactions to a post
[**ReactionsPost**](ReactionsApi.md#reactionspost) | **POST** /reactions | Create a reaction
[**UsersUserIdPostsPostIdReactionsEmojiNameDelete**](ReactionsApi.md#usersuseridpostspostidreactionsemojinamedelete) | **DELETE** /users/{user_id}/posts/{post_id}/reactions/{emoji_name} | Remove a reaction from a post


<a name="postsidsreactionspost"></a>
# **PostsIdsReactionsPost**
> Dictionary&lt;string, List&lt;Reaction&gt;&gt; PostsIdsReactionsPost (List<string> postIds)

Bulk get the reaction for posts

Get a list of reactions made by all users to a given post. ##### Permissions Must have `read_channel` permission for the channel the post is in.  __Minimum server version__: 5.8 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class PostsIdsReactionsPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new ReactionsApi(Configuration.Default);
            var postIds = new List<string>(); // List<string> | Array of post IDs

            try
            {
                // Bulk get the reaction for posts
                Dictionary<string, List<Reaction>> result = apiInstance.PostsIdsReactionsPost(postIds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReactionsApi.PostsIdsReactionsPost: " + e.Message );
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
 **postIds** | [**List&lt;string&gt;**](string.md)| Array of post IDs | 

### Return type

**Dictionary<string, List<Reaction>>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Reactions retrieval successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postspostidreactionsget"></a>
# **PostsPostIdReactionsGet**
> List&lt;Reaction&gt; PostsPostIdReactionsGet (string postId)

Get a list of reactions to a post

Get a list of reactions made by all users to a given post. ##### Permissions Must have `read_channel` permission for the channel the post is in. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class PostsPostIdReactionsGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new ReactionsApi(Configuration.Default);
            var postId = postId_example;  // string | ID of a post

            try
            {
                // Get a list of reactions to a post
                List<Reaction> result = apiInstance.PostsPostIdReactionsGet(postId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReactionsApi.PostsPostIdReactionsGet: " + e.Message );
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
 **postId** | **string**| ID of a post | 

### Return type

[**List&lt;Reaction&gt;**](Reaction.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List reactions retrieve successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reactionspost"></a>
# **ReactionsPost**
> Reaction ReactionsPost (Reaction reaction)

Create a reaction

Create a reaction. ##### Permissions Must have `read_channel` permission for the channel the post is in. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class ReactionsPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new ReactionsApi(Configuration.Default);
            var reaction = new Reaction(); // Reaction | The user's reaction with its post_id, user_id, and emoji_name fields set

            try
            {
                // Create a reaction
                Reaction result = apiInstance.ReactionsPost(reaction);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReactionsApi.ReactionsPost: " + e.Message );
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
 **reaction** | [**Reaction**](Reaction.md)| The user&#39;s reaction with its post_id, user_id, and emoji_name fields set | 

### Return type

[**Reaction**](Reaction.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Reaction creation successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersuseridpostspostidreactionsemojinamedelete"></a>
# **UsersUserIdPostsPostIdReactionsEmojiNameDelete**
> StatusOK UsersUserIdPostsPostIdReactionsEmojiNameDelete (string userId, string postId, string emojiName)

Remove a reaction from a post

Deletes a reaction made by a user from the given post. ##### Permissions Must be user or have `manage_system` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class UsersUserIdPostsPostIdReactionsEmojiNameDeleteExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new ReactionsApi(Configuration.Default);
            var userId = userId_example;  // string | ID of the user
            var postId = postId_example;  // string | ID of the post
            var emojiName = emojiName_example;  // string | emoji name

            try
            {
                // Remove a reaction from a post
                StatusOK result = apiInstance.UsersUserIdPostsPostIdReactionsEmojiNameDelete(userId, postId, emojiName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReactionsApi.UsersUserIdPostsPostIdReactionsEmojiNameDelete: " + e.Message );
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
 **userId** | **string**| ID of the user | 
 **postId** | **string**| ID of the post | 
 **emojiName** | **string**| emoji name | 

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
| **200** | Reaction deletion successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

