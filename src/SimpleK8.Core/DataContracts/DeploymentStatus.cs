namespace SimpleK8.Core.DataContracts;

/// <summary>
/// DeploymentStatus is the most recently observed status of the Deployment.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class DeploymentStatus
{
	/// <summary>
	/// Total number of available non-terminating pods (ready for at least minReadySeconds) targeted by this deployment.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("availableReplicas", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? AvailableReplicas { get; set; }

	/// <summary>
	/// Count of hash collisions for the Deployment. The Deployment controller uses this field as a collision avoidance mechanism when it needs to create the name for the newest ReplicaSet.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("collisionCount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? CollisionCount { get; set; }

	/// <summary>
	/// Represents the latest available observations of a deployment's current state.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("conditions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<DeploymentCondition> Conditions { get; set; }

	/// <summary>
	/// The generation observed by the deployment controller.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("observedGeneration", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public long? ObservedGeneration { get; set; }

	/// <summary>
	/// Total number of non-terminating pods targeted by this Deployment with a Ready Condition.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("readyReplicas", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? ReadyReplicas { get; set; }

	/// <summary>
	/// Total number of non-terminating pods targeted by this deployment (their labels match the selector).
	/// </summary>
	[Newtonsoft.Json.JsonProperty("replicas", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? Replicas { get; set; }

	/// <summary>
	/// Total number of terminating pods targeted by this deployment. Terminating pods have a non-null .metadata.deletionTimestamp and have not yet reached the Failed or Succeeded .status.phase.
	/// <br/>
	/// <br/>This is an alpha field. Enable DeploymentPodReplacementPolicy to be able to use this field.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("terminatingReplicas", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? TerminatingReplicas { get; set; }

	/// <summary>
	/// Total number of unavailable pods targeted by this deployment. This is the total number of pods that are still required for the deployment to have 100% available capacity. They may either be pods that are running but not yet available or pods that still have not been created.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("unavailableReplicas", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? UnavailableReplicas { get; set; }

	/// <summary>
	/// Total number of non-terminating pods targeted by this deployment that have the desired template spec.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("updatedReplicas", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? UpdatedReplicas { get; set; }

}