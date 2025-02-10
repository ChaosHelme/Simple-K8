namespace SimpleK8.Core.DataContracts;

/// <summary>
/// TokenReviewStatus is the result of the token authentication request.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class TokenReviewStatus
{
	/// <summary>
	/// Audiences are audience identifiers chosen by the authenticator that are compatible with both the TokenReview and token. An identifier is any identifier in the intersection of the TokenReviewSpec audiences and the token's audiences. A client of the TokenReview API that sets the spec.audiences field should validate that a compatible audience identifier is returned in the status.audiences field to ensure that the TokenReview server is audience aware. If a TokenReview returns an empty status.audience field where status.authenticated is "true", the token is valid against the audience of the Kubernetes API server.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("audiences", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<string> Audiences { get; set; }

	/// <summary>
	/// Authenticated indicates that the token was associated with a known user.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("authenticated", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public bool? Authenticated { get; set; }

	/// <summary>
	/// Error indicates that the token couldn't be checked
	/// </summary>
	[Newtonsoft.Json.JsonProperty("error", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Error { get; set; }

	/// <summary>
	/// User is the UserInfo associated with the provided token.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("user", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public UserInfo User { get; set; }

}