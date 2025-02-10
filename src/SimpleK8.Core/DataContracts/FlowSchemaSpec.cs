namespace SimpleK8.Core.DataContracts;

/// <summary>
/// FlowSchemaSpec describes how the FlowSchema's specification looks like.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class FlowSchemaSpec
{
	/// <summary>
	/// `distinguisherMethod` defines how to compute the flow distinguisher for requests that match this schema. `nil` specifies that the distinguisher is disabled and thus will always be the empty string.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("distinguisherMethod", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public FlowDistinguisherMethod DistinguisherMethod { get; set; }

	/// <summary>
	/// `matchingPrecedence` is used to choose among the FlowSchemas that match a given request. The chosen FlowSchema is among those with the numerically lowest (which we take to be logically highest) MatchingPrecedence.  Each MatchingPrecedence value must be ranged in [1,10000]. Note that if the precedence is not specified, it will be set to 1000 as default.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("matchingPrecedence", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? MatchingPrecedence { get; set; }

	/// <summary>
	/// `priorityLevelConfiguration` should reference a PriorityLevelConfiguration in the cluster. If the reference cannot be resolved, the FlowSchema will be ignored and marked as invalid in its status. Required.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("priorityLevelConfiguration", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required]
	public PriorityLevelConfigurationReference PriorityLevelConfiguration { get; set; } = new PriorityLevelConfigurationReference();

	/// <summary>
	/// `rules` describes which requests will match this flow schema. This FlowSchema matches a request if and only if at least one member of rules matches the request. if it is an empty slice, there will be no requests matching the FlowSchema.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("rules", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<PolicyRulesWithSubjects> Rules { get; set; }

}