namespace SimpleK8.Core.DataContracts;

/// <summary>
/// HPAScalingPolicy is a single policy which must hold true for a specified past interval.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class HPAScalingPolicy
{
	/// <summary>
	/// periodSeconds specifies the window of time for which the policy should hold true. PeriodSeconds must be greater than zero and less than or equal to 1800 (30 min).
	/// </summary>
	[Newtonsoft.Json.JsonProperty("periodSeconds", Required = Newtonsoft.Json.Required.Always)]
	public int PeriodSeconds { get; set; }

	/// <summary>
	/// type is used to specify the scaling policy.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Type { get; set; }

	/// <summary>
	/// value contains the amount of change which is permitted by the policy. It must be greater than zero
	/// </summary>
	[Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.Always)]
	public int Value { get; set; }

}