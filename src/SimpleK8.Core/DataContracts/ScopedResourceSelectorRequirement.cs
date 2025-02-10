namespace SimpleK8.Core.DataContracts;

/// <summary>
/// A scoped-resource selector requirement is a selector that contains values, a scope name, and an operator that relates the scope name and values.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class ScopedResourceSelectorRequirement
{
	/// <summary>
	/// Represents a scope's relationship to a set of values. Valid operators are In, NotIn, Exists, DoesNotExist.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("operator", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Operator { get; set; }

	/// <summary>
	/// The name of the scope that the selector applies to.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("scopeName", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string ScopeName { get; set; }

	/// <summary>
	/// An array of string values. If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("values", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<string> Values { get; set; }

}