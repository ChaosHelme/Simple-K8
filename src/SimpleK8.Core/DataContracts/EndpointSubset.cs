namespace SimpleK8.Core.DataContracts;

/// <summary>
/// EndpointSubset is a group of addresses with a common set of ports. The expanded set of endpoints is the Cartesian product of Addresses x Ports. For example, given:
/// <br/>
/// <br/>	{
/// <br/>	  Addresses: [{"ip": "10.10.1.1"}, {"ip": "10.10.2.2"}],
/// <br/>	  Ports:     [{"name": "a", "port": 8675}, {"name": "b", "port": 309}]
/// <br/>	}
/// <br/>
/// <br/>The resulting set of endpoints can be viewed as:
/// <br/>
/// <br/>	a: [ 10.10.1.1:8675, 10.10.2.2:8675 ],
/// <br/>	b: [ 10.10.1.1:309, 10.10.2.2:309 ]
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class EndpointSubset
{
	/// <summary>
	/// IP addresses which offer the related ports that are marked as ready. These endpoints should be considered safe for load balancers and clients to utilize.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("addresses", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<EndpointAddress> Addresses { get; set; }

	/// <summary>
	/// IP addresses which offer the related ports but are not currently marked as ready because they have not yet finished starting, have recently failed a readiness check, or have recently failed a liveness check.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("notReadyAddresses", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<EndpointAddress> NotReadyAddresses { get; set; }

	/// <summary>
	/// Port numbers available on the related IP addresses.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("ports", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<EndpointPort> Ports { get; set; }

}