namespace SimpleK8.Core.DataContracts;

/// <summary>
/// Endpoint represents a single logical "backend" implementing a service.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class Endpoint
{
	/// <summary>
	/// addresses of this endpoint. The contents of this field are interpreted according to the corresponding EndpointSlice addressType field. Consumers must handle different types of addresses in the context of their own capabilities. This must contain at least one address but no more than 100. These are all assumed to be fungible and clients may choose to only use the first element. Refer to: https://issue.k8s.io/106267
	/// </summary>
	[Newtonsoft.Json.JsonProperty("addresses", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required]
	public System.Collections.Generic.List<string> Addresses { get; set; } = new System.Collections.Generic.List<string>();

	/// <summary>
	/// conditions contains information about the current status of the endpoint.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("conditions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public EndpointConditions Conditions { get; set; }

	/// <summary>
	/// deprecatedTopology contains topology information part of the v1beta1 API. This field is deprecated, and will be removed when the v1beta1 API is removed (no sooner than kubernetes v1.24).  While this field can hold values, it is not writable through the v1 API, and any attempts to write to it will be silently ignored. Topology information can be found in the zone and nodeName fields instead.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("deprecatedTopology", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.IDictionary<string, string> DeprecatedTopology { get; set; }

	/// <summary>
	/// hints contains information associated with how an endpoint should be consumed.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("hints", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public EndpointHints Hints { get; set; }

	/// <summary>
	/// hostname of this endpoint. This field may be used by consumers of endpoints to distinguish endpoints from each other (e.g. in DNS names). Multiple endpoints which use the same hostname should be considered fungible (e.g. multiple A values in DNS). Must be lowercase and pass DNS Label (RFC 1123) validation.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("hostname", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Hostname { get; set; }

	/// <summary>
	/// nodeName represents the name of the Node hosting this endpoint. This can be used to determine endpoints local to a Node.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("nodeName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string NodeName { get; set; }

	/// <summary>
	/// targetRef is a reference to a Kubernetes object that represents this endpoint.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("targetRef", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public ObjectReference TargetRef { get; set; }

	/// <summary>
	/// zone is the name of the Zone this endpoint exists in.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("zone", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Zone { get; set; }

}