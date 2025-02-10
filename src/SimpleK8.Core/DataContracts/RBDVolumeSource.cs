namespace SimpleK8.Core.DataContracts;

/// <summary>
/// Represents a Rados Block Device mount that lasts the lifetime of a pod. RBD volumes support ownership management and SELinux relabeling.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class RBDVolumeSource
{
	/// <summary>
	/// fsType is the filesystem type of the volume that you want to mount. Tip: Ensure that the filesystem type is supported by the host operating system. Examples: "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified. More info: https://kubernetes.io/docs/concepts/storage/volumes#rbd
	/// </summary>
	[Newtonsoft.Json.JsonProperty("fsType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string FsType { get; set; }

	/// <summary>
	/// image is the rados image name. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it
	/// </summary>
	[Newtonsoft.Json.JsonProperty("image", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Image { get; set; }

	/// <summary>
	/// keyring is the path to key ring for RBDUser. Default is /etc/ceph/keyring. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it
	/// </summary>
	[Newtonsoft.Json.JsonProperty("keyring", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Keyring { get; set; }

	/// <summary>
	/// monitors is a collection of Ceph monitors. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it
	/// </summary>
	[Newtonsoft.Json.JsonProperty("monitors", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required]
	public System.Collections.Generic.List<string> Monitors { get; set; } = new System.Collections.Generic.List<string>();

	/// <summary>
	/// pool is the rados pool name. Default is rbd. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it
	/// </summary>
	[Newtonsoft.Json.JsonProperty("pool", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Pool { get; set; }

	/// <summary>
	/// readOnly here will force the ReadOnly setting in VolumeMounts. Defaults to false. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it
	/// </summary>
	[Newtonsoft.Json.JsonProperty("readOnly", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public bool? ReadOnly { get; set; }

	/// <summary>
	/// secretRef is name of the authentication secret for RBDUser. If provided overrides keyring. Default is nil. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it
	/// </summary>
	[Newtonsoft.Json.JsonProperty("secretRef", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public LocalObjectReference SecretRef { get; set; }

	/// <summary>
	/// user is the rados user name. Default is admin. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it
	/// </summary>
	[Newtonsoft.Json.JsonProperty("user", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string User { get; set; }

}