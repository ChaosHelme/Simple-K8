namespace SimpleK8.Core.DataContracts;

/// <summary>
/// SubjectAccessReviewStatus
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class SubjectAccessReviewStatus
{
	/// <summary>
	/// Allowed is required. True if the action would be allowed, false otherwise.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("allowed", Required = Newtonsoft.Json.Required.Always)]
	public bool Allowed { get; set; }

	/// <summary>
	/// Denied is optional. True if the action would be denied, otherwise false. If both allowed is false and denied is false, then the authorizer has no opinion on whether to authorize the action. Denied may not be true if Allowed is true.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("denied", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public bool? Denied { get; set; }

	/// <summary>
	/// EvaluationError is an indication that some error occurred during the authorization check. It is entirely possible to get an error and be able to continue determine authorization status in spite of it. For instance, RBAC can be missing a role, but enough roles are still present and bound to reason about the request.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("evaluationError", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string EvaluationError { get; set; }

	/// <summary>
	/// Reason is optional.  It indicates why a request was allowed or denied.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("reason", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Reason { get; set; }

}