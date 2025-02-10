namespace SimpleK8.Core.DataContracts;

/// <summary>
/// ServiceCIDRStatus describes the current state of the ServiceCIDR.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class ServiceCIDRStatus2
{
	/// <summary>
	/// conditions holds an array of metav1.Condition that describe the state of the ServiceCIDR. Current service state
	/// </summary>
	[Newtonsoft.Json.JsonProperty("conditions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<Condition> Conditions { get; set; }

}