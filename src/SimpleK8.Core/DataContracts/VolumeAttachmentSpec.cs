namespace SimpleK8.Core.DataContracts;

/// <summary>
/// VolumeAttachmentSpec is the specification of a VolumeAttachment request.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class VolumeAttachmentSpec
{
	/// <summary>
	/// attacher indicates the name of the volume driver that MUST handle this request. This is the name returned by GetPluginName().
	/// </summary>
	[Newtonsoft.Json.JsonProperty("attacher", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Attacher { get; set; }

	/// <summary>
	/// nodeName represents the node that the volume should be attached to.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("nodeName", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string NodeName { get; set; }

	/// <summary>
	/// source represents the volume that should be attached.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("source", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required]
	public VolumeAttachmentSource Source { get; set; } = new VolumeAttachmentSource();

}