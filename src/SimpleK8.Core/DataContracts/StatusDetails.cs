namespace SimpleK8.Core.DataContracts;

/// <summary>
/// StatusDetails is a set of additional properties that MAY be set by the server to provide additional information about a response. The Reason field of a Status object defines what attributes will be set. Clients must ignore fields that do not match the defined type of each attribute, and should assume that any attribute may be empty, invalid, or under defined.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class StatusDetails
{
	/// <summary>
	/// The Causes array includes more details associated with the StatusReason failure. Not all StatusReasons may provide detailed causes.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("causes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<StatusCause> Causes { get; set; }

	/// <summary>
	/// The group attribute of the resource associated with the status StatusReason.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("group", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Group { get; set; }

	/// <summary>
	/// The kind attribute of the resource associated with the status StatusReason. On some operations may differ from the requested resource Kind. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
	/// </summary>
	[Newtonsoft.Json.JsonProperty("kind", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Kind { get; set; }

	/// <summary>
	/// The name attribute of the resource associated with the status StatusReason (when there is a single name which can be described).
	/// </summary>
	[Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Name { get; set; }

	/// <summary>
	/// If specified, the time in seconds before the operation should be retried. Some errors may indicate the client must take an alternate action - for those errors this field may indicate how long to wait before taking the alternate action.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("retryAfterSeconds", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? RetryAfterSeconds { get; set; }

	/// <summary>
	/// UID of the resource. (when there is a single resource which can be described). More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names#uids
	/// </summary>
	[Newtonsoft.Json.JsonProperty("uid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Uid { get; set; }

}