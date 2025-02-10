namespace SimpleK8.Core.DataContracts;

/// <summary>
/// IngressPortStatus represents the error condition of a service port
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class IngressPortStatus
{
	/// <summary>
	/// error is to record the problem with the service port The format of the error shall comply with the following rules: - built-in error values shall be specified in this file and those shall use
	/// <br/>  CamelCase names
	/// <br/>- cloud provider specific error values must have names that comply with the
	/// <br/>  format foo.example.com/CamelCase.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("error", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Error { get; set; }

	/// <summary>
	/// port is the port number of the ingress port.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("port", Required = Newtonsoft.Json.Required.Always)]
	public int Port { get; set; }

	/// <summary>
	/// protocol is the protocol of the ingress port. The supported values are: "TCP", "UDP", "SCTP"
	/// </summary>
	[Newtonsoft.Json.JsonProperty("protocol", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Protocol { get; set; }

}