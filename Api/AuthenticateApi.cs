using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using TeamWorldwideModel;

namespace TeamWorldwideAPI
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuthenticateApi
    {
        /// <summary>
        /// Authenticate to start session. 
        /// </summary>
        /// <param name="body">Start Session</param>
        /// <returns></returns>
        void PostCredentialsItem (Credentials body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AuthenticateApi : IAuthenticateApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticateApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AuthenticateApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticateApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuthenticateApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    

        /// <summary>
        /// Wrapper that calls PostCredentialsItem
        /// </summary>
        /// <param name="credentials"></param>
        public void Authenticate(Credentials credentials)
        {
            this.PostCredentialsItem(credentials);
        }


        /// <summary>
        /// Authenticate to start session. 
        /// </summary>
        /// <param name="body">Start Session</param>
        /// <returns></returns>
        public void PostCredentialsItem (Credentials body)
        {
    
            var path = "/api/authenticate";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostCredentialsItem: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostCredentialsItem: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
