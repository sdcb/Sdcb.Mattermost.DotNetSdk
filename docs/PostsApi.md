# Sdcb.Mattermost.DotNetSdk.Api.PostsApi

All URIs are relative to *http://your-mattermost-url.com/api/v4*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ChannelsChannelIdPostsGet**](PostsApi.md#channelschannelidpostsget) | **GET** /channels/{channel_id}/posts | Get posts for a channel
[**PostsEphemeralPost**](PostsApi.md#postsephemeralpost) | **POST** /posts/ephemeral | Create a ephemeral post
[**PostsPost**](PostsApi.md#postspost) | **POST** /posts | Create a post
[**PostsPostIdActionsActionIdPost**](PostsApi.md#postspostidactionsactionidpost) | **POST** /posts/{post_id}/actions/{action_id} | Perform a post action
[**PostsPostIdDelete**](PostsApi.md#postspostiddelete) | **DELETE** /posts/{post_id} | Delete a post
[**PostsPostIdFilesInfoGet**](PostsApi.md#postspostidfilesinfoget) | **GET** /posts/{post_id}/files/info | Get file info for post
[**PostsPostIdGet**](PostsApi.md#postspostidget) | **GET** /posts/{post_id} | Get a post
[**PostsPostIdPatchPut**](PostsApi.md#postspostidpatchput) | **PUT** /posts/{post_id}/patch | Patch a post
[**PostsPostIdPinPost**](PostsApi.md#postspostidpinpost) | **POST** /posts/{post_id}/pin | Pin a post to the channel
[**PostsPostIdPut**](PostsApi.md#postspostidput) | **PUT** /posts/{post_id} | Update a post
[**PostsPostIdThreadGet**](PostsApi.md#postspostidthreadget) | **GET** /posts/{post_id}/thread | Get a thread
[**PostsPostIdUnpinPost**](PostsApi.md#postspostidunpinpost) | **POST** /posts/{post_id}/unpin | Unpin a post to the channel
[**TeamsTeamIdPostsSearchPost**](PostsApi.md#teamsteamidpostssearchpost) | **POST** /teams/{team_id}/posts/search | Search for team posts
[**UsersUserIdChannelsChannelIdPostsUnreadGet**](PostsApi.md#usersuseridchannelschannelidpostsunreadget) | **GET** /users/{user_id}/channels/{channel_id}/posts/unread | Get posts around last unread
[**UsersUserIdPostsFlaggedGet**](PostsApi.md#usersuseridpostsflaggedget) | **GET** /users/{user_id}/posts/flagged | Get a list of flagged posts


<a name="channelschannelidpostsget"></a>
# **ChannelsChannelIdPostsGet**
> PostList ChannelsChannelIdPostsGet (string channelId, string page = null, string perPage = null, int? since = null, string before = null, string after = null)

Get posts for a channel

Get a page of posts in a channel. Use the query parameters to modify the behaviour of this endpoint. The parameters `since`, `before` and `after` must not be used together. ##### Permissions Must have `read_channel` permission for the channel. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class ChannelsChannelIdPostsGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new PostsApi(Configuration.Default);
            var channelId = channelId_example;  // string | The channel ID to get the posts for
            var page = page_example;  // string | The page to select (optional)  (default to "0")
            var perPage = perPage_example;  // string | The number of posts per page (optional)  (default to "60")
            var since = 56;  // int? | Provide a non-zero value in Unix time milliseconds to select posts created after that time (optional) 
            var before = before_example;  // string | A post id to select the posts that came before this one (optional) 
            var after = after_example;  // string | A post id to select the posts that came after this one (optional) 

            try
            {
                // Get posts for a channel
                PostList result = apiInstance.ChannelsChannelIdPostsGet(channelId, page, perPage, since, before, after);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PostsApi.ChannelsChannelIdPostsGet: " + e.Message );
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
 **channelId** | **string**| The channel ID to get the posts for | 
 **page** | **string**| The page to select | [optional] [default to &quot;0&quot;]
 **perPage** | **string**| The number of posts per page | [optional] [default to &quot;60&quot;]
 **since** | **int?**| Provide a non-zero value in Unix time milliseconds to select posts created after that time | [optional] 
 **before** | **string**| A post id to select the posts that came before this one | [optional] 
 **after** | **string**| A post id to select the posts that came after this one | [optional] 

### Return type

[**PostList**](PostList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Post list retrieval successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postsephemeralpost"></a>
# **PostsEphemeralPost**
> Post PostsEphemeralPost (InlineObject42 ephemeralPost)

Create a ephemeral post

Create a new ephemeral post in a channel. ##### Permissions Must have `create_post_ephemeral` permission (currently only given to system admin) 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class PostsEphemeralPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new PostsApi(Configuration.Default);
            var ephemeralPost = new InlineObject42(); // InlineObject42 | 

            try
            {
                // Create a ephemeral post
                Post result = apiInstance.PostsEphemeralPost(ephemeralPost);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PostsApi.PostsEphemeralPost: " + e.Message );
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
 **ephemeralPost** | [**InlineObject42**](InlineObject42.md)|  | 

### Return type

[**Post**](Post.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Post creation successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postspost"></a>
# **PostsPost**
> Post PostsPost (InlineObject41 post)

Create a post

Create a new post in a channel. To create the post as a comment on another post, provide `root_id`. ##### Permissions Must have `create_post` permission for the channel the post is being created in. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class PostsPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new PostsApi(Configuration.Default);
            var post = new InlineObject41(); // InlineObject41 | 

            try
            {
                // Create a post
                Post result = apiInstance.PostsPost(post);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PostsApi.PostsPost: " + e.Message );
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
 **post** | [**InlineObject41**](InlineObject41.md)|  | 

### Return type

[**Post**](Post.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Post creation successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postspostidactionsactionidpost"></a>
# **PostsPostIdActionsActionIdPost**
> StatusOK PostsPostIdActionsActionIdPost (string postId, string actionId)

Perform a post action

Perform a post action, which allows users to interact with integrations through posts. ##### Permissions Must be authenticated and have the `read_channel` permission to the channel the post is in. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class PostsPostIdActionsActionIdPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new PostsApi(Configuration.Default);
            var postId = postId_example;  // string | Post GUID
            var actionId = actionId_example;  // string | Action GUID

            try
            {
                // Perform a post action
                StatusOK result = apiInstance.PostsPostIdActionsActionIdPost(postId, actionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PostsApi.PostsPostIdActionsActionIdPost: " + e.Message );
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
 **postId** | **string**| Post GUID | 
 **actionId** | **string**| Action GUID | 

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
| **200** | Post action successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postspostiddelete"></a>
# **PostsPostIdDelete**
> StatusOK PostsPostIdDelete (string postId)

Delete a post

Soft deletes a post, by marking the post as deleted in the database. Soft deleted posts will not be returned in post queries. ##### Permissions Must be logged in as the user or have `delete_others_posts` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class PostsPostIdDeleteExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new PostsApi(Configuration.Default);
            var postId = postId_example;  // string | ID of the post to delete

            try
            {
                // Delete a post
                StatusOK result = apiInstance.PostsPostIdDelete(postId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PostsApi.PostsPostIdDelete: " + e.Message );
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
 **postId** | **string**| ID of the post to delete | 

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
| **200** | Post deletion successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postspostidfilesinfoget"></a>
# **PostsPostIdFilesInfoGet**
> List&lt;FileInfo&gt; PostsPostIdFilesInfoGet (string postId)

Get file info for post

Gets a list of file information objects for the files attached to a post. ##### Permissions Must have `read_channel` permission for the channel the post is in. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class PostsPostIdFilesInfoGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new PostsApi(Configuration.Default);
            var postId = postId_example;  // string | ID of the post

            try
            {
                // Get file info for post
                List<FileInfo> result = apiInstance.PostsPostIdFilesInfoGet(postId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PostsApi.PostsPostIdFilesInfoGet: " + e.Message );
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
 **postId** | **string**| ID of the post | 

### Return type

[**List&lt;FileInfo&gt;**](FileInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | File info retrieval successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postspostidget"></a>
# **PostsPostIdGet**
> Post PostsPostIdGet (string postId)

Get a post

Get a single post. ##### Permissions Must have `read_channel` permission for the channel the post is in or if the channel is public, have the `read_public_channels` permission for the team. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class PostsPostIdGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new PostsApi(Configuration.Default);
            var postId = postId_example;  // string | ID of the post to get

            try
            {
                // Get a post
                Post result = apiInstance.PostsPostIdGet(postId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PostsApi.PostsPostIdGet: " + e.Message );
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
 **postId** | **string**| ID of the post to get | 

### Return type

[**Post**](Post.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Post retrieval successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postspostidpatchput"></a>
# **PostsPostIdPatchPut**
> Post PostsPostIdPatchPut (string postId, InlineObject44 body)

Patch a post

Partially update a post by providing only the fields you want to update. Omitted fields will not be updated. The fields that can be updated are defined in the request body, all other provided fields will be ignored. ##### Permissions Must have the `edit_post` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class PostsPostIdPatchPutExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new PostsApi(Configuration.Default);
            var postId = postId_example;  // string | Post GUID
            var body = new InlineObject44(); // InlineObject44 | 

            try
            {
                // Patch a post
                Post result = apiInstance.PostsPostIdPatchPut(postId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PostsApi.PostsPostIdPatchPut: " + e.Message );
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
 **postId** | **string**| Post GUID | 
 **body** | [**InlineObject44**](InlineObject44.md)|  | 

### Return type

[**Post**](Post.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Post patch successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postspostidpinpost"></a>
# **PostsPostIdPinPost**
> StatusOK PostsPostIdPinPost (string postId)

Pin a post to the channel

Pin a post to a channel it is in based from the provided post id string. ##### Permissions Must be authenticated and have the `read_channel` permission to the channel the post is in. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class PostsPostIdPinPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new PostsApi(Configuration.Default);
            var postId = postId_example;  // string | Post GUID

            try
            {
                // Pin a post to the channel
                StatusOK result = apiInstance.PostsPostIdPinPost(postId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PostsApi.PostsPostIdPinPost: " + e.Message );
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
 **postId** | **string**| Post GUID | 

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
| **200** | Pinned post successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postspostidput"></a>
# **PostsPostIdPut**
> Post PostsPostIdPut (string postId, InlineObject43 body)

Update a post

Update a post. Only the fields listed below are updatable, omitted fields will be treated as blank. ##### Permissions Must have `edit_post` permission for the channel the post is in. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class PostsPostIdPutExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new PostsApi(Configuration.Default);
            var postId = postId_example;  // string | ID of the post to update
            var body = new InlineObject43(); // InlineObject43 | 

            try
            {
                // Update a post
                Post result = apiInstance.PostsPostIdPut(postId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PostsApi.PostsPostIdPut: " + e.Message );
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
 **postId** | **string**| ID of the post to update | 
 **body** | [**InlineObject43**](InlineObject43.md)|  | 

### Return type

[**Post**](Post.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Post update successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postspostidthreadget"></a>
# **PostsPostIdThreadGet**
> PostList PostsPostIdThreadGet (string postId)

Get a thread

Get a post and the rest of the posts in the same thread. ##### Permissions Must have `read_channel` permission for the channel the post is in or if the channel is public, have the `read_public_channels` permission for the team. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class PostsPostIdThreadGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new PostsApi(Configuration.Default);
            var postId = postId_example;  // string | ID of a post in the thread

            try
            {
                // Get a thread
                PostList result = apiInstance.PostsPostIdThreadGet(postId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PostsApi.PostsPostIdThreadGet: " + e.Message );
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
 **postId** | **string**| ID of a post in the thread | 

### Return type

[**PostList**](PostList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Post list retrieval successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postspostidunpinpost"></a>
# **PostsPostIdUnpinPost**
> StatusOK PostsPostIdUnpinPost (string postId)

Unpin a post to the channel

Unpin a post to a channel it is in based from the provided post id string. ##### Permissions Must be authenticated and have the `read_channel` permission to the channel the post is in. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class PostsPostIdUnpinPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new PostsApi(Configuration.Default);
            var postId = postId_example;  // string | Post GUID

            try
            {
                // Unpin a post to the channel
                StatusOK result = apiInstance.PostsPostIdUnpinPost(postId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PostsApi.PostsPostIdUnpinPost: " + e.Message );
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
 **postId** | **string**| Post GUID | 

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
| **200** | Unpinned post successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="teamsteamidpostssearchpost"></a>
# **TeamsTeamIdPostsSearchPost**
> PostListWithSearchMatches TeamsTeamIdPostsSearchPost (string teamId, InlineObject45 body)

Search for team posts

Search posts in the team and from the provided terms string. ##### Permissions Must be authenticated and have the `view_team` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class TeamsTeamIdPostsSearchPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new PostsApi(Configuration.Default);
            var teamId = teamId_example;  // string | Team GUID
            var body = new InlineObject45(); // InlineObject45 | 

            try
            {
                // Search for team posts
                PostListWithSearchMatches result = apiInstance.TeamsTeamIdPostsSearchPost(teamId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PostsApi.TeamsTeamIdPostsSearchPost: " + e.Message );
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
 **teamId** | **string**| Team GUID | 
 **body** | [**InlineObject45**](InlineObject45.md)|  | 

### Return type

[**PostListWithSearchMatches**](PostListWithSearchMatches.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Post list retrieval successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersuseridchannelschannelidpostsunreadget"></a>
# **UsersUserIdChannelsChannelIdPostsUnreadGet**
> PostList UsersUserIdChannelsChannelIdPostsUnreadGet (string userId, string channelId, string limitBefore = null, string limitAfter = null)

Get posts around last unread

Get the oldest unread post in the channel for the given user as well as the posts around it. ##### Permissions Must be logged in as the user or have `edit_other_users` permission, and must have `read_channel` permission for the channel. __Minimum server version__: 5.14 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class UsersUserIdChannelsChannelIdPostsUnreadGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new PostsApi(Configuration.Default);
            var userId = userId_example;  // string | ID of the user
            var channelId = channelId_example;  // string | The channel ID to get the posts for
            var limitBefore = limitBefore_example;  // string | Number of posts before the last unread posts. Maximum is 200 posts if limit is set greater than that. (optional)  (default to "60")
            var limitAfter = limitAfter_example;  // string | Number of posts after and including the last unread post. Maximum is 200 posts if limit is set greater than that. (optional)  (default to "60")

            try
            {
                // Get posts around last unread
                PostList result = apiInstance.UsersUserIdChannelsChannelIdPostsUnreadGet(userId, channelId, limitBefore, limitAfter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PostsApi.UsersUserIdChannelsChannelIdPostsUnreadGet: " + e.Message );
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
 **channelId** | **string**| The channel ID to get the posts for | 
 **limitBefore** | **string**| Number of posts before the last unread posts. Maximum is 200 posts if limit is set greater than that. | [optional] [default to &quot;60&quot;]
 **limitAfter** | **string**| Number of posts after and including the last unread post. Maximum is 200 posts if limit is set greater than that. | [optional] [default to &quot;60&quot;]

### Return type

[**PostList**](PostList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Post list retrieval successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersuseridpostsflaggedget"></a>
# **UsersUserIdPostsFlaggedGet**
> List&lt;PostList&gt; UsersUserIdPostsFlaggedGet (string userId, string teamId = null, string channelId = null, string page = null, string perPage = null)

Get a list of flagged posts

Get a page of flagged posts of a user provided user id string. Selects from a channel, team or all flagged posts by a user. ##### Permissions Must be user or have `manage_system` permission. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Example
{
    public class UsersUserIdPostsFlaggedGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://your-mattermost-url.com/api/v4";
            var apiInstance = new PostsApi(Configuration.Default);
            var userId = userId_example;  // string | ID of the user
            var teamId = teamId_example;  // string | Team ID (optional) 
            var channelId = channelId_example;  // string | Channel ID (optional) 
            var page = page_example;  // string | The page to select (optional)  (default to "0")
            var perPage = perPage_example;  // string | The number of posts per page (optional)  (default to "60")

            try
            {
                // Get a list of flagged posts
                List<PostList> result = apiInstance.UsersUserIdPostsFlaggedGet(userId, teamId, channelId, page, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PostsApi.UsersUserIdPostsFlaggedGet: " + e.Message );
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
 **teamId** | **string**| Team ID | [optional] 
 **channelId** | **string**| Channel ID | [optional] 
 **page** | **string**| The page to select | [optional] [default to &quot;0&quot;]
 **perPage** | **string**| The number of posts per page | [optional] [default to &quot;60&quot;]

### Return type

[**List&lt;PostList&gt;**](PostList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Post list retrieval successful |  -  |
| **400** | Invalid or missing parameters in URL or request body |  -  |
| **401** | No access token provided |  -  |
| **403** | Do not have appropriate permissions |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

