namespace SimpleK8.Core.DataContracts;

/// <summary>
/// DaemonEndpoint contains information about a single Daemon endpoint.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class DaemonEndpoint
{
	/// <summary>
	/// Port number of the given endpoint.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("Port", Required = Newtonsoft.Json.Required.Always)]
	public int Port { get; set; }

}