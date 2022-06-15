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
  public class BookShipmentTeamBookShipmentCreate {
    /// <summary>
    /// Gets or Sets QuoteId
    /// </summary>
    [DataMember(Name="quoteId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quoteId")]
    public int? QuoteId { get; set; }

    /// <summary>
    /// Reserve a house bill from either /api/teamww/get-house-bill or get one from /api/team-book/get-quote/{rateId}
    /// </summary>
    /// <value>Reserve a house bill from either /api/teamww/get-house-bill or get one from /api/team-book/get-quote/{rateId}</value>
    [DataMember(Name="houseBill", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "houseBill")]
    public string HouseBill { get; set; }

    /// <summary>
    /// Leave this null. This is used in special cases.
    /// </summary>
    /// <value>Leave this null. This is used in special cases.</value>
    [DataMember(Name="bolPrefix", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bolPrefix")]
    public string BolPrefix { get; set; }

    /// <summary>
    /// Gets or Sets InsuranceAddon
    /// </summary>
    [DataMember(Name="insuranceAddon", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "insuranceAddon")]
    public bool? InsuranceAddon { get; set; }

    /// <summary>
    /// Gets or Sets ThirdPartyReferenceNumber
    /// </summary>
    [DataMember(Name="thirdPartyReferenceNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "thirdPartyReferenceNumber")]
    public string ThirdPartyReferenceNumber { get; set; }

    /// <summary>
    /// Gets or Sets ProNumber
    /// </summary>
    [DataMember(Name="proNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "proNumber")]
    public string ProNumber { get; set; }

    /// <summary>
    /// Gets or Sets TeamBookShipper
    /// </summary>
    [DataMember(Name="teamBookShipper", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "teamBookShipper")]
    public TeamBookShipperTeamBookShipmentCreate TeamBookShipper { get; set; }

    /// <summary>
    /// Gets or Sets TeamBookConsignee
    /// </summary>
    [DataMember(Name="teamBookConsignee", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "teamBookConsignee")]
    public TeamBookConsigneeTeamBookShipmentCreate TeamBookConsignee { get; set; }

    /// <summary>
    /// Gets or Sets BrokerInformation
    /// </summary>
    [DataMember(Name="brokerInformation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "brokerInformation")]
    public AnyOfBookShipmentTeamBookShipmentCreateBrokerInformation BrokerInformation { get; set; }

    /// <summary>
    /// Gets or Sets Instructions
    /// </summary>
    [DataMember(Name="instructions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "instructions")]
    public string Instructions { get; set; }

    /// <summary>
    /// Gets or Sets ShipmentNotes
    /// </summary>
    [DataMember(Name="shipmentNotes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipmentNotes")]
    public string ShipmentNotes { get; set; }

    /// <summary>
    /// Emergency Contact. Required if a shipment has hazardous materials.
    /// </summary>
    /// <value>Emergency Contact. Required if a shipment has hazardous materials.</value>
    [DataMember(Name="emergencyContact", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "emergencyContact")]
    public string EmergencyContact { get; set; }

    /// <summary>
    /// Emergency Phone Number. Required if a shipment has hazardous materials.
    /// </summary>
    /// <value>Emergency Phone Number. Required if a shipment has hazardous materials.</value>
    [DataMember(Name="emergencyPhone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "emergencyPhone")]
    public string EmergencyPhone { get; set; }

    /// <summary>
    /// Unit of Measure. Valid values: US (lbs/in) - METRIC (kgs/cm) - MIXED (kgs/cms)
    /// </summary>
    /// <value>Unit of Measure. Valid values: US (lbs/in) - METRIC (kgs/cm) - MIXED (kgs/cms)</value>
    [DataMember(Name="unitOfMeasure", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unitOfMeasure")]
    public string UnitOfMeasure { get; set; }

    /// <summary>
    /// Gets or Sets ShipmentReference1
    /// </summary>
    [DataMember(Name="shipmentReference1", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipmentReference1")]
    public string ShipmentReference1 { get; set; }

    /// <summary>
    /// Gets or Sets ShipmentReference2
    /// </summary>
    [DataMember(Name="shipmentReference2", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipmentReference2")]
    public string ShipmentReference2 { get; set; }

    /// <summary>
    /// Gets or Sets Pickup
    /// </summary>
    [DataMember(Name="pickup", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pickup")]
    public PickupTeamBookShipmentCreate Pickup { get; set; }

    /// <summary>
    /// Gets or Sets Delivery
    /// </summary>
    [DataMember(Name="delivery", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "delivery")]
    public AnyOfBookShipmentTeamBookShipmentCreateDelivery Delivery { get; set; }

    /// <summary>
    /// Array of accessorial codes. Refer to enabledAccessorials returned in /api/team-book/get-accessorials. Provide the code.
    /// </summary>
    /// <value>Array of accessorial codes. Refer to enabledAccessorials returned in /api/team-book/get-accessorials. Provide the code.</value>
    [DataMember(Name="teamBookAccessorials", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "teamBookAccessorials")]
    public List<string> TeamBookAccessorials { get; set; }

    /// <summary>
    /// Gets or Sets Freight
    /// </summary>
    [DataMember(Name="freight", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "freight")]
    public List<FreightTeamBookShipmentCreate> Freight { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BookShipmentTeamBookShipmentCreate {\n");
      sb.Append("  QuoteId: ").Append(QuoteId).Append("\n");
      sb.Append("  HouseBill: ").Append(HouseBill).Append("\n");
      sb.Append("  BolPrefix: ").Append(BolPrefix).Append("\n");
      sb.Append("  InsuranceAddon: ").Append(InsuranceAddon).Append("\n");
      sb.Append("  ThirdPartyReferenceNumber: ").Append(ThirdPartyReferenceNumber).Append("\n");
      sb.Append("  ProNumber: ").Append(ProNumber).Append("\n");
      sb.Append("  TeamBookShipper: ").Append(TeamBookShipper).Append("\n");
      sb.Append("  TeamBookConsignee: ").Append(TeamBookConsignee).Append("\n");
      sb.Append("  BrokerInformation: ").Append(BrokerInformation).Append("\n");
      sb.Append("  Instructions: ").Append(Instructions).Append("\n");
      sb.Append("  ShipmentNotes: ").Append(ShipmentNotes).Append("\n");
      sb.Append("  EmergencyContact: ").Append(EmergencyContact).Append("\n");
      sb.Append("  EmergencyPhone: ").Append(EmergencyPhone).Append("\n");
      sb.Append("  UnitOfMeasure: ").Append(UnitOfMeasure).Append("\n");
      sb.Append("  ShipmentReference1: ").Append(ShipmentReference1).Append("\n");
      sb.Append("  ShipmentReference2: ").Append(ShipmentReference2).Append("\n");
      sb.Append("  Pickup: ").Append(Pickup).Append("\n");
      sb.Append("  Delivery: ").Append(Delivery).Append("\n");
      sb.Append("  TeamBookAccessorials: ").Append(TeamBookAccessorials).Append("\n");
      sb.Append("  Freight: ").Append(Freight).Append("\n");
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
