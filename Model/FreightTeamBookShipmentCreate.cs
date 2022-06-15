using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace TeamWorldwideModel {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class FreightTeamBookShipmentCreate {
    /// <summary>
    /// Gets or Sets Quantity
    /// </summary>
    [DataMember(Name="quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quantity")]
    public int? Quantity { get; set; }

    /// <summary>
    /// Gets or Sets Weight
    /// </summary>
    [DataMember(Name="weight", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "weight")]
    public decimal? Weight { get; set; }

    /// <summary>
    /// Gets or Sets WeightType
    /// </summary>
    [DataMember(Name="weightType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "weightType")]
    public string WeightType { get; set; }

    /// <summary>
    /// Gets or Sets Length
    /// </summary>
    [DataMember(Name="length", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "length")]
    public decimal? Length { get; set; }

    /// <summary>
    /// Gets or Sets Width
    /// </summary>
    [DataMember(Name="width", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "width")]
    public decimal? Width { get; set; }

    /// <summary>
    /// Gets or Sets Height
    /// </summary>
    [DataMember(Name="height", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "height")]
    public decimal? Height { get; set; }

    /// <summary>
    ///           PLT (Pallet),          CTN (Carton),          CRT (Crate),          DRM (Drum),          CON (Container),          BOX (Box),          BDL (Bundle),          ENV (Envelope),          CYL (Cylinder,          TOT (Totes),          CAS (Case),          OTH (Other)      
    /// </summary>
    /// <value>          PLT (Pallet),          CTN (Carton),          CRT (Crate),          DRM (Drum),          CON (Container),          BOX (Box),          BDL (Bundle),          ENV (Envelope),          CYL (Cylinder,          TOT (Totes),          CAS (Case),          OTH (Other)      </value>
    [DataMember(Name="packageType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "packageType")]
    public string PackageType { get; set; }

    /// <summary>
    /// Is this a hazardous shipment?
    /// </summary>
    /// <value>Is this a hazardous shipment?</value>
    [DataMember(Name="isDangerous", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isDangerous")]
    public bool? IsDangerous { get; set; }

    /// <summary>
    ///           Note: Normally the class is auto-assigned by the rating system.           Class 50 – Clean Freight - Over 50 lbs,          Class 55 - Bricks, cement, mortar, hardwood flooring, cloths or rags, magazines, copy paper,          Class 60 - Car accessories & car parts, steel cables, used tires, stone blocks, glass, moldings,          Class 65 - Car parts & accessories, bottled beverages, books in boxes, conveyors, chocolate in boxes, electric cords, tile,          Class 70 - Newspapers, wooden pencils, machinery, caskets, un-assembled furniture, food items, automobile engine,          Class 77.5 - Tires, bathroom fixtures, garments, shirts/pants, snowplows,          Class 85 - Crated machinery, transmissions, clutches, doors, CDs/DVDs, motorcycle engine,          Class 92.5 - Computers, monitors, refrigerators and freezers, gas-powered generators, cabinets, kiosk or ATMs,          Class 100 - Vacuum, boat & car covers, canvas, wine cases, caskets,          CLass 110 - Cabinets, framed paintings & artwork, table saw, metalworking,          Class 125 - Small household appliances, pictures/posters in boxes, exhibit booths, vending machines,          Class 150 - ATV, jet skis, motorcycles, assembled wooden furniture, work stations,          Class 175 - Clothing, couches, stuffed furniture, metal cabinets,          Class 200 - TVs, aircraft parts, aluminum table, packaged mattresses, snowmobiles,          Class 250 - Bamboo furniture, engine hoods, mattresses and box springs, un-assembled couch, plasma TV,          Class 300 - Wood cabinets, tables, chairs, model boats, kayaks/canoes, chassis,          Class 400 - Deer antlers,          Class 500 - Bags of gold dust, ping pong balls      
    /// </summary>
    /// <value>          Note: Normally the class is auto-assigned by the rating system.           Class 50 – Clean Freight - Over 50 lbs,          Class 55 - Bricks, cement, mortar, hardwood flooring, cloths or rags, magazines, copy paper,          Class 60 - Car accessories & car parts, steel cables, used tires, stone blocks, glass, moldings,          Class 65 - Car parts & accessories, bottled beverages, books in boxes, conveyors, chocolate in boxes, electric cords, tile,          Class 70 - Newspapers, wooden pencils, machinery, caskets, un-assembled furniture, food items, automobile engine,          Class 77.5 - Tires, bathroom fixtures, garments, shirts/pants, snowplows,          Class 85 - Crated machinery, transmissions, clutches, doors, CDs/DVDs, motorcycle engine,          Class 92.5 - Computers, monitors, refrigerators and freezers, gas-powered generators, cabinets, kiosk or ATMs,          Class 100 - Vacuum, boat & car covers, canvas, wine cases, caskets,          CLass 110 - Cabinets, framed paintings & artwork, table saw, metalworking,          Class 125 - Small household appliances, pictures/posters in boxes, exhibit booths, vending machines,          Class 150 - ATV, jet skis, motorcycles, assembled wooden furniture, work stations,          Class 175 - Clothing, couches, stuffed furniture, metal cabinets,          Class 200 - TVs, aircraft parts, aluminum table, packaged mattresses, snowmobiles,          Class 250 - Bamboo furniture, engine hoods, mattresses and box springs, un-assembled couch, plasma TV,          Class 300 - Wood cabinets, tables, chairs, model boats, kayaks/canoes, chassis,          Class 400 - Deer antlers,          Class 500 - Bags of gold dust, ping pong balls      </value>
    [DataMember(Name="class", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "class")]
    public string _Class { get; set; }

    /// <summary>
    /// Gets or Sets Commodity
    /// </summary>
    [DataMember(Name="commodity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "commodity")]
    public string Commodity { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FreightTeamBookShipmentCreate {\n");
      sb.Append("  Quantity: ").Append(Quantity).Append("\n");
      sb.Append("  Weight: ").Append(Weight).Append("\n");
      sb.Append("  WeightType: ").Append(WeightType).Append("\n");
      sb.Append("  Length: ").Append(Length).Append("\n");
      sb.Append("  Width: ").Append(Width).Append("\n");
      sb.Append("  Height: ").Append(Height).Append("\n");
      sb.Append("  PackageType: ").Append(PackageType).Append("\n");
      sb.Append("  IsDangerous: ").Append(IsDangerous).Append("\n");
      sb.Append("  _Class: ").Append(_Class).Append("\n");
      sb.Append("  Commodity: ").Append(Commodity).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
