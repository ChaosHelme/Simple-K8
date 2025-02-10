namespace SimpleK8.Core.DataContracts;

/// <summary>
/// LimitRangeSpec defines a min/max usage limit for resources that match on kind.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class LimitRangeSpec
{
	/// <summary>
	/// Limits is the list of LimitRangeItem objects that are enforced.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("limits", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required]
	public System.Collections.Generic.List<LimitRangeItem> Limits { get; set; } = new System.Collections.Generic.List<LimitRangeItem>();

}