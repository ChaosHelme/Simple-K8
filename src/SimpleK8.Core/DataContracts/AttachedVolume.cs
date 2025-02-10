namespace SimpleK8.Core.DataContracts;

/// <summary>
/// AttachedVolume describes a volume attached to a node
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class AttachedVolume
{
	/// <summary>
	/// DevicePath represents the device path where the volume should be available
	/// </summary>
	[Newtonsoft.Json.JsonProperty("devicePath", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string DevicePath { get; set; }

	/// <summary>
	/// Name of the attached volume
	/// </summary>
	[Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Name { get; set; }

}