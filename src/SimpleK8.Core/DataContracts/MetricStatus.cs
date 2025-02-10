namespace SimpleK8.Core.DataContracts;

/// <summary>
/// MetricStatus describes the last-read state of a single metric.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class MetricStatus
{
	/// <summary>
	/// container resource refers to a resource metric (such as those specified in requests and limits) known to Kubernetes describing a single container in each pod in the current scale target (e.g. CPU or memory). Such metrics are built in to Kubernetes, and have special scaling options on top of those available to normal per-pod metrics using the "pods" source.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("containerResource", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public ContainerResourceMetricStatus ContainerResource { get; set; }

	/// <summary>
	/// external refers to a global metric that is not associated with any Kubernetes object. It allows autoscaling based on information coming from components running outside of cluster (for example length of queue in cloud messaging service, or QPS from loadbalancer running outside of cluster).
	/// </summary>
	[Newtonsoft.Json.JsonProperty("external", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public ExternalMetricStatus External { get; set; }

	/// <summary>
	/// object refers to a metric describing a single kubernetes object (for example, hits-per-second on an Ingress object).
	/// </summary>
	[Newtonsoft.Json.JsonProperty("object", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public ObjectMetricStatus Object { get; set; }

	/// <summary>
	/// pods refers to a metric describing each pod in the current scale target (for example, transactions-processed-per-second).  The values will be averaged together before being compared to the target value.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("pods", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public PodsMetricStatus Pods { get; set; }

	/// <summary>
	/// resource refers to a resource metric (such as those specified in requests and limits) known to Kubernetes describing each pod in the current scale target (e.g. CPU or memory). Such metrics are built in to Kubernetes, and have special scaling options on top of those available to normal per-pod metrics using the "pods" source.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("resource", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public ResourceMetricStatus Resource { get; set; }

	/// <summary>
	/// type is the type of metric source.  It will be one of "ContainerResource", "External", "Object", "Pods" or "Resource", each corresponds to a matching field in the object.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Type { get; set; }

}