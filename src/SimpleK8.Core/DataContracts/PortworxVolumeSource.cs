namespace SimpleK8.Core.DataContracts;

/// <summary>
/// PortworxVolumeSource represents a Portworx volume resource.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class PortworxVolumeSource
{
	/// <summary>
	/// fSType represents the filesystem type to mount Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs". Implicitly inferred to be "ext4" if unspecified.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("fsType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string FsType { get; set; }

	/// <summary>
	/// readOnly defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("readOnly", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public bool? ReadOnly { get; set; }

	/// <summary>
	/// volumeID uniquely identifies a Portworx volume
	/// </summary>
	[Newtonsoft.Json.JsonProperty("volumeID", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string VolumeID { get; set; }

}