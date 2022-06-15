# TeamWorldwideModel.FreightTeamBookShipmentCreate
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Quantity** | **int?** |  | 
**Weight** | [**decimal?**](BigDecimal.md) |  | 
**WeightType** | **string** |  | [default to "each"]
**Length** | [**decimal?**](BigDecimal.md) |  | 
**Width** | [**decimal?**](BigDecimal.md) |  | 
**Height** | [**decimal?**](BigDecimal.md) |  | 
**PackageType** | **string** |           PLT (Pallet),          CTN (Carton),          CRT (Crate),          DRM (Drum),          CON (Container),          BOX (Box),          BDL (Bundle),          ENV (Envelope),          CYL (Cylinder,          TOT (Totes),          CAS (Case),          OTH (Other)       | [optional] 
**IsDangerous** | **bool?** | Is this a hazardous shipment? | 
**_Class** | **string** |           Note: Normally the class is auto-assigned by the rating system.           Class 50 – Clean Freight - Over 50 lbs,          Class 55 - Bricks, cement, mortar, hardwood flooring, cloths or rags, magazines, copy paper,          Class 60 - Car accessories &amp; car parts, steel cables, used tires, stone blocks, glass, moldings,          Class 65 - Car parts &amp; accessories, bottled beverages, books in boxes, conveyors, chocolate in boxes, electric cords, tile,          Class 70 - Newspapers, wooden pencils, machinery, caskets, un-assembled furniture, food items, automobile engine,          Class 77.5 - Tires, bathroom fixtures, garments, shirts/pants, snowplows,          Class 85 - Crated machinery, transmissions, clutches, doors, CDs/DVDs, motorcycle engine,          Class 92.5 - Computers, monitors, refrigerators and freezers, gas-powered generators, cabinets, kiosk or ATMs,          Class 100 - Vacuum, boat &amp; car covers, canvas, wine cases, caskets,          CLass 110 - Cabinets, framed paintings &amp; artwork, table saw, metalworking,          Class 125 - Small household appliances, pictures/posters in boxes, exhibit booths, vending machines,          Class 150 - ATV, jet skis, motorcycles, assembled wooden furniture, work stations,          Class 175 - Clothing, couches, stuffed furniture, metal cabinets,          Class 200 - TVs, aircraft parts, aluminum table, packaged mattresses, snowmobiles,          Class 250 - Bamboo furniture, engine hoods, mattresses and box springs, un-assembled couch, plasma TV,          Class 300 - Wood cabinets, tables, chairs, model boats, kayaks/canoes, chassis,          Class 400 - Deer antlers,          Class 500 - Bags of gold dust, ping pong balls       | [optional] 
**Commodity** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

