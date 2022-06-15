# TeamWorldwideModel.GetRateJsonld
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Context** | [**OneOfGetRateJsonldContext**](OneOfGetRateJsonldContext.md) |  | [optional] 
**Id** | **string** |  | [optional] 
**Type** | **string** |  | [optional] 
**UniqueId** | **string** |  | [optional] 
**OriginCity** | **string** |  | 
**OriginState** | **string** |  | 
**OriginZipCode** | **string** |  | 
**OriginCountry** | **string** |  | 
**DestinationCity** | **string** |  | 
**DestinationState** | **string** |  | 
**DestinationZipCode** | **string** |  | 
**DestinationCountry** | **string** |  | 
**Freight** | [**List&lt;FreightJsonld&gt;**](FreightJsonld.md) |  | 
**UnitOfMeasure** | **string** |  | [default to "US"]
**TeamBookAccessorials** | **List&lt;string&gt;** | Array of accessorial codes. Refer to enabledAccessorials returned in /api/team-book/get-accessorials. Provide the code. | [optional] 
**PickupDate** | **DateTime?** |  | [optional] 
**RateTypeList** | **List&lt;string&gt;** |  | [optional] 
**Equipment** | **string** |  | [optional] 
**InsuranceAddOn** | **bool?** |  | [optional] 
**InsureFreight** | **bool?** |  | [optional] 
**InsuranceAmount** | [**decimal?**](BigDecimal.md) |  | [optional] 
**LinearFeet** | [**decimal?**](BigDecimal.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

