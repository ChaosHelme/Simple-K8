namespace SimpleK8.Core.DataContracts;

/// <summary>
/// Represents a vSphere volume resource.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class VsphereVirtualDiskVolumeSource
{
	/// <summary>
	/// fsType is filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("fsType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string FsType { get; set; }

	/// <summary>
	/// storagePolicyID is the storage Policy Based Management (SPBM) profile ID associated with the StoragePolicyName.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("storagePolicyID", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string StoragePolicyID { get; set; }

	/// <summary>
	/// storagePolicyName is the storage Policy Based Management (SPBM) profile name.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("storagePolicyName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string StoragePolicyName { get; set; }

	/// <summary>
	/// volumePath is the path that identifies vSphere volume vmdk
	/// </summary>
	[Newtonsoft.Json.JsonProperty("volumePath", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string VolumePath { get; set; }

}