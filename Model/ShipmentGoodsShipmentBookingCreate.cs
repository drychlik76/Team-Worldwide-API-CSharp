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
  public class ShipmentGoodsShipmentBookingCreate {
    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets Pieces
    /// </summary>
    [DataMember(Name="pieces", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pieces")]
    public int? Pieces { get; set; }

    /// <summary>
    /// Gets or Sets Length
    /// </summary>
    [DataMember(Name="length", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "length")]
    public decimal? Length { get; set; }

    /// <summary>
    /// Gets or Sets Height
    /// </summary>
    [DataMember(Name="height", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "height")]
    public decimal? Height { get; set; }

    /// <summary>
    /// Gets or Sets Width
    /// </summary>
    [DataMember(Name="width", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "width")]
    public decimal? Width { get; set; }

    /// <summary>
    /// Gets or Sets ItemWeight
    /// </summary>
    [DataMember(Name="itemWeight", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "itemWeight")]
    public decimal? ItemWeight { get; set; }

    /// <summary>
    /// Need to know if this a dangerous goods shipment
    /// </summary>
    /// <value>Need to know if this a dangerous goods shipment</value>
    [DataMember(Name="isDangerousGoods", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isDangerousGoods")]
    public bool? IsDangerousGoods { get; set; }

    /// <summary>
    /// If is dangerous goods, a description is required
    /// </summary>
    /// <value>If is dangerous goods, a description is required</value>
    [DataMember(Name="dangerousGoodsDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dangerousGoodsDescription")]
    public string DangerousGoodsDescription { get; set; }

    /// <summary>
    ///            [P] Piece,           [G] Bag,           [B] Box,           [K] Case,           [T] Tube,           [C] Crate,           [L] Loose,           [E] Pallet,           [S] Skid,           [U] Tub,           [D] Drum,           [N] Container         
    /// </summary>
    /// <value>           [P] Piece,           [G] Bag,           [B] Box,           [K] Case,           [T] Tube,           [C] Crate,           [L] Loose,           [E] Pallet,           [S] Skid,           [U] Tub,           [D] Drum,           [N] Container         </value>
    [DataMember(Name="packageType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "packageType")]
    public string PackageType { get; set; }

    /// <summary>
    /// Container Type
    /// </summary>
    /// <value>Container Type</value>
    [DataMember(Name="containerType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "containerType")]
    public string ContainerType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ShipmentGoodsShipmentBookingCreate {\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Pieces: ").Append(Pieces).Append("\n");
      sb.Append("  Length: ").Append(Length).Append("\n");
      sb.Append("  Height: ").Append(Height).Append("\n");
      sb.Append("  Width: ").Append(Width).Append("\n");
      sb.Append("  ItemWeight: ").Append(ItemWeight).Append("\n");
      sb.Append("  IsDangerousGoods: ").Append(IsDangerousGoods).Append("\n");
      sb.Append("  DangerousGoodsDescription: ").Append(DangerousGoodsDescription).Append("\n");
      sb.Append("  PackageType: ").Append(PackageType).Append("\n");
      sb.Append("  ContainerType: ").Append(ContainerType).Append("\n");
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
