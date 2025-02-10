namespace SimpleK8.Core.DataContracts;

/// <summary>
/// HorizontalPodAutoscalerStatus describes the current status of a horizontal pod autoscaler.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class HorizontalPodAutoscalerStatus2
{
	/// <summary>
	/// conditions is the set of conditions required for this autoscaler to scale its target, and indicates whether or not those conditions are met.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("conditions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<HorizontalPodAutoscalerCondition> Conditions { get; set; }

	/// <summary>
	/// currentMetrics is the last read state of the metrics used by this autoscaler.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("currentMetrics", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<MetricStatus> CurrentMetrics { get; set; }

	/// <summary>
	/// currentReplicas is current number of replicas of pods managed by this autoscaler, as last seen by the autoscaler.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("currentReplicas", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? CurrentReplicas { get; set; }

	/// <summary>
	/// desiredReplicas is the desired number of replicas of pods managed by this autoscaler, as last calculated by the autoscaler.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("desiredReplicas", Required = Newtonsoft.Json.Required.Always)]
	public int DesiredReplicas { get; set; }

	/// <summary>
	/// lastScaleTime is the last time the HorizontalPodAutoscaler scaled the number of pods, used by the autoscaler to control how often the number of pods is changed.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("lastScaleTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.DateTimeOffset? LastScaleTime { get; set; }

	/// <summary>
	/// observedGeneration is the most recent generation observed by this autoscaler.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("observedGeneration", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public long? ObservedGeneration { get; set; }

}