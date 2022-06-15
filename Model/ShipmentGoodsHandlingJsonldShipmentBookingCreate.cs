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
  public class ShipmentGoodsHandlingJsonldShipmentBookingCreate {
    /// <summary>
    /// Gets or Sets Context
    /// </summary>
    [DataMember(Name="@context", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "@context")]
    public OneOfShipmentGoodsHandlingJsonldShipmentBookingCreateContext Context { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="@id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "@id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="@type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "@type")]
    public string Type { get; set; }

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
    /// Gets or Sets Weight
    /// </summary>
    [DataMember(Name="weight", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "weight")]
    public decimal? Weight { get; set; }

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
    /// Gets or Sets Length
    /// </summary>
    [DataMember(Name="length", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "length")]
    public decimal? Length { get; set; }

    /// <summary>
    /// Gets or Sets Volume
    /// </summary>
    [DataMember(Name="volume", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "volume")]
    public decimal? Volume { get; set; }

    /// <summary>
    /// Gets or Sets DimensionalWeight
    /// </summary>
    [DataMember(Name="dimensionalWeight", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dimensionalWeight")]
    public decimal? DimensionalWeight { get; set; }

    /// <summary>
    /// Gets or Sets ContainerType
    /// </summary>
    [DataMember(Name="containerType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "containerType")]
    public string ContainerType { get; set; }

    /// <summary>
    /// Gets or Sets ContainerNumber
    /// </summary>
    [DataMember(Name="containerNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "containerNumber")]
    public string ContainerNumber { get; set; }

    /// <summary>
    /// Gets or Sets SealNumber
    /// </summary>
    [DataMember(Name="sealNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sealNumber")]
    public string SealNumber { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ShipmentGoodsHandlingJsonldShipmentBookingCreate {\n");
      sb.Append("  Context: ").Append(Context).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Pieces: ").Append(Pieces).Append("\n");
      sb.Append("  Weight: ").Append(Weight).Append("\n");
      sb.Append("  Height: ").Append(Height).Append("\n");
      sb.Append("  Width: ").Append(Width).Append("\n");
      sb.Append("  Length: ").Append(Length).Append("\n");
      sb.Append("  Volume: ").Append(Volume).Append("\n");
      sb.Append("  DimensionalWeight: ").Append(DimensionalWeight).Append("\n");
      sb.Append("  ContainerType: ").Append(ContainerType).Append("\n");
      sb.Append("  ContainerNumber: ").Append(ContainerNumber).Append("\n");
      sb.Append("  SealNumber: ").Append(SealNumber).Append("\n");
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
