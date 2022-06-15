# TeamWorldwideModel.BookShipmentTeamBookShipmentCreate
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**QuoteId** | **int?** |  | [optional] 
**HouseBill** | **string** | Reserve a house bill from either /api/teamww/get-house-bill or get one from /api/team-book/get-quote/{rateId} | 
**BolPrefix** | **string** | Leave this null. This is used in special cases. | [optional] 
**InsuranceAddon** | **bool?** |  | [optional] 
**ThirdPartyReferenceNumber** | **string** |  | [optional] 
**ProNumber** | **string** |  | [optional] 
**TeamBookShipper** | [**TeamBookShipperTeamBookShipmentCreate**](TeamBookShipperTeamBookShipmentCreate.md) |  | [optional] 
**TeamBookConsignee** | [**TeamBookConsigneeTeamBookShipmentCreate**](TeamBookConsigneeTeamBookShipmentCreate.md) |  | [optional] 
**BrokerInformation** | [**AnyOfBookShipmentTeamBookShipmentCreateBrokerInformation**](AnyOfBookShipmentTeamBookShipmentCreateBrokerInformation.md) |  | [optional] 
**Instructions** | **string** |  | [optional] 
**ShipmentNotes** | **string** |  | [optional] 
**EmergencyContact** | **string** | Emergency Contact. Required if a shipment has hazardous materials. | [optional] 
**EmergencyPhone** | **string** | Emergency Phone Number. Required if a shipment has hazardous materials. | [optional] 
**UnitOfMeasure** | **string** | Unit of Measure. Valid values: US (lbs/in) - METRIC (kgs/cm) - MIXED (kgs/cms) | [optional] [default to "US"]
**ShipmentReference1** | **string** |  | [optional] 
**ShipmentReference2** | **string** |  | [optional] 
**Pickup** | [**PickupTeamBookShipmentCreate**](PickupTeamBookShipmentCreate.md) |  | 
**Delivery** | [**AnyOfBookShipmentTeamBookShipmentCreateDelivery**](AnyOfBookShipmentTeamBookShipmentCreateDelivery.md) |  | [optional] 
**TeamBookAccessorials** | **List&lt;string&gt;** | Array of accessorial codes. Refer to enabledAccessorials returned in /api/team-book/get-accessorials. Provide the code. | [optional] 
**Freight** | [**List&lt;FreightTeamBookShipmentCreate&gt;**](FreightTeamBookShipmentCreate.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

