namespace SimpleK8.DataContracts;

/// <summary>
/// This is filled in by the server and reports the current state of the system. In most cases, users don't need to change this.
/// </summary>
/// <param name="AvailableReplicas"></param>
/// <param name="CollisionCount"></param>
/// <param name="Conditions"></param>
/// <param name="ObservedGeneration"></param>
/// <param name="ReadyReplicas"></param>
/// <param name="Replicas"></param>
/// <param name="UnavailableReplicas"></param>
/// <param name="UpdatedReplicas"></param>
public record DeploymentStatus(
	int AvailableReplicas,
	int CollisionCount,
	DeploymentCondition Conditions,
	int ObservedGeneration,
	int ReadyReplicas,
	int Replicas,
	int UnavailableReplicas,
	int UpdatedReplicas);