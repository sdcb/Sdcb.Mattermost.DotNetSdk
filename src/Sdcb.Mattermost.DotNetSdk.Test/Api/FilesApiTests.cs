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
    ///  Class for testing FilesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class FilesApiTests : IDisposable
    {
        private FilesApi instance;

        public FilesApiTests()
        {
            instance = new FilesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of FilesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' FilesApi
            //Assert.IsType(typeof(FilesApi), instance, "instance is a FilesApi");
        }

        
        /// <summary>
        /// Test FilesFileIdGet
        /// </summary>
        [Fact]
        public void FilesFileIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string fileId = null;
            //instance.FilesFileIdGet(fileId);
            
        }
        
        /// <summary>
        /// Test FilesFileIdInfoGet
        /// </summary>
        [Fact]
        public void FilesFileIdInfoGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string fileId = null;
            //var response = instance.FilesFileIdInfoGet(fileId);
            //Assert.IsType<FileInfo> (response, "response is FileInfo");
        }
        
        /// <summary>
        /// Test FilesFileIdLinkGet
        /// </summary>
        [Fact]
        public void FilesFileIdLinkGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string fileId = null;
            //var response = instance.FilesFileIdLinkGet(fileId);
            //Assert.IsType<InlineResponse2007> (response, "response is InlineResponse2007");
        }
        
        /// <summary>
        /// Test FilesFileIdPreviewGet
        /// </summary>
        [Fact]
        public void FilesFileIdPreviewGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string fileId = null;
            //instance.FilesFileIdPreviewGet(fileId);
            
        }
        
        /// <summary>
        /// Test FilesFileIdThumbnailGet
        /// </summary>
        [Fact]
        public void FilesFileIdThumbnailGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string fileId = null;
            //instance.FilesFileIdThumbnailGet(fileId);
            
        }
        
        /// <summary>
        /// Test FilesPost
        /// </summary>
        [Fact]
        public void FilesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string channelId = null;
            //string filename = null;
            //System.IO.Stream files = null;
            //string channelId = null;
            //string clientIds = null;
            //var response = instance.FilesPost(channelId, filename, files, channelId, clientIds);
            //Assert.IsType<InlineResponse201> (response, "response is InlineResponse201");
        }
        
    }

}
