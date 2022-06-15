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
  public class RateDataJsonldTeamBookGetRateCreateCollectionGetRead {
    /// <summary>
    /// Gets or Sets Context
    /// </summary>
    [DataMember(Name="@context", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "@context")]
    public OneOfRateDataJsonldTeamBookGetRateCreateCollectionGetReadContext Context { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="@id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "@id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="@type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "@type")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets RateId
    /// </summary>
    [DataMember(Name="rateId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rateId")]
    public string RateId { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Code
    /// </summary>
    [DataMember(Name="code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "code")]
    public string Code { get; set; }

    /// <summary>
    /// Gets or Sets ServiceLevel
    /// </summary>
    [DataMember(Name="serviceLevel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "serviceLevel")]
    public string ServiceLevel { get; set; }

    /// <summary>
    /// Gets or Sets AccountNumber
    /// </summary>
    [DataMember(Name="accountNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountNumber")]
    public string AccountNumber { get; set; }

    /// <summary>
    /// Gets or Sets Total
    /// </summary>
    [DataMember(Name="total", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total")]
    public decimal? Total { get; set; }

    /// <summary>
    /// Gets or Sets RateType
    /// </summary>
    [DataMember(Name="rateType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rateType")]
    public string RateType { get; set; }

    /// <summary>
    /// Gets or Sets TransitDays
    /// </summary>
    [DataMember(Name="transitDays", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transitDays")]
    public int? TransitDays { get; set; }

    /// <summary>
    /// Gets or Sets IconUrl
    /// </summary>
    [DataMember(Name="iconUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "iconUrl")]
    public string IconUrl { get; set; }

    /// <summary>
    /// Gets or Sets RateRemarks
    /// </summary>
    [DataMember(Name="rateRemarks", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rateRemarks")]
    public List<string> RateRemarks { get; set; }

    /// <summary>
    /// Gets or Sets RateBreakDownList
    /// </summary>
    [DataMember(Name="rateBreakDownList", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rateBreakDownList")]
    public List<RateBreakDownJsonldTeamBookGetRateCreateCollectionGetRead> RateBreakDownList { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RateDataJsonldTeamBookGetRateCreateCollectionGetRead {\n");
      sb.Append("  Context: ").Append(Context).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  RateId: ").Append(RateId).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Code: ").Append(Code).Append("\n");
      sb.Append("  ServiceLevel: ").Append(ServiceLevel).Append("\n");
      sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
      sb.Append("  Total: ").Append(Total).Append("\n");
      sb.Append("  RateType: ").Append(RateType).Append("\n");
      sb.Append("  TransitDays: ").Append(TransitDays).Append("\n");
      sb.Append("  IconUrl: ").Append(IconUrl).Append("\n");
      sb.Append("  RateRemarks: ").Append(RateRemarks).Append("\n");
      sb.Append("  RateBreakDownList: ").Append(RateBreakDownList).Append("\n");
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
