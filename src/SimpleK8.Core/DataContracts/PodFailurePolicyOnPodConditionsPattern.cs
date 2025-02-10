namespace SimpleK8.Core.DataContracts;

/// <summary>
/// PodFailurePolicyOnPodConditionsPattern describes a pattern for matching an actual pod condition type.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class PodFailurePolicyOnPodConditionsPattern
{
	/// <summary>
	/// Specifies the required Pod condition status. To match a pod condition it is required that the specified status equals the pod condition status. Defaults to True.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Status { get; set; }

	/// <summary>
	/// Specifies the required Pod condition type. To match a pod condition it is required that specified type equals the pod condition type.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Type { get; set; }

}