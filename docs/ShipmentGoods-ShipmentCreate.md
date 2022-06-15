# TeamWorldwideModel.ShipmentGoodsShipmentCreate
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **string** |  | 
**Pieces** | **int?** |  | [default to 1]
**Length** | [**decimal?**](BigDecimal.md) |  | [optional] 
**Height** | [**decimal?**](BigDecimal.md) |  | [optional] 
**Width** | [**decimal?**](BigDecimal.md) |  | [optional] 
**ItemWeight** | [**decimal?**](BigDecimal.md) |  | [optional] 
**IsDangerousGoods** | **bool?** | Need to know if this a dangerous goods shipment | 
**DangerousGoodsDescription** | **string** | If is dangerous goods, a description is required | [optional] 
**PackageType** | **string** |            [P] Piece,           [G] Bag,           [B] Box,           [K] Case,           [T] Tube,           [C] Crate,           [L] Loose,           [E] Pallet,           [S] Skid,           [U] Tub,           [D] Drum,           [N] Container          | 
**ContainerType** | **string** | Container Type | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

