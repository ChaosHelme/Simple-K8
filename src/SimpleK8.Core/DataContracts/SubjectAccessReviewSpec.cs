namespace SimpleK8.Core.DataContracts;

/// <summary>
/// SubjectAccessReviewSpec is a description of the access request.  Exactly one of ResourceAuthorizationAttributes and NonResourceAuthorizationAttributes must be set
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class SubjectAccessReviewSpec
{
	/// <summary>
	/// Extra corresponds to the user.Info.GetExtra() method from the authenticator.  Since that is input to the authorizer it needs a reflection here.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("extra", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.IDictionary<string, System.Collections.Generic.List<string>> Extra { get; set; }

	/// <summary>
	/// Groups is the groups you're testing for.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("groups", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<string> Groups { get; set; }

	/// <summary>
	/// NonResourceAttributes describes information for a non-resource access request
	/// </summary>
	[Newtonsoft.Json.JsonProperty("nonResourceAttributes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public NonResourceAttributes NonResourceAttributes { get; set; }

	/// <summary>
	/// ResourceAuthorizationAttributes describes information for a resource access request
	/// </summary>
	[Newtonsoft.Json.JsonProperty("resourceAttributes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public ResourceAttributes ResourceAttributes { get; set; }

	/// <summary>
	/// UID information about the requesting user.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("uid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Uid { get; set; }

	/// <summary>
	/// User is the user you're testing for. If you specify "User" but not "Groups", then is it interpreted as "What if User were not a member of any groups
	/// </summary>
	[Newtonsoft.Json.JsonProperty("user", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string User { get; set; }

}