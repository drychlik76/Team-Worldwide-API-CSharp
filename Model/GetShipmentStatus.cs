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
  public class GetShipmentStatus {
    /// <summary>
    /// Search by house bill or list of house bills.
    /// </summary>
    /// <value>Search by house bill or list of house bills.</value>
    [DataMember(Name="houseBill", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "houseBill")]
    public string HouseBill { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetShipmentStatus {\n");
      sb.Append("  HouseBill: ").Append(HouseBill).Append("\n");
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
