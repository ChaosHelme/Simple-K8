namespace SimpleK8.Core.DataContracts;

/// <summary>
/// The names of the group, the version, and the resource.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class GroupVersionResource
{
	/// <summary>
	/// The name of the group.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("group", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Group { get; set; }

	/// <summary>
	/// The name of the resource.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("resource", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Resource { get; set; }

	/// <summary>
	/// The name of the version.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("version", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Version { get; set; }

}