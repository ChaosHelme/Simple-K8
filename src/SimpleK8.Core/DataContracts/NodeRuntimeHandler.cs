namespace SimpleK8.Core.DataContracts;

/// <summary>
/// NodeRuntimeHandler is a set of runtime handler information.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class NodeRuntimeHandler
{
	/// <summary>
	/// Supported features.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("features", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public NodeRuntimeHandlerFeatures Features { get; set; }

	/// <summary>
	/// Runtime handler name. Empty for the default runtime handler.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Name { get; set; }

}