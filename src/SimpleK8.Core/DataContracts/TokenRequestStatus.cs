namespace SimpleK8.Core.DataContracts;

/// <summary>
/// TokenRequestStatus is the result of a token request.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class TokenRequestStatus
{
	/// <summary>
	/// ExpirationTimestamp is the time of expiration of the returned token.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("expirationTimestamp", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public System.DateTimeOffset ExpirationTimestamp { get; set; }

	/// <summary>
	/// Token is the opaque bearer token.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("token", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Token { get; set; }

}