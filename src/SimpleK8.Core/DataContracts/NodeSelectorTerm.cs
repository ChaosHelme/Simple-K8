namespace SimpleK8.Core.DataContracts;

/// <summary>
/// A null or empty node selector term matches no objects. The requirements of them are ANDed. The TopologySelectorTerm type implements a subset of the NodeSelectorTerm.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class NodeSelectorTerm
{
	/// <summary>
	/// A list of node selector requirements by node's labels.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("matchExpressions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<NodeSelectorRequirement> MatchExpressions { get; set; }

	/// <summary>
	/// A list of node selector requirements by node's fields.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("matchFields", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<NodeSelectorRequirement> MatchFields { get; set; }

}