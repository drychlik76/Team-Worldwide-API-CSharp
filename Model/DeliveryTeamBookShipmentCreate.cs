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
  public class DeliveryTeamBookShipmentCreate {
    /// <summary>
    /// Gets or Sets Date
    /// </summary>
    [DataMember(Name="date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "date")]
    public DateTime? Date { get; set; }

    /// <summary>
    /// Delivery on or deliver by
    /// </summary>
    /// <value>Delivery on or deliver by</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// From time
    /// </summary>
    /// <value>From time</value>
    [DataMember(Name="fromTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fromTime")]
    public DateTime? FromTime { get; set; }

    /// <summary>
    /// Time between
    /// </summary>
    /// <value>Time between</value>
    [DataMember(Name="toTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "toTime")]
    public DateTime? ToTime { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DeliveryTeamBookShipmentCreate {\n");
      sb.Append("  Date: ").Append(Date).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  FromTime: ").Append(FromTime).Append("\n");
      sb.Append("  ToTime: ").Append(ToTime).Append("\n");
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
