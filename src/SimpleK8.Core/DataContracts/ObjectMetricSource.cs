namespace SimpleK8.Core.DataContracts;

/// <summary>
/// ObjectMetricSource indicates how to scale on a metric describing a kubernetes object (for example, hits-per-second on an Ingress object).
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class ObjectMetricSource
{
	/// <summary>
	/// describedObject specifies the descriptions of a object,such as kind,name apiVersion
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

	/// <summary>
	/// target specifies the target value for the given metric
	/// </summary>
	[Newtonsoft.Json.JsonProperty("target", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required]
	public MetricTarget Target { get; set; } = new MetricTarget();

}