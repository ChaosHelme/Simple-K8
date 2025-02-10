namespace SimpleK8.Core.DataContracts;

/// <summary>
/// TokenReviewSpec is a description of the token authentication request.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class TokenReviewSpec
{
	/// <summary>
	/// Audiences is a list of the identifiers that the resource server presented with the token identifies as. Audience-aware token authenticators will verify that the token was intended for at least one of the audiences in this list. If no audiences are provided, the audience will default to the audience of the Kubernetes apiserver.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("audiences", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<string> Audiences { get; set; }

	/// <summary>
	/// Token is the opaque bearer token.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("token", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Token { get; set; }

}