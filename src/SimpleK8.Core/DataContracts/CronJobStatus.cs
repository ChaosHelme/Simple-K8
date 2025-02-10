namespace SimpleK8.Core.DataContracts;

/// <summary>
/// CronJobStatus represents the current state of a cron job.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class CronJobStatus
{
	/// <summary>
	/// A list of pointers to currently running jobs.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("active", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<ObjectReference> Active { get; set; }

	/// <summary>
	/// Information when was the last time the job was successfully scheduled.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("lastScheduleTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.DateTimeOffset? LastScheduleTime { get; set; }

	/// <summary>
	/// Information when was the last time the job successfully completed.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("lastSuccessfulTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.DateTimeOffset? LastSuccessfulTime { get; set; }

}