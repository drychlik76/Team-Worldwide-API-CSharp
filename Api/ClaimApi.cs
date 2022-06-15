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
    public interface IClaimApi
    {
        /// <summary>
        /// Gets collection of Team WorldWide Claims Retrieves the collection of Claim resources.
        /// </summary>
        /// <param name="page">The collection page number</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 GetClaimCollection (int? page);
        /// <summary>
        /// Gets a single Team WorldWide Claim Retrieves a Claim resource.
        /// </summary>
        /// <param name="id">Resource identifier</param>
        /// <returns>ClaimClaimsResponseJsonldClaimCollectionReadRead</returns>
        ClaimClaimsResponseJsonldClaimCollectionReadRead GetClaimItem (string id);
        /// <summary>
        /// File a single Team WorldWide Claim Creates a Claim resource.
        /// </summary>
        /// <param name="body">The new Claim resource</param>
        /// <returns>ClaimClaimsResponseJsonldClaimCollectionReadRead</returns>
        ClaimClaimsResponseJsonldClaimCollectionReadRead PostClaimCollection (ClaimJsonldClaimCollectionWriteWrite body);
        /// <summary>
        /// Update an existing Team WorldWide Claim Updates the Claim resource.
        /// </summary>
        /// <param name="body">The updated Claim resource</param>
        /// <param name="id">Resource identifier</param>
        /// <returns>ClaimClaimsResponseJsonldClaimCollectionReadRead</returns>
        ClaimClaimsResponseJsonldClaimCollectionReadRead UpdateClaimItem (ClaimClaimCollectionWriteWrite body, string id);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ClaimApi : IClaimApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClaimApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ClaimApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ClaimApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ClaimApi(String basePath)
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
        /// Gets collection of Team WorldWide Claims Retrieves the collection of Claim resources.
        /// </summary>
        /// <param name="page">The collection page number</param>
        /// <returns>InlineResponse2002</returns>
        public InlineResponse2002 GetClaimCollection (int? page)
        {
    
            var path = "/api/teamww/get-claim";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClaimCollection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClaimCollection: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response.Content, typeof(InlineResponse2002), (IList<Parameter>)response.Headers);
        }
    
        /// <summary>
        /// Gets a single Team WorldWide Claim Retrieves a Claim resource.
        /// </summary>
        /// <param name="id">Resource identifier</param>
        /// <returns>ClaimClaimsResponseJsonldClaimCollectionReadRead</returns>
        public ClaimClaimsResponseJsonldClaimCollectionReadRead GetClaimItem (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetClaimItem");
    
            var path = "/api/teamww/get-single-claim/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClaimItem: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClaimItem: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ClaimClaimsResponseJsonldClaimCollectionReadRead) ApiClient.Deserialize(response.Content, typeof(ClaimClaimsResponseJsonldClaimCollectionReadRead), (IList<Parameter>)response.Headers);
        }
    
        /// <summary>
        /// File a single Team WorldWide Claim Creates a Claim resource.
        /// </summary>
        /// <param name="body">The new Claim resource</param>
        /// <returns>ClaimClaimsResponseJsonldClaimCollectionReadRead</returns>
        public ClaimClaimsResponseJsonldClaimCollectionReadRead PostClaimCollection (ClaimJsonldClaimCollectionWriteWrite body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PostClaimCollection");
    
            var path = "/api/teamww/post-claim";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PostClaimCollection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostClaimCollection: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ClaimClaimsResponseJsonldClaimCollectionReadRead) ApiClient.Deserialize(response.Content, typeof(ClaimClaimsResponseJsonldClaimCollectionReadRead), (IList<Parameter>)response.Headers);
        }
    
        /// <summary>
        /// Update an existing Team WorldWide Claim Updates the Claim resource.
        /// </summary>
        /// <param name="body">The updated Claim resource</param>
        /// <param name="id">Resource identifier</param>
        /// <returns>ClaimClaimsResponseJsonldClaimCollectionReadRead</returns>
        public ClaimClaimsResponseJsonldClaimCollectionReadRead UpdateClaimItem (ClaimClaimCollectionWriteWrite body, string id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateClaimItem");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateClaimItem");
    
            var path = "/api/teamww/update-claim/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Patch, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateClaimItem: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateClaimItem: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ClaimClaimsResponseJsonldClaimCollectionReadRead) ApiClient.Deserialize(response.Content, typeof(ClaimClaimsResponseJsonldClaimCollectionReadRead), (IList<Parameter>)response.Headers);
        }
    
    }
}
