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
    public interface IInvoicesApi
    {
        /// <summary>
        /// Get invoice by house bill Retrieves a GetInvoice resource.
        /// </summary>
        /// <param name="houseBill">Resource identifier</param>
        /// <returns>GetInvoiceInvoiceJsonldInvoiceItemGetRead</returns>
        GetInvoiceInvoiceJsonldInvoiceItemGetRead GetGetInvoiceItem (string houseBill);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class InvoicesApi : IInvoicesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoicesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public InvoicesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoicesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public InvoicesApi(String basePath)
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
        /// Get invoice by house bill Retrieves a GetInvoice resource.
        /// </summary>
        /// <param name="houseBill">Resource identifier</param>
        /// <returns>GetInvoiceInvoiceJsonldInvoiceItemGetRead</returns>
        public GetInvoiceInvoiceJsonldInvoiceItemGetRead GetGetInvoiceItem (string houseBill)
        {
            // verify the required parameter 'houseBill' is set
            if (houseBill == null) throw new ApiException(400, "Missing required parameter 'houseBill' when calling GetGetInvoiceItem");
    
            var path = "/api/teamww/invoice/get/{houseBill}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "houseBill" + "}", ApiClient.ParameterToString(houseBill));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetGetInvoiceItem: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetGetInvoiceItem: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GetInvoiceInvoiceJsonldInvoiceItemGetRead) ApiClient.Deserialize(response.Content, typeof(GetInvoiceInvoiceJsonldInvoiceItemGetRead), (IList<Parameter>)response.Headers);
        }
    
    }
}
