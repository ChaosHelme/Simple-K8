namespace SimpleK8.Core.DataContracts;

/// <summary>
/// SelfSubjectReviewStatus is filled by the kube-apiserver and sent back to a user.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class SelfSubjectReviewStatus2
{
	/// <summary>
	/// User attributes of the user making this request.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("userInfo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public UserInfo UserInfo { get; set; }

}