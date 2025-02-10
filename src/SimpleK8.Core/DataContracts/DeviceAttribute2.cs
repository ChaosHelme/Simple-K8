namespace SimpleK8.Core.DataContracts;

/// <summary>
/// DeviceAttribute must have exactly one field set.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class DeviceAttribute2
{
	/// <summary>
	/// BoolValue is a true/false value.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("bool", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public bool? Bool { get; set; }

	/// <summary>
	/// IntValue is a number.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("int", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public long? Int { get; set; }

	/// <summary>
	/// StringValue is a string. Must not be longer than 64 characters.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("string", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string String { get; set; }

	/// <summary>
	/// VersionValue is a semantic version according to semver.org spec 2.0.0. Must not be longer than 64 characters.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("version", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Version { get; set; }

}