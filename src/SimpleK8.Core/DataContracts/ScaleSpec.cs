namespace SimpleK8.Core.DataContracts;

/// <summary>
/// ScaleSpec describes the attributes of a scale subresource.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class ScaleSpec
{
	/// <summary>
	/// replicas is the desired number of instances for the scaled object.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("replicas", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? Replicas { get; set; }

}