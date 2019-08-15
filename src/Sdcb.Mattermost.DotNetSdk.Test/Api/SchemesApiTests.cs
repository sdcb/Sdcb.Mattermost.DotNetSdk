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
    ///  Class for testing SchemesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SchemesApiTests : IDisposable
    {
        private SchemesApi instance;

        public SchemesApiTests()
        {
            instance = new SchemesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SchemesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' SchemesApi
            //Assert.IsType(typeof(SchemesApi), instance, "instance is a SchemesApi");
        }

        
        /// <summary>
        /// Test SchemesGet
        /// </summary>
        [Fact]
        public void SchemesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string scope = null;
            //string page = null;
            //string perPage = null;
            //var response = instance.SchemesGet(scope, page, perPage);
            //Assert.IsType<List<Scheme>> (response, "response is List<Scheme>");
        }
        
        /// <summary>
        /// Test SchemesPost
        /// </summary>
        [Fact]
        public void SchemesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //InlineObject58 scheme = null;
            //var response = instance.SchemesPost(scheme);
            //Assert.IsType<Scheme> (response, "response is Scheme");
        }
        
        /// <summary>
        /// Test SchemesSchemeIdChannelsGet
        /// </summary>
        [Fact]
        public void SchemesSchemeIdChannelsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string schemeId = null;
            //string page = null;
            //string perPage = null;
            //var response = instance.SchemesSchemeIdChannelsGet(schemeId, page, perPage);
            //Assert.IsType<List<Channel>> (response, "response is List<Channel>");
        }
        
        /// <summary>
        /// Test SchemesSchemeIdDelete
        /// </summary>
        [Fact]
        public void SchemesSchemeIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string schemeId = null;
            //var response = instance.SchemesSchemeIdDelete(schemeId);
            //Assert.IsType<StatusOK> (response, "response is StatusOK");
        }
        
        /// <summary>
        /// Test SchemesSchemeIdGet
        /// </summary>
        [Fact]
        public void SchemesSchemeIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string schemeId = null;
            //var response = instance.SchemesSchemeIdGet(schemeId);
            //Assert.IsType<Scheme> (response, "response is Scheme");
        }
        
        /// <summary>
        /// Test SchemesSchemeIdPatchPut
        /// </summary>
        [Fact]
        public void SchemesSchemeIdPatchPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string schemeId = null;
            //InlineObject59 body = null;
            //var response = instance.SchemesSchemeIdPatchPut(schemeId, body);
            //Assert.IsType<Scheme> (response, "response is Scheme");
        }
        
        /// <summary>
        /// Test SchemesSchemeIdTeamsGet
        /// </summary>
        [Fact]
        public void SchemesSchemeIdTeamsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string schemeId = null;
            //string page = null;
            //string perPage = null;
            //var response = instance.SchemesSchemeIdTeamsGet(schemeId, page, perPage);
            //Assert.IsType<List<Team>> (response, "response is List<Team>");
        }
        
    }

}
