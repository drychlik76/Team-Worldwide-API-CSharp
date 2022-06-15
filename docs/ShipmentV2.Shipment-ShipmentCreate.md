# TeamWorldwideModel.ShipmentV2ShipmentShipmentCreate
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsTestShipment** | **bool?** | Set true if this is a live shipment | [optional] 
**HouseBill** | **string** | If your account is enabled to pre-reserve the house bill,               you must reserve a house bill from the /api/teamww/get-house-bill endpoint.  Leave this property blank and a house bill,              will be generated for you. | [optional] 
**ControlBranch** | **string** | Control branch.  Can be null. | [optional] 
**Company** | **string** |                [01] TAE,               [02] TOS,               [03] TCB,               [05] TWC,               [21] LIB,               [25] PWJ,               [27] RAV           | [default to "[01] TAE"]
**ShipmentType** | **string** |               [1] Domestic Air,              [2] International Air Export,              [3] International Air Import,              [4] Ocean Export (FMC),              [5] Ocean Export (NVOCC),              [6] Ocean Import (FMC),              [7] Ocean Import (NVOCC),              [8] Domestic Truck,              [19] Domestic Warehouse,              [20] Ocean Warehouse,              [21] International Warehouse,              [22] Intl Customs Brokerage,              [23] Ocean Customs Brokerage,              [24] Ocean Import (Unregulated),              [25] Ocean Export (Unregulated),              [26] International Truck Import,              [27] International Truck Export,              [30] International Truck,              [31] International Air,              [32] Ocean Unregulated           | [default to "[8] Domestic Truck"]
**Service** | **string** |           [D] Same Day,          [N] Over The Counter,          [A] Overnight AM,          [P] Overnight PM,          [R] International Express,          [T] International Standard,          [M] International Economy,          [O] Other,          [Q] Charter,          [S] Standard,          [2] Standard 2 (2-day),          [3] Economy (3-day),          [5] Deferred (4-5 day),          [L] LTL,          [F] FTL,          [U] EUV/Hotshot | [default to "[3] Economy (3-day)"]
**PickupDate** | **DateTime?** | Pickup date YYYY-MM-DD | 
**Origin** | **string** | Origin location. Must be a valid Team Worldwide origin. | [optional] 
**Destination** | **string** | Destination location.  Must be a valid Team Worldwide destination | [optional] 
**LinearUnits** | **string** | Acceptable values are IN and CM | [default to "IN"]
**WeightUnits** | **string** | Acceptable values are LB and KG | [default to "LB"]
**Oversize** | **string** | Is the shipment oversize? | [optional] [default to "N"]
**GoodsDescription** | **string** | Description of the goods | 
**Weight** | [**decimal?**](BigDecimal.md) |  | [optional] 
**SpecialInstructions** | **string** | Special instructions | [optional] 
**DeclaredValue** | [**decimal?**](BigDecimal.md) | Declared value | [optional] 
**Shipper** | [**ShipperShipmentCreate**](ShipperShipmentCreate.md) |  | 
**Consignee** | [**ConsigneeShipmentCreate**](ConsigneeShipmentCreate.md) |  | 
**BillTo** | [**AnyOfShipmentV2ShipmentShipmentCreateBillTo**](AnyOfShipmentV2ShipmentShipmentCreateBillTo.md) | Billing party of this shipment | [optional] 
**RequestedPickup** | [**AnyOfShipmentV2ShipmentShipmentCreateRequestedPickup**](AnyOfShipmentV2ShipmentShipmentCreateRequestedPickup.md) | Requested pickup | [optional] 
**RequestedDelivery** | [**AnyOfShipmentV2ShipmentShipmentCreateRequestedDelivery**](AnyOfShipmentV2ShipmentShipmentCreateRequestedDelivery.md) | Request delivery | [optional] 
**ShipmentGoods** | [**List&lt;ShipmentGoodsShipmentCreate&gt;**](ShipmentGoodsShipmentCreate.md) | Shipment goods | [optional] 
**ShipmentGoodsHandling** | [**List&lt;ShipmentGoodsHandlingShipmentCreate&gt;**](ShipmentGoodsHandlingShipmentCreate.md) | Shipment goods handling | [optional] 
**ShipmentNotes** | [**List&lt;ShipmentNoteResourceShipmentCreate&gt;**](ShipmentNoteResourceShipmentCreate.md) | Shipment notes | [optional] 
**AdditionalReferences** | [**List&lt;ShipmentAdditionalReferencesShipmentCreate&gt;**](ShipmentAdditionalReferencesShipmentCreate.md) | Any additional references for this shipment | [optional] 
**ProjectedExpenses** | [**List&lt;ProjectedExpenseShipmentCreate&gt;**](ProjectedExpenseShipmentCreate.md) | Projected Expenses | [optional] 
**ProjectedCustomerCharges** | [**List&lt;ProjectedCustomerChargeShipmentCreate&gt;**](ProjectedCustomerChargeShipmentCreate.md) | Projected customer charges | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

