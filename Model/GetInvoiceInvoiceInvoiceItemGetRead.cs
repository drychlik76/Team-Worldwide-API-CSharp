using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace TeamWorldwideModel {

  /// <summary>
  /// Invoice API Resource
  /// </summary>
  [DataContract]
  public class GetInvoiceInvoiceInvoiceItemGetRead {
    /// <summary>
    /// Gets or Sets InvoiceNumber
    /// </summary>
    [DataMember(Name="invoiceNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoiceNumber")]
    public string InvoiceNumber { get; set; }

    /// <summary>
    /// Gets or Sets ControlBranch
    /// </summary>
    [DataMember(Name="controlBranch", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "controlBranch")]
    public string ControlBranch { get; set; }

    /// <summary>
    /// Gets or Sets Company
    /// </summary>
    [DataMember(Name="company", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "company")]
    public string Company { get; set; }

    /// <summary>
    /// Gets or Sets ShipmentType
    /// </summary>
    [DataMember(Name="shipmentType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipmentType")]
    public string ShipmentType { get; set; }

    /// <summary>
    /// Gets or Sets Origin
    /// </summary>
    [DataMember(Name="origin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "origin")]
    public string Origin { get; set; }

    /// <summary>
    /// Gets or Sets Destination
    /// </summary>
    [DataMember(Name="destination", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "destination")]
    public string Destination { get; set; }

    /// <summary>
    /// Gets or Sets Pieces
    /// </summary>
    [DataMember(Name="pieces", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pieces")]
    public int? Pieces { get; set; }

    /// <summary>
    /// Gets or Sets Weight
    /// </summary>
    [DataMember(Name="weight", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "weight")]
    public decimal? Weight { get; set; }

    /// <summary>
    /// Gets or Sets PickupDate
    /// </summary>
    [DataMember(Name="pickupDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pickupDate")]
    public DateTime? PickupDate { get; set; }

    /// <summary>
    /// Gets or Sets ShipDate
    /// </summary>
    [DataMember(Name="shipDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipDate")]
    public DateTime? ShipDate { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Gets or Sets InvoiceDate
    /// </summary>
    [DataMember(Name="invoiceDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoiceDate")]
    public DateTime? InvoiceDate { get; set; }

    /// <summary>
    /// Gets or Sets CustomerNumber
    /// </summary>
    [DataMember(Name="customerNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customerNumber")]
    public string CustomerNumber { get; set; }

    /// <summary>
    /// Gets or Sets CustomerName
    /// </summary>
    [DataMember(Name="customerName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customerName")]
    public string CustomerName { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets Total
    /// </summary>
    [DataMember(Name="total", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total")]
    public decimal? Total { get; set; }

    /// <summary>
    /// Gets or Sets TotalInvoice
    /// </summary>
    [DataMember(Name="totalInvoice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalInvoice")]
    public string TotalInvoice { get; set; }

    /// <summary>
    /// Gets or Sets Shipper
    /// </summary>
    [DataMember(Name="shipper", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipper")]
    public ShipperInvoiceItemGetRead Shipper { get; set; }

    /// <summary>
    /// Gets or Sets Consignee
    /// </summary>
    [DataMember(Name="consignee", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "consignee")]
    public ConsigneeInvoiceItemGetRead Consignee { get; set; }

    /// <summary>
    /// Gets or Sets BillTo
    /// </summary>
    [DataMember(Name="billTo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billTo")]
    public BillToInvoiceItemGetRead BillTo { get; set; }

    /// <summary>
    /// Gets or Sets InvoiceDetail
    /// </summary>
    [DataMember(Name="invoiceDetail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoiceDetail")]
    public List<InvoiceDetailInvoiceItemGetRead> InvoiceDetail { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetInvoiceInvoiceInvoiceItemGetRead {\n");
      sb.Append("  InvoiceNumber: ").Append(InvoiceNumber).Append("\n");
      sb.Append("  ControlBranch: ").Append(ControlBranch).Append("\n");
      sb.Append("  Company: ").Append(Company).Append("\n");
      sb.Append("  ShipmentType: ").Append(ShipmentType).Append("\n");
      sb.Append("  Origin: ").Append(Origin).Append("\n");
      sb.Append("  Destination: ").Append(Destination).Append("\n");
      sb.Append("  Pieces: ").Append(Pieces).Append("\n");
      sb.Append("  Weight: ").Append(Weight).Append("\n");
      sb.Append("  PickupDate: ").Append(PickupDate).Append("\n");
      sb.Append("  ShipDate: ").Append(ShipDate).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  InvoiceDate: ").Append(InvoiceDate).Append("\n");
      sb.Append("  CustomerNumber: ").Append(CustomerNumber).Append("\n");
      sb.Append("  CustomerName: ").Append(CustomerName).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Total: ").Append(Total).Append("\n");
      sb.Append("  TotalInvoice: ").Append(TotalInvoice).Append("\n");
      sb.Append("  Shipper: ").Append(Shipper).Append("\n");
      sb.Append("  Consignee: ").Append(Consignee).Append("\n");
      sb.Append("  BillTo: ").Append(BillTo).Append("\n");
      sb.Append("  InvoiceDetail: ").Append(InvoiceDetail).Append("\n");
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
