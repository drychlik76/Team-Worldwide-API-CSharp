# TeamWorldwideModel.BookShipmentJsonldTeamBookShipmentCreate
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Context** | [**OneOfBookShipmentJsonldTeamBookShipmentCreateContext**](OneOfBookShipmentJsonldTeamBookShipmentCreateContext.md) |  | [optional] 
**Id** | **string** |  | [optional] 
**Type** | **string** |  | [optional] 
**QuoteId** | **int?** |  | [optional] 
**HouseBill** | **string** | Reserve a house bill from either /api/teamww/get-house-bill or get one from /api/team-book/get-quote/{rateId} | 
**BolPrefix** | **string** | Leave this null. This is used in special cases. | [optional] 
**InsuranceAddon** | **bool?** |  | [optional] 
**ThirdPartyReferenceNumber** | **string** |  | [optional] 
**ProNumber** | **string** |  | [optional] 
**TeamBookShipper** | [**TeamBookShipperJsonldTeamBookShipmentCreate**](TeamBookShipperJsonldTeamBookShipmentCreate.md) |  | [optional] 
**TeamBookConsignee** | [**TeamBookConsigneeJsonldTeamBookShipmentCreate**](TeamBookConsigneeJsonldTeamBookShipmentCreate.md) |  | [optional] 
**BrokerInformation** | [**AnyOfBookShipmentJsonldTeamBookShipmentCreateBrokerInformation**](AnyOfBookShipmentJsonldTeamBookShipmentCreateBrokerInformation.md) |  | [optional] 
**Instructions** | **string** |  | [optional] 
**ShipmentNotes** | **string** |  | [optional] 
**EmergencyContact** | **string** | Emergency Contact. Required if a shipment has hazardous materials. | [optional] 
**EmergencyPhone** | **string** | Emergency Phone Number. Required if a shipment has hazardous materials. | [optional] 
**UnitOfMeasure** | **string** | Unit of Measure. Valid values: US (lbs/in) - METRIC (kgs/cm) - MIXED (kgs/cms) | [optional] [default to "US"]
**ShipmentReference1** | **string** |  | [optional] 
**ShipmentReference2** | **string** |  | [optional] 
**Pickup** | [**PickupJsonldTeamBookShipmentCreate**](PickupJsonldTeamBookShipmentCreate.md) |  | 
**Delivery** | [**AnyOfBookShipmentJsonldTeamBookShipmentCreateDelivery**](AnyOfBookShipmentJsonldTeamBookShipmentCreateDelivery.md) |  | [optional] 
**TeamBookAccessorials** | **List&lt;string&gt;** | Array of accessorial codes. Refer to enabledAccessorials returned in /api/team-book/get-accessorials. Provide the code. | [optional] 
**Freight** | [**List&lt;FreightJsonldTeamBookShipmentCreate&gt;**](FreightJsonldTeamBookShipmentCreate.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

