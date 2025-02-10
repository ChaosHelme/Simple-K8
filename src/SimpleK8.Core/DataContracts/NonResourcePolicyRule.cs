namespace SimpleK8.Core.DataContracts;

/// <summary>
/// NonResourcePolicyRule is a predicate that matches non-resource requests according to their verb and the target non-resource URL. A NonResourcePolicyRule matches a request if and only if both (a) at least one member of verbs matches the request and (b) at least one member of nonResourceURLs matches the request.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class NonResourcePolicyRule
{
	/// <summary>
	/// `nonResourceURLs` is a set of url prefixes that a user should have access to and may not be empty. For example:
	/// <br/>  - "/healthz" is legal
	/// <br/>  - "/hea*" is illegal
	/// <br/>  - "/hea" is legal but matches nothing
	/// <br/>  - "/hea/*" also matches nothing
	/// <br/>  - "/healthz/*" matches all per-component health checks.
	/// <br/>"*" matches all non-resource urls. if it is present, it must be the only entry. Required.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("nonResourceURLs", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required]
	public System.Collections.Generic.List<string> NonResourceURLs { get; set; } = new System.Collections.Generic.List<string>();

	/// <summary>
	/// `verbs` is a list of matching verbs and may not be empty. "*" matches all verbs. If it is present, it must be the only entry. Required.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("verbs", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required]
	public System.Collections.Generic.List<string> Verbs { get; set; } = new System.Collections.Generic.List<string>();

}