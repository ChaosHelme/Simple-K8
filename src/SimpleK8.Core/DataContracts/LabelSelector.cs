namespace SimpleK8.Core.DataContracts;

/// <summary>
/// A label selector is a label query over a set of resources. The result of matchLabels and matchExpressions are ANDed. An empty label selector matches all objects. A null label selector matches no objects.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class LabelSelector
{
	/// <summary>
	/// matchExpressions is a list of label selector requirements. The requirements are ANDed.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("matchExpressions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<LabelSelectorRequirement> MatchExpressions { get; set; }

	/// <summary>
	/// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("matchLabels", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.IDictionary<string, string> MatchLabels { get; set; }

}