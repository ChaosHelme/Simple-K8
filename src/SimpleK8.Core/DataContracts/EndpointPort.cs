namespace SimpleK8.Core.DataContracts;

/// <summary>
/// EndpointPort is a tuple that describes a single port.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class EndpointPort
{
	/// <summary>
	/// The application protocol for this port. This is used as a hint for implementations to offer richer behavior for protocols that they understand. This field follows standard Kubernetes label syntax. Valid values are either:
	/// <br/>
	/// <br/>* Un-prefixed protocol names - reserved for IANA standard service names (as per RFC-6335 and https://www.iana.org/assignments/service-names).
	/// <br/>
	/// <br/>* Kubernetes-defined prefixed names:
	/// <br/>  * 'kubernetes.io/h2c' - HTTP/2 prior knowledge over cleartext as described in https://www.rfc-editor.org/rfc/rfc9113.html#name-starting-http-2-with-prior-
	/// <br/>  * 'kubernetes.io/ws'  - WebSocket over cleartext as described in https://www.rfc-editor.org/rfc/rfc6455
	/// <br/>  * 'kubernetes.io/wss' - WebSocket over TLS as described in https://www.rfc-editor.org/rfc/rfc6455
	/// <br/>
	/// <br/>* Other protocols should use implementation-defined prefixed names such as mycompany.com/my-custom-protocol.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("appProtocol", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string AppProtocol { get; set; }

	/// <summary>
	/// The name of this port.  This must match the 'name' field in the corresponding ServicePort. Must be a DNS_LABEL. Optional only if one port is defined.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Name { get; set; }

	/// <summary>
	/// The port number of the endpoint.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("port", Required = Newtonsoft.Json.Required.Always)]
	public int Port { get; set; }

	/// <summary>
	/// The IP protocol for this port. Must be UDP, TCP, or SCTP. Default is TCP.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("protocol", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Protocol { get; set; }

}