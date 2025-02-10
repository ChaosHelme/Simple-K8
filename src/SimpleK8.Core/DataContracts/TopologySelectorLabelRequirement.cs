namespace SimpleK8.Core.DataContracts;

/// <summary>
/// A topology selector requirement is a selector that matches given label. This is an alpha feature and may change in the future.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class TopologySelectorLabelRequirement
{
	/// <summary>
	/// The label key that the selector applies to.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("key", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Key { get; set; }

	/// <summary>
	/// An array of string values. One value must match the label to be selected. Each entry in Values is ORed.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("values", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required]
	public System.Collections.Generic.List<string> Values { get; set; } = new System.Collections.Generic.List<string>();

}