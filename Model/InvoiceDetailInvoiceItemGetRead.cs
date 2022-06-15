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
  public class InvoiceDetailInvoiceItemGetRead {
    /// <summary>
    /// Gets or Sets ChargeCode
    /// </summary>
    [DataMember(Name="chargeCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "chargeCode")]
    public string ChargeCode { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets Charge
    /// </summary>
    [DataMember(Name="charge", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "charge")]
    public decimal? Charge { get; set; }

    /// <summary>
    /// Gets or Sets Amount
    /// </summary>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public string Amount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class InvoiceDetailInvoiceItemGetRead {\n");
      sb.Append("  ChargeCode: ").Append(ChargeCode).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Charge: ").Append(Charge).Append("\n");
      sb.Append("  Amount: ").Append(Amount).Append("\n");
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
