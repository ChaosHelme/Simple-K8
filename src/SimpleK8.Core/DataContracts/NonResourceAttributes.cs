namespace SimpleK8.Core.DataContracts;

/// <summary>
/// NonResourceAttributes includes the authorization attributes available for non-resource requests to the Authorizer interface
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class NonResourceAttributes
{
	/// <summary>
	/// Path is the URL path of the request
	/// </summary>
	[Newtonsoft.Json.JsonProperty("path", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Path { get; set; }

	/// <summary>
	/// Verb is the standard HTTP verb
	/// </summary>
	[Newtonsoft.Json.JsonProperty("verb", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Verb { get; set; }

}