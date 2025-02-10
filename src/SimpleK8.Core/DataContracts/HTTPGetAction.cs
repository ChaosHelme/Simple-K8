namespace SimpleK8.Core.DataContracts;

/// <summary>
/// HTTPGetAction describes an action based on HTTP Get requests.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class HTTPGetAction
{
	/// <summary>
	/// Host name to connect to, defaults to the pod IP. You probably want to set "Host" in httpHeaders instead.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("host", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Host { get; set; }

	/// <summary>
	/// Custom headers to set in the request. HTTP allows repeated headers.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("httpHeaders", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<HTTPHeader> HttpHeaders { get; set; }

	/// <summary>
	/// Path to access on the HTTP server.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("path", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Path { get; set; }

	/// <summary>
	/// Name or number of the port to access on the container. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("port", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Port { get; set; }

	/// <summary>
	/// Scheme to use for connecting to the host. Defaults to HTTP.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("scheme", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Scheme { get; set; }

}