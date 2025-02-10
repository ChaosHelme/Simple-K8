namespace SimpleK8.Core.DataContracts;

/// <summary>
/// Represents storage that is managed by an external CSI volume driver
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class CSIPersistentVolumeSource
{
	/// <summary>
	/// controllerExpandSecretRef is a reference to the secret object containing sensitive information to pass to the CSI driver to complete the CSI ControllerExpandVolume call. This field is optional, and may be empty if no secret is required. If the secret object contains more than one secret, all secrets are passed.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("controllerExpandSecretRef", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public SecretReference ControllerExpandSecretRef { get; set; }

	/// <summary>
	/// controllerPublishSecretRef is a reference to the secret object containing sensitive information to pass to the CSI driver to complete the CSI ControllerPublishVolume and ControllerUnpublishVolume calls. This field is optional, and may be empty if no secret is required. If the secret object contains more than one secret, all secrets are passed.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("controllerPublishSecretRef", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public SecretReference ControllerPublishSecretRef { get; set; }

	/// <summary>
	/// driver is the name of the driver to use for this volume. Required.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("driver", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Driver { get; set; }

	/// <summary>
	/// fsType to mount. Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs", "ntfs".
	/// </summary>
	[Newtonsoft.Json.JsonProperty("fsType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string FsType { get; set; }

	/// <summary>
	/// nodeExpandSecretRef is a reference to the secret object containing sensitive information to pass to the CSI driver to complete the CSI NodeExpandVolume call. This field is optional, may be omitted if no secret is required. If the secret object contains more than one secret, all secrets are passed.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("nodeExpandSecretRef", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public SecretReference NodeExpandSecretRef { get; set; }

	/// <summary>
	/// nodePublishSecretRef is a reference to the secret object containing sensitive information to pass to the CSI driver to complete the CSI NodePublishVolume and NodeUnpublishVolume calls. This field is optional, and may be empty if no secret is required. If the secret object contains more than one secret, all secrets are passed.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("nodePublishSecretRef", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public SecretReference NodePublishSecretRef { get; set; }

	/// <summary>
	/// nodeStageSecretRef is a reference to the secret object containing sensitive information to pass to the CSI driver to complete the CSI NodeStageVolume and NodeStageVolume and NodeUnstageVolume calls. This field is optional, and may be empty if no secret is required. If the secret object contains more than one secret, all secrets are passed.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("nodeStageSecretRef", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public SecretReference NodeStageSecretRef { get; set; }

	/// <summary>
	/// readOnly value to pass to ControllerPublishVolumeRequest. Defaults to false (read/write).
	/// </summary>
	[Newtonsoft.Json.JsonProperty("readOnly", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public bool? ReadOnly { get; set; }

	/// <summary>
	/// volumeAttributes of the volume to publish.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("volumeAttributes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.IDictionary<string, string> VolumeAttributes { get; set; }

	/// <summary>
	/// volumeHandle is the unique volume name returned by the CSI volume plugin’s CreateVolume to refer to the volume on all subsequent calls. Required.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("volumeHandle", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string VolumeHandle { get; set; }

}