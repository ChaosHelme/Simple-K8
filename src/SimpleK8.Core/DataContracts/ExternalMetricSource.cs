namespace SimpleK8.Core.DataContracts;

/// <summary>
/// ExternalMetricSource indicates how to scale on a metric not associated with any Kubernetes object (for example length of queue in cloud messaging service, or QPS from loadbalancer running outside of cluster).
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class ExternalMetricSource
{
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