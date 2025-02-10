namespace SimpleK8.Core.DataContracts;

/// <summary>
/// IngressLoadBalancerStatus represents the status of a load-balancer.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class IngressLoadBalancerStatus
{
	/// <summary>
	/// ingress is a list containing ingress points for the load-balancer.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("ingress", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<IngressLoadBalancerIngress> Ingress { get; set; }

}