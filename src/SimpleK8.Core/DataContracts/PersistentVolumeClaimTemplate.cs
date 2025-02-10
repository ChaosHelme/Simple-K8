namespace SimpleK8.Core.DataContracts;

/// <summary>
/// PersistentVolumeClaimTemplate is used to produce PersistentVolumeClaim objects as part of an EphemeralVolumeSource.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class PersistentVolumeClaimTemplate
{
	/// <summary>
	/// May contain labels and annotations that will be copied into the PVC when creating it. No other fields are allowed and will be rejected during validation.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("metadata", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public ObjectMeta Metadata { get; set; }

	/// <summary>
	/// The specification for the PersistentVolumeClaim. The entire content is copied unchanged into the PVC that gets created from this template. The same fields as in a PersistentVolumeClaim are also valid here.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("spec", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required]
	public PersistentVolumeClaimSpec Spec { get; set; } = new PersistentVolumeClaimSpec();

}