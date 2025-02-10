namespace SimpleK8.Core.DataContracts;

/// <summary>
/// SuccessPolicy describes when a Job can be declared as succeeded based on the success of some indexes.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class SuccessPolicy
{
	/// <summary>
	/// rules represents the list of alternative rules for the declaring the Jobs as successful before `.status.succeeded &gt;= .spec.completions`. Once any of the rules are met, the "SucceededCriteriaMet" condition is added, and the lingering pods are removed. The terminal state for such a Job has the "Complete" condition. Additionally, these rules are evaluated in order; Once the Job meets one of the rules, other rules are ignored. At most 20 elements are allowed.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("rules", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required]
	public System.Collections.Generic.List<SuccessPolicyRule> Rules { get; set; } = new System.Collections.Generic.List<SuccessPolicyRule>();

}