/* 
 * Mattermost API Reference
 *
 * There is also a work-in-progress [Postman API reference](https://documenter.getpostman.com/view/4508214/RW8FERUn). 
 *
 * The version of the OpenAPI document: 4.0.0
 * Contact: feedback@mattermost.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Api;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Sdcb.Mattermost.DotNetSdk.Test
{
    /// <summary>
    ///  Class for testing ReactionsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ReactionsApiTests : IDisposable
    {
        private ReactionsApi instance;

        public ReactionsApiTests()
        {
            instance = new ReactionsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ReactionsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ReactionsApi
            //Assert.IsType(typeof(ReactionsApi), instance, "instance is a ReactionsApi");
        }

        
        /// <summary>
        /// Test PostsIdsReactionsPost
        /// </summary>
        [Fact]
        public void PostsIdsReactionsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string> postIds = null;
            //var response = instance.PostsIdsReactionsPost(postIds);
            //Assert.IsType<Dictionary<string, List<Reaction>>> (response, "response is Dictionary<string, List<Reaction>>");
        }
        
        /// <summary>
        /// Test PostsPostIdReactionsGet
        /// </summary>
        [Fact]
        public void PostsPostIdReactionsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string postId = null;
            //var response = instance.PostsPostIdReactionsGet(postId);
            //Assert.IsType<List<Reaction>> (response, "response is List<Reaction>");
        }
        
        /// <summary>
        /// Test ReactionsPost
        /// </summary>
        [Fact]
        public void ReactionsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Reaction reaction = null;
            //var response = instance.ReactionsPost(reaction);
            //Assert.IsType<Reaction> (response, "response is Reaction");
        }
        
        /// <summary>
        /// Test UsersUserIdPostsPostIdReactionsEmojiNameDelete
        /// </summary>
        [Fact]
        public void UsersUserIdPostsPostIdReactionsEmojiNameDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userId = null;
            //string postId = null;
            //string emojiName = null;
            //var response = instance.UsersUserIdPostsPostIdReactionsEmojiNameDelete(userId, postId, emojiName);
            //Assert.IsType<StatusOK> (response, "response is StatusOK");
        }
        
    }

}
