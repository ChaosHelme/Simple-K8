namespace SimpleK8.Core.DataContracts;

/// <summary>
/// Represents a StorageOS persistent volume resource.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class StorageOSVolumeSource
{
	/// <summary>
	/// fsType is the filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("fsType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string FsType { get; set; }

	/// <summary>
	/// readOnly defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("readOnly", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public bool? ReadOnly { get; set; }

	/// <summary>
	/// secretRef specifies the secret to use for obtaining the StorageOS API credentials.  If not specified, default values will be attempted.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("secretRef", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public LocalObjectReference SecretRef { get; set; }

	/// <summary>
	/// volumeName is the human-readable name of the StorageOS volume.  Volume names are only unique within a namespace.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("volumeName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string VolumeName { get; set; }

	/// <summary>
	/// volumeNamespace specifies the scope of the volume within StorageOS.  If no namespace is specified then the Pod's namespace will be used.  This allows the Kubernetes name scoping to be mirrored within StorageOS for tighter integration. Set VolumeName to any name to override the default behaviour. Set to "default" if you are not using namespaces within StorageOS. Namespaces that do not pre-exist within StorageOS will be created.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("volumeNamespace", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string VolumeNamespace { get; set; }

}