using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace TeamWorldwideModel {

  /// <summary>
  /// Shipment API Resource
  /// </summary>
  [DataContract]
  public class ShipmentV2ShipmentShipmentCreate {
    /// <summary>
    /// Set true if this is a live shipment
    /// </summary>
    /// <value>Set true if this is a live shipment</value>
    [DataMember(Name="isTestShipment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isTestShipment")]
    public bool? IsTestShipment { get; set; }

    /// <summary>
    /// If your account is enabled to pre-reserve the house bill,               you must reserve a house bill from the /api/teamww/get-house-bill endpoint.  Leave this property blank and a house bill,              will be generated for you.
    /// </summary>
    /// <value>If your account is enabled to pre-reserve the house bill,               you must reserve a house bill from the /api/teamww/get-house-bill endpoint.  Leave this property blank and a house bill,              will be generated for you.</value>
    [DataMember(Name="houseBill", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "houseBill")]
    public string HouseBill { get; set; }

    /// <summary>
    /// Control branch.  Can be null.
    /// </summary>
    /// <value>Control branch.  Can be null.</value>
    [DataMember(Name="controlBranch", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "controlBranch")]
    public string ControlBranch { get; set; }

    /// <summary>
    ///                [01] TAE,               [02] TOS,               [03] TCB,               [05] TWC,               [21] LIB,               [25] PWJ,               [27] RAV          
    /// </summary>
    /// <value>               [01] TAE,               [02] TOS,               [03] TCB,               [05] TWC,               [21] LIB,               [25] PWJ,               [27] RAV          </value>
    [DataMember(Name="company", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "company")]
    public string Company { get; set; }

    /// <summary>
    ///               [1] Domestic Air,              [2] International Air Export,              [3] International Air Import,              [4] Ocean Export (FMC),              [5] Ocean Export (NVOCC),              [6] Ocean Import (FMC),              [7] Ocean Import (NVOCC),              [8] Domestic Truck,              [19] Domestic Warehouse,              [20] Ocean Warehouse,              [21] International Warehouse,              [22] Intl Customs Brokerage,              [23] Ocean Customs Brokerage,              [24] Ocean Import (Unregulated),              [25] Ocean Export (Unregulated),              [26] International Truck Import,              [27] International Truck Export,              [30] International Truck,              [31] International Air,              [32] Ocean Unregulated          
    /// </summary>
    /// <value>              [1] Domestic Air,              [2] International Air Export,              [3] International Air Import,              [4] Ocean Export (FMC),              [5] Ocean Export (NVOCC),              [6] Ocean Import (FMC),              [7] Ocean Import (NVOCC),              [8] Domestic Truck,              [19] Domestic Warehouse,              [20] Ocean Warehouse,              [21] International Warehouse,              [22] Intl Customs Brokerage,              [23] Ocean Customs Brokerage,              [24] Ocean Import (Unregulated),              [25] Ocean Export (Unregulated),              [26] International Truck Import,              [27] International Truck Export,              [30] International Truck,              [31] International Air,              [32] Ocean Unregulated          </value>
    [DataMember(Name="shipmentType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipmentType")]
    public string ShipmentType { get; set; }

    /// <summary>
    ///           [D] Same Day,          [N] Over The Counter,          [A] Overnight AM,          [P] Overnight PM,          [R] International Express,          [T] International Standard,          [M] International Economy,          [O] Other,          [Q] Charter,          [S] Standard,          [2] Standard 2 (2-day),          [3] Economy (3-day),          [5] Deferred (4-5 day),          [L] LTL,          [F] FTL,          [U] EUV/Hotshot
    /// </summary>
    /// <value>          [D] Same Day,          [N] Over The Counter,          [A] Overnight AM,          [P] Overnight PM,          [R] International Express,          [T] International Standard,          [M] International Economy,          [O] Other,          [Q] Charter,          [S] Standard,          [2] Standard 2 (2-day),          [3] Economy (3-day),          [5] Deferred (4-5 day),          [L] LTL,          [F] FTL,          [U] EUV/Hotshot</value>
    [DataMember(Name="service", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "service")]
    public string Service { get; set; }

    /// <summary>
    /// Pickup date YYYY-MM-DD
    /// </summary>
    /// <value>Pickup date YYYY-MM-DD</value>
    [DataMember(Name="pickupDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pickupDate")]
    public DateTime? PickupDate { get; set; }

    /// <summary>
    /// Origin location. Must be a valid Team Worldwide origin.
    /// </summary>
    /// <value>Origin location. Must be a valid Team Worldwide origin.</value>
    [DataMember(Name="origin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "origin")]
    public string Origin { get; set; }

    /// <summary>
    /// Destination location.  Must be a valid Team Worldwide destination
    /// </summary>
    /// <value>Destination location.  Must be a valid Team Worldwide destination</value>
    [DataMember(Name="destination", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "destination")]
    public string Destination { get; set; }

    /// <summary>
    /// Acceptable values are IN and CM
    /// </summary>
    /// <value>Acceptable values are IN and CM</value>
    [DataMember(Name="linearUnits", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "linearUnits")]
    public string LinearUnits { get; set; }

    /// <summary>
    /// Acceptable values are LB and KG
    /// </summary>
    /// <value>Acceptable values are LB and KG</value>
    [DataMember(Name="weightUnits", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "weightUnits")]
    public string WeightUnits { get; set; }

    /// <summary>
    /// Is the shipment oversize?
    /// </summary>
    /// <value>Is the shipment oversize?</value>
    [DataMember(Name="oversize", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "oversize")]
    public string Oversize { get; set; }

    /// <summary>
    /// Description of the goods
    /// </summary>
    /// <value>Description of the goods</value>
    [DataMember(Name="goodsDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "goodsDescription")]
    public string GoodsDescription { get; set; }

    /// <summary>
    /// Gets or Sets Weight
    /// </summary>
    [DataMember(Name="weight", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "weight")]
    public decimal? Weight { get; set; }

    /// <summary>
    /// Special instructions
    /// </summary>
    /// <value>Special instructions</value>
    [DataMember(Name="specialInstructions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "specialInstructions")]
    public string SpecialInstructions { get; set; }

    /// <summary>
    /// Declared value
    /// </summary>
    /// <value>Declared value</value>
    [DataMember(Name="declaredValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "declaredValue")]
    public decimal? DeclaredValue { get; set; }

    /// <summary>
    /// Gets or Sets Shipper
    /// </summary>
    [DataMember(Name="shipper", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipper")]
    public ShipperShipmentCreate Shipper { get; set; }

    /// <summary>
    /// Gets or Sets Consignee
    /// </summary>
    [DataMember(Name="consignee", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "consignee")]
    public ConsigneeShipmentCreate Consignee { get; set; }

    /// <summary>
    /// Billing party of this shipment
    /// </summary>
    /// <value>Billing party of this shipment</value>
    [DataMember(Name="billTo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billTo")]
    public AnyOfShipmentV2ShipmentShipmentCreateBillTo BillTo { get; set; }

    /// <summary>
    /// Requested pickup
    /// </summary>
    /// <value>Requested pickup</value>
    [DataMember(Name="requestedPickup", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requestedPickup")]
    public AnyOfShipmentV2ShipmentShipmentCreateRequestedPickup RequestedPickup { get; set; }

    /// <summary>
    /// Request delivery
    /// </summary>
    /// <value>Request delivery</value>
    [DataMember(Name="requestedDelivery", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requestedDelivery")]
    public AnyOfShipmentV2ShipmentShipmentCreateRequestedDelivery RequestedDelivery { get; set; }

    /// <summary>
    /// Shipment goods
    /// </summary>
    /// <value>Shipment goods</value>
    [DataMember(Name="shipmentGoods", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipmentGoods")]
    public List<ShipmentGoodsShipmentCreate> ShipmentGoods { get; set; }

    /// <summary>
    /// Shipment goods handling
    /// </summary>
    /// <value>Shipment goods handling</value>
    [DataMember(Name="shipmentGoodsHandling", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipmentGoodsHandling")]
    public List<ShipmentGoodsHandlingShipmentCreate> ShipmentGoodsHandling { get; set; }

    /// <summary>
    /// Shipment notes
    /// </summary>
    /// <value>Shipment notes</value>
    [DataMember(Name="shipmentNotes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipmentNotes")]
    public List<ShipmentNoteResourceShipmentCreate> ShipmentNotes { get; set; }

    /// <summary>
    /// Any additional references for this shipment
    /// </summary>
    /// <value>Any additional references for this shipment</value>
    [DataMember(Name="additionalReferences", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "additionalReferences")]
    public List<ShipmentAdditionalReferencesShipmentCreate> AdditionalReferences { get; set; }

    /// <summary>
    /// Projected Expenses
    /// </summary>
    /// <value>Projected Expenses</value>
    [DataMember(Name="projectedExpenses", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "projectedExpenses")]
    public List<ProjectedExpenseShipmentCreate> ProjectedExpenses { get; set; }

    /// <summary>
    /// Projected customer charges
    /// </summary>
    /// <value>Projected customer charges</value>
    [DataMember(Name="projectedCustomerCharges", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "projectedCustomerCharges")]
    public List<ProjectedCustomerChargeShipmentCreate> ProjectedCustomerCharges { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ShipmentV2ShipmentShipmentCreate {\n");
      sb.Append("  IsTestShipment: ").Append(IsTestShipment).Append("\n");
      sb.Append("  HouseBill: ").Append(HouseBill).Append("\n");
      sb.Append("  ControlBranch: ").Append(ControlBranch).Append("\n");
      sb.Append("  Company: ").Append(Company).Append("\n");
      sb.Append("  ShipmentType: ").Append(ShipmentType).Append("\n");
      sb.Append("  Service: ").Append(Service).Append("\n");
      sb.Append("  PickupDate: ").Append(PickupDate).Append("\n");
      sb.Append("  Origin: ").Append(Origin).Append("\n");
      sb.Append("  Destination: ").Append(Destination).Append("\n");
      sb.Append("  LinearUnits: ").Append(LinearUnits).Append("\n");
      sb.Append("  WeightUnits: ").Append(WeightUnits).Append("\n");
      sb.Append("  Oversize: ").Append(Oversize).Append("\n");
      sb.Append("  GoodsDescription: ").Append(GoodsDescription).Append("\n");
      sb.Append("  Weight: ").Append(Weight).Append("\n");
      sb.Append("  SpecialInstructions: ").Append(SpecialInstructions).Append("\n");
      sb.Append("  DeclaredValue: ").Append(DeclaredValue).Append("\n");
      sb.Append("  Shipper: ").Append(Shipper).Append("\n");
      sb.Append("  Consignee: ").Append(Consignee).Append("\n");
      sb.Append("  BillTo: ").Append(BillTo).Append("\n");
      sb.Append("  RequestedPickup: ").Append(RequestedPickup).Append("\n");
      sb.Append("  RequestedDelivery: ").Append(RequestedDelivery).Append("\n");
      sb.Append("  ShipmentGoods: ").Append(ShipmentGoods).Append("\n");
      sb.Append("  ShipmentGoodsHandling: ").Append(ShipmentGoodsHandling).Append("\n");
      sb.Append("  ShipmentNotes: ").Append(ShipmentNotes).Append("\n");
      sb.Append("  AdditionalReferences: ").Append(AdditionalReferences).Append("\n");
      sb.Append("  ProjectedExpenses: ").Append(ProjectedExpenses).Append("\n");
      sb.Append("  ProjectedCustomerCharges: ").Append(ProjectedCustomerCharges).Append("\n");
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
