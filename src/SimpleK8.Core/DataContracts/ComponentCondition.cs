namespace SimpleK8.Core.DataContracts;

/// <summary>
/// Information about the condition of a component.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class ComponentCondition
{
	/// <summary>
	/// Condition error code for a component. For example, a health check error code.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("error", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Error { get; set; }

	/// <summary>
	/// Message about the condition for a component. For example, information about a health check.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("message", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Message { get; set; }

	/// <summary>
	/// Status of the condition for a component. Valid values for "Healthy": "True", "False", or "Unknown".
	/// </summary>
	[Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Status { get; set; }

	/// <summary>
	/// Type of condition for a component. Valid value: "Healthy"
	/// </summary>
	[Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Type { get; set; }

}