namespace SimpleK8.Core.DataContracts;

/// <summary>
/// MetricTarget defines the target value, average value, or average utilization of a specific metric
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class MetricTarget
{
	/// <summary>
	/// averageUtilization is the target value of the average of the resource metric across all relevant pods, represented as a percentage of the requested value of the resource for the pods. Currently only valid for Resource metric source type
	/// </summary>
	[Newtonsoft.Json.JsonProperty("averageUtilization", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? AverageUtilization { get; set; }

	/// <summary>
	/// averageValue is the target value of the average of the metric across all relevant pods (as a quantity)
	/// </summary>
	[Newtonsoft.Json.JsonProperty("averageValue", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string AverageValue { get; set; }

	/// <summary>
	/// type represents whether the metric type is Utilization, Value, or AverageValue
	/// </summary>
	[Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Type { get; set; }

	/// <summary>
	/// value is the target value of the metric (as a quantity).
	/// </summary>
	[Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Value { get; set; }

}