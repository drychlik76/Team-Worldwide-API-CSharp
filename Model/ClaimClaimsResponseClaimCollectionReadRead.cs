using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace TeamWorldwideModel {

  /// <summary>
  /// Get, File or Update a Claim
  /// </summary>
  [DataContract]
  public class ClaimClaimsResponseClaimCollectionReadRead {
    /// <summary>
    /// Gets or Sets ClaimId
    /// </summary>
    [DataMember(Name="claimId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "claimId")]
    public string ClaimId { get; set; }

    /// <summary>
    /// Gets or Sets IsActive
    /// </summary>
    [DataMember(Name="isActive", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isActive")]
    public bool? IsActive { get; set; }

    /// <summary>
    /// Gets or Sets Hawb
    /// </summary>
    [DataMember(Name="hawb", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hawb")]
    public string Hawb { get; set; }

    /// <summary>
    /// Gets or Sets CarrierAirBillNumber
    /// </summary>
    [DataMember(Name="carrierAirBillNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "carrierAirBillNumber")]
    public string CarrierAirBillNumber { get; set; }

    /// <summary>
    /// Gets or Sets BrokerNumber
    /// </summary>
    [DataMember(Name="brokerNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "brokerNumber")]
    public string BrokerNumber { get; set; }

    /// <summary>
    /// Gets or Sets StatusOfMaster
    /// </summary>
    [DataMember(Name="statusOfMaster", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "statusOfMaster")]
    public string StatusOfMaster { get; set; }

    /// <summary>
    /// Gets or Sets FinalStatusOfClaim
    /// </summary>
    [DataMember(Name="finalStatusOfClaim", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "finalStatusOfClaim")]
    public string FinalStatusOfClaim { get; set; }

    /// <summary>
    /// Gets or Sets CustomerNumber
    /// </summary>
    [DataMember(Name="customerNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customerNumber")]
    public string CustomerNumber { get; set; }

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
    /// Gets or Sets PiecesDamaged
    /// </summary>
    [DataMember(Name="piecesDamaged", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "piecesDamaged")]
    public int? PiecesDamaged { get; set; }

    /// <summary>
    /// Gets or Sets WeightDamaged
    /// </summary>
    [DataMember(Name="weightDamaged", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "weightDamaged")]
    public decimal? WeightDamaged { get; set; }

    /// <summary>
    /// Gets or Sets Carrier
    /// </summary>
    [DataMember(Name="carrier", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "carrier")]
    public string Carrier { get; set; }

    /// <summary>
    /// Gets or Sets CarrierNumber
    /// </summary>
    [DataMember(Name="carrierNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "carrierNumber")]
    public string CarrierNumber { get; set; }

    /// <summary>
    /// Gets or Sets Company
    /// </summary>
    [DataMember(Name="company", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "company")]
    public string Company { get; set; }

    /// <summary>
    /// Gets or Sets SubAmount
    /// </summary>
    [DataMember(Name="subAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subAmount")]
    public decimal? SubAmount { get; set; }

    /// <summary>
    /// Gets or Sets SubPaidAmount
    /// </summary>
    [DataMember(Name="subPaidAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subPaidAmount")]
    public decimal? SubPaidAmount { get; set; }

    /// <summary>
    /// Gets or Sets ClaimsAmount
    /// </summary>
    [DataMember(Name="claimsAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "claimsAmount")]
    public decimal? ClaimsAmount { get; set; }

    /// <summary>
    /// Gets or Sets ClaimPaidAmount
    /// </summary>
    [DataMember(Name="claimPaidAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "claimPaidAmount")]
    public decimal? ClaimPaidAmount { get; set; }

    /// <summary>
    /// Gets or Sets ClaimCheckNumber
    /// </summary>
    [DataMember(Name="claimCheckNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "claimCheckNumber")]
    public string ClaimCheckNumber { get; set; }

    /// <summary>
    /// Gets or Sets ClaimCheckDate
    /// </summary>
    [DataMember(Name="claimCheckDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "claimCheckDate")]
    public DateTime? ClaimCheckDate { get; set; }

    /// <summary>
    /// Gets or Sets SubrogateAgainst
    /// </summary>
    [DataMember(Name="subrogateAgainst", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subrogateAgainst")]
    public string SubrogateAgainst { get; set; }

    /// <summary>
    /// Gets or Sets SubrogateAmount
    /// </summary>
    [DataMember(Name="subrogateAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subrogateAmount")]
    public decimal? SubrogateAmount { get; set; }

    /// <summary>
    /// Gets or Sets SubrogatePaidAmount
    /// </summary>
    [DataMember(Name="subrogatePaidAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subrogatePaidAmount")]
    public decimal? SubrogatePaidAmount { get; set; }

    /// <summary>
    /// Gets or Sets SubrogateCheckNumber
    /// </summary>
    [DataMember(Name="subrogateCheckNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subrogateCheckNumber")]
    public string SubrogateCheckNumber { get; set; }

    /// <summary>
    /// Gets or Sets SubrogateCheckDate
    /// </summary>
    [DataMember(Name="subrogateCheckDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subrogateCheckDate")]
    public DateTime? SubrogateCheckDate { get; set; }

    /// <summary>
    /// Gets or Sets DeclaredValueRecap
    /// </summary>
    [DataMember(Name="declaredValueRecap", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "declaredValueRecap")]
    public decimal? DeclaredValueRecap { get; set; }

    /// <summary>
    /// Gets or Sets DeclaredValueAmountOnClaim
    /// </summary>
    [DataMember(Name="declaredValueAmountOnClaim", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "declaredValueAmountOnClaim")]
    public decimal? DeclaredValueAmountOnClaim { get; set; }

    /// <summary>
    /// Gets or Sets Information
    /// </summary>
    [DataMember(Name="information", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "information")]
    public string Information { get; set; }

    /// <summary>
    /// Gets or Sets DateClaimCalledInByConsignee
    /// </summary>
    [DataMember(Name="dateClaimCalledInByConsignee", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dateClaimCalledInByConsignee")]
    public DateTime? DateClaimCalledInByConsignee { get; set; }

    /// <summary>
    /// Gets or Sets EntryDate
    /// </summary>
    [DataMember(Name="entryDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "entryDate")]
    public DateTime? EntryDate { get; set; }

    /// <summary>
    /// Gets or Sets FreightPaidDate
    /// </summary>
    [DataMember(Name="freightPaidDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "freightPaidDate")]
    public DateTime? FreightPaidDate { get; set; }

    /// <summary>
    /// Gets or Sets ReceiveDate
    /// </summary>
    [DataMember(Name="receiveDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "receiveDate")]
    public DateTime? ReceiveDate { get; set; }

    /// <summary>
    /// Gets or Sets RecapDate
    /// </summary>
    [DataMember(Name="recapDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recapDate")]
    public DateTime? RecapDate { get; set; }

    /// <summary>
    /// Gets or Sets ShipDate
    /// </summary>
    [DataMember(Name="shipDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipDate")]
    public DateTime? ShipDate { get; set; }

    /// <summary>
    /// Gets or Sets TransactionDate
    /// </summary>
    [DataMember(Name="transactionDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transactionDate")]
    public DateTime? TransactionDate { get; set; }

    /// <summary>
    /// Gets or Sets Code
    /// </summary>
    [DataMember(Name="code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "code")]
    public string Code { get; set; }

    /// <summary>
    /// Gets or Sets Decision
    /// </summary>
    [DataMember(Name="decision", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "decision")]
    public string Decision { get; set; }

    /// <summary>
    /// Gets or Sets SubCode
    /// </summary>
    [DataMember(Name="subCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subCode")]
    public string SubCode { get; set; }

    /// <summary>
    /// Gets or Sets _Operator
    /// </summary>
    [DataMember(Name="operator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "operator")]
    public string _Operator { get; set; }

    /// <summary>
    /// Gets or Sets Product
    /// </summary>
    [DataMember(Name="product", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "product")]
    public string Product { get; set; }

    /// <summary>
    /// Gets or Sets Content
    /// </summary>
    [DataMember(Name="content", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "content")]
    public string Content { get; set; }

    /// <summary>
    /// Gets or Sets ClaimantName
    /// </summary>
    [DataMember(Name="claimantName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "claimantName")]
    public string ClaimantName { get; set; }

    /// <summary>
    /// Gets or Sets InsuranceCompany
    /// </summary>
    [DataMember(Name="insuranceCompany", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "insuranceCompany")]
    public string InsuranceCompany { get; set; }

    /// <summary>
    /// Gets or Sets WayBillNumber
    /// </summary>
    [DataMember(Name="wayBillNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "wayBillNumber")]
    public string WayBillNumber { get; set; }

    /// <summary>
    /// Gets or Sets SubCheckNumber
    /// </summary>
    [DataMember(Name="subCheckNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subCheckNumber")]
    public string SubCheckNumber { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets LossDamaged
    /// </summary>
    [DataMember(Name="lossDamaged", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lossDamaged")]
    public string LossDamaged { get; set; }

    /// <summary>
    /// Gets or Sets FirstName
    /// </summary>
    [DataMember(Name="firstName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "firstName")]
    public string FirstName { get; set; }

    /// <summary>
    /// Gets or Sets LastName
    /// </summary>
    [DataMember(Name="lastName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastName")]
    public string LastName { get; set; }

    /// <summary>
    /// Gets or Sets Email
    /// </summary>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }

    /// <summary>
    /// Gets or Sets Phone
    /// </summary>
    [DataMember(Name="phone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phone")]
    public string Phone { get; set; }

    /// <summary>
    /// Gets or Sets Address
    /// </summary>
    [DataMember(Name="address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address")]
    public string Address { get; set; }

    /// <summary>
    /// Gets or Sets Address2
    /// </summary>
    [DataMember(Name="address2", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address2")]
    public string Address2 { get; set; }

    /// <summary>
    /// Gets or Sets City
    /// </summary>
    [DataMember(Name="city", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "city")]
    public string City { get; set; }

    /// <summary>
    /// Gets or Sets State
    /// </summary>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    /// <summary>
    /// Gets or Sets ZipCode
    /// </summary>
    [DataMember(Name="zipCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "zipCode")]
    public string ZipCode { get; set; }

    /// <summary>
    /// Gets or Sets Form
    /// </summary>
    [DataMember(Name="form", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "form")]
    public string Form { get; set; }

    /// <summary>
    /// Gets or Sets Sent
    /// </summary>
    [DataMember(Name="sent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sent")]
    public bool? Sent { get; set; }

    /// <summary>
    /// Gets or Sets Comment
    /// </summary>
    [DataMember(Name="comment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "comment")]
    public string Comment { get; set; }

    /// <summary>
    /// Gets or Sets ReportDate
    /// </summary>
    [DataMember(Name="reportDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reportDate")]
    public DateTime? ReportDate { get; set; }

    /// <summary>
    /// Gets or Sets CheckDate
    /// </summary>
    [DataMember(Name="checkDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "checkDate")]
    public DateTime? CheckDate { get; set; }

    /// <summary>
    /// Gets or Sets SubDatePaid
    /// </summary>
    [DataMember(Name="subDatePaid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subDatePaid")]
    public DateTime? SubDatePaid { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ClaimClaimsResponseClaimCollectionReadRead {\n");
      sb.Append("  ClaimId: ").Append(ClaimId).Append("\n");
      sb.Append("  IsActive: ").Append(IsActive).Append("\n");
      sb.Append("  Hawb: ").Append(Hawb).Append("\n");
      sb.Append("  CarrierAirBillNumber: ").Append(CarrierAirBillNumber).Append("\n");
      sb.Append("  BrokerNumber: ").Append(BrokerNumber).Append("\n");
      sb.Append("  StatusOfMaster: ").Append(StatusOfMaster).Append("\n");
      sb.Append("  FinalStatusOfClaim: ").Append(FinalStatusOfClaim).Append("\n");
      sb.Append("  CustomerNumber: ").Append(CustomerNumber).Append("\n");
      sb.Append("  Origin: ").Append(Origin).Append("\n");
      sb.Append("  Destination: ").Append(Destination).Append("\n");
      sb.Append("  Pieces: ").Append(Pieces).Append("\n");
      sb.Append("  Weight: ").Append(Weight).Append("\n");
      sb.Append("  PiecesDamaged: ").Append(PiecesDamaged).Append("\n");
      sb.Append("  WeightDamaged: ").Append(WeightDamaged).Append("\n");
      sb.Append("  Carrier: ").Append(Carrier).Append("\n");
      sb.Append("  CarrierNumber: ").Append(CarrierNumber).Append("\n");
      sb.Append("  Company: ").Append(Company).Append("\n");
      sb.Append("  SubAmount: ").Append(SubAmount).Append("\n");
      sb.Append("  SubPaidAmount: ").Append(SubPaidAmount).Append("\n");
      sb.Append("  ClaimsAmount: ").Append(ClaimsAmount).Append("\n");
      sb.Append("  ClaimPaidAmount: ").Append(ClaimPaidAmount).Append("\n");
      sb.Append("  ClaimCheckNumber: ").Append(ClaimCheckNumber).Append("\n");
      sb.Append("  ClaimCheckDate: ").Append(ClaimCheckDate).Append("\n");
      sb.Append("  SubrogateAgainst: ").Append(SubrogateAgainst).Append("\n");
      sb.Append("  SubrogateAmount: ").Append(SubrogateAmount).Append("\n");
      sb.Append("  SubrogatePaidAmount: ").Append(SubrogatePaidAmount).Append("\n");
      sb.Append("  SubrogateCheckNumber: ").Append(SubrogateCheckNumber).Append("\n");
      sb.Append("  SubrogateCheckDate: ").Append(SubrogateCheckDate).Append("\n");
      sb.Append("  DeclaredValueRecap: ").Append(DeclaredValueRecap).Append("\n");
      sb.Append("  DeclaredValueAmountOnClaim: ").Append(DeclaredValueAmountOnClaim).Append("\n");
      sb.Append("  Information: ").Append(Information).Append("\n");
      sb.Append("  DateClaimCalledInByConsignee: ").Append(DateClaimCalledInByConsignee).Append("\n");
      sb.Append("  EntryDate: ").Append(EntryDate).Append("\n");
      sb.Append("  FreightPaidDate: ").Append(FreightPaidDate).Append("\n");
      sb.Append("  ReceiveDate: ").Append(ReceiveDate).Append("\n");
      sb.Append("  RecapDate: ").Append(RecapDate).Append("\n");
      sb.Append("  ShipDate: ").Append(ShipDate).Append("\n");
      sb.Append("  TransactionDate: ").Append(TransactionDate).Append("\n");
      sb.Append("  Code: ").Append(Code).Append("\n");
      sb.Append("  Decision: ").Append(Decision).Append("\n");
      sb.Append("  SubCode: ").Append(SubCode).Append("\n");
      sb.Append("  _Operator: ").Append(_Operator).Append("\n");
      sb.Append("  Product: ").Append(Product).Append("\n");
      sb.Append("  Content: ").Append(Content).Append("\n");
      sb.Append("  ClaimantName: ").Append(ClaimantName).Append("\n");
      sb.Append("  InsuranceCompany: ").Append(InsuranceCompany).Append("\n");
      sb.Append("  WayBillNumber: ").Append(WayBillNumber).Append("\n");
      sb.Append("  SubCheckNumber: ").Append(SubCheckNumber).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  LossDamaged: ").Append(LossDamaged).Append("\n");
      sb.Append("  FirstName: ").Append(FirstName).Append("\n");
      sb.Append("  LastName: ").Append(LastName).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  Phone: ").Append(Phone).Append("\n");
      sb.Append("  Address: ").Append(Address).Append("\n");
      sb.Append("  Address2: ").Append(Address2).Append("\n");
      sb.Append("  City: ").Append(City).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  ZipCode: ").Append(ZipCode).Append("\n");
      sb.Append("  Form: ").Append(Form).Append("\n");
      sb.Append("  Sent: ").Append(Sent).Append("\n");
      sb.Append("  Comment: ").Append(Comment).Append("\n");
      sb.Append("  ReportDate: ").Append(ReportDate).Append("\n");
      sb.Append("  CheckDate: ").Append(CheckDate).Append("\n");
      sb.Append("  SubDatePaid: ").Append(SubDatePaid).Append("\n");
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
