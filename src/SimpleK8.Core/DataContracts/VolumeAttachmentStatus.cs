namespace SimpleK8.Core.DataContracts;

/// <summary>
/// VolumeAttachmentStatus is the status of a VolumeAttachment request.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class VolumeAttachmentStatus
{
	/// <summary>
	/// attachError represents the last error encountered during attach operation, if any. This field must only be set by the entity completing the attach operation, i.e. the external-attacher.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("attachError", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public VolumeError AttachError { get; set; }

	/// <summary>
	/// attached indicates the volume is successfully attached. This field must only be set by the entity completing the attach operation, i.e. the external-attacher.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("attached", Required = Newtonsoft.Json.Required.Always)]
	public bool Attached { get; set; }

	/// <summary>
	/// attachmentMetadata is populated with any information returned by the attach operation, upon successful attach, that must be passed into subsequent WaitForAttach or Mount calls. This field must only be set by the entity completing the attach operation, i.e. the external-attacher.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("attachmentMetadata", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.IDictionary<string, string> AttachmentMetadata { get; set; }

	/// <summary>
	/// detachError represents the last error encountered during detach operation, if any. This field must only be set by the entity completing the detach operation, i.e. the external-attacher.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("detachError", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public VolumeError DetachError { get; set; }

}