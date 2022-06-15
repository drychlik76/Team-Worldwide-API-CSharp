# TeamWorldwideAPI.ShipmentV2Api

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetGetShipmentStatusCollection**](ShipmentV2Api.md#getgetshipmentstatuscollection) | **GET** /api/teamww/get-shipment-statuses | Gets the shipment status by house bill.
[**GetHouseBillGetHouseBillCollection**](ShipmentV2Api.md#gethousebillgethousebillcollection) | **GET** /api/teamww/get-house-bill | Gets and Reserves a Team WorldWide HouseBill.
[**PostCreateShipmentBookingShipmentBookingV2Collection**](ShipmentV2Api.md#postcreateshipmentbookingshipmentbookingv2collection) | **POST** /api/teamww/create/shipmentBooking | Book shipments to Team Worldwide.
[**PostCreateShipmentShipmentV2Collection**](ShipmentV2Api.md#postcreateshipmentshipmentv2collection) | **POST** /api/teamww/create/shipment | Book a single shipment to Team Worldwide.
[**PutAddNewShipmentNoteShipmentNoteResourceItem**](ShipmentV2Api.md#putaddnewshipmentnoteshipmentnoteresourceitem) | **PUT** /api/teamww/create/new/{houseBill}/note | Add Shipment Note.
[**PutUpdateTeamBookingUpdateTeamBookingItem**](ShipmentV2Api.md#putupdateteambookingupdateteambookingitem) | **PATCH** /api/teamww/update/updateShipmentBooking/{teamBookingNumber} | Update Booking.

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

            var apiInstance = new ShipmentV2Api();
            var houseBill = houseBill_example;  // string |  (optional) 

            try
            {
                // Gets the shipment status by house bill.
                InlineResponse2004 result = apiInstance.GetGetShipmentStatusCollection(houseBill);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShipmentV2Api.GetGetShipmentStatusCollection: " + e.Message );
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

<a name="gethousebillgethousebillcollection"></a>
# **GetHouseBillGetHouseBillCollection**
> InlineResponse2003 GetHouseBillGetHouseBillCollection ()

Gets and Reserves a Team WorldWide HouseBill.

Retrieves the collection of GetHouseBill resources.

### Example
```csharp
using System;
using System.Diagnostics;
using TeamWorldwideAPI;
using IO.Swagger.Client;
using TeamWorldwideModel;

namespace Example
{
    public class GetHouseBillGetHouseBillCollectionExample
    {
        public void main()
        {

            var apiInstance = new ShipmentV2Api();

            try
            {
                // Gets and Reserves a Team WorldWide HouseBill.
                InlineResponse2003 result = apiInstance.GetHouseBillGetHouseBillCollection();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShipmentV2Api.GetHouseBillGetHouseBillCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/ld+json, application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcreateshipmentbookingshipmentbookingv2collection"></a>
# **PostCreateShipmentBookingShipmentBookingV2Collection**
> ShipmentBookingV2ShipmentBookingCreatedJsonld PostCreateShipmentBookingShipmentBookingV2Collection (ShipmentBookingV2JsonldShipmentBookingCreate body)

Book shipments to Team Worldwide.

Creates a ShipmentBookingV2 resource.

### Example
```csharp
using System;
using System.Diagnostics;
using TeamWorldwideAPI;
using IO.Swagger.Client;
using TeamWorldwideModel;

namespace Example
{
    public class PostCreateShipmentBookingShipmentBookingV2CollectionExample
    {
        public void main()
        {

            var apiInstance = new ShipmentV2Api();
            var body = new ShipmentBookingV2JsonldShipmentBookingCreate(); // ShipmentBookingV2JsonldShipmentBookingCreate | The new ShipmentBookingV2 resource

            try
            {
                // Book shipments to Team Worldwide.
                ShipmentBookingV2ShipmentBookingCreatedJsonld result = apiInstance.PostCreateShipmentBookingShipmentBookingV2Collection(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShipmentV2Api.PostCreateShipmentBookingShipmentBookingV2Collection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ShipmentBookingV2JsonldShipmentBookingCreate**](ShipmentBookingV2JsonldShipmentBookingCreate.md)| The new ShipmentBookingV2 resource | 

### Return type

[**ShipmentBookingV2ShipmentBookingCreatedJsonld**](ShipmentBookingV2ShipmentBookingCreatedJsonld.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/ld+json, application/json, text/html
 - **Accept**: application/ld+json, application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postcreateshipmentshipmentv2collection"></a>
# **PostCreateShipmentShipmentV2Collection**
> ShipmentV2ShipmentCreatedJsonld PostCreateShipmentShipmentV2Collection (ShipmentV2ShipmentJsonldShipmentCreate body)

Book a single shipment to Team Worldwide.

Creates a ShipmentV2 resource.

### Example
```csharp
using System;
using System.Diagnostics;
using TeamWorldwideAPI;
using IO.Swagger.Client;
using TeamWorldwideModel;

namespace Example
{
    public class PostCreateShipmentShipmentV2CollectionExample
    {
        public void main()
        {

            var apiInstance = new ShipmentV2Api();
            var body = new ShipmentV2ShipmentJsonldShipmentCreate(); // ShipmentV2ShipmentJsonldShipmentCreate | The new ShipmentV2 resource

            try
            {
                // Book a single shipment to Team Worldwide.
                ShipmentV2ShipmentCreatedJsonld result = apiInstance.PostCreateShipmentShipmentV2Collection(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShipmentV2Api.PostCreateShipmentShipmentV2Collection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ShipmentV2ShipmentJsonldShipmentCreate**](ShipmentV2ShipmentJsonldShipmentCreate.md)| The new ShipmentV2 resource | 

### Return type

[**ShipmentV2ShipmentCreatedJsonld**](ShipmentV2ShipmentCreatedJsonld.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/ld+json, application/json, text/html
 - **Accept**: application/ld+json, application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putaddnewshipmentnoteshipmentnoteresourceitem"></a>
# **PutAddNewShipmentNoteShipmentNoteResourceItem**
> ShipmentNoteResourceJsonld PutAddNewShipmentNoteShipmentNoteResourceItem (ShipmentNoteResourceJsonldShipmentNoteResourceJsonldShipmentCreate body, string houseBill)

Add Shipment Note.

Replaces the ShipmentNoteResource resource.

### Example
```csharp
using System;
using System.Diagnostics;
using TeamWorldwideAPI;
using IO.Swagger.Client;
using TeamWorldwideModel;

namespace Example
{
    public class PutAddNewShipmentNoteShipmentNoteResourceItemExample
    {
        public void main()
        {

            var apiInstance = new ShipmentV2Api();
            var body = new ShipmentNoteResourceJsonldShipmentNoteResourceJsonldShipmentCreate(); // ShipmentNoteResourceJsonldShipmentNoteResourceJsonldShipmentCreate | The updated ShipmentNoteResource resource
            var houseBill = houseBill_example;  // string | Resource identifier

            try
            {
                // Add Shipment Note.
                ShipmentNoteResourceJsonld result = apiInstance.PutAddNewShipmentNoteShipmentNoteResourceItem(body, houseBill);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShipmentV2Api.PutAddNewShipmentNoteShipmentNoteResourceItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ShipmentNoteResourceJsonldShipmentNoteResourceJsonldShipmentCreate**](ShipmentNoteResourceJsonldShipmentNoteResourceJsonldShipmentCreate.md)| The updated ShipmentNoteResource resource | 
 **houseBill** | **string**| Resource identifier | 

### Return type

[**ShipmentNoteResourceJsonld**](ShipmentNoteResourceJsonld.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/ld+json, application/json, text/html
 - **Accept**: application/ld+json, application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putupdateteambookingupdateteambookingitem"></a>
# **PutUpdateTeamBookingUpdateTeamBookingItem**
> UpdateTeamBookingJsonldGetShipmentBookingCollectionGetRead PutUpdateTeamBookingUpdateTeamBookingItem (UpdateTeamBookingUpdateTeamBooking body, string teamBookingNumber)

Update Booking.

Updates the UpdateTeamBooking resource.

### Example
```csharp
using System;
using System.Diagnostics;
using TeamWorldwideAPI;
using IO.Swagger.Client;
using TeamWorldwideModel;

namespace Example
{
    public class PutUpdateTeamBookingUpdateTeamBookingItemExample
    {
        public void main()
        {

            var apiInstance = new ShipmentV2Api();
            var body = new UpdateTeamBookingUpdateTeamBooking(); // UpdateTeamBookingUpdateTeamBooking | The updated UpdateTeamBooking resource
            var teamBookingNumber = teamBookingNumber_example;  // string | Resource identifier

            try
            {
                // Update Booking.
                UpdateTeamBookingJsonldGetShipmentBookingCollectionGetRead result = apiInstance.PutUpdateTeamBookingUpdateTeamBookingItem(body, teamBookingNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShipmentV2Api.PutUpdateTeamBookingUpdateTeamBookingItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UpdateTeamBookingUpdateTeamBooking**](UpdateTeamBookingUpdateTeamBooking.md)| The updated UpdateTeamBooking resource | 
 **teamBookingNumber** | **string**| Resource identifier | 

### Return type

[**UpdateTeamBookingJsonldGetShipmentBookingCollectionGetRead**](UpdateTeamBookingJsonldGetShipmentBookingCollectionGetRead.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/merge-patch+json
 - **Accept**: application/ld+json, application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

