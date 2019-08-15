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
    ///  Class for testing JobsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class JobsApiTests : IDisposable
    {
        private JobsApi instance;

        public JobsApiTests()
        {
            instance = new JobsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of JobsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' JobsApi
            //Assert.IsType(typeof(JobsApi), instance, "instance is a JobsApi");
        }

        
        /// <summary>
        /// Test JobsGet
        /// </summary>
        [Fact]
        public void JobsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string page = null;
            //string perPage = null;
            //var response = instance.JobsGet(page, perPage);
            //Assert.IsType<List<Job>> (response, "response is List<Job>");
        }
        
        /// <summary>
        /// Test JobsJobIdCancelPost
        /// </summary>
        [Fact]
        public void JobsJobIdCancelPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string jobId = null;
            //var response = instance.JobsJobIdCancelPost(jobId);
            //Assert.IsType<StatusOK> (response, "response is StatusOK");
        }
        
        /// <summary>
        /// Test JobsJobIdGet
        /// </summary>
        [Fact]
        public void JobsJobIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string jobId = null;
            //var response = instance.JobsJobIdGet(jobId);
            //Assert.IsType<Job> (response, "response is Job");
        }
        
        /// <summary>
        /// Test JobsPost
        /// </summary>
        [Fact]
        public void JobsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //InlineObject46 body = null;
            //var response = instance.JobsPost(body);
            //Assert.IsType<Job> (response, "response is Job");
        }
        
        /// <summary>
        /// Test JobsTypeTypeGet
        /// </summary>
        [Fact]
        public void JobsTypeTypeGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string type = null;
            //string page = null;
            //string perPage = null;
            //var response = instance.JobsTypeTypeGet(type, page, perPage);
            //Assert.IsType<List<Job>> (response, "response is List<Job>");
        }
        
    }

}