namespace SimpleK8.Core.DataContracts;

/// <summary>
/// NetworkPolicyPeer describes a peer to allow traffic to/from. Only certain combinations of fields are allowed
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class NetworkPolicyPeer
{
	/// <summary>
	/// ipBlock defines policy on a particular IPBlock. If this field is set then neither of the other fields can be.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("ipBlock", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public IPBlock IpBlock { get; set; }

	/// <summary>
	/// namespaceSelector selects namespaces using cluster-scoped labels. This field follows standard label selector semantics; if present but empty, it selects all namespaces.
	/// <br/>
	/// <br/>If podSelector is also set, then the NetworkPolicyPeer as a whole selects the pods matching podSelector in the namespaces selected by namespaceSelector. Otherwise it selects all pods in the namespaces selected by namespaceSelector.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("namespaceSelector", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public LabelSelector NamespaceSelector { get; set; }

	/// <summary>
	/// podSelector is a label selector which selects pods. This field follows standard label selector semantics; if present but empty, it selects all pods.
	/// <br/>
	/// <br/>If namespaceSelector is also set, then the NetworkPolicyPeer as a whole selects the pods matching podSelector in the Namespaces selected by NamespaceSelector. Otherwise it selects the pods matching podSelector in the policy's own namespace.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("podSelector", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public LabelSelector PodSelector { get; set; }

}