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
  public class GetHouseBillJsonld {
    /// <summary>
    /// Gets or Sets Context
    /// </summary>
    [DataMember(Name="@context", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "@context")]
    public OneOfGetHouseBillJsonldContext Context { get; set; }

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
    /// Branch ID, or can use Airport code.  This is sometimes referred to as `station id`.
    /// </summary>
    /// <value>Branch ID, or can use Airport code.  This is sometimes referred to as `station id`.</value>
    [DataMember(Name="branchId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "branchId")]
    public string BranchId { get; set; }

    /// <summary>
    /// Account number for customer
    /// </summary>
    /// <value>Account number for customer</value>
    [DataMember(Name="accountNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountNumber")]
    public string AccountNumber { get; set; }

    /// <summary>
    /// Class of house bills          AIR,          AIRT,          CAN,          OCN,          OCNT,          PRIM,          TEST,          TRAC,          TRK,          TRKT      
    /// </summary>
    /// <value>Class of house bills          AIR,          AIRT,          CAN,          OCN,          OCNT,          PRIM,          TEST,          TRAC,          TRK,          TRKT      </value>
    [DataMember(Name="class", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "class")]
    public string _Class { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetHouseBillJsonld {\n");
      sb.Append("  Context: ").Append(Context).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  BranchId: ").Append(BranchId).Append("\n");
      sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
      sb.Append("  _Class: ").Append(_Class).Append("\n");
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
