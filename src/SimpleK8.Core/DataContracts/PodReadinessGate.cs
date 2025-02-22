namespace SimpleK8.Core.DataContracts;

/// <summary>
/// PodReadinessGate contains the reference to a pod condition
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class PodReadinessGate
{
	/// <summary>
	/// ConditionType refers to a condition in the pod's condition list with matching type.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("conditionType", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string ConditionType { get; set; }

}