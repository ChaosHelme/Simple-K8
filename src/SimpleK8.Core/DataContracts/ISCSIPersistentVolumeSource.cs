namespace SimpleK8.Core.DataContracts;

/// <summary>
/// ISCSIPersistentVolumeSource represents an ISCSI disk. ISCSI volumes can only be mounted as read/write once. ISCSI volumes support ownership management and SELinux relabeling.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class ISCSIPersistentVolumeSource
{
	/// <summary>
	/// chapAuthDiscovery defines whether support iSCSI Discovery CHAP authentication
	/// </summary>
	[Newtonsoft.Json.JsonProperty("chapAuthDiscovery", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public bool? ChapAuthDiscovery { get; set; }

	/// <summary>
	/// chapAuthSession defines whether support iSCSI Session CHAP authentication
	/// </summary>
	[Newtonsoft.Json.JsonProperty("chapAuthSession", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public bool? ChapAuthSession { get; set; }

	/// <summary>
	/// fsType is the filesystem type of the volume that you want to mount. Tip: Ensure that the filesystem type is supported by the host operating system. Examples: "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified. More info: https://kubernetes.io/docs/concepts/storage/volumes#iscsi
	/// </summary>
	[Newtonsoft.Json.JsonProperty("fsType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string FsType { get; set; }

	/// <summary>
	/// initiatorName is the custom iSCSI Initiator Name. If initiatorName is specified with iscsiInterface simultaneously, new iSCSI interface &lt;target portal&gt;:&lt;volume name&gt; will be created for the connection.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("initiatorName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string InitiatorName { get; set; }

	/// <summary>
	/// iqn is Target iSCSI Qualified Name.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("iqn", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Iqn { get; set; }

	/// <summary>
	/// iscsiInterface is the interface Name that uses an iSCSI transport. Defaults to 'default' (tcp).
	/// </summary>
	[Newtonsoft.Json.JsonProperty("iscsiInterface", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string IscsiInterface { get; set; }

	/// <summary>
	/// lun is iSCSI Target Lun number.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("lun", Required = Newtonsoft.Json.Required.Always)]
	public int Lun { get; set; }

	/// <summary>
	/// portals is the iSCSI Target Portal List. The Portal is either an IP or ip_addr:port if the port is other than default (typically TCP ports 860 and 3260).
	/// </summary>
	[Newtonsoft.Json.JsonProperty("portals", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<string> Portals { get; set; }

	/// <summary>
	/// readOnly here will force the ReadOnly setting in VolumeMounts. Defaults to false.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("readOnly", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public bool? ReadOnly { get; set; }

	/// <summary>
	/// secretRef is the CHAP Secret for iSCSI target and initiator authentication
	/// </summary>
	[Newtonsoft.Json.JsonProperty("secretRef", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public SecretReference SecretRef { get; set; }

	/// <summary>
	/// targetPortal is iSCSI Target Portal. The Portal is either an IP or ip_addr:port if the port is other than default (typically TCP ports 860 and 3260).
	/// </summary>
	[Newtonsoft.Json.JsonProperty("targetPortal", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string TargetPortal { get; set; }

}