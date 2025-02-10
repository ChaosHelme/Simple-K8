namespace SimpleK8.Core.DataContracts;

/// <summary>
/// SelfSubjectRulesReviewSpec defines the specification for SelfSubjectRulesReview.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class SelfSubjectRulesReviewSpec
{
	/// <summary>
	/// Namespace to evaluate rules for. Required.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("namespace", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Namespace { get; set; }

}