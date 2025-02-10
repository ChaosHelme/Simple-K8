namespace SimpleK8.Core.DataContracts;

/// <summary>
/// API server instances report the versions they can decode and the version they encode objects to when persisting objects in the backend.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class StorageVersionStatus
{
	/// <summary>
	/// If all API server instances agree on the same encoding storage version, then this field is set to that version. Otherwise this field is left empty. API servers should finish updating its storageVersionStatus entry before serving write operations, so that this field will be in sync with the reality.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("commonEncodingVersion", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string CommonEncodingVersion { get; set; }

	/// <summary>
	/// The latest available observations of the storageVersion's state.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("conditions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<StorageVersionCondition> Conditions { get; set; }

	/// <summary>
	/// The reported versions per API server instance.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("storageVersions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<ServerStorageVersion> StorageVersions { get; set; }

}