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
    ///  Class for testing EmojiApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class EmojiApiTests : IDisposable
    {
        private EmojiApi instance;

        public EmojiApiTests()
        {
            instance = new EmojiApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of EmojiApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' EmojiApi
            //Assert.IsType(typeof(EmojiApi), instance, "instance is a EmojiApi");
        }

        
        /// <summary>
        /// Test EmojiAutocompleteGet
        /// </summary>
        [Fact]
        public void EmojiAutocompleteGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //var response = instance.EmojiAutocompleteGet(name);
            //Assert.IsType<Emoji> (response, "response is Emoji");
        }
        
        /// <summary>
        /// Test EmojiEmojiIdDelete
        /// </summary>
        [Fact]
        public void EmojiEmojiIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string emojiId = null;
            //var response = instance.EmojiEmojiIdDelete(emojiId);
            //Assert.IsType<Emoji> (response, "response is Emoji");
        }
        
        /// <summary>
        /// Test EmojiEmojiIdGet
        /// </summary>
        [Fact]
        public void EmojiEmojiIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string emojiId = null;
            //var response = instance.EmojiEmojiIdGet(emojiId);
            //Assert.IsType<Emoji> (response, "response is Emoji");
        }
        
        /// <summary>
        /// Test EmojiEmojiIdImageGet
        /// </summary>
        [Fact]
        public void EmojiEmojiIdImageGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string emojiId = null;
            //instance.EmojiEmojiIdImageGet(emojiId);
            
        }
        
        /// <summary>
        /// Test EmojiGet
        /// </summary>
        [Fact]
        public void EmojiGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string page = null;
            //string perPage = null;
            //string sort = null;
            //var response = instance.EmojiGet(page, perPage, sort);
            //Assert.IsType<Emoji> (response, "response is Emoji");
        }
        
        /// <summary>
        /// Test EmojiNameEmojiNameGet
        /// </summary>
        [Fact]
        public void EmojiNameEmojiNameGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string emojiName = null;
            //var response = instance.EmojiNameEmojiNameGet(emojiName);
            //Assert.IsType<Emoji> (response, "response is Emoji");
        }
        
        /// <summary>
        /// Test EmojiPost
        /// </summary>
        [Fact]
        public void EmojiPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream image = null;
            //string emoji = null;
            //var response = instance.EmojiPost(image, emoji);
            //Assert.IsType<Emoji> (response, "response is Emoji");
        }
        
        /// <summary>
        /// Test EmojiSearchPost
        /// </summary>
        [Fact]
        public void EmojiSearchPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //InlineObject48 body = null;
            //var response = instance.EmojiSearchPost(body);
            //Assert.IsType<List<Emoji>> (response, "response is List<Emoji>");
        }
        
    }

}
