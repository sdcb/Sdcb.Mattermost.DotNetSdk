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
    ///  Class for testing TeamsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TeamsApiTests : IDisposable
    {
        private TeamsApi instance;

        public TeamsApiTests()
        {
            instance = new TeamsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TeamsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' TeamsApi
            //Assert.IsType(typeof(TeamsApi), instance, "instance is a TeamsApi");
        }

        
        /// <summary>
        /// Test TeamsGet
        /// </summary>
        [Fact]
        public void TeamsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string page = null;
            //string perPage = null;
            //var response = instance.TeamsGet(page, perPage);
            //Assert.IsType<List<Team>> (response, "response is List<Team>");
        }
        
        /// <summary>
        /// Test TeamsInviteInviteIdGet
        /// </summary>
        [Fact]
        public void TeamsInviteInviteIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string inviteId = null;
            //var response = instance.TeamsInviteInviteIdGet(inviteId);
            //Assert.IsType<InlineResponse2005> (response, "response is InlineResponse2005");
        }
        
        /// <summary>
        /// Test TeamsInvitesEmailDelete
        /// </summary>
        [Fact]
        public void TeamsInvitesEmailDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.TeamsInvitesEmailDelete();
            //Assert.IsType<StatusOK> (response, "response is StatusOK");
        }
        
        /// <summary>
        /// Test TeamsMembersInvitePost
        /// </summary>
        [Fact]
        public void TeamsMembersInvitePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string token = null;
            //var response = instance.TeamsMembersInvitePost(token);
            //Assert.IsType<TeamMember> (response, "response is TeamMember");
        }
        
        /// <summary>
        /// Test TeamsNameNameExistsGet
        /// </summary>
        [Fact]
        public void TeamsNameNameExistsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //var response = instance.TeamsNameNameExistsGet(name);
            //Assert.IsType<TeamExists> (response, "response is TeamExists");
        }
        
        /// <summary>
        /// Test TeamsNameNameGet
        /// </summary>
        [Fact]
        public void TeamsNameNameGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //var response = instance.TeamsNameNameGet(name);
            //Assert.IsType<Team> (response, "response is Team");
        }
        
        /// <summary>
        /// Test TeamsPost
        /// </summary>
        [Fact]
        public void TeamsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //InlineObject23 body = null;
            //var response = instance.TeamsPost(body);
            //Assert.IsType<Team> (response, "response is Team");
        }
        
        /// <summary>
        /// Test TeamsSearchPost
        /// </summary>
        [Fact]
        public void TeamsSearchPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //InlineObject26 body = null;
            //var response = instance.TeamsSearchPost(body);
            //Assert.IsType<List<Team>> (response, "response is List<Team>");
        }
        
        /// <summary>
        /// Test TeamsTeamIdDelete
        /// </summary>
        [Fact]
        public void TeamsTeamIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamId = null;
            //bool? permanent = null;
            //var response = instance.TeamsTeamIdDelete(teamId, permanent);
            //Assert.IsType<StatusOK> (response, "response is StatusOK");
        }
        
        /// <summary>
        /// Test TeamsTeamIdGet
        /// </summary>
        [Fact]
        public void TeamsTeamIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamId = null;
            //var response = instance.TeamsTeamIdGet(teamId);
            //Assert.IsType<Team> (response, "response is Team");
        }
        
        /// <summary>
        /// Test TeamsTeamIdImageDelete
        /// </summary>
        [Fact]
        public void TeamsTeamIdImageDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamId = null;
            //var response = instance.TeamsTeamIdImageDelete(teamId);
            //Assert.IsType<StatusOK> (response, "response is StatusOK");
        }
        
        /// <summary>
        /// Test TeamsTeamIdImageGet
        /// </summary>
        [Fact]
        public void TeamsTeamIdImageGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamId = null;
            //instance.TeamsTeamIdImageGet(teamId);
            
        }
        
        /// <summary>
        /// Test TeamsTeamIdImagePost
        /// </summary>
        [Fact]
        public void TeamsTeamIdImagePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamId = null;
            //System.IO.Stream image = null;
            //var response = instance.TeamsTeamIdImagePost(teamId, image);
            //Assert.IsType<StatusOK> (response, "response is StatusOK");
        }
        
        /// <summary>
        /// Test TeamsTeamIdImportPost
        /// </summary>
        [Fact]
        public void TeamsTeamIdImportPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamId = null;
            //System.IO.Stream file = null;
            //int filesize = null;
            //string importFrom = null;
            //var response = instance.TeamsTeamIdImportPost(teamId, file, filesize, importFrom);
            //Assert.IsType<InlineResponse2004> (response, "response is InlineResponse2004");
        }
        
        /// <summary>
        /// Test TeamsTeamIdInviteEmailPost
        /// </summary>
        [Fact]
        public void TeamsTeamIdInviteEmailPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamId = null;
            //List<string> body = null;
            //var response = instance.TeamsTeamIdInviteEmailPost(teamId, body);
            //Assert.IsType<StatusOK> (response, "response is StatusOK");
        }
        
        /// <summary>
        /// Test TeamsTeamIdMembersBatchPost
        /// </summary>
        [Fact]
        public void TeamsTeamIdMembersBatchPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamId = null;
            //List<TeamMember> body = null;
            //var response = instance.TeamsTeamIdMembersBatchPost(teamId, body);
            //Assert.IsType<List<TeamMember>> (response, "response is List<TeamMember>");
        }
        
        /// <summary>
        /// Test TeamsTeamIdMembersGet
        /// </summary>
        [Fact]
        public void TeamsTeamIdMembersGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamId = null;
            //string page = null;
            //string perPage = null;
            //var response = instance.TeamsTeamIdMembersGet(teamId, page, perPage);
            //Assert.IsType<List<TeamMember>> (response, "response is List<TeamMember>");
        }
        
        /// <summary>
        /// Test TeamsTeamIdMembersIdsPost
        /// </summary>
        [Fact]
        public void TeamsTeamIdMembersIdsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamId = null;
            //List<string> body = null;
            //var response = instance.TeamsTeamIdMembersIdsPost(teamId, body);
            //Assert.IsType<List<TeamMember>> (response, "response is List<TeamMember>");
        }
        
        /// <summary>
        /// Test TeamsTeamIdMembersMinusGroupMembersGet
        /// </summary>
        [Fact]
        public void TeamsTeamIdMembersMinusGroupMembersGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamId = null;
            //string groupIds = null;
            //string page = null;
            //string perPage = null;
            //instance.TeamsTeamIdMembersMinusGroupMembersGet(teamId, groupIds, page, perPage);
            
        }
        
        /// <summary>
        /// Test TeamsTeamIdMembersPost
        /// </summary>
        [Fact]
        public void TeamsTeamIdMembersPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamId = null;
            //InlineObject27 body = null;
            //var response = instance.TeamsTeamIdMembersPost(teamId, body);
            //Assert.IsType<TeamMember> (response, "response is TeamMember");
        }
        
        /// <summary>
        /// Test TeamsTeamIdMembersUserIdDelete
        /// </summary>
        [Fact]
        public void TeamsTeamIdMembersUserIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamId = null;
            //string userId = null;
            //var response = instance.TeamsTeamIdMembersUserIdDelete(teamId, userId);
            //Assert.IsType<StatusOK> (response, "response is StatusOK");
        }
        
        /// <summary>
        /// Test TeamsTeamIdMembersUserIdGet
        /// </summary>
        [Fact]
        public void TeamsTeamIdMembersUserIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamId = null;
            //string userId = null;
            //var response = instance.TeamsTeamIdMembersUserIdGet(teamId, userId);
            //Assert.IsType<TeamMember> (response, "response is TeamMember");
        }
        
        /// <summary>
        /// Test TeamsTeamIdMembersUserIdRolesPut
        /// </summary>
        [Fact]
        public void TeamsTeamIdMembersUserIdRolesPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamId = null;
            //string userId = null;
            //InlineObject28 body = null;
            //var response = instance.TeamsTeamIdMembersUserIdRolesPut(teamId, userId, body);
            //Assert.IsType<StatusOK> (response, "response is StatusOK");
        }
        
        /// <summary>
        /// Test TeamsTeamIdMembersUserIdSchemeRolesPut
        /// </summary>
        [Fact]
        public void TeamsTeamIdMembersUserIdSchemeRolesPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamId = null;
            //string userId = null;
            //InlineObject29 body = null;
            //var response = instance.TeamsTeamIdMembersUserIdSchemeRolesPut(teamId, userId, body);
            //Assert.IsType<StatusOK> (response, "response is StatusOK");
        }
        
        /// <summary>
        /// Test TeamsTeamIdPatchPut
        /// </summary>
        [Fact]
        public void TeamsTeamIdPatchPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamId = null;
            //InlineObject25 body = null;
            //var response = instance.TeamsTeamIdPatchPut(teamId, body);
            //Assert.IsType<Team> (response, "response is Team");
        }
        
        /// <summary>
        /// Test TeamsTeamIdPut
        /// </summary>
        [Fact]
        public void TeamsTeamIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamId = null;
            //InlineObject24 body = null;
            //var response = instance.TeamsTeamIdPut(teamId, body);
            //Assert.IsType<Team> (response, "response is Team");
        }
        
        /// <summary>
        /// Test TeamsTeamIdRegenerateInviteIdPost
        /// </summary>
        [Fact]
        public void TeamsTeamIdRegenerateInviteIdPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamId = null;
            //var response = instance.TeamsTeamIdRegenerateInviteIdPost(teamId);
            //Assert.IsType<Team> (response, "response is Team");
        }
        
        /// <summary>
        /// Test TeamsTeamIdSchemePut
        /// </summary>
        [Fact]
        public void TeamsTeamIdSchemePutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamId = null;
            //InlineObject30 body = null;
            //var response = instance.TeamsTeamIdSchemePut(teamId, body);
            //Assert.IsType<StatusOK> (response, "response is StatusOK");
        }
        
        /// <summary>
        /// Test TeamsTeamIdStatsGet
        /// </summary>
        [Fact]
        public void TeamsTeamIdStatsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamId = null;
            //var response = instance.TeamsTeamIdStatsGet(teamId);
            //Assert.IsType<TeamStats> (response, "response is TeamStats");
        }
        
        /// <summary>
        /// Test UsersUserIdTeamsGet
        /// </summary>
        [Fact]
        public void UsersUserIdTeamsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userId = null;
            //var response = instance.UsersUserIdTeamsGet(userId);
            //Assert.IsType<List<Team>> (response, "response is List<Team>");
        }
        
        /// <summary>
        /// Test UsersUserIdTeamsMembersGet
        /// </summary>
        [Fact]
        public void UsersUserIdTeamsMembersGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userId = null;
            //var response = instance.UsersUserIdTeamsMembersGet(userId);
            //Assert.IsType<List<TeamMember>> (response, "response is List<TeamMember>");
        }
        
        /// <summary>
        /// Test UsersUserIdTeamsTeamIdUnreadGet
        /// </summary>
        [Fact]
        public void UsersUserIdTeamsTeamIdUnreadGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userId = null;
            //string teamId = null;
            //var response = instance.UsersUserIdTeamsTeamIdUnreadGet(userId, teamId);
            //Assert.IsType<TeamUnread> (response, "response is TeamUnread");
        }
        
        /// <summary>
        /// Test UsersUserIdTeamsUnreadGet
        /// </summary>
        [Fact]
        public void UsersUserIdTeamsUnreadGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userId = null;
            //string excludeTeam = null;
            //var response = instance.UsersUserIdTeamsUnreadGet(userId, excludeTeam);
            //Assert.IsType<List<TeamUnread>> (response, "response is List<TeamUnread>");
        }
        
    }

}
