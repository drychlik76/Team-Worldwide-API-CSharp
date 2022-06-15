using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace TeamWorldwideModel {

  /// <summary>
  /// Shipment API Resource
  /// </summary>
  [DataContract]
  public class UpdateTeamBookingUpdateTeamBooking {
    /// <summary>
    /// Carrier booking number
    /// </summary>
    /// <value>Carrier booking number</value>
    [DataMember(Name="carrierBookingNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "carrierBookingNumber")]
    public string CarrierBookingNumber { get; set; }

    /// <summary>
    /// Secondary carrier booking number
    /// </summary>
    /// <value>Secondary carrier booking number</value>
    [DataMember(Name="carrierBookingNumber2", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "carrierBookingNumber2")]
    public string CarrierBookingNumber2 { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UpdateTeamBookingUpdateTeamBooking {\n");
      sb.Append("  CarrierBookingNumber: ").Append(CarrierBookingNumber).Append("\n");
      sb.Append("  CarrierBookingNumber2: ").Append(CarrierBookingNumber2).Append("\n");
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
