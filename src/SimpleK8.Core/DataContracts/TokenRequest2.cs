namespace SimpleK8.Core.DataContracts;

/// <summary>
/// TokenRequest contains parameters of a service account token.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class TokenRequest2
{
	/// <summary>
	/// audience is the intended audience of the token in "TokenRequestSpec". It will default to the audiences of kube apiserver.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("audience", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Audience { get; set; }

	/// <summary>
	/// expirationSeconds is the duration of validity of the token in "TokenRequestSpec". It has the same default value of "ExpirationSeconds" in "TokenRequestSpec".
	/// </summary>
	[Newtonsoft.Json.JsonProperty("expirationSeconds", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public long? ExpirationSeconds { get; set; }

}