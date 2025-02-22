namespace SimpleK8.Core.DataContracts;

/// <summary>
/// NodeSpec describes the attributes that a node is created with.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class NodeSpec
{
	/// <summary>
	/// Deprecated: Previously used to specify the source of the node's configuration for the DynamicKubeletConfig feature. This feature is removed.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("configSource", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public NodeConfigSource ConfigSource { get; set; }

	/// <summary>
	/// Deprecated. Not all kubelets will set this field. Remove field after 1.13. see: https://issues.k8s.io/61966
	/// </summary>
	[Newtonsoft.Json.JsonProperty("externalID", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string ExternalID { get; set; }

	/// <summary>
	/// PodCIDR represents the pod IP range assigned to the node.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("podCIDR", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string PodCIDR { get; set; }

	/// <summary>
	/// podCIDRs represents the IP ranges assigned to the node for usage by Pods on that node. If this field is specified, the 0th entry must match the podCIDR field. It may contain at most 1 value for each of IPv4 and IPv6.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("podCIDRs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<string> PodCIDRs { get; set; }

	/// <summary>
	/// ID of the node assigned by the cloud provider in the format: &lt;ProviderName&gt;://&lt;ProviderSpecificNodeID&gt;
	/// </summary>
	[Newtonsoft.Json.JsonProperty("providerID", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string ProviderID { get; set; }

	/// <summary>
	/// If specified, the node's taints.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("taints", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<Taint> Taints { get; set; }

	/// <summary>
	/// Unschedulable controls node schedulability of new pods. By default, node is schedulable. More info: https://kubernetes.io/docs/concepts/nodes/node/#manual-node-administration
	/// </summary>
	[Newtonsoft.Json.JsonProperty("unschedulable", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public bool? Unschedulable { get; set; }

}