namespace SimpleK8.Core.DataContracts;

/// <summary>
/// ObjectMetricStatus indicates the current value of a metric describing a kubernetes object (for example, hits-per-second on an Ingress object).
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class ObjectMetricStatus
{
	/// <summary>
	/// current contains the current value for the given metric
	/// </summary>
	[Newtonsoft.Json.JsonProperty("current", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required]
	public MetricValueStatus Current { get; set; } = new MetricValueStatus();

	/// <summary>
	/// DescribedObject specifies the descriptions of a object,such as kind,name apiVersion
	/// </summary>
	[Newtonsoft.Json.JsonProperty("describedObject", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required]
	public CrossVersionObjectReference2 DescribedObject { get; set; } = new CrossVersionObjectReference2();

	/// <summary>
	/// metric identifies the target metric by name and selector
	/// </summary>
	[Newtonsoft.Json.JsonProperty("metric", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required]
	public MetricIdentifier Metric { get; set; } = new MetricIdentifier();

}