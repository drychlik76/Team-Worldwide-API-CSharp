# TeamWorldwideModel.ShipmentBookingV2ShipmentBookingCreate
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BookedDate** | **DateTime?** |  | [optional] 
**ShippingMode** | **string** |           [DA] Domestic-Air,          [IA] International-Air,          [O] Ocean,          [T] Domestic/International Truck,          [TLN] Team Line Haul       | [default to "[T] Domestic/International Truck"]
**CarrierName** | **string** |  | [optional] 
**OriginCode** | **string** |  | [optional] 
**DestinationCode** | **string** |  | [optional] 
**VendorCode** | **string** |  | [optional] 
**CarrierBookingNumber** | **string** | Carrier master bill or booking number | [optional] 
**CarrierBookingNumber2** | **string** | Secondary carrier master bill or booking number | [optional] 
**Service** | **string** |           [S] Standard,          [X] Express,          [F] Road Feeder,          [N] Over the Counter,          [W] Weekend,          [T] Truck/Line Haul,          [E] Economy,          [H] Hot Shot,          [K] Full Truck Load,          [L] Less Than Truck Load,          [U] Exclusive Use,          [R] Live Recovery,          [C] Local       | [default to "[S] Standard"]
**DirectToConsignee** | **bool?** | Ship direct to consignee | [optional] 
**OverrideMeasures** | **bool?** | Override Pieces/Weight/Volume | [optional] 
**TotalPieces** | **int?** | Total number of pieces | [optional] 
**TotalWeight** | [**decimal?**](BigDecimal.md) | Total weight of all shipments | [optional] 
**DepartureDate** | **DateTime?** |  | [optional] 
**DepartureTime** | **DateTime?** |  | [optional] 
**ArrivalDate** | **DateTime?** |  | [optional] 
**ArrivalTime** | **DateTime?** |  | [optional] 
**BookingStation** | **string** | The booking station or airport code.  Generally speaking it will be airport code | [optional] 
**GeneralNotes** | **string** | General notes for the booking | [optional] 
**Shipments** | [**List&lt;ShipmentShipmentBookingCreate&gt;**](ShipmentShipmentBookingCreate.md) | Shipments | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

