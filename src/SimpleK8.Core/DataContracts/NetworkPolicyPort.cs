namespace SimpleK8.Core.DataContracts;

/// <summary>
/// NetworkPolicyPort describes a port to allow traffic on
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class NetworkPolicyPort
{
	/// <summary>
	/// endPort indicates that the range of ports from port to endPort if set, inclusive, should be allowed by the policy. This field cannot be defined if the port field is not defined or if the port field is defined as a named (string) port. The endPort must be equal or greater than port.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("endPort", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? EndPort { get; set; }

	/// <summary>
	/// port represents the port on the given protocol. This can either be a numerical or named port on a pod. If this field is not provided, this matches all port names and numbers. If present, only traffic on the specified protocol AND port will be matched.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("port", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Port { get; set; }

	/// <summary>
	/// protocol represents the protocol (TCP, UDP, or SCTP) which traffic must match. If not specified, this field defaults to TCP.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("protocol", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Protocol { get; set; }

}