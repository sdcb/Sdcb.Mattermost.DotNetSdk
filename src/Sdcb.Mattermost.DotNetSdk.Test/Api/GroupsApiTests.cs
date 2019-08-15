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
    ///  Class for testing GroupsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class GroupsApiTests : IDisposable
    {
        private GroupsApi instance;

        public GroupsApiTests()
        {
            instance = new GroupsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of GroupsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' GroupsApi
            //Assert.IsType(typeof(GroupsApi), instance, "instance is a GroupsApi");
        }

        
        /// <summary>
        /// Test ChannelsChannelIdGroupsGet
        /// </summary>
        [Fact]
        public void ChannelsChannelIdGroupsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string channelId = null;
            //string page = null;
            //string perPage = null;
            //var response = instance.ChannelsChannelIdGroupsGet(channelId, page, perPage);
            //Assert.IsType<List<Group>> (response, "response is List<Group>");
        }
        
        /// <summary>
        /// Test TeamsTeamIdGroupsGet
        /// </summary>
        [Fact]
        public void TeamsTeamIdGroupsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamId = null;
            //string page = null;
            //string perPage = null;
            //var response = instance.TeamsTeamIdGroupsGet(teamId, page, perPage);
            //Assert.IsType<List<Group>> (response, "response is List<Group>");
        }
        
    }

}
