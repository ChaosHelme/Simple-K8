namespace SimpleK8.Core.DataContracts;

/// <summary>
/// NodeStatus is information about the current status of a node.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class NodeStatus
{
	/// <summary>
	/// List of addresses reachable to the node. Queried from cloud provider, if available. More info: https://kubernetes.io/docs/reference/node/node-status/#addresses Note: This field is declared as mergeable, but the merge key is not sufficiently unique, which can cause data corruption when it is merged. Callers should instead use a full-replacement patch. See https://pr.k8s.io/79391 for an example. Consumers should assume that addresses can change during the lifetime of a Node. However, there are some exceptions where this may not be possible, such as Pods that inherit a Node's address in its own status or consumers of the downward API (status.hostIP).
	/// </summary>
	[Newtonsoft.Json.JsonProperty("addresses", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<NodeAddress> Addresses { get; set; }

	/// <summary>
	/// Allocatable represents the resources of a node that are available for scheduling. Defaults to Capacity.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("allocatable", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.IDictionary<string, string> Allocatable { get; set; }

	/// <summary>
	/// Capacity represents the total resources of a node. More info: https://kubernetes.io/docs/reference/node/node-status/#capacity
	/// </summary>
	[Newtonsoft.Json.JsonProperty("capacity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.IDictionary<string, string> Capacity { get; set; }

	/// <summary>
	/// Conditions is an array of current observed node conditions. More info: https://kubernetes.io/docs/reference/node/node-status/#condition
	/// </summary>
	[Newtonsoft.Json.JsonProperty("conditions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<NodeCondition> Conditions { get; set; }

	/// <summary>
	/// Status of the config assigned to the node via the dynamic Kubelet config feature.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("config", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public NodeConfigStatus Config { get; set; }

	/// <summary>
	/// Endpoints of daemons running on the Node.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("daemonEndpoints", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public NodeDaemonEndpoints DaemonEndpoints { get; set; }

	/// <summary>
	/// Features describes the set of features implemented by the CRI implementation.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("features", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public NodeFeatures Features { get; set; }

	/// <summary>
	/// List of container images on this node
	/// </summary>
	[Newtonsoft.Json.JsonProperty("images", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<ContainerImage> Images { get; set; }

	/// <summary>
	/// Set of ids/uuids to uniquely identify the node. More info: https://kubernetes.io/docs/reference/node/node-status/#info
	/// </summary>
	[Newtonsoft.Json.JsonProperty("nodeInfo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public NodeSystemInfo NodeInfo { get; set; }

	/// <summary>
	/// NodePhase is the recently observed lifecycle phase of the node. More info: https://kubernetes.io/docs/concepts/nodes/node/#phase The field is never populated, and now is deprecated.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("phase", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Phase { get; set; }

	/// <summary>
	/// The available runtime handlers.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("runtimeHandlers", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<NodeRuntimeHandler> RuntimeHandlers { get; set; }

	/// <summary>
	/// List of volumes that are attached to the node.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("volumesAttached", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<AttachedVolume> VolumesAttached { get; set; }

	/// <summary>
	/// List of attachable volumes in use (mounted) by the node.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("volumesInUse", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<string> VolumesInUse { get; set; }

}