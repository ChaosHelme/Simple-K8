namespace SimpleK8.Core.DataContracts;

/// <summary>
/// TokenRequestSpec contains client provided parameters of a token request.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class TokenRequestSpec
{
	/// <summary>
	/// Audiences are the intendend audiences of the token. A recipient of a token must identify themself with an identifier in the list of audiences of the token, and otherwise should reject the token. A token issued for multiple audiences may be used to authenticate against any of the audiences listed but implies a high degree of trust between the target audiences.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("audiences", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required]
	public System.Collections.Generic.List<string> Audiences { get; set; } = new System.Collections.Generic.List<string>();

	/// <summary>
	/// BoundObjectRef is a reference to an object that the token will be bound to. The token will only be valid for as long as the bound object exists. NOTE: The API server's TokenReview endpoint will validate the BoundObjectRef, but other audiences may not. Keep ExpirationSeconds small if you want prompt revocation.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("boundObjectRef", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public BoundObjectReference BoundObjectRef { get; set; }

	/// <summary>
	/// ExpirationSeconds is the requested duration of validity of the request. The token issuer may return a token with a different validity duration so a client needs to check the 'expiration' field in a response.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("expirationSeconds", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public long? ExpirationSeconds { get; set; }

}