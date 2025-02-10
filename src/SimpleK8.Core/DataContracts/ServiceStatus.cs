namespace SimpleK8.Core.DataContracts;

/// <summary>
/// ServiceStatus represents the current status of a service.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class ServiceStatus
{
	/// <summary>
	/// Current service state
	/// </summary>
	[Newtonsoft.Json.JsonProperty("conditions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<Condition> Conditions { get; set; }

	/// <summary>
	/// LoadBalancer contains the current status of the load-balancer, if one is present.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("loadBalancer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public LoadBalancerStatus LoadBalancer { get; set; }

}