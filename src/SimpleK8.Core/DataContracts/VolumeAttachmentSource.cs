namespace SimpleK8.Core.DataContracts;

/// <summary>
/// VolumeAttachmentSource represents a volume that should be attached. Right now only PersistentVolumes can be attached via external attacher, in the future we may allow also inline volumes in pods. Exactly one member can be set.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class VolumeAttachmentSource
{
	/// <summary>
	/// inlineVolumeSpec contains all the information necessary to attach a persistent volume defined by a pod's inline VolumeSource. This field is populated only for the CSIMigration feature. It contains translated fields from a pod's inline VolumeSource to a PersistentVolumeSpec. This field is beta-level and is only honored by servers that enabled the CSIMigration feature.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("inlineVolumeSpec", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public PersistentVolumeSpec InlineVolumeSpec { get; set; }

	/// <summary>
	/// persistentVolumeName represents the name of the persistent volume to attach.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("persistentVolumeName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string PersistentVolumeName { get; set; }

}