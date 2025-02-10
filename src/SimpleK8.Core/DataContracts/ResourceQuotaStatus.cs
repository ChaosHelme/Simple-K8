namespace SimpleK8.Core.DataContracts;

/// <summary>
/// ResourceQuotaStatus defines the enforced hard limits and observed use.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class ResourceQuotaStatus
{
	/// <summary>
	/// Hard is the set of enforced hard limits for each named resource. More info: https://kubernetes.io/docs/concepts/policy/resource-quotas/
	/// </summary>
	[Newtonsoft.Json.JsonProperty("hard", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.IDictionary<string, string> Hard { get; set; }

	/// <summary>
	/// Used is the current observed total usage of the resource in the namespace.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("used", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.IDictionary<string, string> Used { get; set; }

}