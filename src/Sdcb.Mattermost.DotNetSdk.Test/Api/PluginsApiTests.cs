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
    ///  Class for testing PluginsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class PluginsApiTests : IDisposable
    {
        private PluginsApi instance;

        public PluginsApiTests()
        {
            instance = new PluginsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PluginsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PluginsApi
            //Assert.IsType(typeof(PluginsApi), instance, "instance is a PluginsApi");
        }

        
        /// <summary>
        /// Test PluginsGet
        /// </summary>
        [Fact]
        public void PluginsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.PluginsGet();
            //Assert.IsType<InlineResponse2009> (response, "response is InlineResponse2009");
        }
        
        /// <summary>
        /// Test PluginsPluginIdDelete
        /// </summary>
        [Fact]
        public void PluginsPluginIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pluginId = null;
            //var response = instance.PluginsPluginIdDelete(pluginId);
            //Assert.IsType<StatusOK> (response, "response is StatusOK");
        }
        
        /// <summary>
        /// Test PluginsPluginIdDisablePost
        /// </summary>
        [Fact]
        public void PluginsPluginIdDisablePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pluginId = null;
            //var response = instance.PluginsPluginIdDisablePost(pluginId);
            //Assert.IsType<StatusOK> (response, "response is StatusOK");
        }
        
        /// <summary>
        /// Test PluginsPluginIdEnablePost
        /// </summary>
        [Fact]
        public void PluginsPluginIdEnablePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pluginId = null;
            //var response = instance.PluginsPluginIdEnablePost(pluginId);
            //Assert.IsType<StatusOK> (response, "response is StatusOK");
        }
        
        /// <summary>
        /// Test PluginsPost
        /// </summary>
        [Fact]
        public void PluginsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream plugin = null;
            //string force = null;
            //var response = instance.PluginsPost(plugin, force);
            //Assert.IsType<StatusOK> (response, "response is StatusOK");
        }
        
        /// <summary>
        /// Test PluginsWebappGet
        /// </summary>
        [Fact]
        public void PluginsWebappGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.PluginsWebappGet();
            //Assert.IsType<List<PluginManifestWebapp>> (response, "response is List<PluginManifestWebapp>");
        }
        
    }

}