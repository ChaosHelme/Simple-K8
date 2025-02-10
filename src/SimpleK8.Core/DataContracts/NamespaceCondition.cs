namespace SimpleK8.Core.DataContracts;

/// <summary>
/// NamespaceCondition contains details about state of namespace.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class NamespaceCondition
{
	/// <summary>
	/// Last time the condition transitioned from one status to another.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("lastTransitionTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.DateTimeOffset? LastTransitionTime { get; set; }

	/// <summary>
	/// Human-readable message indicating details about last transition.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("message", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Message { get; set; }

	/// <summary>
	/// Unique, one-word, CamelCase reason for the condition's last transition.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("reason", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Reason { get; set; }

	/// <summary>
	/// Status of the condition, one of True, False, Unknown.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Status { get; set; }

	/// <summary>
	/// Type of namespace controller condition.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Type { get; set; }

}