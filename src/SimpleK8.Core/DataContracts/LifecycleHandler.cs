namespace SimpleK8.Core.DataContracts;

/// <summary>
/// LifecycleHandler defines a specific action that should be taken in a lifecycle hook. One and only one of the fields, except TCPSocket must be specified.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class LifecycleHandler
{
	/// <summary>
	/// Exec specifies a command to execute in the container.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("exec", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public ExecAction Exec { get; set; }

	/// <summary>
	/// HTTPGet specifies an HTTP GET request to perform.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("httpGet", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public HTTPGetAction HttpGet { get; set; }

	/// <summary>
	/// Sleep represents a duration that the container should sleep.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("sleep", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public SleepAction Sleep { get; set; }

	/// <summary>
	/// Deprecated. TCPSocket is NOT supported as a LifecycleHandler and kept for backward compatibility. There is no validation of this field and lifecycle hooks will fail at runtime when it is specified.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("tcpSocket", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public TCPSocketAction TcpSocket { get; set; }

}