namespace SimpleK8.Core.DataContracts;

/// <summary>
/// A scope selector represents the AND of the selectors represented by the scoped-resource selector requirements.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class ScopeSelector
{
	/// <summary>
	/// A list of scope selector requirements by scope of the resources.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("matchExpressions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<ScopedResourceSelectorRequirement> MatchExpressions { get; set; }

}