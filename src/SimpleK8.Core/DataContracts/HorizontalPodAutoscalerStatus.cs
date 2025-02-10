namespace SimpleK8.Core.DataContracts;

/// <summary>
/// current status of a horizontal pod autoscaler
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class HorizontalPodAutoscalerStatus
{
	/// <summary>
	/// currentCPUUtilizationPercentage is the current average CPU utilization over all pods, represented as a percentage of requested CPU, e.g. 70 means that an average pod is using now 70% of its requested CPU.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("currentCPUUtilizationPercentage", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? CurrentCPUUtilizationPercentage { get; set; }

	/// <summary>
	/// currentReplicas is the current number of replicas of pods managed by this autoscaler.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("currentReplicas", Required = Newtonsoft.Json.Required.Always)]
	public int CurrentReplicas { get; set; }

	/// <summary>
	/// desiredReplicas is the  desired number of replicas of pods managed by this autoscaler.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("desiredReplicas", Required = Newtonsoft.Json.Required.Always)]
	public int DesiredReplicas { get; set; }

	/// <summary>
	/// lastScaleTime is the last time the HorizontalPodAutoscaler scaled the number of pods; used by the autoscaler to control how often the number of pods is changed.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("lastScaleTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.DateTimeOffset? LastScaleTime { get; set; }

	/// <summary>
	/// observedGeneration is the most recent generation observed by this autoscaler.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("observedGeneration", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public long? ObservedGeneration { get; set; }

}