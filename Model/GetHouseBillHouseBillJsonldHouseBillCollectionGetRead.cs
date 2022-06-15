using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace TeamWorldwideModel {

  /// <summary>
  /// Get and Reserve House Bill
  /// </summary>
  [DataContract]
  public class GetHouseBillHouseBillJsonldHouseBillCollectionGetRead {
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
    /// Gets or Sets Context
    /// </summary>
    [DataMember(Name="@context", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "@context")]
    public OneOfGetHouseBillHouseBillJsonldHouseBillCollectionGetReadContext Context { get; set; }

    /// <summary>
    /// Gets or Sets HouseBill
    /// </summary>
    [DataMember(Name="houseBill", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "houseBill")]
    public string HouseBill { get; set; }

    /// <summary>
    /// Gets or Sets CreatedDateTime
    /// </summary>
    [DataMember(Name="createdDateTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdDateTime")]
    public DateTime? CreatedDateTime { get; set; }

    /// <summary>
    /// Gets or Sets Reserved
    /// </summary>
    [DataMember(Name="reserved", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reserved")]
    public bool? Reserved { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetHouseBillHouseBillJsonldHouseBillCollectionGetRead {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Context: ").Append(Context).Append("\n");
      sb.Append("  HouseBill: ").Append(HouseBill).Append("\n");
      sb.Append("  CreatedDateTime: ").Append(CreatedDateTime).Append("\n");
      sb.Append("  Reserved: ").Append(Reserved).Append("\n");
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
