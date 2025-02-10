namespace SimpleK8.Core.DataContracts;

/// <summary>
/// Represents downward API info for projecting into a projected volume. Note that this is identical to a downwardAPI volume source without the default mode.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class DownwardAPIProjection
{
	/// <summary>
	/// Items is a list of DownwardAPIVolume file
	/// </summary>
	[Newtonsoft.Json.JsonProperty("items", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<DownwardAPIVolumeFile> Items { get; set; }

}