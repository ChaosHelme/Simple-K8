namespace SimpleK8.Core.DataContracts;

/// <summary>
/// StatefulSetStatus represents the current state of a StatefulSet.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class StatefulSetStatus
{
	/// <summary>
	/// Total number of available pods (ready for at least minReadySeconds) targeted by this statefulset.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("availableReplicas", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? AvailableReplicas { get; set; }

	/// <summary>
	/// collisionCount is the count of hash collisions for the StatefulSet. The StatefulSet controller uses this field as a collision avoidance mechanism when it needs to create the name for the newest ControllerRevision.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("collisionCount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? CollisionCount { get; set; }

	/// <summary>
	/// Represents the latest available observations of a statefulset's current state.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("conditions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<StatefulSetCondition> Conditions { get; set; }

	/// <summary>
	/// currentReplicas is the number of Pods created by the StatefulSet controller from the StatefulSet version indicated by currentRevision.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("currentReplicas", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? CurrentReplicas { get; set; }

	/// <summary>
	/// currentRevision, if not empty, indicates the version of the StatefulSet used to generate Pods in the sequence [0,currentReplicas).
	/// </summary>
	[Newtonsoft.Json.JsonProperty("currentRevision", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string CurrentRevision { get; set; }

	/// <summary>
	/// observedGeneration is the most recent generation observed for this StatefulSet. It corresponds to the StatefulSet's generation, which is updated on mutation by the API Server.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("observedGeneration", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public long? ObservedGeneration { get; set; }

	/// <summary>
	/// readyReplicas is the number of pods created for this StatefulSet with a Ready Condition.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("readyReplicas", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? ReadyReplicas { get; set; }

	/// <summary>
	/// replicas is the number of Pods created by the StatefulSet controller.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("replicas", Required = Newtonsoft.Json.Required.Always)]
	public int Replicas { get; set; }

	/// <summary>
	/// updateRevision, if not empty, indicates the version of the StatefulSet used to generate Pods in the sequence [replicas-updatedReplicas,replicas)
	/// </summary>
	[Newtonsoft.Json.JsonProperty("updateRevision", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string UpdateRevision { get; set; }

	/// <summary>
	/// updatedReplicas is the number of Pods created by the StatefulSet controller from the StatefulSet version indicated by updateRevision.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("updatedReplicas", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? UpdatedReplicas { get; set; }

}