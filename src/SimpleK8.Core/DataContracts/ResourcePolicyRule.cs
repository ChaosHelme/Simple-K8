namespace SimpleK8.Core.DataContracts;

/// <summary>
/// ResourcePolicyRule is a predicate that matches some resource requests, testing the request's verb and the target resource. A ResourcePolicyRule matches a resource request if and only if: (a) at least one member of verbs matches the request, (b) at least one member of apiGroups matches the request, (c) at least one member of resources matches the request, and (d) either (d1) the request does not specify a namespace (i.e., `Namespace==""`) and clusterScope is true or (d2) the request specifies a namespace and least one member of namespaces matches the request's namespace.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class ResourcePolicyRule
{
	/// <summary>
	/// `apiGroups` is a list of matching API groups and may not be empty. "*" matches all API groups and, if present, must be the only entry. Required.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("apiGroups", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required]
	public System.Collections.Generic.List<string> ApiGroups { get; set; } = new System.Collections.Generic.List<string>();

	/// <summary>
	/// `clusterScope` indicates whether to match requests that do not specify a namespace (which happens either because the resource is not namespaced or the request targets all namespaces). If this field is omitted or false then the `namespaces` field must contain a non-empty list.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("clusterScope", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public bool? ClusterScope { get; set; }

	/// <summary>
	/// `namespaces` is a list of target namespaces that restricts matches.  A request that specifies a target namespace matches only if either (a) this list contains that target namespace or (b) this list contains "*".  Note that "*" matches any specified namespace but does not match a request that _does not specify_ a namespace (see the `clusterScope` field for that). This list may be empty, but only if `clusterScope` is true.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("namespaces", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<string> Namespaces { get; set; }

	/// <summary>
	/// `resources` is a list of matching resources (i.e., lowercase and plural) with, if desired, subresource.  For example, [ "services", "nodes/status" ].  This list may not be empty. "*" matches all resources and, if present, must be the only entry. Required.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("resources", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required]
	public System.Collections.Generic.List<string> Resources { get; set; } = new System.Collections.Generic.List<string>();

	/// <summary>
	/// `verbs` is a list of matching verbs and may not be empty. "*" matches all verbs and, if present, must be the only entry. Required.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("verbs", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required]
	public System.Collections.Generic.List<string> Verbs { get; set; } = new System.Collections.Generic.List<string>();

}