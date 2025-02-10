namespace SimpleK8.Core.DataContracts;

/// <summary>
/// ValidatingAdmissionPolicyStatus represents the status of an admission validation policy.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class ValidatingAdmissionPolicyStatus
{
	/// <summary>
	/// The conditions represent the latest available observations of a policy's current state.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("conditions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<Condition> Conditions { get; set; }

	/// <summary>
	/// The generation observed by the controller.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("observedGeneration", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public long? ObservedGeneration { get; set; }

	/// <summary>
	/// The results of type checking for each expression. Presence of this field indicates the completion of the type checking.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("typeChecking", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public TypeChecking TypeChecking { get; set; }

}