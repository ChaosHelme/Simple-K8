namespace SimpleK8.Core.DataContracts;

/// <summary>
/// specification of a horizontal pod autoscaler.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class HorizontalPodAutoscalerSpec
{
	/// <summary>
	/// maxReplicas is the upper limit for the number of pods that can be set by the autoscaler; cannot be smaller than MinReplicas.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("maxReplicas", Required = Newtonsoft.Json.Required.Always)]
	public int MaxReplicas { get; set; }

	/// <summary>
	/// minReplicas is the lower limit for the number of replicas to which the autoscaler can scale down.  It defaults to 1 pod.  minReplicas is allowed to be 0 if the alpha feature gate HPAScaleToZero is enabled and at least one Object or External metric is configured.  Scaling is active as long as at least one metric value is available.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("minReplicas", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? MinReplicas { get; set; }

	/// <summary>
	/// reference to scaled resource; horizontal pod autoscaler will learn the current resource consumption and will set the desired number of pods by using its Scale subresource.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("scaleTargetRef", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required]
	public CrossVersionObjectReference ScaleTargetRef { get; set; } = new CrossVersionObjectReference();

	/// <summary>
	/// targetCPUUtilizationPercentage is the target average CPU utilization (represented as a percentage of requested CPU) over all the pods; if not specified the default autoscaling policy will be used.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("targetCPUUtilizationPercentage", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? TargetCPUUtilizationPercentage { get; set; }

}