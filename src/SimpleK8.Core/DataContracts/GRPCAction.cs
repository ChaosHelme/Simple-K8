namespace SimpleK8.Core.DataContracts;

/// <summary>
/// GRPCAction specifies an action involving a GRPC service.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class GRPCAction
{
	/// <summary>
	/// Port number of the gRPC service. Number must be in the range 1 to 65535.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("port", Required = Newtonsoft.Json.Required.Always)]
	public int Port { get; set; }

	/// <summary>
	/// Service is the name of the service to place in the gRPC HealthCheckRequest (see https://github.com/grpc/grpc/blob/master/doc/health-checking.md).
	/// <br/>
	/// <br/>If this is not specified, the default behavior is defined by gRPC.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("service", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Service { get; set; }

}