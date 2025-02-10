namespace SimpleK8.Core.DataContracts;

/// <summary>
/// PodsMetricStatus indicates the current value of a metric describing each pod in the current scale target (for example, transactions-processed-per-second).
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class PodsMetricStatus
{
	/// <summary>
	/// current contains the current value for the given metric
	/// </summary>
	[Newtonsoft.Json.JsonProperty("current", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required]
	public MetricValueStatus Current { get; set; } = new MetricValueStatus();

	/// <summary>
	/// metric identifies the target metric by name and selector
	/// </summary>
	[Newtonsoft.Json.JsonProperty("metric", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required]
	public MetricIdentifier Metric { get; set; } = new MetricIdentifier();

}