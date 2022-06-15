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
  public class UpdateTeamBookingGetShipmentBookingCollectionGetRead {
    /// <summary>
    /// Team Booking number
    /// </summary>
    /// <value>Team Booking number</value>
    [DataMember(Name="teamBookingNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "teamBookingNumber")]
    public string TeamBookingNumber { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UpdateTeamBookingGetShipmentBookingCollectionGetRead {\n");
      sb.Append("  TeamBookingNumber: ").Append(TeamBookingNumber).Append("\n");
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
