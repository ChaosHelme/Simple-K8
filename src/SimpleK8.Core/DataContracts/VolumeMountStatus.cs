namespace SimpleK8.Core.DataContracts;

/// <summary>
/// VolumeMountStatus shows status of volume mounts.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class VolumeMountStatus
{
	/// <summary>
	/// MountPath corresponds to the original VolumeMount.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("mountPath", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string MountPath { get; set; }

	/// <summary>
	/// Name corresponds to the name of the original VolumeMount.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Name { get; set; }

	/// <summary>
	/// ReadOnly corresponds to the original VolumeMount.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("readOnly", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public bool? ReadOnly { get; set; }

	/// <summary>
	/// RecursiveReadOnly must be set to Disabled, Enabled, or unspecified (for non-readonly mounts). An IfPossible value in the original VolumeMount must be translated to Disabled or Enabled, depending on the mount result.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("recursiveReadOnly", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string RecursiveReadOnly { get; set; }

}