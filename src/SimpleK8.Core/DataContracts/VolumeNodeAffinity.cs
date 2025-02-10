namespace SimpleK8.Core.DataContracts;

/// <summary>
/// VolumeNodeAffinity defines constraints that limit what nodes this volume can be accessed from.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class VolumeNodeAffinity
{
	/// <summary>
	/// required specifies hard node constraints that must be met.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("required", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public NodeSelector Required { get; set; }

}