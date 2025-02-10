namespace SimpleK8.Core.DataContracts;

/// <summary>
/// Adds and removes POSIX capabilities from running containers.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class Capabilities
{
	/// <summary>
	/// Added capabilities
	/// </summary>
	[Newtonsoft.Json.JsonProperty("add", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<string> Add { get; set; }

	/// <summary>
	/// Removed capabilities
	/// </summary>
	[Newtonsoft.Json.JsonProperty("drop", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<string> Drop { get; set; }

}