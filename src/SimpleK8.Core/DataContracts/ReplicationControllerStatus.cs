namespace SimpleK8.Core.DataContracts;

/// <summary>
/// ReplicationControllerStatus represents the current status of a replication controller.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class ReplicationControllerStatus
{
	/// <summary>
	/// The number of available replicas (ready for at least minReadySeconds) for this replication controller.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("availableReplicas", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? AvailableReplicas { get; set; }

	/// <summary>
	/// Represents the latest available observations of a replication controller's current state.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("conditions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<ReplicationControllerCondition> Conditions { get; set; }

	/// <summary>
	/// The number of pods that have labels matching the labels of the pod template of the replication controller.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("fullyLabeledReplicas", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? FullyLabeledReplicas { get; set; }

	/// <summary>
	/// ObservedGeneration reflects the generation of the most recently observed replication controller.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("observedGeneration", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public long? ObservedGeneration { get; set; }

	/// <summary>
	/// The number of ready replicas for this replication controller.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("readyReplicas", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? ReadyReplicas { get; set; }

	/// <summary>
	/// Replicas is the most recently observed number of replicas. More info: https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller#what-is-a-replicationcontroller
	/// </summary>
	[Newtonsoft.Json.JsonProperty("replicas", Required = Newtonsoft.Json.Required.Always)]
	public int Replicas { get; set; }

}