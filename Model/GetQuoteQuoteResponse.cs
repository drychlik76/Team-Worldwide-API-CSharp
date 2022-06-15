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
  public class GetQuoteQuoteResponse {
    /// <summary>
    /// Gets or Sets UniqueId
    /// </summary>
    [DataMember(Name="uniqueId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uniqueId")]
    public string UniqueId { get; set; }

    /// <summary>
    /// Gets or Sets QuoteId
    /// </summary>
    [DataMember(Name="quoteId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quoteId")]
    public int? QuoteId { get; set; }

    /// <summary>
    /// Gets or Sets QuoteNumber
    /// </summary>
    [DataMember(Name="quoteNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quoteNumber")]
    public string QuoteNumber { get; set; }

    /// <summary>
    /// Gets or Sets HouseBill
    /// </summary>
    [DataMember(Name="houseBill", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "houseBill")]
    public string HouseBill { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetQuoteQuoteResponse {\n");
      sb.Append("  UniqueId: ").Append(UniqueId).Append("\n");
      sb.Append("  QuoteId: ").Append(QuoteId).Append("\n");
      sb.Append("  QuoteNumber: ").Append(QuoteNumber).Append("\n");
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
