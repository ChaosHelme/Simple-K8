namespace SimpleK8.Core.DataContracts;

/// <summary>
/// ResourceQuotaSpec defines the desired hard limits to enforce for Quota.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class ResourceQuotaSpec
{
	/// <summary>
	/// hard is the set of desired hard limits for each named resource. More info: https://kubernetes.io/docs/concepts/policy/resource-quotas/
	/// </summary>
	[Newtonsoft.Json.JsonProperty("hard", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.IDictionary<string, string> Hard { get; set; }

	/// <summary>
	/// scopeSelector is also a collection of filters like scopes that must match each object tracked by a quota but expressed using ScopeSelectorOperator in combination with possible values. For a resource to match, both scopes AND scopeSelector (if specified in spec), must be matched.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("scopeSelector", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public ScopeSelector ScopeSelector { get; set; }

	/// <summary>
	/// A collection of filters that must match each object tracked by a quota. If not specified, the quota matches all objects.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("scopes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<string> Scopes { get; set; }

}