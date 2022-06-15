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
  public class RequestedDeliveryShipmentBookingCreate {
    /// <summary>
    ///           [R] Regular Delivery,          [M] Must Delivery,          [S] Special Delivery,          [D] Direct to Consignee,          [H] Hold on Dock      
    /// </summary>
    /// <value>          [R] Regular Delivery,          [M] Must Delivery,          [S] Special Delivery,          [D] Direct to Consignee,          [H] Hold on Dock      </value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Delivery date YYYY-MM-DD
    /// </summary>
    /// <value>Delivery date YYYY-MM-DD</value>
    [DataMember(Name="date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "date")]
    public DateTime? Date { get; set; }

    /// <summary>
    /// Time between
    /// </summary>
    /// <value>Time between</value>
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
    ///           [O] On,           [B] By          
    /// </summary>
    /// <value>          [O] On,           [B] By          </value>
    [DataMember(Name="onBy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "onBy")]
    public string OnBy { get; set; }

    /// <summary>
    /// Requested pickup related notes
    /// </summary>
    /// <value>Requested pickup related notes</value>
    [DataMember(Name="notes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "notes")]
    public string Notes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RequestedDeliveryShipmentBookingCreate {\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Date: ").Append(Date).Append("\n");
      sb.Append("  FromTime: ").Append(FromTime).Append("\n");
      sb.Append("  ToTime: ").Append(ToTime).Append("\n");
      sb.Append("  OnBy: ").Append(OnBy).Append("\n");
      sb.Append("  Notes: ").Append(Notes).Append("\n");
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
