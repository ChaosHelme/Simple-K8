namespace SimpleK8.Core.DataContracts;

/// <summary>
/// PodFailurePolicy describes how failed pods influence the backoffLimit.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class PodFailurePolicy
{
	/// <summary>
	/// A list of pod failure policy rules. The rules are evaluated in order. Once a rule matches a Pod failure, the remaining of the rules are ignored. When no rule matches the Pod failure, the default handling applies - the counter of pod failures is incremented and it is checked against the backoffLimit. At most 20 elements are allowed.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("rules", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required]
	public System.Collections.Generic.List<PodFailurePolicyRule> Rules { get; set; } = new System.Collections.Generic.List<PodFailurePolicyRule>();

}