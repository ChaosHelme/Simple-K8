namespace SimpleK8.Core.DataContracts;

/// <summary>
/// FlowSchemaStatus represents the current state of a FlowSchema.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class FlowSchemaStatus
{
	/// <summary>
	/// `conditions` is a list of the current states of FlowSchema.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("conditions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<FlowSchemaCondition> Conditions { get; set; }

}