namespace SimpleK8.Core.DataContracts;

/// <summary>
/// IngressLoadBalancerIngress represents the status of a load-balancer ingress point.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class IngressLoadBalancerIngress
{
	/// <summary>
	/// hostname is set for load-balancer ingress points that are DNS based.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("hostname", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Hostname { get; set; }

	/// <summary>
	/// ip is set for load-balancer ingress points that are IP based.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("ip", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Ip { get; set; }

	/// <summary>
	/// ports provides information about the ports exposed by this LoadBalancer.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("ports", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<IngressPortStatus> Ports { get; set; }

}