namespace SimpleK8.Core.DataContracts;

/// <summary>
/// PriorityLevelConfigurationStatus represents the current state of a "request-priority".
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class PriorityLevelConfigurationStatus
{
	/// <summary>
	/// `conditions` is the current state of "request-priority".
	/// </summary>
	[Newtonsoft.Json.JsonProperty("conditions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<PriorityLevelConfigurationCondition> Conditions { get; set; }

}