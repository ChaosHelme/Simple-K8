namespace SimpleK8.Core.DataContracts;

/// <summary>
/// PodDisruptionBudgetStatus represents information about the status of a PodDisruptionBudget. Status may trail the actual state of a system.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class PodDisruptionBudgetStatus
{
	/// <summary>
	/// Conditions contain conditions for PDB. The disruption controller sets the DisruptionAllowed condition. The following are known values for the reason field (additional reasons could be added in the future): - SyncFailed: The controller encountered an error and wasn't able to compute
	/// <br/>              the number of allowed disruptions. Therefore no disruptions are
	/// <br/>              allowed and the status of the condition will be False.
	/// <br/>- InsufficientPods: The number of pods are either at or below the number
	/// <br/>                    required by the PodDisruptionBudget. No disruptions are
	/// <br/>                    allowed and the status of the condition will be False.
	/// <br/>- SufficientPods: There are more pods than required by the PodDisruptionBudget.
	/// <br/>                  The condition will be True, and the number of allowed
	/// <br/>                  disruptions are provided by the disruptionsAllowed property.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("conditions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<Condition> Conditions { get; set; }

	/// <summary>
	/// current number of healthy pods
	/// </summary>
	[Newtonsoft.Json.JsonProperty("currentHealthy", Required = Newtonsoft.Json.Required.Always)]
	public int CurrentHealthy { get; set; }

	/// <summary>
	/// minimum desired number of healthy pods
	/// </summary>
	[Newtonsoft.Json.JsonProperty("desiredHealthy", Required = Newtonsoft.Json.Required.Always)]
	public int DesiredHealthy { get; set; }

	/// <summary>
	/// DisruptedPods contains information about pods whose eviction was processed by the API server eviction subresource handler but has not yet been observed by the PodDisruptionBudget controller. A pod will be in this map from the time when the API server processed the eviction request to the time when the pod is seen by PDB controller as having been marked for deletion (or after a timeout). The key in the map is the name of the pod and the value is the time when the API server processed the eviction request. If the deletion didn't occur and a pod is still there it will be removed from the list automatically by PodDisruptionBudget controller after some time. If everything goes smooth this map should be empty for the most of the time. Large number of entries in the map may indicate problems with pod deletions.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("disruptedPods", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.IDictionary<string, System.DateTimeOffset> DisruptedPods { get; set; }

	/// <summary>
	/// Number of pod disruptions that are currently allowed.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("disruptionsAllowed", Required = Newtonsoft.Json.Required.Always)]
	public int DisruptionsAllowed { get; set; }

	/// <summary>
	/// total number of pods counted by this disruption budget
	/// </summary>
	[Newtonsoft.Json.JsonProperty("expectedPods", Required = Newtonsoft.Json.Required.Always)]
	public int ExpectedPods { get; set; }

	/// <summary>
	/// Most recent generation observed when updating this PDB status. DisruptionsAllowed and other status information is valid only if observedGeneration equals to PDB's object generation.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("observedGeneration", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public long? ObservedGeneration { get; set; }

}