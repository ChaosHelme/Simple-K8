namespace SimpleK8.Core.DataContracts;

/// <summary>
/// Probe describes a health check to be performed against a container to determine whether it is alive or ready to receive traffic.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class Probe
{
	/// <summary>
	/// Exec specifies a command to execute in the container.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("exec", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public ExecAction Exec { get; set; }

	/// <summary>
	/// Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3. Minimum value is 1.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("failureThreshold", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? FailureThreshold { get; set; }

	/// <summary>
	/// GRPC specifies a GRPC HealthCheckRequest.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("grpc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public GRPCAction Grpc { get; set; }

	/// <summary>
	/// HTTPGet specifies an HTTP GET request to perform.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("httpGet", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public HTTPGetAction HttpGet { get; set; }

	/// <summary>
	/// Number of seconds after the container has started before liveness probes are initiated. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes
	/// </summary>
	[Newtonsoft.Json.JsonProperty("initialDelaySeconds", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? InitialDelaySeconds { get; set; }

	/// <summary>
	/// How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("periodSeconds", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? PeriodSeconds { get; set; }

	/// <summary>
	/// Minimum consecutive successes for the probe to be considered successful after having failed. Defaults to 1. Must be 1 for liveness and startup. Minimum value is 1.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("successThreshold", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? SuccessThreshold { get; set; }

	/// <summary>
	/// TCPSocket specifies a connection to a TCP port.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("tcpSocket", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public TCPSocketAction TcpSocket { get; set; }

	/// <summary>
	/// Optional duration in seconds the pod needs to terminate gracefully upon probe failure. The grace period is the duration in seconds after the processes running in the pod are sent a termination signal and the time when the processes are forcibly halted with a kill signal. Set this value longer than the expected cleanup time for your process. If this value is nil, the pod's terminationGracePeriodSeconds will be used. Otherwise, this value overrides the value provided by the pod spec. Value must be non-negative integer. The value zero indicates stop immediately via the kill signal (no opportunity to shut down). This is a beta field and requires enabling ProbeTerminationGracePeriod feature gate. Minimum value is 1. spec.terminationGracePeriodSeconds is used if unset.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("terminationGracePeriodSeconds", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public long? TerminationGracePeriodSeconds { get; set; }

	/// <summary>
	/// Number of seconds after which the probe times out. Defaults to 1 second. Minimum value is 1. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#container-probes
	/// </summary>
	[Newtonsoft.Json.JsonProperty("timeoutSeconds", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? TimeoutSeconds { get; set; }

}