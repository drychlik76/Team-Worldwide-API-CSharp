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
    public interface ITeamBookApi
    {
        /// <summary>
        /// Get TeamBook accessorials. Retrieves the collection of GetAccessorials resources.
        /// </summary>
        /// <returns>InlineResponse200</returns>
        InlineResponse200 GetGetAccessorialsCollection ();
        /// <summary>
        /// Get a Quote along with a reserved house bill.  Use a rateId from get-rates endpoint. Retrieves a GetQuote resource.
        /// </summary>
        /// <param name="rateId">Resource identifier</param>
        /// <returns>GetQuoteQuoteResponseJsonld</returns>
        GetQuoteQuoteResponseJsonld GetGetQuoteItem (string rateId);
        /// <summary>
        /// Get rates from the Team Book System. Retrieves the collection of GetRate resources.
        /// </summary>
        /// <param name="originCity"></param>
        /// <param name="originState"></param>
        /// <param name="originZipCode"></param>
        /// <param name="originCountry"></param>
        /// <param name="destinationCity"></param>
        /// <param name="destinationState"></param>
        /// <param name="destinationZipCode"></param>
        /// <param name="destinationCountry"></param>
        /// <param name="unitOfMeasure">Unit of Measure. Valid values: US (lbs/in) - METRIC (kgs/cm) - MIXED (kgs/cms)</param>
        /// <param name="pickupDate">Pickup Date. Format: YYYY-MM-DD</param>
        /// <param name="insuranceAddOn">Option to add 10% to the insurance value</param>
        /// <param name="insureFreight">Used to tell the API to quote insurance. Your account must be setup for quoting insurance.</param>
        /// <param name="insuranceAmount">This parameter refers to the extra value of &#x27;Money&#x27; type accessorials like declared value.</param>
        /// <param name="linearFeet">Linear feet value. Helpful for some volume vendors to return a rate based on space needed in a truck.</param>
        /// <param name="equipment">Used for volume vendors and rates they return. Valid values: All, Van, Flatbed</param>
        /// <returns>InlineResponse2001</returns>
        InlineResponse2001 GetGetRateCollection (string originCity, string originState, string originZipCode, string originCountry, string destinationCity, string destinationState, string destinationZipCode, string destinationCountry, string unitOfMeasure, string pickupDate, bool? insuranceAddOn, bool? insureFreight, decimal? insuranceAmount, decimal? linearFeet, string equipment);
        /// <summary>
        /// Gets the shipment status by house bill. Retrieves the collection of GetShipmentStatus resources.
        /// </summary>
        /// <param name="houseBill"></param>
        /// <returns>InlineResponse2004</returns>
        InlineResponse2004 GetGetShipmentStatusCollection (string houseBill);
        /// <summary>
        /// Book and dispatch a shipment in the TeamBook system. Creates a BookShipment resource.
        /// </summary>
        /// <param name="body">The new BookShipment resource</param>
        /// <returns>BookShipmentTeamBookResponseJsonld</returns>
        BookShipmentTeamBookResponseJsonld PostBookShipmentCollection (BookShipmentJsonldTeamBookShipmentCreate body);

    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TeamBookApi : ITeamBookApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamBookApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public TeamBookApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamBookApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TeamBookApi(String basePath)
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
        /// Get TeamBook accessorials. Retrieves the collection of GetAccessorials resources.
        /// </summary>
        /// <returns>InlineResponse200</returns>
        public InlineResponse200 GetGetAccessorialsCollection ()
        {
    
            var path = "/api/team-book/get-accessorials";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetGetAccessorialsCollection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetGetAccessorialsCollection: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200) ApiClient.Deserialize(response.Content, typeof(InlineResponse200), (IList<Parameter>)response.Headers);
        }
    
        /// <summary>
        /// Get a Quote along with a reserved house bill.  Use a rateId from get-rates endpoint. Retrieves a GetQuote resource.
        /// </summary>
        /// <param name="rateId">Resource identifier</param>
        /// <returns>GetQuoteQuoteResponseJsonld</returns>
        public GetQuoteQuoteResponseJsonld GetGetQuoteItem (string rateId)
        {
            // verify the required parameter 'rateId' is set
            if (rateId == null) throw new ApiException(400, "Missing required parameter 'rateId' when calling GetGetQuoteItem");
    
            var path = "/api/team-book/get-quote/{rateId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "rateId" + "}", ApiClient.ParameterToString(rateId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetGetQuoteItem: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetGetQuoteItem: " + response.ErrorMessage, response.ErrorMessage);
    
            return (GetQuoteQuoteResponseJsonld) ApiClient.Deserialize(response.Content, typeof(GetQuoteQuoteResponseJsonld), (IList<Parameter>)response.Headers);
        }
    
        /// <summary>
        /// Get rates from the Team Book System. Retrieves the collection of GetRate resources.
        /// </summary>
        /// <param name="originCity"></param>
        /// <param name="originState"></param>
        /// <param name="originZipCode"></param>
        /// <param name="originCountry"></param>
        /// <param name="destinationCity"></param>
        /// <param name="destinationState"></param>
        /// <param name="destinationZipCode"></param>
        /// <param name="destinationCountry"></param>
        /// <param name="unitOfMeasure">Unit of Measure. Valid values: US (lbs/in) - METRIC (kgs/cm) - MIXED (kgs/cms)</param>
        /// <param name="pickupDate">Pickup Date. Format: YYYY-MM-DD</param>
        /// <param name="insuranceAddOn">Option to add 10% to the insurance value</param>
        /// <param name="insureFreight">Used to tell the API to quote insurance. Your account must be setup for quoting insurance.</param>
        /// <param name="insuranceAmount">This parameter refers to the extra value of &#x27;Money&#x27; type accessorials like declared value.</param>
        /// <param name="linearFeet">Linear feet value. Helpful for some volume vendors to return a rate based on space needed in a truck.</param>
        /// <param name="equipment">Used for volume vendors and rates they return. Valid values: All, Van, Flatbed</param>
        /// <returns>InlineResponse2001</returns>
        public InlineResponse2001 GetGetRateCollection (string originCity, string originState, string originZipCode, string originCountry, string destinationCity, string destinationState, string destinationZipCode, string destinationCountry, string unitOfMeasure, string pickupDate, bool? insuranceAddOn, bool? insureFreight, decimal? insuranceAmount, decimal? linearFeet, string equipment)
        {
            // verify the required parameter 'originCity' is set
            if (originCity == null) throw new ApiException(400, "Missing required parameter 'originCity' when calling GetGetRateCollection");
            // verify the required parameter 'originState' is set
            if (originState == null) throw new ApiException(400, "Missing required parameter 'originState' when calling GetGetRateCollection");
            // verify the required parameter 'originZipCode' is set
            if (originZipCode == null) throw new ApiException(400, "Missing required parameter 'originZipCode' when calling GetGetRateCollection");
            // verify the required parameter 'originCountry' is set
            if (originCountry == null) throw new ApiException(400, "Missing required parameter 'originCountry' when calling GetGetRateCollection");
            // verify the required parameter 'destinationCity' is set
            if (destinationCity == null) throw new ApiException(400, "Missing required parameter 'destinationCity' when calling GetGetRateCollection");
            // verify the required parameter 'destinationState' is set
            if (destinationState == null) throw new ApiException(400, "Missing required parameter 'destinationState' when calling GetGetRateCollection");
            // verify the required parameter 'destinationZipCode' is set
            if (destinationZipCode == null) throw new ApiException(400, "Missing required parameter 'destinationZipCode' when calling GetGetRateCollection");
            // verify the required parameter 'destinationCountry' is set
            if (destinationCountry == null) throw new ApiException(400, "Missing required parameter 'destinationCountry' when calling GetGetRateCollection");
            // verify the required parameter 'unitOfMeasure' is set
            if (unitOfMeasure == null) throw new ApiException(400, "Missing required parameter 'unitOfMeasure' when calling GetGetRateCollection");
    
            var path = "/api/team-book/get-rates";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (originCity != null) queryParams.Add("originCity", ApiClient.ParameterToString(originCity)); // query parameter
 if (originState != null) queryParams.Add("originState", ApiClient.ParameterToString(originState)); // query parameter
 if (originZipCode != null) queryParams.Add("originZipCode", ApiClient.ParameterToString(originZipCode)); // query parameter
 if (originCountry != null) queryParams.Add("originCountry", ApiClient.ParameterToString(originCountry)); // query parameter
 if (destinationCity != null) queryParams.Add("destinationCity", ApiClient.ParameterToString(destinationCity)); // query parameter
 if (destinationState != null) queryParams.Add("destinationState", ApiClient.ParameterToString(destinationState)); // query parameter
 if (destinationZipCode != null) queryParams.Add("destinationZipCode", ApiClient.ParameterToString(destinationZipCode)); // query parameter
 if (destinationCountry != null) queryParams.Add("destinationCountry", ApiClient.ParameterToString(destinationCountry)); // query parameter
 if (unitOfMeasure != null) queryParams.Add("unitOfMeasure", ApiClient.ParameterToString(unitOfMeasure)); // query parameter
 if (pickupDate != null) queryParams.Add("pickupDate", ApiClient.ParameterToString(pickupDate)); // query parameter
 if (insuranceAddOn != null) queryParams.Add("insuranceAddOn", ApiClient.ParameterToString(insuranceAddOn)); // query parameter
 if (insureFreight != null) queryParams.Add("insureFreight", ApiClient.ParameterToString(insureFreight)); // query parameter
 if (insuranceAmount != null) queryParams.Add("insuranceAmount", ApiClient.ParameterToString(insuranceAmount)); // query parameter
 if (linearFeet != null) queryParams.Add("linearFeet", ApiClient.ParameterToString(linearFeet)); // query parameter
 if (equipment != null) queryParams.Add("equipment", ApiClient.ParameterToString(equipment)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetGetRateCollection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetGetRateCollection: " + response.ErrorMessage, response.ErrorMessage);
    
            return ApiClient.Deserialize(response.Content, typeof(InlineResponse2001), response.Headers);
        }
    
        /// <summary>
        /// Gets the shipment status by house bill. Retrieves the collection of GetShipmentStatus resources.
        /// </summary>
        /// <param name="houseBill"></param>
        /// <returns>InlineResponse2004</returns>
        public InlineResponse2004 GetGetShipmentStatusCollection (string houseBill)
        {
    
            var path = "/api/teamww/get-shipment-statuses";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (houseBill != null) queryParams.Add("houseBill", ApiClient.ParameterToString(houseBill)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetGetShipmentStatusCollection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetGetShipmentStatusCollection: " + response.ErrorMessage, response.ErrorMessage);
    
           
            return (InlineResponse2004) ApiClient.Deserialize(response.Content, typeof(InlineResponse2004), (IList<Parameter>)response.Headers);
        }
    
        /// <summary>
        /// Book and dispatch a shipment in the TeamBook system. Creates a BookShipment resource.
        /// </summary>
        /// <param name="body">The new BookShipment resource</param>
        /// <returns>BookShipmentTeamBookResponseJsonld</returns>
        public BookShipmentTeamBookResponseJsonld PostBookShipmentCollection (BookShipmentJsonldTeamBookShipmentCreate body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PostBookShipmentCollection");
    
            var path = "/api/team-book/book-shipment";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PostBookShipmentCollection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostBookShipmentCollection: " + response.ErrorMessage, response.ErrorMessage);
    
            return (BookShipmentTeamBookResponseJsonld) ApiClient.Deserialize(response.Content, typeof(BookShipmentTeamBookResponseJsonld), (IList<Parameter>)response.Headers);
        }    
    }
}
