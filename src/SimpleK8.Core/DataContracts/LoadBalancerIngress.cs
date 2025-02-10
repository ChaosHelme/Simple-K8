namespace SimpleK8.Core.DataContracts;

/// <summary>
/// LoadBalancerIngress represents the status of a load-balancer ingress point: traffic intended for the service should be sent to an ingress point.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class LoadBalancerIngress
{
	/// <summary>
	/// Hostname is set for load-balancer ingress points that are DNS based (typically AWS load-balancers)
	/// </summary>
	[Newtonsoft.Json.JsonProperty("hostname", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Hostname { get; set; }

	/// <summary>
	/// IP is set for load-balancer ingress points that are IP based (typically GCE or OpenStack load-balancers)
	/// </summary>
	[Newtonsoft.Json.JsonProperty("ip", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Ip { get; set; }

	/// <summary>
	/// IPMode specifies how the load-balancer IP behaves, and may only be specified when the ip field is specified. Setting this to "VIP" indicates that traffic is delivered to the node with the destination set to the load-balancer's IP and port. Setting this to "Proxy" indicates that traffic is delivered to the node or pod with the destination set to the node's IP and node port or the pod's IP and port. Service implementations may use this information to adjust traffic routing.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("ipMode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string IpMode { get; set; }

	/// <summary>
	/// Ports is a list of records of service ports If used, every port defined in the service should have an entry in it
	/// </summary>
	[Newtonsoft.Json.JsonProperty("ports", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<PortStatus> Ports { get; set; }

}