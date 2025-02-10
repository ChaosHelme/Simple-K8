namespace SimpleK8.Core.DataContracts;

/// <summary>
/// Represents a projected volume source
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class ProjectedVolumeSource
{
	/// <summary>
	/// defaultMode are the mode bits used to set permissions on created files by default. Must be an octal value between 0000 and 0777 or a decimal value between 0 and 511. YAML accepts both octal and decimal values, JSON requires decimal values for mode bits. Directories within the path are not affected by this setting. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("defaultMode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? DefaultMode { get; set; }

	/// <summary>
	/// sources is the list of volume projections. Each entry in this list handles one source.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("sources", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<VolumeProjection> Sources { get; set; }

}