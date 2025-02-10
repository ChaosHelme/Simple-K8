namespace SimpleK8.Core.DataContracts;

/// <summary>
/// ServerAddressByClientCIDR helps the client to determine the server address that they should use, depending on the clientCIDR that they match.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class ServerAddressByClientCIDR
{
	/// <summary>
	/// The CIDR with which clients can match their IP to figure out the server address that they should use.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("clientCIDR", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string ClientCIDR { get; set; }

	/// <summary>
	/// Address of this server, suitable for a client that matches the above CIDR. This can be a hostname, hostname:port, IP or IP:port.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("serverAddress", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string ServerAddress { get; set; }

}