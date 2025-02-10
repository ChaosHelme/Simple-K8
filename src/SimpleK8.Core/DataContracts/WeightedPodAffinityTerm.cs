namespace SimpleK8.Core.DataContracts;

/// <summary>
/// The weights of all of the matched WeightedPodAffinityTerm fields are added per-node to find the most preferred node(s)
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class WeightedPodAffinityTerm
{
	/// <summary>
	/// Required. A pod affinity term, associated with the corresponding weight.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("podAffinityTerm", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required]
	public PodAffinityTerm PodAffinityTerm { get; set; } = new PodAffinityTerm();

	/// <summary>
	/// weight associated with matching the corresponding podAffinityTerm, in the range 1-100.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("weight", Required = Newtonsoft.Json.Required.Always)]
	public int Weight { get; set; }

}