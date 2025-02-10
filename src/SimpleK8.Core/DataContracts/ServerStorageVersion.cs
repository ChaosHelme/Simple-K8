namespace SimpleK8.Core.DataContracts;

/// <summary>
/// An API server instance reports the version it can decode and the version it encodes objects to when persisting objects in the backend.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class ServerStorageVersion
{
	/// <summary>
	/// The ID of the reporting API server.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("apiServerID", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string ApiServerID { get; set; }

	/// <summary>
	/// The API server can decode objects encoded in these versions. The encodingVersion must be included in the decodableVersions.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("decodableVersions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<string> DecodableVersions { get; set; }

	/// <summary>
	/// The API server encodes the object to this version when persisting it in the backend (e.g., etcd).
	/// </summary>
	[Newtonsoft.Json.JsonProperty("encodingVersion", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string EncodingVersion { get; set; }

	/// <summary>
	/// The API server can serve these versions. DecodableVersions must include all ServedVersions.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("servedVersions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<string> ServedVersions { get; set; }

}