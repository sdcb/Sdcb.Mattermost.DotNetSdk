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
    ///  Class for testing DataretentionApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DataretentionApiTests : IDisposable
    {
        private DataretentionApi instance;

        public DataretentionApiTests()
        {
            instance = new DataretentionApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DataretentionApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' DataretentionApi
            //Assert.IsType(typeof(DataretentionApi), instance, "instance is a DataretentionApi");
        }

        
        /// <summary>
        /// Test DataRetentionPolicyGet
        /// </summary>
        [Fact]
        public void DataRetentionPolicyGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.DataRetentionPolicyGet();
            //Assert.IsType<DataRetentionPolicy> (response, "response is DataRetentionPolicy");
        }
        
    }

}
