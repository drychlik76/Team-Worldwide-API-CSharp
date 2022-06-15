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
  public class ShipmentCreated {
    /// <summary>
    /// Gets or Sets UniqueId
    /// </summary>
    [DataMember(Name="uniqueId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uniqueId")]
    public string UniqueId { get; set; }

    /// <summary>
    /// Gets or Sets ShipmentKey
    /// </summary>
    [DataMember(Name="shipmentKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipmentKey")]
    public int? ShipmentKey { get; set; }

    /// <summary>
    /// Gets or Sets HouseBill
    /// </summary>
    [DataMember(Name="houseBill", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "houseBill")]
    public string HouseBill { get; set; }

    /// <summary>
    /// Gets or Sets PickupDateAsReadable
    /// </summary>
    [DataMember(Name="pickupDateAsReadable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pickupDateAsReadable")]
    public string PickupDateAsReadable { get; set; }

    /// <summary>
    /// Gets or Sets PickupDate
    /// </summary>
    [DataMember(Name="pickupDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pickupDate")]
    public DateTime? PickupDate { get; set; }

    /// <summary>
    /// Gets or Sets ReferenceNumbers
    /// </summary>
    [DataMember(Name="referenceNumbers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "referenceNumbers")]
    public List<string> ReferenceNumbers { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ShipmentCreated {\n");
      sb.Append("  UniqueId: ").Append(UniqueId).Append("\n");
      sb.Append("  ShipmentKey: ").Append(ShipmentKey).Append("\n");
      sb.Append("  HouseBill: ").Append(HouseBill).Append("\n");
      sb.Append("  PickupDateAsReadable: ").Append(PickupDateAsReadable).Append("\n");
      sb.Append("  PickupDate: ").Append(PickupDate).Append("\n");
      sb.Append("  ReferenceNumbers: ").Append(ReferenceNumbers).Append("\n");
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
