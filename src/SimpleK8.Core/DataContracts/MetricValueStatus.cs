namespace SimpleK8.Core.DataContracts;

/// <summary>
/// MetricValueStatus holds the current value for a metric
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class MetricValueStatus
{
	/// <summary>
	/// currentAverageUtilization is the current value of the average of the resource metric across all relevant pods, represented as a percentage of the requested value of the resource for the pods.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("averageUtilization", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? AverageUtilization { get; set; }

	/// <summary>
	/// averageValue is the current value of the average of the metric across all relevant pods (as a quantity)
	/// </summary>
	[Newtonsoft.Json.JsonProperty("averageValue", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string AverageValue { get; set; }

	/// <summary>
	/// value is the current value of the metric (as a quantity).
	/// </summary>
	[Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Value { get; set; }

}