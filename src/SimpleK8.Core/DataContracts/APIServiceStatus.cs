namespace SimpleK8.Core.DataContracts;

/// <summary>
/// APIServiceStatus contains derived information about an API server
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class APIServiceStatus
{
	/// <summary>
	/// Current service state of apiService.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("conditions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<APIServiceCondition> Conditions { get; set; }

}