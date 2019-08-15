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
    ///  Class for testing BrandApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class BrandApiTests : IDisposable
    {
        private BrandApi instance;

        public BrandApiTests()
        {
            instance = new BrandApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of BrandApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' BrandApi
            //Assert.IsType(typeof(BrandApi), instance, "instance is a BrandApi");
        }

        
        /// <summary>
        /// Test BrandImageDelete
        /// </summary>
        [Fact]
        public void BrandImageDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.BrandImageDelete();
            //Assert.IsType<StatusOK> (response, "response is StatusOK");
        }
        
        /// <summary>
        /// Test BrandImageGet
        /// </summary>
        [Fact]
        public void BrandImageGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.BrandImageGet();
            //Assert.IsType<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test BrandImagePost
        /// </summary>
        [Fact]
        public void BrandImagePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream image = null;
            //var response = instance.BrandImagePost(image);
            //Assert.IsType<StatusOK> (response, "response is StatusOK");
        }
        
    }

}
