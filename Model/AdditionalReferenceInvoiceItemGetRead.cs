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
  public class AdditionalReferenceInvoiceItemGetRead {
    /// <summary>
    ///           [GBL] GBL/CBL#,          [RF] Reference Number (General),          [PO] Purchase Order#,          [IN] Invoice Number,          [TCN] Transportation Control Number,          [MF] Manifest Number,          [CI] Commercial Invoice,          [PK] Packing List,          [PN] Part Number ,          [VIN] Vehicle Identification Number,          [PRO] Progressive (Pro) Number,          [CTR] Container Number,          [SN] Serial Number,          [SEL] Seal Number,          [VTL] Vehicle Title Number,          [VTS] Vehicle Title State,          [SO] Service Order#,          [BTH] Booth Number,          [QTE] Quote Number,          [JN] Job Number,          [SHW] Show Name,          [SHW] Decorator,          [SHN] Show Number,          [APT] Appointment Number,          [DN] Delivery Number,          [BOL] Bill of Lading,          [PUP] Pickup Number      
    /// </summary>
    /// <value>          [GBL] GBL/CBL#,          [RF] Reference Number (General),          [PO] Purchase Order#,          [IN] Invoice Number,          [TCN] Transportation Control Number,          [MF] Manifest Number,          [CI] Commercial Invoice,          [PK] Packing List,          [PN] Part Number ,          [VIN] Vehicle Identification Number,          [PRO] Progressive (Pro) Number,          [CTR] Container Number,          [SN] Serial Number,          [SEL] Seal Number,          [VTL] Vehicle Title Number,          [VTS] Vehicle Title State,          [SO] Service Order#,          [BTH] Booth Number,          [QTE] Quote Number,          [JN] Job Number,          [SHW] Show Name,          [SHW] Decorator,          [SHN] Show Number,          [APT] Appointment Number,          [DN] Delivery Number,          [BOL] Bill of Lading,          [PUP] Pickup Number      </value>
    [DataMember(Name="referenceType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "referenceType")]
    public string ReferenceType { get; set; }

    /// <summary>
    /// Gets or Sets Reference
    /// </summary>
    [DataMember(Name="reference", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reference")]
    public string Reference { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AdditionalReferenceInvoiceItemGetRead {\n");
      sb.Append("  ReferenceType: ").Append(ReferenceType).Append("\n");
      sb.Append("  Reference: ").Append(Reference).Append("\n");
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
