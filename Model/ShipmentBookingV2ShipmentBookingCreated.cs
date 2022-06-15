using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace TeamWorldwideModel {

  /// <summary>
  /// Shipment Booking API Resource
  /// </summary>
  [DataContract]
  public class ShipmentBookingV2ShipmentBookingCreated {
    /// <summary>
    /// Gets or Sets UniqueId
    /// </summary>
    [DataMember(Name="uniqueId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uniqueId")]
    public string UniqueId { get; set; }

    /// <summary>
    /// Gets or Sets TeamBookingNumber
    /// </summary>
    [DataMember(Name="teamBookingNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "teamBookingNumber")]
    public string TeamBookingNumber { get; set; }

    /// <summary>
    /// Gets or Sets IsBooked
    /// </summary>
    [DataMember(Name="isBooked", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isBooked")]
    public bool? IsBooked { get; set; }

    /// <summary>
    /// Gets or Sets Shipments
    /// </summary>
    [DataMember(Name="shipments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipments")]
    public List<ShipmentCreated> Shipments { get; set; }

    /// <summary>
    /// Gets or Sets Booked
    /// </summary>
    [DataMember(Name="booked", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "booked")]
    public bool? Booked { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ShipmentBookingV2ShipmentBookingCreated {\n");
      sb.Append("  UniqueId: ").Append(UniqueId).Append("\n");
      sb.Append("  TeamBookingNumber: ").Append(TeamBookingNumber).Append("\n");
      sb.Append("  IsBooked: ").Append(IsBooked).Append("\n");
      sb.Append("  Shipments: ").Append(Shipments).Append("\n");
      sb.Append("  Booked: ").Append(Booked).Append("\n");
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
