using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace TeamWorldwideModel {

  /// <summary>
  /// Get Rates
  /// </summary>
  [DataContract]
  public class GetRateRateResponseTeamBookGetRateCreateCollectionGetRead {
    /// <summary>
    /// Gets or Sets UniqueId
    /// </summary>
    [DataMember(Name="uniqueId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uniqueId")]
    public string UniqueId { get; set; }

    /// <summary>
    /// Gets or Sets QuoteDisclaimer
    /// </summary>
    [DataMember(Name="quoteDisclaimer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quoteDisclaimer")]
    public string QuoteDisclaimer { get; set; }

    /// <summary>
    /// Gets or Sets Vendors
    /// </summary>
    [DataMember(Name="vendors", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vendors")]
    public List<string> Vendors { get; set; }

    /// <summary>
    /// Rates from provider
    /// </summary>
    /// <value>Rates from provider</value>
    [DataMember(Name="rateDataCollection", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rateDataCollection")]
    public List<RateDataTeamBookGetRateCreateCollectionGetRead> RateDataCollection { get; set; }

    /// <summary>
    /// No rates available from provider
    /// </summary>
    /// <value>No rates available from provider</value>
    [DataMember(Name="rateNoDataCollection", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rateNoDataCollection")]
    public List<RateNoDataTeamBookGetRateCreateCollectionGetRead> RateNoDataCollection { get; set; }

    /// <summary>
    /// Gets or Sets Accessorials
    /// </summary>
    [DataMember(Name="accessorials", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accessorials")]
    public List<string> Accessorials { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetRateRateResponseTeamBookGetRateCreateCollectionGetRead {\n");
      sb.Append("  UniqueId: ").Append(UniqueId).Append("\n");
      sb.Append("  QuoteDisclaimer: ").Append(QuoteDisclaimer).Append("\n");
      sb.Append("  Vendors: ").Append(Vendors).Append("\n");
      sb.Append("  RateDataCollection: ").Append(RateDataCollection).Append("\n");
      sb.Append("  RateNoDataCollection: ").Append(RateNoDataCollection).Append("\n");
      sb.Append("  Accessorials: ").Append(Accessorials).Append("\n");
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
