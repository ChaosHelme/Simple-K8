namespace SimpleK8.Core.DataContracts;

/// <summary>
/// SelfSubjectAccessReviewSpec is a description of the access request.  Exactly one of ResourceAuthorizationAttributes and NonResourceAuthorizationAttributes must be set
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class SelfSubjectAccessReviewSpec
{
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

}