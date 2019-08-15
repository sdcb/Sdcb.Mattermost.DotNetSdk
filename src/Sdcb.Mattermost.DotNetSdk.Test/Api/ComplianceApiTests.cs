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
    ///  Class for testing ComplianceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ComplianceApiTests : IDisposable
    {
        private ComplianceApi instance;

        public ComplianceApiTests()
        {
            instance = new ComplianceApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ComplianceApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ComplianceApi
            //Assert.IsType(typeof(ComplianceApi), instance, "instance is a ComplianceApi");
        }

        
        /// <summary>
        /// Test ComplianceReportsGet
        /// </summary>
        [Fact]
        public void ComplianceReportsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string page = null;
            //string perPage = null;
            //var response = instance.ComplianceReportsGet(page, perPage);
            //Assert.IsType<List<Compliance>> (response, "response is List<Compliance>");
        }
        
        /// <summary>
        /// Test ComplianceReportsPost
        /// </summary>
        [Fact]
        public void ComplianceReportsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ComplianceReportsPost();
            //Assert.IsType<Compliance> (response, "response is Compliance");
        }
        
        /// <summary>
        /// Test ComplianceReportsReportIdDownloadGet
        /// </summary>
        [Fact]
        public void ComplianceReportsReportIdDownloadGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string reportId = null;
            //instance.ComplianceReportsReportIdDownloadGet(reportId);
            
        }
        
        /// <summary>
        /// Test ComplianceReportsReportIdGet
        /// </summary>
        [Fact]
        public void ComplianceReportsReportIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string reportId = null;
            //var response = instance.ComplianceReportsReportIdGet(reportId);
            //Assert.IsType<Compliance> (response, "response is Compliance");
        }
        
    }

}