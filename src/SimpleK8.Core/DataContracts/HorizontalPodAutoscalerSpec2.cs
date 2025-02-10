namespace SimpleK8.Core.DataContracts;

/// <summary>
/// HorizontalPodAutoscalerSpec describes the desired functionality of the HorizontalPodAutoscaler.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class HorizontalPodAutoscalerSpec2
{
	/// <summary>
	/// behavior configures the scaling behavior of the target in both Up and Down directions (scaleUp and scaleDown fields respectively). If not set, the default HPAScalingRules for scale up and scale down are used.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("behavior", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public HorizontalPodAutoscalerBehavior Behavior { get; set; }

	/// <summary>
	/// maxReplicas is the upper limit for the number of replicas to which the autoscaler can scale up. It cannot be less that minReplicas.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("maxReplicas", Required = Newtonsoft.Json.Required.Always)]
	public int MaxReplicas { get; set; }

	/// <summary>
	/// metrics contains the specifications for which to use to calculate the desired replica count (the maximum replica count across all metrics will be used).  The desired replica count is calculated multiplying the ratio between the target value and the current value by the current number of pods.  Ergo, metrics used must decrease as the pod count is increased, and vice-versa.  See the individual metric source types for more information about how each type of metric must respond. If not set, the default metric will be set to 80% average CPU utilization.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("metrics", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<MetricSpec> Metrics { get; set; }

	/// <summary>
	/// minReplicas is the lower limit for the number of replicas to which the autoscaler can scale down.  It defaults to 1 pod.  minReplicas is allowed to be 0 if the alpha feature gate HPAScaleToZero is enabled and at least one Object or External metric is configured.  Scaling is active as long as at least one metric value is available.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("minReplicas", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? MinReplicas { get; set; }

	/// <summary>
	/// scaleTargetRef points to the target resource to scale, and is used to the pods for which metrics should be collected, as well as to actually change the replica count.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("scaleTargetRef", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required]
	public CrossVersionObjectReference2 ScaleTargetRef { get; set; } = new CrossVersionObjectReference2();

}