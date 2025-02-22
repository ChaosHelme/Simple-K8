namespace SimpleK8.Core.DataContracts;

/// <summary>
/// DaemonSetSpec is the specification of a daemon set.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class DaemonSetSpec
{
	/// <summary>
	/// The minimum number of seconds for which a newly created DaemonSet pod should be ready without any of its container crashing, for it to be considered available. Defaults to 0 (pod will be considered available as soon as it is ready).
	/// </summary>
	[Newtonsoft.Json.JsonProperty("minReadySeconds", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? MinReadySeconds { get; set; }

	/// <summary>
	/// The number of old history to retain to allow rollback. This is a pointer to distinguish between explicit zero and not specified. Defaults to 10.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("revisionHistoryLimit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? RevisionHistoryLimit { get; set; }

	/// <summary>
	/// A label query over pods that are managed by the daemon set. Must match in order to be controlled. It must match the pod template's labels. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#label-selectors
	/// </summary>
	[Newtonsoft.Json.JsonProperty("selector", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required]
	public LabelSelector Selector { get; set; } = new LabelSelector();

	/// <summary>
	/// An object that describes the pod that will be created. The DaemonSet will create exactly one copy of this pod on every node that matches the template's node selector (or on every node if no node selector is specified). The only allowed template.spec.restartPolicy value is "Always". More info: https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller#pod-template
	/// </summary>
	[Newtonsoft.Json.JsonProperty("template", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required]
	public PodTemplateSpec Template { get; set; } = new PodTemplateSpec();

	/// <summary>
	/// An update strategy to replace existing DaemonSet pods with new pods.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("updateStrategy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public DaemonSetUpdateStrategy UpdateStrategy { get; set; }

}