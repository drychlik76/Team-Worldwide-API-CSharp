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
    public interface IShipmentV2Api
    {
        /// <summary>
        /// Gets the shipment status by house bill. Retrieves the collection of GetShipmentStatus resources.
        /// </summary>
        /// <param name="houseBill"></param>
        /// <returns>InlineResponse2004</returns>
        InlineResponse2004 GetGetShipmentStatusCollection (string houseBill);
        /// <summary>
        /// Gets and Reserves a Team WorldWide HouseBill. Retrieves the collection of GetHouseBill resources.
        /// </summary>
        /// <returns>InlineResponse2003</returns>
        InlineResponse2003 GetHouseBillGetHouseBillCollection ();
        /// <summary>
        /// Book shipments to Team Worldwide. Creates a ShipmentBookingV2 resource.
        /// </summary>
        /// <param name="body">The new ShipmentBookingV2 resource</param>
        /// <returns>ShipmentBookingV2ShipmentBookingCreatedJsonld</returns>
        ShipmentBookingV2ShipmentBookingCreatedJsonld PostCreateShipmentBookingShipmentBookingV2Collection (ShipmentBookingV2JsonldShipmentBookingCreate body);
        /// <summary>
        /// Book shipments to Team Worldwide. Creates a ShipmentBookingV2 resource.
        /// </summary>
        /// <param name="body">The new ShipmentBookingV2 resource</param>
        /// <returns>ShipmentBookingV2ShipmentBookingCreatedJsonld</returns>
        ShipmentV2ShipmentCreatedJsonld PostCreateShipmentShipmentV2Collection (ShipmentV2ShipmentJsonldShipmentCreate body);
        /// <summary>
        /// Book a single shipment to Team Worldwide. Creates a ShipmentV2 resource.
        /// </summary>
        /// <param name="body">The new ShipmentV2 resource</param>
        /// <returns>ShipmentV2ShipmentCreatedJsonld</returns>
        ShipmentNoteResourceJsonld PutAddNewShipmentNoteShipmentNoteResourceItem (ShipmentNoteResourceJsonldShipmentNoteResourceJsonldShipmentCreate body, string houseBill);
        /// <summary>
        /// Add Shipment Note. Replaces the ShipmentNoteResource resource.
        /// </summary>
        /// <param name="body">The updated ShipmentNoteResource resource</param>
        /// <param name="houseBill">Resource identifier</param>
        /// <returns>ShipmentNoteResourceJsonld</returns>
        UpdateTeamBookingJsonldGetShipmentBookingCollectionGetRead PutUpdateTeamBookingUpdateTeamBookingItem (UpdateTeamBookingUpdateTeamBooking body, string teamBookingNumber);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ShipmentV2Api : IShipmentV2Api
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentV2Api"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ShipmentV2Api(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentV2Api"/> class.
        /// </summary>
        /// <returns></returns>
        public ShipmentV2Api(String basePath)
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

            object t = ApiClient.Deserialize(response.Content, typeof(InlineResponse2004), response.Headers);



            return (InlineResponse2004) ApiClient.Deserialize(response.Content, typeof(InlineResponse2004), (IList<Parameter>)response.Headers);
        }
    
        /// <summary>
        /// Gets and Reserves a Team WorldWide HouseBill. Retrieves the collection of GetHouseBill resources.
        /// </summary>
        /// <returns>InlineResponse2003</returns>
        public InlineResponse2003 GetHouseBillGetHouseBillCollection ()
        {
    
            var path = "/api/teamww/get-house-bill";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetHouseBillGetHouseBillCollection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetHouseBillGetHouseBillCollection: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2003) ApiClient.Deserialize(response.Content, typeof(InlineResponse2003), (IList<Parameter>)response.Headers);
        }
    
        /// <summary>
        /// Book shipments to Team Worldwide. Creates a ShipmentBookingV2 resource.
        /// </summary>
        /// <param name="body">The new ShipmentBookingV2 resource</param>
        /// <returns>ShipmentBookingV2ShipmentBookingCreatedJsonld</returns>
        public ShipmentBookingV2ShipmentBookingCreatedJsonld PostCreateShipmentBookingShipmentBookingV2Collection (ShipmentBookingV2JsonldShipmentBookingCreate body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PostCreateShipmentBookingShipmentBookingV2Collection");
    
            var path = "/api/teamww/create/shipmentBooking";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PostCreateShipmentBookingShipmentBookingV2Collection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostCreateShipmentBookingShipmentBookingV2Collection: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ShipmentBookingV2ShipmentBookingCreatedJsonld) ApiClient.Deserialize(response.Content, typeof(ShipmentBookingV2ShipmentBookingCreatedJsonld), (IList<Parameter>)response.Headers);
        }

        /// <summary>
        /// Book a single shipment to Team Worldwide. Creates a ShipmentV2 resource.
        /// </summary>
        /// <param name="body">The new ShipmentV2 resource</param>
        /// <returns>ShipmentV2ShipmentCreatedJsonld</returns>
        public ShipmentV2ShipmentCreatedJsonld PostCreateShipmentShipmentV2Collection (ShipmentV2ShipmentJsonldShipmentCreate body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PostCreateShipmentShipmentV2Collection");
    
            var path = "/api/teamww/create/shipment";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PostCreateShipmentShipmentV2Collection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostCreateShipmentShipmentV2Collection: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ShipmentV2ShipmentCreatedJsonld) ApiClient.Deserialize(response.Content, typeof(ShipmentV2ShipmentCreatedJsonld), (IList<Parameter>)response.Headers);
        }
    
        /// <summary>
        /// Add Shipment Note. Replaces the ShipmentNoteResource resource.
        /// </summary>
        /// <param name="body">The updated ShipmentNoteResource resource</param>
        /// <param name="houseBill">Resource identifier</param>
        /// <returns>ShipmentNoteResourceJsonld</returns>
        public ShipmentNoteResourceJsonld PutAddNewShipmentNoteShipmentNoteResourceItem (ShipmentNoteResourceJsonldShipmentNoteResourceJsonldShipmentCreate body, string houseBill)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PutAddNewShipmentNoteShipmentNoteResourceItem");
            // verify the required parameter 'houseBill' is set
            if (houseBill == null) throw new ApiException(400, "Missing required parameter 'houseBill' when calling PutAddNewShipmentNoteShipmentNoteResourceItem");
    
            var path = "/api/teamww/create/new/{houseBill}/note";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "houseBill" + "}", ApiClient.ParameterToString(houseBill));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Put, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PutAddNewShipmentNoteShipmentNoteResourceItem: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PutAddNewShipmentNoteShipmentNoteResourceItem: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ShipmentNoteResourceJsonld) ApiClient.Deserialize(response.Content, typeof(ShipmentNoteResourceJsonld), (IList<Parameter>)response.Headers);
        }
    
        /// <summary>
        /// Update Booking. Updates the UpdateTeamBooking resource.
        /// </summary>
        /// <param name="body">The updated UpdateTeamBooking resource</param>
        /// <param name="teamBookingNumber">Resource identifier</param>
        /// <returns>UpdateTeamBookingJsonldGetShipmentBookingCollectionGetRead</returns>
        public UpdateTeamBookingJsonldGetShipmentBookingCollectionGetRead PutUpdateTeamBookingUpdateTeamBookingItem (UpdateTeamBookingUpdateTeamBooking body, string teamBookingNumber)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PutUpdateTeamBookingUpdateTeamBookingItem");
            // verify the required parameter 'teamBookingNumber' is set
            if (teamBookingNumber == null) throw new ApiException(400, "Missing required parameter 'teamBookingNumber' when calling PutUpdateTeamBookingUpdateTeamBookingItem");
    
            var path = "/api/teamww/update/updateShipmentBooking/{teamBookingNumber}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "teamBookingNumber" + "}", ApiClient.ParameterToString(teamBookingNumber));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling PutUpdateTeamBookingUpdateTeamBookingItem: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PutUpdateTeamBookingUpdateTeamBookingItem: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UpdateTeamBookingJsonldGetShipmentBookingCollectionGetRead) ApiClient.Deserialize(response.Content, typeof(UpdateTeamBookingJsonldGetShipmentBookingCollectionGetRead), (IList<Parameter>)response.Headers);
        }
    
    }
}
