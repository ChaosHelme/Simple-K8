namespace SimpleK8.Core.DataContracts;

/// <summary>
/// EndpointAddress is a tuple that describes single IP address.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class EndpointAddress
{
	/// <summary>
	/// The Hostname of this endpoint
	/// </summary>
	[Newtonsoft.Json.JsonProperty("hostname", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Hostname { get; set; }

	/// <summary>
	/// The IP of this endpoint. May not be loopback (127.0.0.0/8 or ::1), link-local (169.254.0.0/16 or fe80::/10), or link-local multicast (224.0.0.0/24 or ff02::/16).
	/// </summary>
	[Newtonsoft.Json.JsonProperty("ip", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Ip { get; set; }

	/// <summary>
	/// Optional: Node hosting this endpoint. This can be used to determine endpoints local to a node.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("nodeName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string NodeName { get; set; }

	/// <summary>
	/// Reference to object providing the endpoint.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("targetRef", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public ObjectReference TargetRef { get; set; }

}