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
    ///  Class for testing LDAPApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class LDAPApiTests : IDisposable
    {
        private LDAPApi instance;

        public LDAPApiTests()
        {
            instance = new LDAPApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of LDAPApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' LDAPApi
            //Assert.IsType(typeof(LDAPApi), instance, "instance is a LDAPApi");
        }

        
        /// <summary>
        /// Test LdapSyncPost
        /// </summary>
        [Fact]
        public void LdapSyncPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.LdapSyncPost();
            //Assert.IsType<StatusOK> (response, "response is StatusOK");
        }
        
        /// <summary>
        /// Test LdapTestPost
        /// </summary>
        [Fact]
        public void LdapTestPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.LdapTestPost();
            //Assert.IsType<StatusOK> (response, "response is StatusOK");
        }
        
    }

}