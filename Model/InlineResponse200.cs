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
  public class InlineResponse200 {
    /// <summary>
    /// Gets or Sets Hydramember
    /// </summary>
    [DataMember(Name="hydra:member", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hydra:member")]
    public List<GetAccessorialsTeamBookAccessorialJsonldTeamBookGetAccessorialCreateCollectionGetRead> Hydramember { get; set; }

    /// <summary>
    /// Gets or Sets HydratotalItems
    /// </summary>
    [DataMember(Name="hydra:totalItems", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hydra:totalItems")]
    public int? HydratotalItems { get; set; }

    /// <summary>
    /// Gets or Sets Hydraview
    /// </summary>
    [DataMember(Name="hydra:view", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hydra:view")]
    public InlineResponse200Hydraview Hydraview { get; set; }

    /// <summary>
    /// Gets or Sets Hydrasearch
    /// </summary>
    [DataMember(Name="hydra:search", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hydra:search")]
    public InlineResponse200Hydrasearch Hydrasearch { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class InlineResponse200 {\n");
      sb.Append("  Hydramember: ").Append(Hydramember).Append("\n");
      sb.Append("  HydratotalItems: ").Append(HydratotalItems).Append("\n");
      sb.Append("  Hydraview: ").Append(Hydraview).Append("\n");
      sb.Append("  Hydrasearch: ").Append(Hydrasearch).Append("\n");
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
