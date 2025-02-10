namespace SimpleK8.Core.DataContracts;

/// <summary>
/// Overhead structure represents the resource overhead associated with running a pod.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class Overhead
{
	/// <summary>
	/// podFixed represents the fixed resource overhead associated with running a pod.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("podFixed", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.IDictionary<string, string> PodFixed { get; set; }

}