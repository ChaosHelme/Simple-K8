namespace SimpleK8.Core.DataContracts;

/// <summary>
/// A topology selector term represents the result of label queries. A null or empty topology selector term matches no objects. The requirements of them are ANDed. It provides a subset of functionality as NodeSelectorTerm. This is an alpha feature and may change in the future.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class TopologySelectorTerm
{
	/// <summary>
	/// A list of topology selector requirements by labels.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("matchLabelExpressions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<TopologySelectorLabelRequirement> MatchLabelExpressions { get; set; }

}