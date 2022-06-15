using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace TeamWorldwideModel {

  /// <summary>
  /// Shipment Status API 
  /// </summary>
  [DataContract]
  public class GetShipmentStatusShipmentStatusGetShipmentStatusCollectionGetRead {
    /// <summary>
    /// Gets or Sets UniqueId
    /// </summary>
    [DataMember(Name="uniqueId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uniqueId")]
    public string UniqueId { get; set; }

    /// <summary>
    /// Gets or Sets HouseBill
    /// </summary>
    [DataMember(Name="houseBill", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "houseBill")]
    public string HouseBill { get; set; }

    /// <summary>
    /// Gets or Sets StatusCode
    /// </summary>
    [DataMember(Name="statusCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "statusCode")]
    public string StatusCode { get; set; }

    /// <summary>
    /// Gets or Sets StatusMessage
    /// </summary>
    [DataMember(Name="statusMessage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "statusMessage")]
    public string StatusMessage { get; set; }

    /// <summary>
    /// Gets or Sets StatusDate
    /// </summary>
    [DataMember(Name="statusDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "statusDate")]
    public string StatusDate { get; set; }

    /// <summary>
    /// Gets or Sets StatusTime
    /// </summary>
    [DataMember(Name="statusTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "statusTime")]
    public string StatusTime { get; set; }

    /// <summary>
    /// Gets or Sets ControlAirport
    /// </summary>
    [DataMember(Name="controlAirport", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "controlAirport")]
    public string ControlAirport { get; set; }

    /// <summary>
    /// Gets or Sets Origin
    /// </summary>
    [DataMember(Name="origin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "origin")]
    public string Origin { get; set; }

    /// <summary>
    /// Gets or Sets Destination
    /// </summary>
    [DataMember(Name="destination", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "destination")]
    public string Destination { get; set; }

    /// <summary>
    /// Gets or Sets Comment
    /// </summary>
    [DataMember(Name="comment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "comment")]
    public string Comment { get; set; }

    /// <summary>
    /// Gets or Sets GmtOffset
    /// </summary>
    [DataMember(Name="gmtOffset", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gmtOffset")]
    public int? GmtOffset { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetShipmentStatusShipmentStatusGetShipmentStatusCollectionGetRead {\n");
      sb.Append("  UniqueId: ").Append(UniqueId).Append("\n");
      sb.Append("  HouseBill: ").Append(HouseBill).Append("\n");
      sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
      sb.Append("  StatusMessage: ").Append(StatusMessage).Append("\n");
      sb.Append("  StatusDate: ").Append(StatusDate).Append("\n");
      sb.Append("  StatusTime: ").Append(StatusTime).Append("\n");
      sb.Append("  ControlAirport: ").Append(ControlAirport).Append("\n");
      sb.Append("  Origin: ").Append(Origin).Append("\n");
      sb.Append("  Destination: ").Append(Destination).Append("\n");
      sb.Append("  Comment: ").Append(Comment).Append("\n");
      sb.Append("  GmtOffset: ").Append(GmtOffset).Append("\n");
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
