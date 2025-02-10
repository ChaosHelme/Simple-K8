namespace SimpleK8.Core.DataContracts;

/// <summary>
/// An empty preferred scheduling term matches all objects with implicit weight 0 (i.e. it's a no-op). A null preferred scheduling term matches no objects (i.e. is also a no-op).
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class PreferredSchedulingTerm
{
	/// <summary>
	/// A node selector term, associated with the corresponding weight.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("preference", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required]
	public NodeSelectorTerm Preference { get; set; } = new NodeSelectorTerm();

	/// <summary>
	/// Weight associated with matching the corresponding nodeSelectorTerm, in the range 1-100.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("weight", Required = Newtonsoft.Json.Required.Always)]
	public int Weight { get; set; }

}