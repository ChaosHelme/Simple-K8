namespace SimpleK8.Core.DataContracts;

/// <summary>
/// TCPSocketAction describes an action based on opening a socket
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class TCPSocketAction
{
	/// <summary>
	/// Optional: Host name to connect to, defaults to the pod IP.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("host", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Host { get; set; }

	/// <summary>
	/// Number or name of the port to access on the container. Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("port", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Port { get; set; }

}