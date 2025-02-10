namespace SimpleK8.Core.DataContracts;

/// <summary>
/// CronJobSpec describes how the job execution will look like and when it will actually run.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class CronJobSpec
{
	/// <summary>
	/// Specifies how to treat concurrent executions of a Job. Valid values are:
	/// <br/>
	/// <br/>- "Allow" (default): allows CronJobs to run concurrently; - "Forbid": forbids concurrent runs, skipping next run if previous run hasn't finished yet; - "Replace": cancels currently running job and replaces it with a new one
	/// </summary>
	[Newtonsoft.Json.JsonProperty("concurrencyPolicy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string ConcurrencyPolicy { get; set; }

	/// <summary>
	/// The number of failed finished jobs to retain. Value must be non-negative integer. Defaults to 1.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("failedJobsHistoryLimit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? FailedJobsHistoryLimit { get; set; }

	/// <summary>
	/// Specifies the job that will be created when executing a CronJob.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("jobTemplate", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required]
	public JobTemplateSpec JobTemplate { get; set; } = new JobTemplateSpec();

	/// <summary>
	/// The schedule in Cron format, see https://en.wikipedia.org/wiki/Cron.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("schedule", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Schedule { get; set; }

	/// <summary>
	/// Optional deadline in seconds for starting the job if it misses scheduled time for any reason.  Missed jobs executions will be counted as failed ones.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("startingDeadlineSeconds", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public long? StartingDeadlineSeconds { get; set; }

	/// <summary>
	/// The number of successful finished jobs to retain. Value must be non-negative integer. Defaults to 3.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("successfulJobsHistoryLimit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? SuccessfulJobsHistoryLimit { get; set; }

	/// <summary>
	/// This flag tells the controller to suspend subsequent executions, it does not apply to already started executions.  Defaults to false.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("suspend", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public bool? Suspend { get; set; }

	/// <summary>
	/// The time zone name for the given schedule, see https://en.wikipedia.org/wiki/List_of_tz_database_time_zones. If not specified, this will default to the time zone of the kube-controller-manager process. The set of valid time zone names and the time zone offset is loaded from the system-wide time zone database by the API server during CronJob validation and the controller manager during execution. If no system-wide time zone database can be found a bundled version of the database is used instead. If the time zone name becomes invalid during the lifetime of a CronJob or due to a change in host configuration, the controller will stop creating new new Jobs and will create a system event with the reason UnknownTimeZone. More information can be found in https://kubernetes.io/docs/concepts/workloads/controllers/cron-jobs/#time-zones
	/// </summary>
	[Newtonsoft.Json.JsonProperty("timeZone", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string TimeZone { get; set; }

}