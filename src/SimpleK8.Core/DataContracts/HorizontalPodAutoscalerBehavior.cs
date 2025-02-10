namespace SimpleK8.Core.DataContracts;

/// <summary>
/// HorizontalPodAutoscalerBehavior configures the scaling behavior of the target in both Up and Down directions (scaleUp and scaleDown fields respectively).
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class HorizontalPodAutoscalerBehavior
{
	/// <summary>
	/// scaleDown is scaling policy for scaling Down. If not set, the default value is to allow to scale down to minReplicas pods, with a 300 second stabilization window (i.e., the highest recommendation for the last 300sec is used).
	/// </summary>
	[Newtonsoft.Json.JsonProperty("scaleDown", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public HPAScalingRules ScaleDown { get; set; }

	/// <summary>
	/// scaleUp is scaling policy for scaling Up. If not set, the default value is the higher of:
	/// <br/>  * increase no more than 4 pods per 60 seconds
	/// <br/>  * double the number of pods per 60 seconds
	/// <br/>No stabilization is used.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("scaleUp", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public HPAScalingRules ScaleUp { get; set; }

}