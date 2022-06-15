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
  public class ProjectedExpenseJsonldShipmentBookingCreate {
    /// <summary>
    /// Gets or Sets Context
    /// </summary>
    [DataMember(Name="@context", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "@context")]
    public OneOfProjectedExpenseJsonldShipmentBookingCreateContext Context { get; set; }

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
    /// Gets or Sets VendorCode
    /// </summary>
    [DataMember(Name="vendorCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vendorCode")]
    public string VendorCode { get; set; }

    /// <summary>
    ///           [D] Delivery,          [P] Pickup/Procurement,          [T] Transfer      
    /// </summary>
    /// <value>          [D] Delivery,          [P] Pickup/Procurement,          [T] Transfer      </value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string ProjectedExpenseType { get; set; }

    /// <summary>
    ///           [2H] TWO MAN SVCS - 1 HR MINIMUM          [2M] TWO MAN SVC - PER 1/4 HOUR          [2MD] TWO MAN DELIVERY          [2T] TWO MAN SVCS - 2 HR MIN          [3M] THREE MAN SERVICE          [4M] FOUR MAN SERVICE          [900] DUE ACS          [925] DUE NSC POOL          [950] DUE FB          [ACC] ALAMEDA CORRIDOR CHARGE          [ADF] ADVANCED DUTY FEE          [ADM] ADMINISTRATION FEE          [ADN] AGENT DEBIT NOTE          [ADR] AIRPORT DROP OR RECOVERY          [ADU] ANTI-DUMPING FEE          [ADV] ADVANCE CHECK FEE          [AES] AES FEE          [AGI] AGRICULTURAL HOLD          [ALH] AIRLINE HANDLING          [AMC] ADDITIONAL MACHINE          [APD] APPOINTMENT DELIVERY          [APP] APPOINTMENT PICKUP          [APQ] ANIMAL PLANT QUARANTINE          [AQI] AGRICULTURAL CHARGE          [ARD] A/R RESERVE DEPOSIT          [ATD] ATTEMPTED DELIVERY          [ATP] ATTEMPTED PICKUP          [AWB] AIR WAYBILL FEE          [BAF] BUNKER ADJUSTMENT FACTOR          [BBK] BROKERAGE ON BREAKBULK          [BFI] BAF INCREASE          [BKF] BOOKING FEE          [BLP] BILL OF LADING PREPARATION          [BND] BOND CHARGES          [BOL] BILL OF LADING FEE          [BPF] BOND PREPARATION FEE          [BRK] BROKERAGE          [C&A] CVD/ADD DUTY          [CBF] CUSTOMS BOND FEE          [CBP] CONTINUOUS ENTRY BOND          [CCF] CREDIT CARD FEE          [CDF] C.O.D. FEE          [CEX] CUSTOMS EXAM FEE          [CFO] COLLECT OCEAN FRT          [CFS] CFS CHARGES          [CGS] CARGO SCREENING          [CHS] CHASSIS CHARGE          [CLD] CONTAINER LOADING          [CLE] CLEARANCE AND HANDLING          [CLR] CUSTOMS CLEARANCE & HANDLING          [CM] CONVENTION MATERIAL          [CNF] CONTRACTOR FEE          [COC] COORDINATION AND CONTROL          [COL] COLLECTION FEE          [COM] COMMISSION ON FREIGHT          [COR] COURIER          [CPF] CONSOL / PORT SERVICE FEE          [CPY] COPY OF DOCUMENT OR POD          [CR] CREDIT          [CRE] CRANE CHARGES          [CRN] PRESENTATION OF CARNET          [CRS] CROSS DOCK FEES          [CRT] CRATING & PACKAGING          [CST] CUSTOMS TITLE SEARCH          [CTF] CLEAN TRUCK FEE          [CTG] CARTAGE          [CXB] CONTAINER BUILDUP          [DAD] DAD/DOC/WHSE          [DAP] DELIVERED AT PLACE          [DCR] DOMINICAN CONTAINER RELEASE          [DDP] DELIVERY DUTY PAID          [DEM] DEMURRAGE          [DET] DETENTION          [DGC] DANGEROUS GOODS CERTIFICATE          [DGR] DANGEROUS GOODS          [DIV] DIVERSION FEE          [DK] DOCKS & PIERS          [DLR] DELIVERY          [DO] DELIVERY ORDER          [DPF] DROP FEE          [DRH] DR HANDLING          [DRY] DRAYAGE          [DSB] DISBURSEMENT FEE          [DST] DESTINATION CHARGES          [DTO] DOCUMENT TURNOVER          [DTQ] DUTY - SUBJECT TO LIQUIDATION          [DTY] DUTY AND TAXES          [DVF] DECLARED VALUE FEE          [DVR] DV (CARRIER COST)          [EDF] EXPORT DECLARATION FEE          [EDH] EXPORT DECLARATION HANDLING          [EFH] ENTRY FEE & HANDLING          [ERO] ERRORS & OMISSIONS POLICY          [EXM] EXAMINATION COORDINATION          [FCC] FEE FOR COLLECT CHARGES          [FDA] FOOD & DRUG ENTRY          [FIN] FINANCE CHARGES          [FKL] FORKLIFT FEE          [FRT] FREIGHT CHARGE          [FSC] FUEL SURCHARGE          [FWD] FORWARDING CHARGES          [GRI] GENERAL RATE INCREASE          [GST] GOODS AND SERVICES TAX          [H&M] HOTELS & MALLS          [HAF] HOUSE AIRFREIGHT          [HAP] HOLD AT AIRPORT          [HAZ] HAZARDOUS MATERIALS          [HD1] HANDLING CHARGES (HD1)          [HKD] HONG KONG DELIVERY ORDER          [HKE] HK EXPORT DECLARATION AND FEES          [HKG] HONG KONG GATE CHARGES          [HLS] HEAVY LIFT SURCHARGE          [HMF] HARBOR MAINTENANCE FEES          [HND] HANDLING CHARGES          [HOF] OCEAN FREIGHT          [HST] HARMONIZED SALES TAX          [IAT] IATA DISCOUNT          [IND] INSIDE DELIVERY          [INH] INSIDE CHARGE - 1 HR MIN          [INL] INLAND FRT          [INS] INSURANCE AND SERVICES          [INT] INTEREST          [IOF] OCEAN FREIGHT B/B          [IPI] IPI FEE          [IPR] IPPC PALLET REPLACEMENT          [ISC] AIRLINE SERVICE FEE          [ISF] ISF FILING FEE & HANDLING          [ISP] INSPECTION SERVICES          [ITF] I.T. FEE & HANDLING          [ITV] I.T. VALIDATION FEE          [LDL] LOCAL DELIVERY          [LEG] LEGALIZATION          [LF] LOCATION FEE          [LG] LIFTGATE          [LH] LINE HAUL          [LOC] LETTER OF CREDIT          [LRF] LATE RECAP FEE          [MIS] MISCELLANEOUS          [MS2] COURIER (MS2)          [MSE] MERCHANDISE PROCESSING FEE          [MSG] MESSENGER FEE          [MYF] MARSHALLING YARD FEE          [NAV] NAVCAN          [NRF] NON-RESIDENTIAL FEE          [NSF] NON-SUFFICIENT FUNDS FEES          [OBF] ORIGIN BROKER SERVICE FEE          [OHR] ON HAND REFUSED SHIPMENT CHG          [ONC] ON-CARRIAGE          [OPH] OCEAN PORT HANDLING          [OPS] OCEAN P/S          [ORG] ORIGIN FEE          [ORI] ORION FEE          [OT] OVERTIME/WEEKEND          [OTC] OVER THE COUNTER          [OTH] OTHER CHARGE          [OTL] OUTLAY FOR ADDITIONAL CHARGES          [OVR] OVERRIDE DISCOUNT          [P/S] PROFIT SPLIT          [PCS] PANAMA CANAL SURCHARGE          [PDE] PROOF OF DELIVERY (ELECTRONIC)          [PE] PERSONAL EFFECTS          [PEN] POST ENTRY SERVICES          [PFA] AIRFREIGHT LESS IATA          [PJ] PALLET JACK CHARGE          [PPF] PIER PASS FEE          [PRC] PRE-CARRIAGE          [PSF] PORT SECURITY FEE          [PSS] PEAK SEASON SURCHARGE          [PST] PROVINCIAL SALES TAX          [PUP] PICKUP          [PYP] PAYMENT PROCESSOR FEE          [QST] QUEBEC SALES TAX          [RCF] RECOVERY FEE          [REB] CUSTOMER REBATE / INCENTIVE          [RLD] RESIDENTIAL DELIVERY          [SC] STAIR CARRY          [SCW] STAIR CARRY WEIGHT RATED          [SEB] SINGLE ENTRY BOND          [SEC] SECURITY SURCHARGE          [SED] SHIPPERS EXPORT DECLARATION          [SEM] SEMINAR FEES          [SMR] SEMINAR          [SP] SHORT PAY AUTHORIZED          [SPD] SPECIAL DELIVERY          [SPH] SPECIAL HANDLING SERVICES          [SPP] SPECIAL PICKUP          [SSB] STEAMSHIP LINE BILL OF LADING          [SSP] SERVICE CENTER PERCENTAGE          [STB] SINGLE TRANSACTION BOND          [STF] CONTAINER STUFFING          [STG] STORAGE          [STP] STOP OFF          [T&F] OTHER DUTY TAXES & FEES          [TAR] TARIFF FILING FEES          [TF] TRANSACTION FEE          [THC] TERMINAL HANDLING          [TKP] PU AT TRK TRMNL OFF AIRPORT          [TRL] TRANSLOAD          [TRR] TRASH REMOVAL          [TST] TESTING CHARGE          [TTC] TEAM TECH COMMERCIAL          [TTD] TEAM TECH DELIVERY          [TTR] TEAM TECH RESIDENTIAL          [TYD] TEAM TECH BEYOND DELIVERY          [UNL] UNLOADING          [UPK] UNPACK          [VAC] VACIS EXAMINATION          [VAT] VAT          [WFG] WHARFAGE          [WGD] WHITE GLOVE DELIVERY          [WGT] WEIGHT BASED RATE ADJUSTMENT          [WHI] WAREHOUSE IN          [WHO] WAREHOUSE OUT          [WHS] WAREHOUSING          [WHX] WAREHOUSE TRANSFER          [WIO] WAREHOUSING, IN & OUT          [WT] WAIT TIME          [WTC] WAIT TIME FOR CONTAINERS          [WTD] WAIT TIME AT DESTINATION          [WTF] WIRE TRANSFER FEE          [WTP] WAIT TIME AT ORIGIN          [WWD] WAREHOUSE WITHDRAWALS          [XDP] EXTD DIST TRUCK TERM DROP          [XDR] EXTRA DRAYAGE          [XEX] X-RAY EXAM FEE          [XFR] TRANSFER          [XRC] EXTD DIST TRUCK TERM RECOVERY          [XRT] EXTRA ROUND TRIP      
    /// </summary>
    /// <value>          [2H] TWO MAN SVCS - 1 HR MINIMUM          [2M] TWO MAN SVC - PER 1/4 HOUR          [2MD] TWO MAN DELIVERY          [2T] TWO MAN SVCS - 2 HR MIN          [3M] THREE MAN SERVICE          [4M] FOUR MAN SERVICE          [900] DUE ACS          [925] DUE NSC POOL          [950] DUE FB          [ACC] ALAMEDA CORRIDOR CHARGE          [ADF] ADVANCED DUTY FEE          [ADM] ADMINISTRATION FEE          [ADN] AGENT DEBIT NOTE          [ADR] AIRPORT DROP OR RECOVERY          [ADU] ANTI-DUMPING FEE          [ADV] ADVANCE CHECK FEE          [AES] AES FEE          [AGI] AGRICULTURAL HOLD          [ALH] AIRLINE HANDLING          [AMC] ADDITIONAL MACHINE          [APD] APPOINTMENT DELIVERY          [APP] APPOINTMENT PICKUP          [APQ] ANIMAL PLANT QUARANTINE          [AQI] AGRICULTURAL CHARGE          [ARD] A/R RESERVE DEPOSIT          [ATD] ATTEMPTED DELIVERY          [ATP] ATTEMPTED PICKUP          [AWB] AIR WAYBILL FEE          [BAF] BUNKER ADJUSTMENT FACTOR          [BBK] BROKERAGE ON BREAKBULK          [BFI] BAF INCREASE          [BKF] BOOKING FEE          [BLP] BILL OF LADING PREPARATION          [BND] BOND CHARGES          [BOL] BILL OF LADING FEE          [BPF] BOND PREPARATION FEE          [BRK] BROKERAGE          [C&A] CVD/ADD DUTY          [CBF] CUSTOMS BOND FEE          [CBP] CONTINUOUS ENTRY BOND          [CCF] CREDIT CARD FEE          [CDF] C.O.D. FEE          [CEX] CUSTOMS EXAM FEE          [CFO] COLLECT OCEAN FRT          [CFS] CFS CHARGES          [CGS] CARGO SCREENING          [CHS] CHASSIS CHARGE          [CLD] CONTAINER LOADING          [CLE] CLEARANCE AND HANDLING          [CLR] CUSTOMS CLEARANCE & HANDLING          [CM] CONVENTION MATERIAL          [CNF] CONTRACTOR FEE          [COC] COORDINATION AND CONTROL          [COL] COLLECTION FEE          [COM] COMMISSION ON FREIGHT          [COR] COURIER          [CPF] CONSOL / PORT SERVICE FEE          [CPY] COPY OF DOCUMENT OR POD          [CR] CREDIT          [CRE] CRANE CHARGES          [CRN] PRESENTATION OF CARNET          [CRS] CROSS DOCK FEES          [CRT] CRATING & PACKAGING          [CST] CUSTOMS TITLE SEARCH          [CTF] CLEAN TRUCK FEE          [CTG] CARTAGE          [CXB] CONTAINER BUILDUP          [DAD] DAD/DOC/WHSE          [DAP] DELIVERED AT PLACE          [DCR] DOMINICAN CONTAINER RELEASE          [DDP] DELIVERY DUTY PAID          [DEM] DEMURRAGE          [DET] DETENTION          [DGC] DANGEROUS GOODS CERTIFICATE          [DGR] DANGEROUS GOODS          [DIV] DIVERSION FEE          [DK] DOCKS & PIERS          [DLR] DELIVERY          [DO] DELIVERY ORDER          [DPF] DROP FEE          [DRH] DR HANDLING          [DRY] DRAYAGE          [DSB] DISBURSEMENT FEE          [DST] DESTINATION CHARGES          [DTO] DOCUMENT TURNOVER          [DTQ] DUTY - SUBJECT TO LIQUIDATION          [DTY] DUTY AND TAXES          [DVF] DECLARED VALUE FEE          [DVR] DV (CARRIER COST)          [EDF] EXPORT DECLARATION FEE          [EDH] EXPORT DECLARATION HANDLING          [EFH] ENTRY FEE & HANDLING          [ERO] ERRORS & OMISSIONS POLICY          [EXM] EXAMINATION COORDINATION          [FCC] FEE FOR COLLECT CHARGES          [FDA] FOOD & DRUG ENTRY          [FIN] FINANCE CHARGES          [FKL] FORKLIFT FEE          [FRT] FREIGHT CHARGE          [FSC] FUEL SURCHARGE          [FWD] FORWARDING CHARGES          [GRI] GENERAL RATE INCREASE          [GST] GOODS AND SERVICES TAX          [H&M] HOTELS & MALLS          [HAF] HOUSE AIRFREIGHT          [HAP] HOLD AT AIRPORT          [HAZ] HAZARDOUS MATERIALS          [HD1] HANDLING CHARGES (HD1)          [HKD] HONG KONG DELIVERY ORDER          [HKE] HK EXPORT DECLARATION AND FEES          [HKG] HONG KONG GATE CHARGES          [HLS] HEAVY LIFT SURCHARGE          [HMF] HARBOR MAINTENANCE FEES          [HND] HANDLING CHARGES          [HOF] OCEAN FREIGHT          [HST] HARMONIZED SALES TAX          [IAT] IATA DISCOUNT          [IND] INSIDE DELIVERY          [INH] INSIDE CHARGE - 1 HR MIN          [INL] INLAND FRT          [INS] INSURANCE AND SERVICES          [INT] INTEREST          [IOF] OCEAN FREIGHT B/B          [IPI] IPI FEE          [IPR] IPPC PALLET REPLACEMENT          [ISC] AIRLINE SERVICE FEE          [ISF] ISF FILING FEE & HANDLING          [ISP] INSPECTION SERVICES          [ITF] I.T. FEE & HANDLING          [ITV] I.T. VALIDATION FEE          [LDL] LOCAL DELIVERY          [LEG] LEGALIZATION          [LF] LOCATION FEE          [LG] LIFTGATE          [LH] LINE HAUL          [LOC] LETTER OF CREDIT          [LRF] LATE RECAP FEE          [MIS] MISCELLANEOUS          [MS2] COURIER (MS2)          [MSE] MERCHANDISE PROCESSING FEE          [MSG] MESSENGER FEE          [MYF] MARSHALLING YARD FEE          [NAV] NAVCAN          [NRF] NON-RESIDENTIAL FEE          [NSF] NON-SUFFICIENT FUNDS FEES          [OBF] ORIGIN BROKER SERVICE FEE          [OHR] ON HAND REFUSED SHIPMENT CHG          [ONC] ON-CARRIAGE          [OPH] OCEAN PORT HANDLING          [OPS] OCEAN P/S          [ORG] ORIGIN FEE          [ORI] ORION FEE          [OT] OVERTIME/WEEKEND          [OTC] OVER THE COUNTER          [OTH] OTHER CHARGE          [OTL] OUTLAY FOR ADDITIONAL CHARGES          [OVR] OVERRIDE DISCOUNT          [P/S] PROFIT SPLIT          [PCS] PANAMA CANAL SURCHARGE          [PDE] PROOF OF DELIVERY (ELECTRONIC)          [PE] PERSONAL EFFECTS          [PEN] POST ENTRY SERVICES          [PFA] AIRFREIGHT LESS IATA          [PJ] PALLET JACK CHARGE          [PPF] PIER PASS FEE          [PRC] PRE-CARRIAGE          [PSF] PORT SECURITY FEE          [PSS] PEAK SEASON SURCHARGE          [PST] PROVINCIAL SALES TAX          [PUP] PICKUP          [PYP] PAYMENT PROCESSOR FEE          [QST] QUEBEC SALES TAX          [RCF] RECOVERY FEE          [REB] CUSTOMER REBATE / INCENTIVE          [RLD] RESIDENTIAL DELIVERY          [SC] STAIR CARRY          [SCW] STAIR CARRY WEIGHT RATED          [SEB] SINGLE ENTRY BOND          [SEC] SECURITY SURCHARGE          [SED] SHIPPERS EXPORT DECLARATION          [SEM] SEMINAR FEES          [SMR] SEMINAR          [SP] SHORT PAY AUTHORIZED          [SPD] SPECIAL DELIVERY          [SPH] SPECIAL HANDLING SERVICES          [SPP] SPECIAL PICKUP          [SSB] STEAMSHIP LINE BILL OF LADING          [SSP] SERVICE CENTER PERCENTAGE          [STB] SINGLE TRANSACTION BOND          [STF] CONTAINER STUFFING          [STG] STORAGE          [STP] STOP OFF          [T&F] OTHER DUTY TAXES & FEES          [TAR] TARIFF FILING FEES          [TF] TRANSACTION FEE          [THC] TERMINAL HANDLING          [TKP] PU AT TRK TRMNL OFF AIRPORT          [TRL] TRANSLOAD          [TRR] TRASH REMOVAL          [TST] TESTING CHARGE          [TTC] TEAM TECH COMMERCIAL          [TTD] TEAM TECH DELIVERY          [TTR] TEAM TECH RESIDENTIAL          [TYD] TEAM TECH BEYOND DELIVERY          [UNL] UNLOADING          [UPK] UNPACK          [VAC] VACIS EXAMINATION          [VAT] VAT          [WFG] WHARFAGE          [WGD] WHITE GLOVE DELIVERY          [WGT] WEIGHT BASED RATE ADJUSTMENT          [WHI] WAREHOUSE IN          [WHO] WAREHOUSE OUT          [WHS] WAREHOUSING          [WHX] WAREHOUSE TRANSFER          [WIO] WAREHOUSING, IN & OUT          [WT] WAIT TIME          [WTC] WAIT TIME FOR CONTAINERS          [WTD] WAIT TIME AT DESTINATION          [WTF] WIRE TRANSFER FEE          [WTP] WAIT TIME AT ORIGIN          [WWD] WAREHOUSE WITHDRAWALS          [XDP] EXTD DIST TRUCK TERM DROP          [XDR] EXTRA DRAYAGE          [XEX] X-RAY EXAM FEE          [XFR] TRANSFER          [XRC] EXTD DIST TRUCK TERM RECOVERY          [XRT] EXTRA ROUND TRIP      </value>
    [DataMember(Name="chargeCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "chargeCode")]
    public string ChargeCode { get; set; }

    /// <summary>
    /// Reference Number for charge
    /// </summary>
    /// <value>Reference Number for charge</value>
    [DataMember(Name="referenceNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "referenceNumber")]
    public string ReferenceNumber { get; set; }

    /// <summary>
    /// Currency
    /// </summary>
    /// <value>Currency</value>
    [DataMember(Name="currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency")]
    public string Currency { get; set; }

    /// <summary>
    /// Comment
    /// </summary>
    /// <value>Comment</value>
    [DataMember(Name="comment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "comment")]
    public string Comment { get; set; }

    /// <summary>
    /// Amount
    /// </summary>
    /// <value>Amount</value>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amount")]
    public decimal? Amount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProjectedExpenseJsonldShipmentBookingCreate {\n");
      sb.Append("  Context: ").Append(Context).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  VendorCode: ").Append(VendorCode).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  ChargeCode: ").Append(ChargeCode).Append("\n");
      sb.Append("  ReferenceNumber: ").Append(ReferenceNumber).Append("\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("  Comment: ").Append(Comment).Append("\n");
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
