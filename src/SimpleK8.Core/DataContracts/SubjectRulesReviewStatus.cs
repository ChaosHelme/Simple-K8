namespace SimpleK8.Core.DataContracts;

/// <summary>
/// SubjectRulesReviewStatus contains the result of a rules check. This check can be incomplete depending on the set of authorizers the server is configured with and any errors experienced during evaluation. Because authorization rules are additive, if a rule appears in a list it's safe to assume the subject has that permission, even if that list is incomplete.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class SubjectRulesReviewStatus
{
	/// <summary>
	/// EvaluationError can appear in combination with Rules. It indicates an error occurred during rule evaluation, such as an authorizer that doesn't support rule evaluation, and that ResourceRules and/or NonResourceRules may be incomplete.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("evaluationError", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string EvaluationError { get; set; }

	/// <summary>
	/// Incomplete is true when the rules returned by this call are incomplete. This is most commonly encountered when an authorizer, such as an external authorizer, doesn't support rules evaluation.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("incomplete", Required = Newtonsoft.Json.Required.Always)]
	public bool Incomplete { get; set; }

	/// <summary>
	/// NonResourceRules is the list of actions the subject is allowed to perform on non-resources. The list ordering isn't significant, may contain duplicates, and possibly be incomplete.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("nonResourceRules", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required]
	public System.Collections.Generic.List<NonResourceRule> NonResourceRules { get; set; } = new System.Collections.Generic.List<NonResourceRule>();

	/// <summary>
	/// ResourceRules is the list of actions the subject is allowed to perform on resources. The list ordering isn't significant, may contain duplicates, and possibly be incomplete.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("resourceRules", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required]
	public System.Collections.Generic.List<ResourceRule> ResourceRules { get; set; } = new System.Collections.Generic.List<ResourceRule>();

}