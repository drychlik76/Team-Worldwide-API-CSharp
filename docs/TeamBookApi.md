# TeamWorldwideAPI.TeamBookApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetGetAccessorialsCollection**](TeamBookApi.md#getgetaccessorialscollection) | **GET** /api/team-book/get-accessorials | Get TeamBook accessorials.
[**GetGetQuoteItem**](TeamBookApi.md#getgetquoteitem) | **GET** /api/team-book/get-quote/{rateId} | Get a Quote along with a reserved house bill.  Use a rateId from get-rates endpoint.
[**GetGetRateCollection**](TeamBookApi.md#getgetratecollection) | **GET** /api/team-book/get-rates | Get rates from the Team Book System.
[**GetGetShipmentStatusCollection**](TeamBookApi.md#getgetshipmentstatuscollection) | **GET** /api/teamww/get-shipment-statuses | Gets the shipment status by house bill.
[**PostBookShipmentCollection**](TeamBookApi.md#postbookshipmentcollection) | **POST** /api/team-book/book-shipment | Book and dispatch a shipment in the TeamBook system.

<a name="getgetaccessorialscollection"></a>
# **GetGetAccessorialsCollection**
> InlineResponse200 GetGetAccessorialsCollection ()

Get TeamBook accessorials.

Retrieves the collection of GetAccessorials resources.

### Example
```csharp
using System;
using System.Diagnostics;
using TeamWorldwideAPI;
using IO.Swagger.Client;
using TeamWorldwideModel;

namespace Example
{
    public class GetGetAccessorialsCollectionExample
    {
        public void main()
        {

            var apiInstance = new TeamBookApi();

            try
            {
                // Get TeamBook accessorials.
                InlineResponse200 result = apiInstance.GetGetAccessorialsCollection();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBookApi.GetGetAccessorialsCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/ld+json, application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgetquoteitem"></a>
# **GetGetQuoteItem**
> GetQuoteQuoteResponseJsonld GetGetQuoteItem (string rateId)

Get a Quote along with a reserved house bill.  Use a rateId from get-rates endpoint.

Retrieves a GetQuote resource.

### Example
```csharp
using System;
using System.Diagnostics;
using TeamWorldwideAPI;
using IO.Swagger.Client;
using TeamWorldwideModel;

namespace Example
{
    public class GetGetQuoteItemExample
    {
        public void main()
        {

            var apiInstance = new TeamBookApi();
            var rateId = rateId_example;  // string | Resource identifier

            try
            {
                // Get a Quote along with a reserved house bill.  Use a rateId from get-rates endpoint.
                GetQuoteQuoteResponseJsonld result = apiInstance.GetGetQuoteItem(rateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBookApi.GetGetQuoteItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rateId** | **string**| Resource identifier | 

### Return type

[**GetQuoteQuoteResponseJsonld**](GetQuoteQuoteResponseJsonld.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/ld+json, application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgetratecollection"></a>
# **GetGetRateCollection**
> InlineResponse2001 GetGetRateCollection (string originCity, string originState, string originZipCode, string originCountry, string destinationCity, string destinationState, string destinationZipCode, string destinationCountry, string unitOfMeasure, string pickupDate, bool? insuranceAddOn, bool? insureFreight, decimal? insuranceAmount, decimal? linearFeet, string equipment)

Get rates from the Team Book System.

Retrieves the collection of GetRate resources.

### Example
```csharp
using System;
using System.Diagnostics;
using TeamWorldwideAPI;
using IO.Swagger.Client;
using TeamWorldwideModel;

namespace Example
{
    public class GetGetRateCollectionExample
    {
        public void main()
        {

            var apiInstance = new TeamBookApi();
            var originCity = originCity_example;  // string | 
            var originState = originState_example;  // string | 
            var originZipCode = originZipCode_example;  // string | 
            var originCountry = originCountry_example;  // string | 
            var destinationCity = destinationCity_example;  // string | 
            var destinationState = destinationState_example;  // string | 
            var destinationZipCode = destinationZipCode_example;  // string | 
            var destinationCountry = destinationCountry_example;  // string | 
            var unitOfMeasure = unitOfMeasure_example;  // string | Unit of Measure. Valid values: US (lbs/in) - METRIC (kgs/cm) - MIXED (kgs/cms)
            var pickupDate = pickupDate_example;  // string | Pickup Date. Format: YYYY-MM-DD (optional) 
            var insuranceAddOn = true;  // bool? | Option to add 10% to the insurance value (optional) 
            var insureFreight = true;  // bool? | Used to tell the API to quote insurance. Your account must be setup for quoting insurance. (optional) 
            var insuranceAmount = 1.2;  // decimal? | This parameter refers to the extra value of 'Money' type accessorials like declared value. (optional) 
            var linearFeet = 1.2;  // decimal? | Linear feet value. Helpful for some volume vendors to return a rate based on space needed in a truck. (optional) 
            var equipment = equipment_example;  // string | Used for volume vendors and rates they return. Valid values: All, Van, Flatbed (optional) 

            try
            {
                // Get rates from the Team Book System.
                InlineResponse2001 result = apiInstance.GetGetRateCollection(originCity, originState, originZipCode, originCountry, destinationCity, destinationState, destinationZipCode, destinationCountry, unitOfMeasure, pickupDate, insuranceAddOn, insureFreight, insuranceAmount, linearFeet, equipment);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBookApi.GetGetRateCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **originCity** | **string**|  | 
 **originState** | **string**|  | 
 **originZipCode** | **string**|  | 
 **originCountry** | **string**|  | 
 **destinationCity** | **string**|  | 
 **destinationState** | **string**|  | 
 **destinationZipCode** | **string**|  | 
 **destinationCountry** | **string**|  | 
 **unitOfMeasure** | **string**| Unit of Measure. Valid values: US (lbs/in) - METRIC (kgs/cm) - MIXED (kgs/cms) | 
 **pickupDate** | **string**| Pickup Date. Format: YYYY-MM-DD | [optional] 
 **insuranceAddOn** | **bool?**| Option to add 10% to the insurance value | [optional] 
 **insureFreight** | **bool?**| Used to tell the API to quote insurance. Your account must be setup for quoting insurance. | [optional] 
 **insuranceAmount** | **decimal?**| This parameter refers to the extra value of &#x27;Money&#x27; type accessorials like declared value. | [optional] 
 **linearFeet** | **decimal?**| Linear feet value. Helpful for some volume vendors to return a rate based on space needed in a truck. | [optional] 
 **equipment** | **string**| Used for volume vendors and rates they return. Valid values: All, Van, Flatbed | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/ld+json, application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgetshipmentstatuscollection"></a>
# **GetGetShipmentStatusCollection**
> InlineResponse2004 GetGetShipmentStatusCollection (string houseBill)

Gets the shipment status by house bill.

Retrieves the collection of GetShipmentStatus resources.

### Example
```csharp
using System;
using System.Diagnostics;
using TeamWorldwideAPI;
using IO.Swagger.Client;
using TeamWorldwideModel;

namespace Example
{
    public class GetGetShipmentStatusCollectionExample
    {
        public void main()
        {

            var apiInstance = new TeamBookApi();
            var houseBill = houseBill_example;  // string |  (optional) 

            try
            {
                // Gets the shipment status by house bill.
                InlineResponse2004 result = apiInstance.GetGetShipmentStatusCollection(houseBill);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBookApi.GetGetShipmentStatusCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **houseBill** | **string**|  | [optional] 

### Return type

[**InlineResponse2004**](InlineResponse2004.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/ld+json, application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postbookshipmentcollection"></a>
# **PostBookShipmentCollection**
> BookShipmentTeamBookResponseJsonld PostBookShipmentCollection (BookShipmentJsonldTeamBookShipmentCreate body)

Book and dispatch a shipment in the TeamBook system.

Creates a BookShipment resource.

### Example
```csharp
using System;
using System.Diagnostics;
using TeamWorldwideAPI;
using IO.Swagger.Client;
using TeamWorldwideModel;

namespace Example
{
    public class PostBookShipmentCollectionExample
    {
        public void main()
        {

            var apiInstance = new TeamBookApi();
            var body = new BookShipmentJsonldTeamBookShipmentCreate(); // BookShipmentJsonldTeamBookShipmentCreate | The new BookShipment resource

            try
            {
                // Book and dispatch a shipment in the TeamBook system.
                BookShipmentTeamBookResponseJsonld result = apiInstance.PostBookShipmentCollection(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeamBookApi.PostBookShipmentCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BookShipmentJsonldTeamBookShipmentCreate**](BookShipmentJsonldTeamBookShipmentCreate.md)| The new BookShipment resource | 

### Return type

[**BookShipmentTeamBookResponseJsonld**](BookShipmentTeamBookResponseJsonld.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/ld+json, application/json, text/html
 - **Accept**: application/ld+json, application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

