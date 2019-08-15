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
    public interface IElasticsearchApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Purge all Elasticsearch indexes
        /// </summary>
        /// <remarks>
        /// Deletes all Elasticsearch indexes and their contents. After calling this endpoint, it is necessary to schedule a new Elasticsearch indexing job to repopulate the indexes. __Minimum server version__: 4.1 ##### Permissions Must have &#x60;manage_system&#x60; permission. 
        /// </remarks>
        /// <exception cref="Sdcb.Mattermost.DotNetSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>StatusOK</returns>
        StatusOK ElasticsearchPurgeIndexesPost ();

        /// <summary>
        /// Purge all Elasticsearch indexes
        /// </summary>
        /// <remarks>
        /// Deletes all Elasticsearch indexes and their contents. After calling this endpoint, it is necessary to schedule a new Elasticsearch indexing job to repopulate the indexes. __Minimum server version__: 4.1 ##### Permissions Must have &#x60;manage_system&#x60; permission. 
        /// </remarks>
        /// <exception cref="Sdcb.Mattermost.DotNetSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of StatusOK</returns>
        ApiResponse<StatusOK> ElasticsearchPurgeIndexesPostWithHttpInfo ();
        /// <summary>
        /// Test Elasticsearch configuration
        /// </summary>
        /// <remarks>
        /// Test the current Elasticsearch configuration to see if the Elasticsearch server can be contacted successfully. Optionally provide a configuration in the request body to test. If no valid configuration is present in the request body the current server configuration will be tested.  __Minimum server version__: 4.1 ##### Permissions Must have &#x60;manage_system&#x60; permission. 
        /// </remarks>
        /// <exception cref="Sdcb.Mattermost.DotNetSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>StatusOK</returns>
        StatusOK ElasticsearchTestPost ();

        /// <summary>
        /// Test Elasticsearch configuration
        /// </summary>
        /// <remarks>
        /// Test the current Elasticsearch configuration to see if the Elasticsearch server can be contacted successfully. Optionally provide a configuration in the request body to test. If no valid configuration is present in the request body the current server configuration will be tested.  __Minimum server version__: 4.1 ##### Permissions Must have &#x60;manage_system&#x60; permission. 
        /// </remarks>
        /// <exception cref="Sdcb.Mattermost.DotNetSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of StatusOK</returns>
        ApiResponse<StatusOK> ElasticsearchTestPostWithHttpInfo ();
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IElasticsearchApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Purge all Elasticsearch indexes
        /// </summary>
        /// <remarks>
        /// Deletes all Elasticsearch indexes and their contents. After calling this endpoint, it is necessary to schedule a new Elasticsearch indexing job to repopulate the indexes. __Minimum server version__: 4.1 ##### Permissions Must have &#x60;manage_system&#x60; permission. 
        /// </remarks>
        /// <exception cref="Sdcb.Mattermost.DotNetSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of StatusOK</returns>
        System.Threading.Tasks.Task<StatusOK> ElasticsearchPurgeIndexesPostAsync ();

        /// <summary>
        /// Purge all Elasticsearch indexes
        /// </summary>
        /// <remarks>
        /// Deletes all Elasticsearch indexes and their contents. After calling this endpoint, it is necessary to schedule a new Elasticsearch indexing job to repopulate the indexes. __Minimum server version__: 4.1 ##### Permissions Must have &#x60;manage_system&#x60; permission. 
        /// </remarks>
        /// <exception cref="Sdcb.Mattermost.DotNetSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (StatusOK)</returns>
        System.Threading.Tasks.Task<ApiResponse<StatusOK>> ElasticsearchPurgeIndexesPostAsyncWithHttpInfo ();
        /// <summary>
        /// Test Elasticsearch configuration
        /// </summary>
        /// <remarks>
        /// Test the current Elasticsearch configuration to see if the Elasticsearch server can be contacted successfully. Optionally provide a configuration in the request body to test. If no valid configuration is present in the request body the current server configuration will be tested.  __Minimum server version__: 4.1 ##### Permissions Must have &#x60;manage_system&#x60; permission. 
        /// </remarks>
        /// <exception cref="Sdcb.Mattermost.DotNetSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of StatusOK</returns>
        System.Threading.Tasks.Task<StatusOK> ElasticsearchTestPostAsync ();

        /// <summary>
        /// Test Elasticsearch configuration
        /// </summary>
        /// <remarks>
        /// Test the current Elasticsearch configuration to see if the Elasticsearch server can be contacted successfully. Optionally provide a configuration in the request body to test. If no valid configuration is present in the request body the current server configuration will be tested.  __Minimum server version__: 4.1 ##### Permissions Must have &#x60;manage_system&#x60; permission. 
        /// </remarks>
        /// <exception cref="Sdcb.Mattermost.DotNetSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (StatusOK)</returns>
        System.Threading.Tasks.Task<ApiResponse<StatusOK>> ElasticsearchTestPostAsyncWithHttpInfo ();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IElasticsearchApi : IElasticsearchApiSync, IElasticsearchApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ElasticsearchApi : IElasticsearchApi
    {
        private Sdcb.Mattermost.DotNetSdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ElasticsearchApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ElasticsearchApi() : this((string) null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ElasticsearchApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ElasticsearchApi(String basePath)
        {
            this.Configuration = Sdcb.Mattermost.DotNetSdk.Client.Configuration.MergeConfigurations(
                Sdcb.Mattermost.DotNetSdk.Client.GlobalConfiguration.Instance,
                new Sdcb.Mattermost.DotNetSdk.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Sdcb.Mattermost.DotNetSdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Sdcb.Mattermost.DotNetSdk.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Sdcb.Mattermost.DotNetSdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ElasticsearchApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ElasticsearchApi(Sdcb.Mattermost.DotNetSdk.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Sdcb.Mattermost.DotNetSdk.Client.Configuration.MergeConfigurations(
                Sdcb.Mattermost.DotNetSdk.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Sdcb.Mattermost.DotNetSdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Sdcb.Mattermost.DotNetSdk.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Sdcb.Mattermost.DotNetSdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PetApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ElasticsearchApi(Sdcb.Mattermost.DotNetSdk.Client.ISynchronousClient client,Sdcb.Mattermost.DotNetSdk.Client.IAsynchronousClient asyncClient, Sdcb.Mattermost.DotNetSdk.Client.IReadableConfiguration configuration)
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
        public Sdcb.Mattermost.DotNetSdk.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Sdcb.Mattermost.DotNetSdk.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Sdcb.Mattermost.DotNetSdk.Client.IReadableConfiguration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Sdcb.Mattermost.DotNetSdk.Client.ExceptionFactory ExceptionFactory
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
        /// Purge all Elasticsearch indexes Deletes all Elasticsearch indexes and their contents. After calling this endpoint, it is necessary to schedule a new Elasticsearch indexing job to repopulate the indexes. __Minimum server version__: 4.1 ##### Permissions Must have &#x60;manage_system&#x60; permission. 
        /// </summary>
        /// <exception cref="Sdcb.Mattermost.DotNetSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>StatusOK</returns>
        public StatusOK ElasticsearchPurgeIndexesPost ()
        {
             Sdcb.Mattermost.DotNetSdk.Client.ApiResponse<StatusOK> localVarResponse = ElasticsearchPurgeIndexesPostWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Purge all Elasticsearch indexes Deletes all Elasticsearch indexes and their contents. After calling this endpoint, it is necessary to schedule a new Elasticsearch indexing job to repopulate the indexes. __Minimum server version__: 4.1 ##### Permissions Must have &#x60;manage_system&#x60; permission. 
        /// </summary>
        /// <exception cref="Sdcb.Mattermost.DotNetSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of StatusOK</returns>
        public Sdcb.Mattermost.DotNetSdk.Client.ApiResponse< StatusOK > ElasticsearchPurgeIndexesPostWithHttpInfo ()
        {
            Sdcb.Mattermost.DotNetSdk.Client.RequestOptions requestOptions = new Sdcb.Mattermost.DotNetSdk.Client.RequestOptions();

            String[] @contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] @accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Sdcb.Mattermost.DotNetSdk.Client.ClientUtils.SelectHeaderContentType(@contentTypes);
            if (localVarContentType != null) requestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Sdcb.Mattermost.DotNetSdk.Client.ClientUtils.SelectHeaderAccept(@accepts);
            if (localVarAccept != null) requestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request

            var response = this.Client.Post< StatusOK >("/elasticsearch/purge_indexes", requestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("ElasticsearchPurgeIndexesPost", response);
                if (exception != null) throw exception;
            }

            return response;
        }

        /// <summary>
        /// Purge all Elasticsearch indexes Deletes all Elasticsearch indexes and their contents. After calling this endpoint, it is necessary to schedule a new Elasticsearch indexing job to repopulate the indexes. __Minimum server version__: 4.1 ##### Permissions Must have &#x60;manage_system&#x60; permission. 
        /// </summary>
        /// <exception cref="Sdcb.Mattermost.DotNetSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of StatusOK</returns>
        public async System.Threading.Tasks.Task<StatusOK> ElasticsearchPurgeIndexesPostAsync ()
        {
             Sdcb.Mattermost.DotNetSdk.Client.ApiResponse<StatusOK> localVarResponse = await ElasticsearchPurgeIndexesPostAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Purge all Elasticsearch indexes Deletes all Elasticsearch indexes and their contents. After calling this endpoint, it is necessary to schedule a new Elasticsearch indexing job to repopulate the indexes. __Minimum server version__: 4.1 ##### Permissions Must have &#x60;manage_system&#x60; permission. 
        /// </summary>
        /// <exception cref="Sdcb.Mattermost.DotNetSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (StatusOK)</returns>
        public async System.Threading.Tasks.Task<Sdcb.Mattermost.DotNetSdk.Client.ApiResponse<StatusOK>> ElasticsearchPurgeIndexesPostAsyncWithHttpInfo ()
        {

            Sdcb.Mattermost.DotNetSdk.Client.RequestOptions requestOptions = new Sdcb.Mattermost.DotNetSdk.Client.RequestOptions();

            String[] @contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] @accepts = new String[] {
                "application/json"
            };
            
            foreach (var contentType in @contentTypes)
                requestOptions.HeaderParameters.Add("Content-Type", contentType);
            
            foreach (var accept in @accepts)
                requestOptions.HeaderParameters.Add("Accept", accept);
            


            // make the HTTP request

            var response = await this.AsynchronousClient.PostAsync<StatusOK>("/elasticsearch/purge_indexes", requestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("ElasticsearchPurgeIndexesPost", response);
                if (exception != null) throw exception;
            }

            return response;
        }

        /// <summary>
        /// Test Elasticsearch configuration Test the current Elasticsearch configuration to see if the Elasticsearch server can be contacted successfully. Optionally provide a configuration in the request body to test. If no valid configuration is present in the request body the current server configuration will be tested.  __Minimum server version__: 4.1 ##### Permissions Must have &#x60;manage_system&#x60; permission. 
        /// </summary>
        /// <exception cref="Sdcb.Mattermost.DotNetSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>StatusOK</returns>
        public StatusOK ElasticsearchTestPost ()
        {
             Sdcb.Mattermost.DotNetSdk.Client.ApiResponse<StatusOK> localVarResponse = ElasticsearchTestPostWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Test Elasticsearch configuration Test the current Elasticsearch configuration to see if the Elasticsearch server can be contacted successfully. Optionally provide a configuration in the request body to test. If no valid configuration is present in the request body the current server configuration will be tested.  __Minimum server version__: 4.1 ##### Permissions Must have &#x60;manage_system&#x60; permission. 
        /// </summary>
        /// <exception cref="Sdcb.Mattermost.DotNetSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of StatusOK</returns>
        public Sdcb.Mattermost.DotNetSdk.Client.ApiResponse< StatusOK > ElasticsearchTestPostWithHttpInfo ()
        {
            Sdcb.Mattermost.DotNetSdk.Client.RequestOptions requestOptions = new Sdcb.Mattermost.DotNetSdk.Client.RequestOptions();

            String[] @contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] @accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Sdcb.Mattermost.DotNetSdk.Client.ClientUtils.SelectHeaderContentType(@contentTypes);
            if (localVarContentType != null) requestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Sdcb.Mattermost.DotNetSdk.Client.ClientUtils.SelectHeaderAccept(@accepts);
            if (localVarAccept != null) requestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request

            var response = this.Client.Post< StatusOK >("/elasticsearch/test", requestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("ElasticsearchTestPost", response);
                if (exception != null) throw exception;
            }

            return response;
        }

        /// <summary>
        /// Test Elasticsearch configuration Test the current Elasticsearch configuration to see if the Elasticsearch server can be contacted successfully. Optionally provide a configuration in the request body to test. If no valid configuration is present in the request body the current server configuration will be tested.  __Minimum server version__: 4.1 ##### Permissions Must have &#x60;manage_system&#x60; permission. 
        /// </summary>
        /// <exception cref="Sdcb.Mattermost.DotNetSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of StatusOK</returns>
        public async System.Threading.Tasks.Task<StatusOK> ElasticsearchTestPostAsync ()
        {
             Sdcb.Mattermost.DotNetSdk.Client.ApiResponse<StatusOK> localVarResponse = await ElasticsearchTestPostAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Test Elasticsearch configuration Test the current Elasticsearch configuration to see if the Elasticsearch server can be contacted successfully. Optionally provide a configuration in the request body to test. If no valid configuration is present in the request body the current server configuration will be tested.  __Minimum server version__: 4.1 ##### Permissions Must have &#x60;manage_system&#x60; permission. 
        /// </summary>
        /// <exception cref="Sdcb.Mattermost.DotNetSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (StatusOK)</returns>
        public async System.Threading.Tasks.Task<Sdcb.Mattermost.DotNetSdk.Client.ApiResponse<StatusOK>> ElasticsearchTestPostAsyncWithHttpInfo ()
        {

            Sdcb.Mattermost.DotNetSdk.Client.RequestOptions requestOptions = new Sdcb.Mattermost.DotNetSdk.Client.RequestOptions();

            String[] @contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] @accepts = new String[] {
                "application/json"
            };
            
            foreach (var contentType in @contentTypes)
                requestOptions.HeaderParameters.Add("Content-Type", contentType);
            
            foreach (var accept in @accepts)
                requestOptions.HeaderParameters.Add("Accept", accept);
            


            // make the HTTP request

            var response = await this.AsynchronousClient.PostAsync<StatusOK>("/elasticsearch/test", requestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("ElasticsearchTestPost", response);
                if (exception != null) throw exception;
            }

            return response;
        }

    }
}
