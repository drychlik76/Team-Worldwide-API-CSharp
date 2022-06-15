using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace TeamWorldwideModel {

  /// <summary>
  /// Get Rates
  /// </summary>
  [DataContract]
  public class GetRate {
    /// <summary>
    /// Gets or Sets UniqueId
    /// </summary>
    [DataMember(Name="uniqueId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uniqueId")]
    public string UniqueId { get; set; }

    /// <summary>
    /// Gets or Sets OriginCity
    /// </summary>
    [DataMember(Name="originCity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "originCity")]
    public string OriginCity { get; set; }

    /// <summary>
    /// Gets or Sets OriginState
    /// </summary>
    [DataMember(Name="originState", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "originState")]
    public string OriginState { get; set; }

    /// <summary>
    /// Gets or Sets OriginZipCode
    /// </summary>
    [DataMember(Name="originZipCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "originZipCode")]
    public string OriginZipCode { get; set; }

    /// <summary>
    /// Gets or Sets OriginCountry
    /// </summary>
    [DataMember(Name="originCountry", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "originCountry")]
    public string OriginCountry { get; set; }

    /// <summary>
    /// Gets or Sets DestinationCity
    /// </summary>
    [DataMember(Name="destinationCity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "destinationCity")]
    public string DestinationCity { get; set; }

    /// <summary>
    /// Gets or Sets DestinationState
    /// </summary>
    [DataMember(Name="destinationState", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "destinationState")]
    public string DestinationState { get; set; }

    /// <summary>
    /// Gets or Sets DestinationZipCode
    /// </summary>
    [DataMember(Name="destinationZipCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "destinationZipCode")]
    public string DestinationZipCode { get; set; }

    /// <summary>
    /// Gets or Sets DestinationCountry
    /// </summary>
    [DataMember(Name="destinationCountry", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "destinationCountry")]
    public string DestinationCountry { get; set; }

    /// <summary>
    /// Gets or Sets Freight
    /// </summary>
    [DataMember(Name="freight", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "freight")]
    public List<Freight> Freight { get; set; }

    /// <summary>
    /// Gets or Sets UnitOfMeasure
    /// </summary>
    [DataMember(Name="unitOfMeasure", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unitOfMeasure")]
    public string UnitOfMeasure { get; set; }

    /// <summary>
    /// Array of accessorial codes. Refer to enabledAccessorials returned in /api/team-book/get-accessorials. Provide the code.
    /// </summary>
    /// <value>Array of accessorial codes. Refer to enabledAccessorials returned in /api/team-book/get-accessorials. Provide the code.</value>
    [DataMember(Name="teamBookAccessorials", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "teamBookAccessorials")]
    public List<string> TeamBookAccessorials { get; set; }

    /// <summary>
    /// Gets or Sets PickupDate
    /// </summary>
    [DataMember(Name="pickupDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pickupDate")]
    public DateTime? PickupDate { get; set; }

    /// <summary>
    /// Gets or Sets RateTypeList
    /// </summary>
    [DataMember(Name="rateTypeList", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rateTypeList")]
    public List<string> RateTypeList { get; set; }

    /// <summary>
    /// Gets or Sets Equipment
    /// </summary>
    [DataMember(Name="equipment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "equipment")]
    public string Equipment { get; set; }

    /// <summary>
    /// Gets or Sets InsuranceAddOn
    /// </summary>
    [DataMember(Name="insuranceAddOn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "insuranceAddOn")]
    public bool? InsuranceAddOn { get; set; }

    /// <summary>
    /// Gets or Sets InsureFreight
    /// </summary>
    [DataMember(Name="insureFreight", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "insureFreight")]
    public bool? InsureFreight { get; set; }

    /// <summary>
    /// Gets or Sets InsuranceAmount
    /// </summary>
    [DataMember(Name="insuranceAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "insuranceAmount")]
    public decimal? InsuranceAmount { get; set; }

    /// <summary>
    /// Gets or Sets LinearFeet
    /// </summary>
    [DataMember(Name="linearFeet", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "linearFeet")]
    public decimal? LinearFeet { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetRate {\n");
      sb.Append("  UniqueId: ").Append(UniqueId).Append("\n");
      sb.Append("  OriginCity: ").Append(OriginCity).Append("\n");
      sb.Append("  OriginState: ").Append(OriginState).Append("\n");
      sb.Append("  OriginZipCode: ").Append(OriginZipCode).Append("\n");
      sb.Append("  OriginCountry: ").Append(OriginCountry).Append("\n");
      sb.Append("  DestinationCity: ").Append(DestinationCity).Append("\n");
      sb.Append("  DestinationState: ").Append(DestinationState).Append("\n");
      sb.Append("  DestinationZipCode: ").Append(DestinationZipCode).Append("\n");
      sb.Append("  DestinationCountry: ").Append(DestinationCountry).Append("\n");
      sb.Append("  Freight: ").Append(Freight).Append("\n");
      sb.Append("  UnitOfMeasure: ").Append(UnitOfMeasure).Append("\n");
      sb.Append("  TeamBookAccessorials: ").Append(TeamBookAccessorials).Append("\n");
      sb.Append("  PickupDate: ").Append(PickupDate).Append("\n");
      sb.Append("  RateTypeList: ").Append(RateTypeList).Append("\n");
      sb.Append("  Equipment: ").Append(Equipment).Append("\n");
      sb.Append("  InsuranceAddOn: ").Append(InsuranceAddOn).Append("\n");
      sb.Append("  InsureFreight: ").Append(InsureFreight).Append("\n");
      sb.Append("  InsuranceAmount: ").Append(InsuranceAmount).Append("\n");
      sb.Append("  LinearFeet: ").Append(LinearFeet).Append("\n");
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
