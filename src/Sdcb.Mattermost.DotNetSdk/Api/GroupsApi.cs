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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Sdcb.Mattermost.DotNetSdk.Client;
using Sdcb.Mattermost.DotNetSdk.Model;

namespace Sdcb.Mattermost.DotNetSdk.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IGroupsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get channel groups
        /// </summary>
        /// <remarks>
        /// Retrieve the list of groups associated with a given channel.  ##### Permissions Must have &#x60;manage_system&#x60; permission.  __Minimum server version__: 5.11 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">Channel GUID</param>
        /// <param name="page">The page to select. (optional, default to &quot;0&quot;)</param>
        /// <param name="perPage">The number of groups per page. (optional, default to &quot;60&quot;)</param>
        /// <returns>List&lt;Group&gt;</returns>
        List<Group> ChannelsChannelIdGroupsGet (string channelId, string page = null, string perPage = null);

        /// <summary>
        /// Get channel groups
        /// </summary>
        /// <remarks>
        /// Retrieve the list of groups associated with a given channel.  ##### Permissions Must have &#x60;manage_system&#x60; permission.  __Minimum server version__: 5.11 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">Channel GUID</param>
        /// <param name="page">The page to select. (optional, default to &quot;0&quot;)</param>
        /// <param name="perPage">The number of groups per page. (optional, default to &quot;60&quot;)</param>
        /// <returns>ApiResponse of List&lt;Group&gt;</returns>
        ApiResponse<List<Group>> ChannelsChannelIdGroupsGetWithHttpInfo (string channelId, string page = null, string perPage = null);
        /// <summary>
        /// Get team groups
        /// </summary>
        /// <remarks>
        /// Retrieve the list of groups associated with a given team.  ##### Permissions Must have &#x60;manage_system&#x60; permission.  __Minimum server version__: 5.11 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Team GUID</param>
        /// <param name="page">The page to select. (optional, default to &quot;0&quot;)</param>
        /// <param name="perPage">The number of groups per page. (optional, default to &quot;60&quot;)</param>
        /// <returns>List&lt;Group&gt;</returns>
        List<Group> TeamsTeamIdGroupsGet (string teamId, string page = null, string perPage = null);

        /// <summary>
        /// Get team groups
        /// </summary>
        /// <remarks>
        /// Retrieve the list of groups associated with a given team.  ##### Permissions Must have &#x60;manage_system&#x60; permission.  __Minimum server version__: 5.11 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Team GUID</param>
        /// <param name="page">The page to select. (optional, default to &quot;0&quot;)</param>
        /// <param name="perPage">The number of groups per page. (optional, default to &quot;60&quot;)</param>
        /// <returns>ApiResponse of List&lt;Group&gt;</returns>
        ApiResponse<List<Group>> TeamsTeamIdGroupsGetWithHttpInfo (string teamId, string page = null, string perPage = null);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IGroupsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get channel groups
        /// </summary>
        /// <remarks>
        /// Retrieve the list of groups associated with a given channel.  ##### Permissions Must have &#x60;manage_system&#x60; permission.  __Minimum server version__: 5.11 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">Channel GUID</param>
        /// <param name="page">The page to select. (optional, default to &quot;0&quot;)</param>
        /// <param name="perPage">The number of groups per page. (optional, default to &quot;60&quot;)</param>
        /// <returns>Task of List&lt;Group&gt;</returns>
        System.Threading.Tasks.Task<List<Group>> ChannelsChannelIdGroupsGetAsync (string channelId, string page = null, string perPage = null);

        /// <summary>
        /// Get channel groups
        /// </summary>
        /// <remarks>
        /// Retrieve the list of groups associated with a given channel.  ##### Permissions Must have &#x60;manage_system&#x60; permission.  __Minimum server version__: 5.11 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">Channel GUID</param>
        /// <param name="page">The page to select. (optional, default to &quot;0&quot;)</param>
        /// <param name="perPage">The number of groups per page. (optional, default to &quot;60&quot;)</param>
        /// <returns>Task of ApiResponse (List&lt;Group&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Group>>> ChannelsChannelIdGroupsGetAsyncWithHttpInfo (string channelId, string page = null, string perPage = null);
        /// <summary>
        /// Get team groups
        /// </summary>
        /// <remarks>
        /// Retrieve the list of groups associated with a given team.  ##### Permissions Must have &#x60;manage_system&#x60; permission.  __Minimum server version__: 5.11 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Team GUID</param>
        /// <param name="page">The page to select. (optional, default to &quot;0&quot;)</param>
        /// <param name="perPage">The number of groups per page. (optional, default to &quot;60&quot;)</param>
        /// <returns>Task of List&lt;Group&gt;</returns>
        System.Threading.Tasks.Task<List<Group>> TeamsTeamIdGroupsGetAsync (string teamId, string page = null, string perPage = null);

        /// <summary>
        /// Get team groups
        /// </summary>
        /// <remarks>
        /// Retrieve the list of groups associated with a given team.  ##### Permissions Must have &#x60;manage_system&#x60; permission.  __Minimum server version__: 5.11 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Team GUID</param>
        /// <param name="page">The page to select. (optional, default to &quot;0&quot;)</param>
        /// <param name="perPage">The number of groups per page. (optional, default to &quot;60&quot;)</param>
        /// <returns>Task of ApiResponse (List&lt;Group&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Group>>> TeamsTeamIdGroupsGetAsyncWithHttpInfo (string teamId, string page = null, string perPage = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IGroupsApi : IGroupsApiSync, IGroupsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class GroupsApi : IGroupsApi
    {
        private ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GroupsApi() : this((string) null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GroupsApi(string basePath)
        {
            this.Configuration = Sdcb.Mattermost.DotNetSdk.Client.Configuration.MergeConfigurations(
                Sdcb.Mattermost.DotNetSdk.Client.GlobalConfiguration.Instance,
                new Configuration { BasePath = basePath }
            );
            this.Client = new ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Sdcb.Mattermost.DotNetSdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public GroupsApi(Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Sdcb.Mattermost.DotNetSdk.Client.Configuration.MergeConfigurations(
                Sdcb.Mattermost.DotNetSdk.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Sdcb.Mattermost.DotNetSdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PetApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public GroupsApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
        {
            if(client == null) throw new ArgumentNullException("client");
            if(asyncClient == null) throw new ArgumentNullException("asyncClient");
            if(configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Sdcb.Mattermost.DotNetSdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public IReadableConfiguration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Get channel groups Retrieve the list of groups associated with a given channel.  ##### Permissions Must have &#x60;manage_system&#x60; permission.  __Minimum server version__: 5.11 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">Channel GUID</param>
        /// <param name="page">The page to select. (optional, default to &quot;0&quot;)</param>
        /// <param name="perPage">The number of groups per page. (optional, default to &quot;60&quot;)</param>
        /// <returns>List&lt;Group&gt;</returns>
        public List<Group> ChannelsChannelIdGroupsGet (string channelId, string page = null, string perPage = null)
        {
            ApiResponse<List<Group>> localVarResponse = ChannelsChannelIdGroupsGetWithHttpInfo(channelId, page, perPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get channel groups Retrieve the list of groups associated with a given channel.  ##### Permissions Must have &#x60;manage_system&#x60; permission.  __Minimum server version__: 5.11 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">Channel GUID</param>
        /// <param name="page">The page to select. (optional, default to &quot;0&quot;)</param>
        /// <param name="perPage">The number of groups per page. (optional, default to &quot;60&quot;)</param>
        /// <returns>ApiResponse of List&lt;Group&gt;</returns>
        public ApiResponse<List<Group>> ChannelsChannelIdGroupsGetWithHttpInfo (string channelId, string page = null, string perPage = null)
        {
            // verify the required parameter 'channelId' is set
            if (channelId == null)
                throw new ApiException(400, "Missing required parameter 'channelId' when calling GroupsApi->ChannelsChannelIdGroupsGet");

            var requestOptions = new RequestOptions();

            string[] @contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] @accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Sdcb.Mattermost.DotNetSdk.Client.ClientUtils.SelectHeaderContentType(@contentTypes);
            if (localVarContentType != null) requestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Sdcb.Mattermost.DotNetSdk.Client.ClientUtils.SelectHeaderAccept(@accepts);
            if (localVarAccept != null) requestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (channelId != null)
                requestOptions.PathParameters.Add("channel_id", Sdcb.Mattermost.DotNetSdk.Client.ClientUtils.ParameterToString(channelId)); // path parameter
            if (page != null)
            {
                foreach (var kvp in Sdcb.Mattermost.DotNetSdk.Client.ClientUtils.ParameterToMultiMap("", "page", page))
                {
                    foreach (var value in kvp.Value)
                    {
                        requestOptions.QueryParameters.Add(kvp.Key, value);
                    }
                }
            }
            if (perPage != null)
            {
                foreach (var kvp in Sdcb.Mattermost.DotNetSdk.Client.ClientUtils.ParameterToMultiMap("", "per_page", perPage))
                {
                    foreach (var value in kvp.Value)
                    {
                        requestOptions.QueryParameters.Add(kvp.Key, value);
                    }
                }
            }


            // make the HTTP request

            var response = this.Client.Get< List<Group> >("/channels/{channel_id}/groups", requestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("ChannelsChannelIdGroupsGet", response);
                if (exception != null) throw exception;
            }

            return response;
        }

        /// <summary>
        /// Get channel groups Retrieve the list of groups associated with a given channel.  ##### Permissions Must have &#x60;manage_system&#x60; permission.  __Minimum server version__: 5.11 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">Channel GUID</param>
        /// <param name="page">The page to select. (optional, default to &quot;0&quot;)</param>
        /// <param name="perPage">The number of groups per page. (optional, default to &quot;60&quot;)</param>
        /// <returns>Task of List&lt;Group&gt;</returns>
        public async System.Threading.Tasks.Task<List<Group>> ChannelsChannelIdGroupsGetAsync (string channelId, string page = null, string perPage = null)
        {
            ApiResponse<List<Group>> localVarResponse = await ChannelsChannelIdGroupsGetAsyncWithHttpInfo(channelId, page, perPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get channel groups Retrieve the list of groups associated with a given channel.  ##### Permissions Must have &#x60;manage_system&#x60; permission.  __Minimum server version__: 5.11 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">Channel GUID</param>
        /// <param name="page">The page to select. (optional, default to &quot;0&quot;)</param>
        /// <param name="perPage">The number of groups per page. (optional, default to &quot;60&quot;)</param>
        /// <returns>Task of ApiResponse (List&lt;Group&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Group>>> ChannelsChannelIdGroupsGetAsyncWithHttpInfo (string channelId, string page = null, string perPage = null)
        {
            // verify the required parameter 'channelId' is set
            if (channelId == null)
                throw new ApiException(400, "Missing required parameter 'channelId' when calling GroupsApi->ChannelsChannelIdGroupsGet");


            var requestOptions = new RequestOptions();

            string[] @contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] @accepts = new string[] {
                "application/json"
            };
            
            foreach (var contentType in @contentTypes)
                requestOptions.HeaderParameters.Add("Content-Type", contentType);
            
            foreach (var accept in @accepts)
                requestOptions.HeaderParameters.Add("Accept", accept);
            
            if (channelId != null)
                requestOptions.PathParameters.Add("channel_id", Sdcb.Mattermost.DotNetSdk.Client.ClientUtils.ParameterToString(channelId)); // path parameter
            if (page != null)
            {
                foreach (var kvp in Sdcb.Mattermost.DotNetSdk.Client.ClientUtils.ParameterToMultiMap("", "page", page))
                {
                    foreach (var value in kvp.Value)
                    {
                        requestOptions.QueryParameters.Add(kvp.Key, value);
                    }
                }
            }
            if (perPage != null)
            {
                foreach (var kvp in Sdcb.Mattermost.DotNetSdk.Client.ClientUtils.ParameterToMultiMap("", "per_page", perPage))
                {
                    foreach (var value in kvp.Value)
                    {
                        requestOptions.QueryParameters.Add(kvp.Key, value);
                    }
                }
            }


            // make the HTTP request

            var response = await this.AsynchronousClient.GetAsync<List<Group>>("/channels/{channel_id}/groups", requestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("ChannelsChannelIdGroupsGet", response);
                if (exception != null) throw exception;
            }

            return response;
        }

        /// <summary>
        /// Get team groups Retrieve the list of groups associated with a given team.  ##### Permissions Must have &#x60;manage_system&#x60; permission.  __Minimum server version__: 5.11 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Team GUID</param>
        /// <param name="page">The page to select. (optional, default to &quot;0&quot;)</param>
        /// <param name="perPage">The number of groups per page. (optional, default to &quot;60&quot;)</param>
        /// <returns>List&lt;Group&gt;</returns>
        public List<Group> TeamsTeamIdGroupsGet (string teamId, string page = null, string perPage = null)
        {
            ApiResponse<List<Group>> localVarResponse = TeamsTeamIdGroupsGetWithHttpInfo(teamId, page, perPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get team groups Retrieve the list of groups associated with a given team.  ##### Permissions Must have &#x60;manage_system&#x60; permission.  __Minimum server version__: 5.11 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Team GUID</param>
        /// <param name="page">The page to select. (optional, default to &quot;0&quot;)</param>
        /// <param name="perPage">The number of groups per page. (optional, default to &quot;60&quot;)</param>
        /// <returns>ApiResponse of List&lt;Group&gt;</returns>
        public ApiResponse<List<Group>> TeamsTeamIdGroupsGetWithHttpInfo (string teamId, string page = null, string perPage = null)
        {
            // verify the required parameter 'teamId' is set
            if (teamId == null)
                throw new ApiException(400, "Missing required parameter 'teamId' when calling GroupsApi->TeamsTeamIdGroupsGet");

            var requestOptions = new RequestOptions();

            string[] @contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] @accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Sdcb.Mattermost.DotNetSdk.Client.ClientUtils.SelectHeaderContentType(@contentTypes);
            if (localVarContentType != null) requestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Sdcb.Mattermost.DotNetSdk.Client.ClientUtils.SelectHeaderAccept(@accepts);
            if (localVarAccept != null) requestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (teamId != null)
                requestOptions.PathParameters.Add("team_id", Sdcb.Mattermost.DotNetSdk.Client.ClientUtils.ParameterToString(teamId)); // path parameter
            if (page != null)
            {
                foreach (var kvp in Sdcb.Mattermost.DotNetSdk.Client.ClientUtils.ParameterToMultiMap("", "page", page))
                {
                    foreach (var value in kvp.Value)
                    {
                        requestOptions.QueryParameters.Add(kvp.Key, value);
                    }
                }
            }
            if (perPage != null)
            {
                foreach (var kvp in Sdcb.Mattermost.DotNetSdk.Client.ClientUtils.ParameterToMultiMap("", "per_page", perPage))
                {
                    foreach (var value in kvp.Value)
                    {
                        requestOptions.QueryParameters.Add(kvp.Key, value);
                    }
                }
            }


            // make the HTTP request

            var response = this.Client.Get< List<Group> >("/teams/{team_id}/groups", requestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("TeamsTeamIdGroupsGet", response);
                if (exception != null) throw exception;
            }

            return response;
        }

        /// <summary>
        /// Get team groups Retrieve the list of groups associated with a given team.  ##### Permissions Must have &#x60;manage_system&#x60; permission.  __Minimum server version__: 5.11 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Team GUID</param>
        /// <param name="page">The page to select. (optional, default to &quot;0&quot;)</param>
        /// <param name="perPage">The number of groups per page. (optional, default to &quot;60&quot;)</param>
        /// <returns>Task of List&lt;Group&gt;</returns>
        public async System.Threading.Tasks.Task<List<Group>> TeamsTeamIdGroupsGetAsync (string teamId, string page = null, string perPage = null)
        {
            ApiResponse<List<Group>> localVarResponse = await TeamsTeamIdGroupsGetAsyncWithHttpInfo(teamId, page, perPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get team groups Retrieve the list of groups associated with a given team.  ##### Permissions Must have &#x60;manage_system&#x60; permission.  __Minimum server version__: 5.11 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Team GUID</param>
        /// <param name="page">The page to select. (optional, default to &quot;0&quot;)</param>
        /// <param name="perPage">The number of groups per page. (optional, default to &quot;60&quot;)</param>
        /// <returns>Task of ApiResponse (List&lt;Group&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Group>>> TeamsTeamIdGroupsGetAsyncWithHttpInfo (string teamId, string page = null, string perPage = null)
        {
            // verify the required parameter 'teamId' is set
            if (teamId == null)
                throw new ApiException(400, "Missing required parameter 'teamId' when calling GroupsApi->TeamsTeamIdGroupsGet");


            var requestOptions = new RequestOptions();

            string[] @contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] @accepts = new string[] {
                "application/json"
            };
            
            foreach (var contentType in @contentTypes)
                requestOptions.HeaderParameters.Add("Content-Type", contentType);
            
            foreach (var accept in @accepts)
                requestOptions.HeaderParameters.Add("Accept", accept);
            
            if (teamId != null)
                requestOptions.PathParameters.Add("team_id", Sdcb.Mattermost.DotNetSdk.Client.ClientUtils.ParameterToString(teamId)); // path parameter
            if (page != null)
            {
                foreach (var kvp in Sdcb.Mattermost.DotNetSdk.Client.ClientUtils.ParameterToMultiMap("", "page", page))
                {
                    foreach (var value in kvp.Value)
                    {
                        requestOptions.QueryParameters.Add(kvp.Key, value);
                    }
                }
            }
            if (perPage != null)
            {
                foreach (var kvp in Sdcb.Mattermost.DotNetSdk.Client.ClientUtils.ParameterToMultiMap("", "per_page", perPage))
                {
                    foreach (var value in kvp.Value)
                    {
                        requestOptions.QueryParameters.Add(kvp.Key, value);
                    }
                }
            }


            // make the HTTP request

            var response = await this.AsynchronousClient.GetAsync<List<Group>>("/teams/{team_id}/groups", requestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("TeamsTeamIdGroupsGet", response);
                if (exception != null) throw exception;
            }

            return response;
        }

    }
}
