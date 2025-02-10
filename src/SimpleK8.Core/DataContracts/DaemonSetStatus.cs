namespace SimpleK8.Core.DataContracts;

/// <summary>
/// DaemonSetStatus represents the current status of a daemon set.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class DaemonSetStatus
{
	/// <summary>
	/// Count of hash collisions for the DaemonSet. The DaemonSet controller uses this field as a collision avoidance mechanism when it needs to create the name for the newest ControllerRevision.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("collisionCount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? CollisionCount { get; set; }

	/// <summary>
	/// Represents the latest available observations of a DaemonSet's current state.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("conditions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<DaemonSetCondition> Conditions { get; set; }

	/// <summary>
	/// The number of nodes that are running at least 1 daemon pod and are supposed to run the daemon pod. More info: https://kubernetes.io/docs/concepts/workloads/controllers/daemonset/
	/// </summary>
	[Newtonsoft.Json.JsonProperty("currentNumberScheduled", Required = Newtonsoft.Json.Required.Always)]
	public int CurrentNumberScheduled { get; set; }

	/// <summary>
	/// The total number of nodes that should be running the daemon pod (including nodes correctly running the daemon pod). More info: https://kubernetes.io/docs/concepts/workloads/controllers/daemonset/
	/// </summary>
	[Newtonsoft.Json.JsonProperty("desiredNumberScheduled", Required = Newtonsoft.Json.Required.Always)]
	public int DesiredNumberScheduled { get; set; }

	/// <summary>
	/// The number of nodes that should be running the daemon pod and have one or more of the daemon pod running and available (ready for at least spec.minReadySeconds)
	/// </summary>
	[Newtonsoft.Json.JsonProperty("numberAvailable", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? NumberAvailable { get; set; }

	/// <summary>
	/// The number of nodes that are running the daemon pod, but are not supposed to run the daemon pod. More info: https://kubernetes.io/docs/concepts/workloads/controllers/daemonset/
	/// </summary>
	[Newtonsoft.Json.JsonProperty("numberMisscheduled", Required = Newtonsoft.Json.Required.Always)]
	public int NumberMisscheduled { get; set; }

	/// <summary>
	/// numberReady is the number of nodes that should be running the daemon pod and have one or more of the daemon pod running with a Ready Condition.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("numberReady", Required = Newtonsoft.Json.Required.Always)]
	public int NumberReady { get; set; }

	/// <summary>
	/// The number of nodes that should be running the daemon pod and have none of the daemon pod running and available (ready for at least spec.minReadySeconds)
	/// </summary>
	[Newtonsoft.Json.JsonProperty("numberUnavailable", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? NumberUnavailable { get; set; }

	/// <summary>
	/// The most recent generation observed by the daemon set controller.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("observedGeneration", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public long? ObservedGeneration { get; set; }

	/// <summary>
	/// The total number of nodes that are running updated daemon pod
	/// </summary>
	[Newtonsoft.Json.JsonProperty("updatedNumberScheduled", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? UpdatedNumberScheduled { get; set; }

}