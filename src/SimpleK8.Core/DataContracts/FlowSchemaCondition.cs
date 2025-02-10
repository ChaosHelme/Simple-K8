namespace SimpleK8.Core.DataContracts;

/// <summary>
/// FlowSchemaCondition describes conditions for a FlowSchema.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class FlowSchemaCondition
{
	/// <summary>
	/// `lastTransitionTime` is the last time the condition transitioned from one status to another.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("lastTransitionTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.DateTimeOffset? LastTransitionTime { get; set; }

	/// <summary>
	/// `message` is a human-readable message indicating details about last transition.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("message", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Message { get; set; }

	/// <summary>
	/// `reason` is a unique, one-word, CamelCase reason for the condition's last transition.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("reason", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Reason { get; set; }

	/// <summary>
	/// `status` is the status of the condition. Can be True, False, Unknown. Required.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Status { get; set; }

	/// <summary>
	/// `type` is the type of the condition. Required.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Type { get; set; }

}