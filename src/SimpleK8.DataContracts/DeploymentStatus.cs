namespace SimpleK8.DataContracts;

/// <summary>
/// This is defined by the user and describes the desired state of system. Fill this in when creating or updating an object.
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