namespace SimpleK8.Core.DataContracts;

/// <summary>
/// DeploymentSpec is the specification of the desired behavior of the Deployment.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class DeploymentSpec
{
	/// <summary>
	/// Minimum number of seconds for which a newly created pod should be ready without any of its container crashing, for it to be considered available. Defaults to 0 (pod will be considered available as soon as it is ready)
	/// </summary>
	[Newtonsoft.Json.JsonProperty("minReadySeconds", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? MinReadySeconds { get; set; }

	/// <summary>
	/// Indicates that the deployment is paused.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("paused", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public bool? Paused { get; set; }

	/// <summary>
	/// The maximum time in seconds for a deployment to make progress before it is considered to be failed. The deployment controller will continue to process failed deployments and a condition with a ProgressDeadlineExceeded reason will be surfaced in the deployment status. Note that progress will not be estimated during the time a deployment is paused. Defaults to 600s.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("progressDeadlineSeconds", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? ProgressDeadlineSeconds { get; set; }

	/// <summary>
	/// Number of desired pods. This is a pointer to distinguish between explicit zero and not specified. Defaults to 1.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("replicas", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? Replicas { get; set; }

	/// <summary>
	/// The number of old ReplicaSets to retain to allow rollback. This is a pointer to distinguish between explicit zero and not specified. Defaults to 10.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("revisionHistoryLimit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? RevisionHistoryLimit { get; set; }

	/// <summary>
	/// Label selector for pods. Existing ReplicaSets whose pods are selected by this will be the ones affected by this deployment. It must match the pod template's labels.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("selector", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required]
	public LabelSelector Selector { get; set; } = new LabelSelector();

	/// <summary>
	/// The deployment strategy to use to replace existing pods with new ones.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("strategy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public DeploymentStrategy Strategy { get; set; } = new DeploymentStrategy();

	/// <summary>
	/// Template describes the pods that will be created. The only allowed template.spec.restartPolicy value is "Always".
	/// </summary>
	[Newtonsoft.Json.JsonProperty("template", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required]
	public PodTemplateSpec Template { get; set; } = new PodTemplateSpec();

}