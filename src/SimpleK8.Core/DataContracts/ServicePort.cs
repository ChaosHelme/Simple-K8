namespace SimpleK8.Core.DataContracts;

/// <summary>
/// ServicePort contains information on service's port.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class ServicePort
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
	/// The name of this port within the service. This must be a DNS_LABEL. All ports within a ServiceSpec must have unique names. When considering the endpoints for a Service, this must match the 'name' field in the EndpointPort. Optional if only one ServicePort is defined on this service.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Name { get; set; }

	/// <summary>
	/// The port on each node on which this service is exposed when type is NodePort or LoadBalancer.  Usually assigned by the system. If a value is specified, in-range, and not in use it will be used, otherwise the operation will fail.  If not specified, a port will be allocated if this Service requires one.  If this field is specified when creating a Service which does not need it, creation will fail. This field will be wiped when updating a Service to no longer need it (e.g. changing type from NodePort to ClusterIP). More info: https://kubernetes.io/docs/concepts/services-networking/service/#type-nodeport
	/// </summary>
	[Newtonsoft.Json.JsonProperty("nodePort", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? NodePort { get; set; }

	/// <summary>
	/// The port that will be exposed by this service.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("port", Required = Newtonsoft.Json.Required.Always)]
	public int Port { get; set; }

	/// <summary>
	/// The IP protocol for this port. Supports "TCP", "UDP", and "SCTP". Default is TCP.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("protocol", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Protocol { get; set; }

	/// <summary>
	/// Number or name of the port to access on the pods targeted by the service. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME. If this is a string, it will be looked up as a named port in the target Pod's container ports. If this is not specified, the value of the 'port' field is used (an identity map). This field is ignored for services with clusterIP=None, and should be omitted or set equal to the 'port' field. More info: https://kubernetes.io/docs/concepts/services-networking/service/#defining-a-service
	/// </summary>
	[Newtonsoft.Json.JsonProperty("targetPort", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string TargetPort { get; set; }

}