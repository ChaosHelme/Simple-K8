namespace SimpleK8.Core.DataContracts;

/// <summary>
/// volumeDevice describes a mapping of a raw block device within a container.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class VolumeDevice
{
	/// <summary>
	/// devicePath is the path inside of the container that the device will be mapped to.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("devicePath", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string DevicePath { get; set; }

	/// <summary>
	/// name must match the name of a persistentVolumeClaim in the pod
	/// </summary>
	[Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Name { get; set; }

}