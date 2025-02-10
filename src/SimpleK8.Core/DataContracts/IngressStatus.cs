namespace SimpleK8.Core.DataContracts;

/// <summary>
/// IngressStatus describe the current state of the Ingress.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class IngressStatus
{
	/// <summary>
	/// loadBalancer contains the current status of the load-balancer.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("loadBalancer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public IngressLoadBalancerStatus LoadBalancer { get; set; }

}