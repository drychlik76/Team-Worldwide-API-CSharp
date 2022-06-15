using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace TeamWorldwideModel {

  /// <summary>
  /// Shipment Note API Resource
  /// </summary>
  [DataContract]
  public class ShipmentNoteResourceJsonldShipmentCreate {
    /// <summary>
    /// Gets or Sets Context
    /// </summary>
    [DataMember(Name="@context", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "@context")]
    public OneOfShipmentNoteResourceJsonldShipmentCreateContext Context { get; set; }

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
    ///           [CA] Carrier,          [DL] Delivery,          [DP] Denied Party,          [DO] Document,          [GN] General,          [HB] HouseBill,          [IN] Invoice,          [PM] Permissions,          [PU] Pickup,          [PR] Procurement,          [PC] Procurement Costs,          [RC] Recap,          [RT] Routing,          [SH] Shipment,          [ST] Status,          [TK] Tracking,          [WT] WorldTrak      
    /// </summary>
    /// <value>          [CA] Carrier,          [DL] Delivery,          [DP] Denied Party,          [DO] Document,          [GN] General,          [HB] HouseBill,          [IN] Invoice,          [PM] Permissions,          [PU] Pickup,          [PR] Procurement,          [PC] Procurement Costs,          [RC] Recap,          [RT] Routing,          [SH] Shipment,          [ST] Status,          [TK] Tracking,          [WT] WorldTrak      </value>
    [DataMember(Name="noteType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "noteType")]
    public string NoteType { get; set; }

    /// <summary>
    /// Gets or Sets Text
    /// </summary>
    [DataMember(Name="text", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "text")]
    public string Text { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ShipmentNoteResourceJsonldShipmentCreate {\n");
      sb.Append("  Context: ").Append(Context).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  NoteType: ").Append(NoteType).Append("\n");
      sb.Append("  Text: ").Append(Text).Append("\n");
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
