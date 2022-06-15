using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace TeamWorldwideModel {

  /// <summary>
  /// Shipment Booking API Resource
  /// </summary>
  [DataContract]
  public class ShipmentBookingV2ShipmentBookingCreate {
    /// <summary>
    /// Gets or Sets BookedDate
    /// </summary>
    [DataMember(Name="bookedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bookedDate")]
    public DateTime? BookedDate { get; set; }

    /// <summary>
    ///           [DA] Domestic-Air,          [IA] International-Air,          [O] Ocean,          [T] Domestic/International Truck,          [TLN] Team Line Haul      
    /// </summary>
    /// <value>          [DA] Domestic-Air,          [IA] International-Air,          [O] Ocean,          [T] Domestic/International Truck,          [TLN] Team Line Haul      </value>
    [DataMember(Name="shippingMode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shippingMode")]
    public string ShippingMode { get; set; }

    /// <summary>
    /// Gets or Sets CarrierName
    /// </summary>
    [DataMember(Name="carrierName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "carrierName")]
    public string CarrierName { get; set; }

    /// <summary>
    /// Gets or Sets OriginCode
    /// </summary>
    [DataMember(Name="originCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "originCode")]
    public string OriginCode { get; set; }

    /// <summary>
    /// Gets or Sets DestinationCode
    /// </summary>
    [DataMember(Name="destinationCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "destinationCode")]
    public string DestinationCode { get; set; }

    /// <summary>
    /// Gets or Sets VendorCode
    /// </summary>
    [DataMember(Name="vendorCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vendorCode")]
    public string VendorCode { get; set; }

    /// <summary>
    /// Carrier master bill or booking number
    /// </summary>
    /// <value>Carrier master bill or booking number</value>
    [DataMember(Name="carrierBookingNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "carrierBookingNumber")]
    public string CarrierBookingNumber { get; set; }

    /// <summary>
    /// Secondary carrier master bill or booking number
    /// </summary>
    /// <value>Secondary carrier master bill or booking number</value>
    [DataMember(Name="carrierBookingNumber2", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "carrierBookingNumber2")]
    public string CarrierBookingNumber2 { get; set; }

    /// <summary>
    ///           [S] Standard,          [X] Express,          [F] Road Feeder,          [N] Over the Counter,          [W] Weekend,          [T] Truck/Line Haul,          [E] Economy,          [H] Hot Shot,          [K] Full Truck Load,          [L] Less Than Truck Load,          [U] Exclusive Use,          [R] Live Recovery,          [C] Local      
    /// </summary>
    /// <value>          [S] Standard,          [X] Express,          [F] Road Feeder,          [N] Over the Counter,          [W] Weekend,          [T] Truck/Line Haul,          [E] Economy,          [H] Hot Shot,          [K] Full Truck Load,          [L] Less Than Truck Load,          [U] Exclusive Use,          [R] Live Recovery,          [C] Local      </value>
    [DataMember(Name="service", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "service")]
    public string Service { get; set; }

    /// <summary>
    /// Ship direct to consignee
    /// </summary>
    /// <value>Ship direct to consignee</value>
    [DataMember(Name="directToConsignee", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "directToConsignee")]
    public bool? DirectToConsignee { get; set; }

    /// <summary>
    /// Override Pieces/Weight/Volume
    /// </summary>
    /// <value>Override Pieces/Weight/Volume</value>
    [DataMember(Name="overrideMeasures", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "overrideMeasures")]
    public bool? OverrideMeasures { get; set; }

    /// <summary>
    /// Total number of pieces
    /// </summary>
    /// <value>Total number of pieces</value>
    [DataMember(Name="totalPieces", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalPieces")]
    public int? TotalPieces { get; set; }

    /// <summary>
    /// Total weight of all shipments
    /// </summary>
    /// <value>Total weight of all shipments</value>
    [DataMember(Name="totalWeight", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalWeight")]
    public decimal? TotalWeight { get; set; }

    /// <summary>
    /// Gets or Sets DepartureDate
    /// </summary>
    [DataMember(Name="departureDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "departureDate")]
    public DateTime? DepartureDate { get; set; }

    /// <summary>
    /// Gets or Sets DepartureTime
    /// </summary>
    [DataMember(Name="departureTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "departureTime")]
    public DateTime? DepartureTime { get; set; }

    /// <summary>
    /// Gets or Sets ArrivalDate
    /// </summary>
    [DataMember(Name="arrivalDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "arrivalDate")]
    public DateTime? ArrivalDate { get; set; }

    /// <summary>
    /// Gets or Sets ArrivalTime
    /// </summary>
    [DataMember(Name="arrivalTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "arrivalTime")]
    public DateTime? ArrivalTime { get; set; }

    /// <summary>
    /// The booking station or airport code.  Generally speaking it will be airport code
    /// </summary>
    /// <value>The booking station or airport code.  Generally speaking it will be airport code</value>
    [DataMember(Name="bookingStation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bookingStation")]
    public string BookingStation { get; set; }

    /// <summary>
    /// General notes for the booking
    /// </summary>
    /// <value>General notes for the booking</value>
    [DataMember(Name="generalNotes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "generalNotes")]
    public string GeneralNotes { get; set; }

    /// <summary>
    /// Shipments
    /// </summary>
    /// <value>Shipments</value>
    [DataMember(Name="shipments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipments")]
    public List<ShipmentShipmentBookingCreate> Shipments { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ShipmentBookingV2ShipmentBookingCreate {\n");
      sb.Append("  BookedDate: ").Append(BookedDate).Append("\n");
      sb.Append("  ShippingMode: ").Append(ShippingMode).Append("\n");
      sb.Append("  CarrierName: ").Append(CarrierName).Append("\n");
      sb.Append("  OriginCode: ").Append(OriginCode).Append("\n");
      sb.Append("  DestinationCode: ").Append(DestinationCode).Append("\n");
      sb.Append("  VendorCode: ").Append(VendorCode).Append("\n");
      sb.Append("  CarrierBookingNumber: ").Append(CarrierBookingNumber).Append("\n");
      sb.Append("  CarrierBookingNumber2: ").Append(CarrierBookingNumber2).Append("\n");
      sb.Append("  Service: ").Append(Service).Append("\n");
      sb.Append("  DirectToConsignee: ").Append(DirectToConsignee).Append("\n");
      sb.Append("  OverrideMeasures: ").Append(OverrideMeasures).Append("\n");
      sb.Append("  TotalPieces: ").Append(TotalPieces).Append("\n");
      sb.Append("  TotalWeight: ").Append(TotalWeight).Append("\n");
      sb.Append("  DepartureDate: ").Append(DepartureDate).Append("\n");
      sb.Append("  DepartureTime: ").Append(DepartureTime).Append("\n");
      sb.Append("  ArrivalDate: ").Append(ArrivalDate).Append("\n");
      sb.Append("  ArrivalTime: ").Append(ArrivalTime).Append("\n");
      sb.Append("  BookingStation: ").Append(BookingStation).Append("\n");
      sb.Append("  GeneralNotes: ").Append(GeneralNotes).Append("\n");
      sb.Append("  Shipments: ").Append(Shipments).Append("\n");
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
