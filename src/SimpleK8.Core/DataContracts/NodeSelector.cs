namespace SimpleK8.Core.DataContracts;

/// <summary>
/// A node selector represents the union of the results of one or more label queries over a set of nodes; that is, it represents the OR of the selectors represented by the node selector terms.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class NodeSelector
{
	/// <summary>
	/// Required. A list of node selector terms. The terms are ORed.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("nodeSelectorTerms", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required]
	public System.Collections.Generic.List<NodeSelectorTerm> NodeSelectorTerms { get; set; } = new System.Collections.Generic.List<NodeSelectorTerm>();

}