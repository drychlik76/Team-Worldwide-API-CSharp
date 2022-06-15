using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace TeamWorldwideModel {

  /// <summary>
  /// Book Team Book Shipment
  /// </summary>
  [DataContract]
  public class BookShipmentTeamBookResponseJsonld {
    /// <summary>
    /// Gets or Sets Context
    /// </summary>
    [DataMember(Name="@context", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "@context")]
    public OneOfBookShipmentTeamBookResponseJsonldContext Context { get; set; }

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
    /// Gets or Sets HouseBill
    /// </summary>
    [DataMember(Name="houseBill", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "houseBill")]
    public string HouseBill { get; set; }

    /// <summary>
    /// Gets or Sets BOLNumber
    /// </summary>
    [DataMember(Name="BOLNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BOLNumber")]
    public string BOLNumber { get; set; }

    /// <summary>
    /// Gets or Sets BOLPrefix
    /// </summary>
    [DataMember(Name="BOLPrefix", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BOLPrefix")]
    public string BOLPrefix { get; set; }

    /// <summary>
    /// Gets or Sets Accessorials
    /// </summary>
    [DataMember(Name="accessorials", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accessorials")]
    public List<string> Accessorials { get; set; }

    /// <summary>
    /// Gets or Sets Dispatched
    /// </summary>
    [DataMember(Name="dispatched", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dispatched")]
    public bool? Dispatched { get; set; }

    /// <summary>
    /// Gets or Sets DispatchError
    /// </summary>
    [DataMember(Name="dispatchError", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dispatchError")]
    public string DispatchError { get; set; }

    /// <summary>
    /// Gets or Sets TotalWeight
    /// </summary>
    [DataMember(Name="totalWeight", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalWeight")]
    public decimal? TotalWeight { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BookShipmentTeamBookResponseJsonld {\n");
      sb.Append("  Context: ").Append(Context).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  HouseBill: ").Append(HouseBill).Append("\n");
      sb.Append("  BOLNumber: ").Append(BOLNumber).Append("\n");
      sb.Append("  BOLPrefix: ").Append(BOLPrefix).Append("\n");
      sb.Append("  Accessorials: ").Append(Accessorials).Append("\n");
      sb.Append("  Dispatched: ").Append(Dispatched).Append("\n");
      sb.Append("  DispatchError: ").Append(DispatchError).Append("\n");
      sb.Append("  TotalWeight: ").Append(TotalWeight).Append("\n");
      sb.Append("  BOLNumber: ").Append(BOLNumber).Append("\n");
      sb.Append("  BOLPrefix: ").Append(BOLPrefix).Append("\n");
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
