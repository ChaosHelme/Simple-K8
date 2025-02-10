namespace SimpleK8.Core.DataContracts;

/// <summary>
/// DownwardAPIVolumeFile represents information to create the file containing the pod field
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class DownwardAPIVolumeFile
{
	/// <summary>
	/// Required: Selects a field of the pod: only annotations, labels, name, namespace and uid are supported.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("fieldRef", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public ObjectFieldSelector FieldRef { get; set; }

	/// <summary>
	/// Optional: mode bits used to set permissions on this file, must be an octal value between 0000 and 0777 or a decimal value between 0 and 511. YAML accepts both octal and decimal values, JSON requires decimal values for mode bits. If not specified, the volume defaultMode will be used. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("mode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? Mode { get; set; }

	/// <summary>
	/// Required: Path is  the relative path name of the file to be created. Must not be absolute or contain the '..' path. Must be utf-8 encoded. The first item of the relative path must not start with '..'
	/// </summary>
	[Newtonsoft.Json.JsonProperty("path", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Path { get; set; }

	/// <summary>
	/// Selects a resource of the container: only resources limits and requests (limits.cpu, limits.memory, requests.cpu and requests.memory) are currently supported.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("resourceFieldRef", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public ResourceFieldSelector ResourceFieldRef { get; set; }

}