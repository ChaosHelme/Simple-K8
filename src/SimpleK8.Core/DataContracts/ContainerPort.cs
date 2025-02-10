namespace SimpleK8.Core.DataContracts;

/// <summary>
/// ContainerPort represents a network port in a single container.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class ContainerPort
{
	/// <summary>
	/// Number of port to expose on the pod's IP address. This must be a valid port number, 0 &lt; x &lt; 65536.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("containerPort", Required = Newtonsoft.Json.Required.Always)]
	public int ContainerPort1 { get; set; }

	/// <summary>
	/// What host IP to bind the external port to.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("hostIP", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string HostIP { get; set; }

	/// <summary>
	/// Number of port to expose on the host. If specified, this must be a valid port number, 0 &lt; x &lt; 65536. If HostNetwork is specified, this must match ContainerPort. Most containers do not need this.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("hostPort", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? HostPort { get; set; }

	/// <summary>
	/// If specified, this must be an IANA_SVC_NAME and unique within the pod. Each named port in a pod must have a unique name. Name for the port that can be referred to by services.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Name { get; set; }

	/// <summary>
	/// Protocol for port. Must be UDP, TCP, or SCTP. Defaults to "TCP".
	/// </summary>
	[Newtonsoft.Json.JsonProperty("protocol", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Protocol { get; set; }

}