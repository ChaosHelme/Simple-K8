namespace SimpleK8.Core.DataContracts;

/// <summary>
/// ContainerStateTerminated is a terminated state of a container.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class ContainerStateTerminated
{
	/// <summary>
	/// Container's ID in the format '&lt;type&gt;://&lt;container_id&gt;'
	/// </summary>
	[Newtonsoft.Json.JsonProperty("containerID", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string ContainerID { get; set; }

	/// <summary>
	/// Exit status from the last termination of the container
	/// </summary>
	[Newtonsoft.Json.JsonProperty("exitCode", Required = Newtonsoft.Json.Required.Always)]
	public int ExitCode { get; set; }

	/// <summary>
	/// Time at which the container last terminated
	/// </summary>
	[Newtonsoft.Json.JsonProperty("finishedAt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.DateTimeOffset? FinishedAt { get; set; }

	/// <summary>
	/// Message regarding the last termination of the container
	/// </summary>
	[Newtonsoft.Json.JsonProperty("message", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Message { get; set; }

	/// <summary>
	/// (brief) reason from the last termination of the container
	/// </summary>
	[Newtonsoft.Json.JsonProperty("reason", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Reason { get; set; }

	/// <summary>
	/// Signal from the last termination of the container
	/// </summary>
	[Newtonsoft.Json.JsonProperty("signal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? Signal { get; set; }

	/// <summary>
	/// Time at which previous execution of the container started
	/// </summary>
	[Newtonsoft.Json.JsonProperty("startedAt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.DateTimeOffset? StartedAt { get; set; }

}