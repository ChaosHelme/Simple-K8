namespace SimpleK8.Core.DataContracts;

/// <summary>
/// ReplicaSetSpec is the specification of a ReplicaSet.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class ReplicaSetSpec
{
	/// <summary>
	/// Minimum number of seconds for which a newly created pod should be ready without any of its container crashing, for it to be considered available. Defaults to 0 (pod will be considered available as soon as it is ready)
	/// </summary>
	[Newtonsoft.Json.JsonProperty("minReadySeconds", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? MinReadySeconds { get; set; }

	/// <summary>
	/// Replicas is the number of desired pods. This is a pointer to distinguish between explicit zero and unspecified. Defaults to 1. More info: https://kubernetes.io/docs/concepts/workloads/controllers/replicaset
	/// </summary>
	[Newtonsoft.Json.JsonProperty("replicas", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? Replicas { get; set; }

	/// <summary>
	/// Selector is a label query over pods that should match the replica count. Label keys and values that must match in order to be controlled by this replica set. It must match the pod template's labels. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#label-selectors
	/// </summary>
	[Newtonsoft.Json.JsonProperty("selector", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required]
	public LabelSelector Selector { get; set; } = new LabelSelector();

	/// <summary>
	/// Template is the object that describes the pod that will be created if insufficient replicas are detected. More info: https://kubernetes.io/docs/concepts/workloads/controllers/replicaset/#pod-template
	/// </summary>
	[Newtonsoft.Json.JsonProperty("template", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public PodTemplateSpec Template { get; set; }

}