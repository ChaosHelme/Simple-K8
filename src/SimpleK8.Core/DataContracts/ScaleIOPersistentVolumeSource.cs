namespace SimpleK8.Core.DataContracts;

/// <summary>
/// ScaleIOPersistentVolumeSource represents a persistent ScaleIO volume
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class ScaleIOPersistentVolumeSource
{
	/// <summary>
	/// fsType is the filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs", "ntfs". Default is "xfs"
	/// </summary>
	[Newtonsoft.Json.JsonProperty("fsType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string FsType { get; set; }

	/// <summary>
	/// gateway is the host address of the ScaleIO API Gateway.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("gateway", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Gateway { get; set; }

	/// <summary>
	/// protectionDomain is the name of the ScaleIO Protection Domain for the configured storage.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("protectionDomain", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string ProtectionDomain { get; set; }

	/// <summary>
	/// readOnly defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("readOnly", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public bool? ReadOnly { get; set; }

	/// <summary>
	/// secretRef references to the secret for ScaleIO user and other sensitive information. If this is not provided, Login operation will fail.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("secretRef", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required]
	public SecretReference SecretRef { get; set; } = new SecretReference();

	/// <summary>
	/// sslEnabled is the flag to enable/disable SSL communication with Gateway, default false
	/// </summary>
	[Newtonsoft.Json.JsonProperty("sslEnabled", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public bool? SslEnabled { get; set; }

	/// <summary>
	/// storageMode indicates whether the storage for a volume should be ThickProvisioned or ThinProvisioned. Default is ThinProvisioned.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("storageMode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string StorageMode { get; set; }

	/// <summary>
	/// storagePool is the ScaleIO Storage Pool associated with the protection domain.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("storagePool", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string StoragePool { get; set; }

	/// <summary>
	/// system is the name of the storage system as configured in ScaleIO.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("system", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string System { get; set; }

	/// <summary>
	/// volumeName is the name of a volume already created in the ScaleIO system that is associated with this volume source.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("volumeName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string VolumeName { get; set; }

}