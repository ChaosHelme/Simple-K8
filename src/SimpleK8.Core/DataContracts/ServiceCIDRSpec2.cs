namespace SimpleK8.Core.DataContracts;

/// <summary>
/// ServiceCIDRSpec define the CIDRs the user wants to use for allocating ClusterIPs for Services.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class ServiceCIDRSpec2
{
	/// <summary>
	/// CIDRs defines the IP blocks in CIDR notation (e.g. "192.168.0.0/24" or "2001:db8::/64") from which to assign service cluster IPs. Max of two CIDRs is allowed, one of each IP family. This field is immutable.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("cidrs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<string> Cidrs { get; set; }

}