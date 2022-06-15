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
  public class InlineResponse200Hydrasearch {
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="@type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "@type")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets Hydratemplate
    /// </summary>
    [DataMember(Name="hydra:template", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hydra:template")]
    public string Hydratemplate { get; set; }

    /// <summary>
    /// Gets or Sets HydravariableRepresentation
    /// </summary>
    [DataMember(Name="hydra:variableRepresentation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hydra:variableRepresentation")]
    public string HydravariableRepresentation { get; set; }

    /// <summary>
    /// Gets or Sets Hydramapping
    /// </summary>
    [DataMember(Name="hydra:mapping", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hydra:mapping")]
    public List<InlineResponse200HydrasearchHydramapping> Hydramapping { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class InlineResponse200Hydrasearch {\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Hydratemplate: ").Append(Hydratemplate).Append("\n");
      sb.Append("  HydravariableRepresentation: ").Append(HydravariableRepresentation).Append("\n");
      sb.Append("  Hydramapping: ").Append(Hydramapping).Append("\n");
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
