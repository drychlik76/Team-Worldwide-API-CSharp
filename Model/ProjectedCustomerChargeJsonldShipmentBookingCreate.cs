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
  public class ProjectedCustomerChargeJsonldShipmentBookingCreate {
    /// <summary>
    /// Gets or Sets Context
    /// </summary>
    [DataMember(Name="@context", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "@context")]
    public OneOfProjectedCustomerChargeJsonldShipmentBookingCreateContext Context { get; set; }

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
    ///           [2H] TWO MAN SVCS - 1 HR MINIMUM          [2M] TWO MAN SVC - PER 1/4 HOUR          [2MD] TWO MAN DELIVERY          [2MP] TWO MAN PICKUP          [2T] TWO MAN SVCS - 2 HR MIN          [3M] THREE MAN SERVICE          [4M] FOUR MAN SERVICE          [ACC] ALAMEDA CORRIDOR CHARGE          [ACD] ADVANCED CHARGES DESTINATION          [ACO] ADVANCED CHARGES ORIGIN          [ADC] ADDRESS CORRECTION          [ADF] ADVANCED DUTY FEE          [ADL] ATTEMPTED DELIVERY          [ADM] ADMINISTRATION FEE          [ADR] AIRPORT DROP OR RECOVERY          [ADU] ANTI-DUMPING FEE          [ADV] ADVANCE CHECK FEE          [AES] AES FEE          [AGI] AGRICULTURAL HOLD          [AHD] AFTER HOURS DELIVERY          [AHP] AFTER HOURS PICKUP          [ALC] ALL CARGO          [ALH] AIRLINE HANDLING          [AMC] ADDITIONAL MACHINE          [AMS] AMS FEE          [APD] APPOINTMENT DELIVERY          [APP] APPOINTMENT PICKUP          [APQ] ANIMAL PLANT QUARANTINE          [APS] AGENT PROFIT SPLIT          [AQI] AGRICULTURAL CHARGE          [ATP] ATTEMPTED PICKUP          [ATX] AIRLINE TAX          [AWB] AIR WAYBILL FEE          [BAF] BUNKER ADJUSTMENT FACTOR          [BBK] BROKERAGE ON BREAKBULK          [BFI] BAF INCREASE          [BLP] BILL OF LADING PREPARATION          [BND] BOND CHARGES          [BOL] BILL OF LADING FEE          [BPF] BOND PREPARATION FEE          [BRK] BROKERAGE          [BSD] BEYOND SPECIAL DELIVERY          [BSP] BEYOND SPECIAL PICKUP          [BYD] BEYOND DELIVERY          [BYP] BEYOND PICKUP          [C&A] CVD/ADD DUTY          [CBF] CUSTOMS BOND FEE          [CBP] CONTINUOUS ENTRY BOND          [CDF] C.O.D. FEE          [CEX] CUSTOMS EXAM FEE          [CFO] COLLECT OCEAN FRT          [CFS] CFS CHARGES          [CGS] CARGO SCREENING          [CHS] CHASSIS CHARGE          [CHZ] CHECK FOR HAZ MAT          [CLD] CONTAINER LOADING          [CLE] CLEARANCE AND HANDLING          [CLR] CUSTOMS CLEARANCE & HANDLING          [CM] CONVENTION MATERIAL          [CMD] CONVENTION CENTER DELIVERY          [CMP] CONVENTION CENTER PICKUP          [CO] CERTIFICATE OF ORIGIN          [COC] COORDINATION AND CONTROL          [COD] C.O.D. MONEY          [COF] CERTIFICATE OF ORIGIN FEE          [COL] COLLECTION FEE          [CON] CONSULTING SERVICES          [COR] COURIER          [CPF] CONSOL / PORT SERVICE FEE          [CPY] COPY OF DOCUMENT OR POD          [CR] CREDIT          [CRE] CRANE CHARGES          [CRN] PRESENTATION OF CARNET          [CRS] CROSS DOCK FEES          [CRT] CRATING & PACKAGING          [CSD] CONTACT SHIPPER FOR DETAILS          [CST] CUSTOMS TITLE SEARCH          [CTF] CLEAN TRUCK FEE          [CTG] CARTAGE          [CVC] CONVENTION CENTER FEE          [CXB] CONTAINER BUILDUP          [DAD] DAD/DOC/WHSE          [DAP] DELIVERED AT PLACE          [DCR] DOMINICAN CONTAINER RELEASE          [DDP] DELIVERY DUTY PAID          [DEM] DEMURRAGE          [DET] DETENTION          [DGC] DANGEROUS GOODS CERTIFICATE          [DGR] DANGEROUS GOODS          [DIM] HEAVY / DIM WEIGHT          [DIV] DIVERSION FEE          [DK] DOCKS & PIERS          [DKD] DOCKS/PIERS DELIVERY          [DKP] DOCKS/PIERS PICKUP          [DLR] DELIVERY          [DO] DELIVERY ORDER          [DOC] DOCUMENTATION          [DPF] DROP FEE          [DRH] DR HANDLING          [DRY] DRAYAGE          [DSB] DISBURSEMENT FEE          [DST] DESTINATION CHARGES          [DTO] DOCUMENT TURNOVER          [DTQ] DUTY - SUBJECT TO LIQUIDATION          [DTY] DUTY AND TAXES          [DVF] DECLARED VALUE FEE          [EDF] EXPORT DECLARATION FEE          [EDH] EXPORT DECLARATION HANDLING          [EFH] ENTRY FEE & HANDLING          [EHD] EXPORT HANDLING          [EOV] EXTRAORDINARY VALUE ITEMS          [ERO] ERRORS & OMISSIONS POLICY          [EUC] EU CUSTOMS FEE          [EUD] EXCLUSIVE USE VEHICLE DELIVERY          [EUP] EXCLUSIVE USE VEHICLE PICKUP          [EUV] EXCLUSIVE USE VEHICLE          [EVD] EOV, HANDLE WITH CARE (D)          [EVP] EOV, HANDLE WITH CARE (P)          [EXM] EXAMINATION COORDINATION          [FCC] FEE FOR COLLECT CHARGES          [FCL] FREIGHT CHARGE COLLECT FEE          [FDA] FOOD & DRUG ENTRY          [FIN] FINANCE CHARGES          [FKL] FORKLIFT FEE          [FRD] FREIGHT DISCOUNT          [FRT] FREIGHT CHARGE          [FSC] FUEL SURCHARGE          [FSD] FUEL SURCHARGE GROUND          [FSJ] FUEL SURCHARGE AIR          [FWD] FORWARDING CHARGES          [GRI] GENERAL RATE INCREASE          [GST] GOODS AND SERVICES TAX          [H&M] HOTELS & MALLS          [HAF] HOUSE AIRFREIGHT          [HAP] HOLD AT AIRPORT          [HAZ] HAZARDOUS MATERIALS          [HD1] HANDLING CHARGES (HD1)          [HKD] HONG KONG DELIVERY ORDER          [HKE] HK EXPORT DECLARATION AND FEES          [HKG] HONG KONG GATE CHARGES          [HLS] HEAVY LIFT SURCHARGE          [HMA] ACCESSIBLE HAZ MAT          [HMF] HARBOR MAINTENANCE FEES          [HMI] INACCESSIBLE HAZ MAT          [HND] HANDLING CHARGES          [HOF] OCEAN FREIGHT          [HPU] HOLD FOR PICKUP          [HST] HARMONIZED SALES TAX          [IEF] IE FEE & HANDLING          [IHD] IMPORT HANDLING          [IND] INSIDE DELIVERY          [INH] INSIDE CHARGE - 1 HR MIN          [INL] INLAND FRT          [INP] INSIDE PICKUP          [INS] INSURANCE AND SERVICES          [INT] INTEREST          [IOF] OCEAN FREIGHT B/B          [IPI] IPI FEE          [IPR] IPPC PALLET REPLACEMENT          [ISC] AIRLINE SERVICE FEE          [ISF] ISF FILING FEE & HANDLING          [ISP] INSPECTION SERVICES          [ITF] I.T. FEE & HANDLING          [ITV] I.T. VALIDATION FEE          [L/S] LUMP SUM          [LAD] LIMITED ACCESS DELIVERY          [LAP] LIMITED ACCESS PICKUP          [LDL] LOCAL DELIVERY          [LEG] LEGALIZATION          [LF] LOCATION FEE          [LG] LIFTGATE          [LGD] LIFTGATE DELIVERY          [LGP] LIFTGATE PICKUP          [LH] LINE HAUL          [LOC] LETTER OF CREDIT          [MBD] MILITARY BASE DELIVERY          [MBP] MILITARY BASE PICKUP          [MFD] MASONITE FLOOR DELIVERY          [MFP] MASONITE FLOOR PICKUP          [MHF] MERCHANDISE PROC/HARBOR MAINT          [MIS] MISCELLANEOUS          [MS2] COURIER (MS2)          [MSE] MERCHANDISE PROCESSING FEE          [MSG] MESSENGER FEE          [MYF] MARSHALLING YARD FEE          [NAB] NEXT DAY AM BEYOND          [NAV] NAVCAN          [NCD] NOTIFY CTRL IF PROBLEMS DEL          [NCF] NAV CAN FEE          [NCP] NOTIFY CTRL IF PROBLEMS PICKUP          [NFB] NFO BEYOND          [NRF] NON-RESIDENTIAL FEE          [NSF] NON-SUFFICIENT FUNDS FEES          [OHR] ON HAND REFUSED SHIPMENT CHG          [ONC] ON-CARRIAGE          [OND] O/N DEL BEFORE NOON          [OPH] OCEAN PORT HANDLING          [OPS] OCEAN P/S          [ORG] ORIGIN FEE          [ORI] ORION FEE          [OSD] OVERSIZE DELIVERY          [OSP] OVERSIZE PICKUP          [OSZ] OVERSIZE SURCHARGE          [OT] OVERTIME/WEEKEND          [OTC] OVER THE COUNTER          [OTH] OTHER CHARGE          [OTL] OUTLAY FOR ADDITIONAL CHARGES          [OZ1] OVERSIZE TIER 1          [OZ2] OVERSIZE TIER 2          [OZ3] OVERSIZE TIER 3          [P/S] PROFIT SPLIT          [PCS] PANAMA CANAL SURCHARGE          [PDE] PROOF OF DELIVERY (ELECTRONIC)          [PE] PERSONAL EFFECTS          [PEN] POST ENTRY SERVICES          [PFA] AIRFREIGHT LESS IATA          [PJ] PALLET JACK CHARGE          [PPF] PIER PASS FEE          [PRC] PRE-CARRIAGE          [PRF] PROTECTIVE FLOORING          [PSF] PORT SECURITY FEE          [PSS] PEAK SEASON SURCHARGE          [PST] PROVINCIAL SALES TAX          [PUP] PICKUP          [QST] QUEBEC SALES TAX          [RBC] RE-BILL CHARGE          [RCC] RECONSIGN / DIVERSION          [RCF] RECOVERY FEE          [RCL] REDELIVERY          [RCM] RECONSIGNMENT          [REB] CUSTOMER REBATE / INCENTIVE          [RLD] RESIDENTIAL DELIVERY          [RLP] RESIDENTIAL PICKUP          [RPK] REPACK          [RWD] REWEIGH AND DIMENSION          [SC] STAIR CARRY          [SCW] STAIR CARRY WEIGHT RATED          [SDA] SPECIAL DELIVERY AFTER HOURS          [SDW] SPECIAL DELIVERY WEEKEND          [SDY] SPECIAL DELIVERY HOLIDAY          [SEB] SINGLE ENTRY BOND          [SEC] SECURITY SURCHARGE          [SED] SHIPPERS EXPORT DECLARATION          [SEM] SEMINAR FEES          [SIG] SIGNATURE SERVICE          [SIL] STEEL IMPORT LICENSE          [SMR] SEMINAR          [SP] SHORT PAY AUTHORIZED          [SPA] SPECIAL PICKUP AFTER HOURS          [SPD] SPECIAL DELIVERY          [SPH] SPECIAL HANDLING SERVICES          [SPP] SPECIAL PICKUP          [SPW] SPECIAL PICKUP WEEKEND          [SPY] SPECIAL PICKUP HOLIDAY          [SRG] SEGREGATION          [SSB] STEAMSHIP LINE BILL OF LADING          [SSP] SERVICE CENTER PERCENTAGE          [STB] SINGLE TRANSACTION BOND          [STD] STORAGE DESTINATION          [STF] CONTAINER STUFFING          [STG] STORAGE          [STO] STORAGE ORIGIN          [STP] STOP OFF          [SVU] SERVICE UPGRADE          [SZD] SPECIAL DELIVERY - ZONE CHARGE          [SZP] SPECIAL PICKUP - ZONE CHARGE          [T&F] OTHER DUTY TAXES & FEES          [TAR] TARIFF FILING FEES          [THC] TERMINAL HANDLING          [TKP] PU AT TRK TRMNL OFF AIRPORT          [TRL] TRANSLOAD          [TRR] TRASH REMOVAL          [TSD] APT TIER SURCHARGE - DEL          [TSH] TRADE SHOW HANDLING          [TSP] APT TIER SURCHARGE - PU          [TST] TESTING CHARGE          [TTC] TEAM TECH COMMERCIAL          [TTD] TEAM TECH DELIVERY          [TTR] TEAM TECH RESIDENTIAL          [TYD] TEAM TECH BEYOND DELIVERY          [UNL] UNLOADING          [UPK] UNPACK          [VAC] VACIS EXAMINATION          [VAT] VAT          [VGM] VERIFIED GROSS WEIGHT          [VLD] VERIFY LIFTGATE REQUIRED DEL          [VLP] VERIFY LIFTGATE REQUIRED PU          [VPK] VERIFY PROPERLY PACKED          [WED] WEEKEND DELIVERY          [WEP] WEEKEND PICKUP          [WFG] WHARFAGE          [WGD] WHITE GLOVE DELIVERY          [WHI] WAREHOUSE IN          [WHO] WAREHOUSE OUT          [WHS] WAREHOUSING          [WHX] WAREHOUSE TRANSFER          [WIO] WAREHOUSING, IN & OUT          [WT] WAIT TIME          [WTC] WAIT TIME FOR CONTAINERS          [WTD] WAIT TIME AT DESTINATION          [WTP] WAIT TIME AT ORIGIN          [WWD] WAREHOUSE WITHDRAWALS          [XAD] EXTENDED AFTER HOURS DELIVERY          [XAP] EXTENDED AFTER HOURS PICKUP          [XDP] EXTD DIST TRUCK TERM DROP          [XDR] EXTRA DRAYAGE          [XEX] X-RAY EXAM FEE          [XFR] TRANSFER          [XRC] EXTD DIST TRUCK TERM RECOVERY          [XRT] EXTRA ROUND TRIP      
    /// </summary>
    /// <value>          [2H] TWO MAN SVCS - 1 HR MINIMUM          [2M] TWO MAN SVC - PER 1/4 HOUR          [2MD] TWO MAN DELIVERY          [2MP] TWO MAN PICKUP          [2T] TWO MAN SVCS - 2 HR MIN          [3M] THREE MAN SERVICE          [4M] FOUR MAN SERVICE          [ACC] ALAMEDA CORRIDOR CHARGE          [ACD] ADVANCED CHARGES DESTINATION          [ACO] ADVANCED CHARGES ORIGIN          [ADC] ADDRESS CORRECTION          [ADF] ADVANCED DUTY FEE          [ADL] ATTEMPTED DELIVERY          [ADM] ADMINISTRATION FEE          [ADR] AIRPORT DROP OR RECOVERY          [ADU] ANTI-DUMPING FEE          [ADV] ADVANCE CHECK FEE          [AES] AES FEE          [AGI] AGRICULTURAL HOLD          [AHD] AFTER HOURS DELIVERY          [AHP] AFTER HOURS PICKUP          [ALC] ALL CARGO          [ALH] AIRLINE HANDLING          [AMC] ADDITIONAL MACHINE          [AMS] AMS FEE          [APD] APPOINTMENT DELIVERY          [APP] APPOINTMENT PICKUP          [APQ] ANIMAL PLANT QUARANTINE          [APS] AGENT PROFIT SPLIT          [AQI] AGRICULTURAL CHARGE          [ATP] ATTEMPTED PICKUP          [ATX] AIRLINE TAX          [AWB] AIR WAYBILL FEE          [BAF] BUNKER ADJUSTMENT FACTOR          [BBK] BROKERAGE ON BREAKBULK          [BFI] BAF INCREASE          [BLP] BILL OF LADING PREPARATION          [BND] BOND CHARGES          [BOL] BILL OF LADING FEE          [BPF] BOND PREPARATION FEE          [BRK] BROKERAGE          [BSD] BEYOND SPECIAL DELIVERY          [BSP] BEYOND SPECIAL PICKUP          [BYD] BEYOND DELIVERY          [BYP] BEYOND PICKUP          [C&A] CVD/ADD DUTY          [CBF] CUSTOMS BOND FEE          [CBP] CONTINUOUS ENTRY BOND          [CDF] C.O.D. FEE          [CEX] CUSTOMS EXAM FEE          [CFO] COLLECT OCEAN FRT          [CFS] CFS CHARGES          [CGS] CARGO SCREENING          [CHS] CHASSIS CHARGE          [CHZ] CHECK FOR HAZ MAT          [CLD] CONTAINER LOADING          [CLE] CLEARANCE AND HANDLING          [CLR] CUSTOMS CLEARANCE & HANDLING          [CM] CONVENTION MATERIAL          [CMD] CONVENTION CENTER DELIVERY          [CMP] CONVENTION CENTER PICKUP          [CO] CERTIFICATE OF ORIGIN          [COC] COORDINATION AND CONTROL          [COD] C.O.D. MONEY          [COF] CERTIFICATE OF ORIGIN FEE          [COL] COLLECTION FEE          [CON] CONSULTING SERVICES          [COR] COURIER          [CPF] CONSOL / PORT SERVICE FEE          [CPY] COPY OF DOCUMENT OR POD          [CR] CREDIT          [CRE] CRANE CHARGES          [CRN] PRESENTATION OF CARNET          [CRS] CROSS DOCK FEES          [CRT] CRATING & PACKAGING          [CSD] CONTACT SHIPPER FOR DETAILS          [CST] CUSTOMS TITLE SEARCH          [CTF] CLEAN TRUCK FEE          [CTG] CARTAGE          [CVC] CONVENTION CENTER FEE          [CXB] CONTAINER BUILDUP          [DAD] DAD/DOC/WHSE          [DAP] DELIVERED AT PLACE          [DCR] DOMINICAN CONTAINER RELEASE          [DDP] DELIVERY DUTY PAID          [DEM] DEMURRAGE          [DET] DETENTION          [DGC] DANGEROUS GOODS CERTIFICATE          [DGR] DANGEROUS GOODS          [DIM] HEAVY / DIM WEIGHT          [DIV] DIVERSION FEE          [DK] DOCKS & PIERS          [DKD] DOCKS/PIERS DELIVERY          [DKP] DOCKS/PIERS PICKUP          [DLR] DELIVERY          [DO] DELIVERY ORDER          [DOC] DOCUMENTATION          [DPF] DROP FEE          [DRH] DR HANDLING          [DRY] DRAYAGE          [DSB] DISBURSEMENT FEE          [DST] DESTINATION CHARGES          [DTO] DOCUMENT TURNOVER          [DTQ] DUTY - SUBJECT TO LIQUIDATION          [DTY] DUTY AND TAXES          [DVF] DECLARED VALUE FEE          [EDF] EXPORT DECLARATION FEE          [EDH] EXPORT DECLARATION HANDLING          [EFH] ENTRY FEE & HANDLING          [EHD] EXPORT HANDLING          [EOV] EXTRAORDINARY VALUE ITEMS          [ERO] ERRORS & OMISSIONS POLICY          [EUC] EU CUSTOMS FEE          [EUD] EXCLUSIVE USE VEHICLE DELIVERY          [EUP] EXCLUSIVE USE VEHICLE PICKUP          [EUV] EXCLUSIVE USE VEHICLE          [EVD] EOV, HANDLE WITH CARE (D)          [EVP] EOV, HANDLE WITH CARE (P)          [EXM] EXAMINATION COORDINATION          [FCC] FEE FOR COLLECT CHARGES          [FCL] FREIGHT CHARGE COLLECT FEE          [FDA] FOOD & DRUG ENTRY          [FIN] FINANCE CHARGES          [FKL] FORKLIFT FEE          [FRD] FREIGHT DISCOUNT          [FRT] FREIGHT CHARGE          [FSC] FUEL SURCHARGE          [FSD] FUEL SURCHARGE GROUND          [FSJ] FUEL SURCHARGE AIR          [FWD] FORWARDING CHARGES          [GRI] GENERAL RATE INCREASE          [GST] GOODS AND SERVICES TAX          [H&M] HOTELS & MALLS          [HAF] HOUSE AIRFREIGHT          [HAP] HOLD AT AIRPORT          [HAZ] HAZARDOUS MATERIALS          [HD1] HANDLING CHARGES (HD1)          [HKD] HONG KONG DELIVERY ORDER          [HKE] HK EXPORT DECLARATION AND FEES          [HKG] HONG KONG GATE CHARGES          [HLS] HEAVY LIFT SURCHARGE          [HMA] ACCESSIBLE HAZ MAT          [HMF] HARBOR MAINTENANCE FEES          [HMI] INACCESSIBLE HAZ MAT          [HND] HANDLING CHARGES          [HOF] OCEAN FREIGHT          [HPU] HOLD FOR PICKUP          [HST] HARMONIZED SALES TAX          [IEF] IE FEE & HANDLING          [IHD] IMPORT HANDLING          [IND] INSIDE DELIVERY          [INH] INSIDE CHARGE - 1 HR MIN          [INL] INLAND FRT          [INP] INSIDE PICKUP          [INS] INSURANCE AND SERVICES          [INT] INTEREST          [IOF] OCEAN FREIGHT B/B          [IPI] IPI FEE          [IPR] IPPC PALLET REPLACEMENT          [ISC] AIRLINE SERVICE FEE          [ISF] ISF FILING FEE & HANDLING          [ISP] INSPECTION SERVICES          [ITF] I.T. FEE & HANDLING          [ITV] I.T. VALIDATION FEE          [L/S] LUMP SUM          [LAD] LIMITED ACCESS DELIVERY          [LAP] LIMITED ACCESS PICKUP          [LDL] LOCAL DELIVERY          [LEG] LEGALIZATION          [LF] LOCATION FEE          [LG] LIFTGATE          [LGD] LIFTGATE DELIVERY          [LGP] LIFTGATE PICKUP          [LH] LINE HAUL          [LOC] LETTER OF CREDIT          [MBD] MILITARY BASE DELIVERY          [MBP] MILITARY BASE PICKUP          [MFD] MASONITE FLOOR DELIVERY          [MFP] MASONITE FLOOR PICKUP          [MHF] MERCHANDISE PROC/HARBOR MAINT          [MIS] MISCELLANEOUS          [MS2] COURIER (MS2)          [MSE] MERCHANDISE PROCESSING FEE          [MSG] MESSENGER FEE          [MYF] MARSHALLING YARD FEE          [NAB] NEXT DAY AM BEYOND          [NAV] NAVCAN          [NCD] NOTIFY CTRL IF PROBLEMS DEL          [NCF] NAV CAN FEE          [NCP] NOTIFY CTRL IF PROBLEMS PICKUP          [NFB] NFO BEYOND          [NRF] NON-RESIDENTIAL FEE          [NSF] NON-SUFFICIENT FUNDS FEES          [OHR] ON HAND REFUSED SHIPMENT CHG          [ONC] ON-CARRIAGE          [OND] O/N DEL BEFORE NOON          [OPH] OCEAN PORT HANDLING          [OPS] OCEAN P/S          [ORG] ORIGIN FEE          [ORI] ORION FEE          [OSD] OVERSIZE DELIVERY          [OSP] OVERSIZE PICKUP          [OSZ] OVERSIZE SURCHARGE          [OT] OVERTIME/WEEKEND          [OTC] OVER THE COUNTER          [OTH] OTHER CHARGE          [OTL] OUTLAY FOR ADDITIONAL CHARGES          [OZ1] OVERSIZE TIER 1          [OZ2] OVERSIZE TIER 2          [OZ3] OVERSIZE TIER 3          [P/S] PROFIT SPLIT          [PCS] PANAMA CANAL SURCHARGE          [PDE] PROOF OF DELIVERY (ELECTRONIC)          [PE] PERSONAL EFFECTS          [PEN] POST ENTRY SERVICES          [PFA] AIRFREIGHT LESS IATA          [PJ] PALLET JACK CHARGE          [PPF] PIER PASS FEE          [PRC] PRE-CARRIAGE          [PRF] PROTECTIVE FLOORING          [PSF] PORT SECURITY FEE          [PSS] PEAK SEASON SURCHARGE          [PST] PROVINCIAL SALES TAX          [PUP] PICKUP          [QST] QUEBEC SALES TAX          [RBC] RE-BILL CHARGE          [RCC] RECONSIGN / DIVERSION          [RCF] RECOVERY FEE          [RCL] REDELIVERY          [RCM] RECONSIGNMENT          [REB] CUSTOMER REBATE / INCENTIVE          [RLD] RESIDENTIAL DELIVERY          [RLP] RESIDENTIAL PICKUP          [RPK] REPACK          [RWD] REWEIGH AND DIMENSION          [SC] STAIR CARRY          [SCW] STAIR CARRY WEIGHT RATED          [SDA] SPECIAL DELIVERY AFTER HOURS          [SDW] SPECIAL DELIVERY WEEKEND          [SDY] SPECIAL DELIVERY HOLIDAY          [SEB] SINGLE ENTRY BOND          [SEC] SECURITY SURCHARGE          [SED] SHIPPERS EXPORT DECLARATION          [SEM] SEMINAR FEES          [SIG] SIGNATURE SERVICE          [SIL] STEEL IMPORT LICENSE          [SMR] SEMINAR          [SP] SHORT PAY AUTHORIZED          [SPA] SPECIAL PICKUP AFTER HOURS          [SPD] SPECIAL DELIVERY          [SPH] SPECIAL HANDLING SERVICES          [SPP] SPECIAL PICKUP          [SPW] SPECIAL PICKUP WEEKEND          [SPY] SPECIAL PICKUP HOLIDAY          [SRG] SEGREGATION          [SSB] STEAMSHIP LINE BILL OF LADING          [SSP] SERVICE CENTER PERCENTAGE          [STB] SINGLE TRANSACTION BOND          [STD] STORAGE DESTINATION          [STF] CONTAINER STUFFING          [STG] STORAGE          [STO] STORAGE ORIGIN          [STP] STOP OFF          [SVU] SERVICE UPGRADE          [SZD] SPECIAL DELIVERY - ZONE CHARGE          [SZP] SPECIAL PICKUP - ZONE CHARGE          [T&F] OTHER DUTY TAXES & FEES          [TAR] TARIFF FILING FEES          [THC] TERMINAL HANDLING          [TKP] PU AT TRK TRMNL OFF AIRPORT          [TRL] TRANSLOAD          [TRR] TRASH REMOVAL          [TSD] APT TIER SURCHARGE - DEL          [TSH] TRADE SHOW HANDLING          [TSP] APT TIER SURCHARGE - PU          [TST] TESTING CHARGE          [TTC] TEAM TECH COMMERCIAL          [TTD] TEAM TECH DELIVERY          [TTR] TEAM TECH RESIDENTIAL          [TYD] TEAM TECH BEYOND DELIVERY          [UNL] UNLOADING          [UPK] UNPACK          [VAC] VACIS EXAMINATION          [VAT] VAT          [VGM] VERIFIED GROSS WEIGHT          [VLD] VERIFY LIFTGATE REQUIRED DEL          [VLP] VERIFY LIFTGATE REQUIRED PU          [VPK] VERIFY PROPERLY PACKED          [WED] WEEKEND DELIVERY          [WEP] WEEKEND PICKUP          [WFG] WHARFAGE          [WGD] WHITE GLOVE DELIVERY          [WHI] WAREHOUSE IN          [WHO] WAREHOUSE OUT          [WHS] WAREHOUSING          [WHX] WAREHOUSE TRANSFER          [WIO] WAREHOUSING, IN & OUT          [WT] WAIT TIME          [WTC] WAIT TIME FOR CONTAINERS          [WTD] WAIT TIME AT DESTINATION          [WTP] WAIT TIME AT ORIGIN          [WWD] WAREHOUSE WITHDRAWALS          [XAD] EXTENDED AFTER HOURS DELIVERY          [XAP] EXTENDED AFTER HOURS PICKUP          [XDP] EXTD DIST TRUCK TERM DROP          [XDR] EXTRA DRAYAGE          [XEX] X-RAY EXAM FEE          [XFR] TRANSFER          [XRC] EXTD DIST TRUCK TERM RECOVERY          [XRT] EXTRA ROUND TRIP      </value>
    [DataMember(Name="chargeCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "chargeCode")]
    public string ChargeCode { get; set; }

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
      sb.Append("class ProjectedCustomerChargeJsonldShipmentBookingCreate {\n");
      sb.Append("  Context: ").Append(Context).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  ChargeCode: ").Append(ChargeCode).Append("\n");
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
