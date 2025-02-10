namespace SimpleK8.Core.DataContracts;

/// <summary>
/// ReplicaSetStatus represents the current status of a ReplicaSet.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class ReplicaSetStatus
{
	/// <summary>
	/// The number of available non-terminating pods (ready for at least minReadySeconds) for this replica set.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("availableReplicas", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? AvailableReplicas { get; set; }

	/// <summary>
	/// Represents the latest available observations of a replica set's current state.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("conditions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<ReplicaSetCondition> Conditions { get; set; }

	/// <summary>
	/// The number of non-terminating pods that have labels matching the labels of the pod template of the replicaset.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("fullyLabeledReplicas", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? FullyLabeledReplicas { get; set; }

	/// <summary>
	/// ObservedGeneration reflects the generation of the most recently observed ReplicaSet.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("observedGeneration", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public long? ObservedGeneration { get; set; }

	/// <summary>
	/// The number of non-terminating pods targeted by this ReplicaSet with a Ready Condition.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("readyReplicas", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? ReadyReplicas { get; set; }

	/// <summary>
	/// Replicas is the most recently observed number of non-terminating pods. More info: https://kubernetes.io/docs/concepts/workloads/controllers/replicaset
	/// </summary>
	[Newtonsoft.Json.JsonProperty("replicas", Required = Newtonsoft.Json.Required.Always)]
	public int Replicas { get; set; }

	/// <summary>
	/// The number of terminating pods for this replica set. Terminating pods have a non-null .metadata.deletionTimestamp and have not yet reached the Failed or Succeeded .status.phase.
	/// <br/>
	/// <br/>This is an alpha field. Enable DeploymentPodReplacementPolicy to be able to use this field.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("terminatingReplicas", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? TerminatingReplicas { get; set; }

}