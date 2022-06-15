using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace TeamWorldwideModel {

  /// <summary>
  /// Get Quote
  /// </summary>
  [DataContract]
  public class GetQuote {
    /// <summary>
    /// Gets or Sets RateId
    /// </summary>
    [DataMember(Name="rateId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rateId")]
    public string RateId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetQuote {\n");
      sb.Append("  RateId: ").Append(RateId).Append("\n");
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
