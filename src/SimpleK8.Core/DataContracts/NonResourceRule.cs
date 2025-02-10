namespace SimpleK8.Core.DataContracts;

/// <summary>
/// NonResourceRule holds information that describes a rule for the non-resource
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class NonResourceRule
{
	/// <summary>
	/// NonResourceURLs is a set of partial urls that a user should have access to.  *s are allowed, but only as the full, final step in the path.  "*" means all.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("nonResourceURLs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<string> NonResourceURLs { get; set; }

	/// <summary>
	/// Verb is a list of kubernetes non-resource API verbs, like: get, post, put, delete, patch, head, options.  "*" means all.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("verbs", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required]
	public System.Collections.Generic.List<string> Verbs { get; set; } = new System.Collections.Generic.List<string>();

}