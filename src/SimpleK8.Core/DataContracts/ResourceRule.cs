namespace SimpleK8.Core.DataContracts;

/// <summary>
/// ResourceRule is the list of actions the subject is allowed to perform on resources. The list ordering isn't significant, may contain duplicates, and possibly be incomplete.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class ResourceRule
{
	/// <summary>
	/// APIGroups is the name of the APIGroup that contains the resources.  If multiple API groups are specified, any action requested against one of the enumerated resources in any API group will be allowed.  "*" means all.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("apiGroups", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<string> ApiGroups { get; set; }

	/// <summary>
	/// ResourceNames is an optional white list of names that the rule applies to.  An empty set means that everything is allowed.  "*" means all.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("resourceNames", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<string> ResourceNames { get; set; }

	/// <summary>
	/// Resources is a list of resources this rule applies to.  "*" means all in the specified apiGroups.
	/// <br/> "*/foo" represents the subresource 'foo' for all resources in the specified apiGroups.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("resources", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<string> Resources { get; set; }

	/// <summary>
	/// Verb is a list of kubernetes resource API verbs, like: get, list, watch, create, update, delete, proxy.  "*" means all.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("verbs", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required]
	public System.Collections.Generic.List<string> Verbs { get; set; } = new System.Collections.Generic.List<string>();

}