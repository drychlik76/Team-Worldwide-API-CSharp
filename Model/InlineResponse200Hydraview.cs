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
  public class InlineResponse200Hydraview {
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
    /// Gets or Sets Hydrafirst
    /// </summary>
    [DataMember(Name="hydra:first", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hydra:first")]
    public string Hydrafirst { get; set; }

    /// <summary>
    /// Gets or Sets Hydralast
    /// </summary>
    [DataMember(Name="hydra:last", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hydra:last")]
    public string Hydralast { get; set; }

    /// <summary>
    /// Gets or Sets Hydraprevious
    /// </summary>
    [DataMember(Name="hydra:previous", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hydra:previous")]
    public string Hydraprevious { get; set; }

    /// <summary>
    /// Gets or Sets Hydranext
    /// </summary>
    [DataMember(Name="hydra:next", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hydra:next")]
    public string Hydranext { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class InlineResponse200Hydraview {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Hydrafirst: ").Append(Hydrafirst).Append("\n");
      sb.Append("  Hydralast: ").Append(Hydralast).Append("\n");
      sb.Append("  Hydraprevious: ").Append(Hydraprevious).Append("\n");
      sb.Append("  Hydranext: ").Append(Hydranext).Append("\n");
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
