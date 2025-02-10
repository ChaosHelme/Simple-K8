namespace SimpleK8.Core.DataContracts;

/// <summary>
/// This is filled in by the server and reports the current state of the system. In most cases, users don't need to change this.
/// </summary>
/// <param name="AvailableReplicas">
/// Total number of available pods (ready for at least minReadySeconds) targeted by this deployment.</param>
/// <param name="CollisionCount">
/// Count of hash collisions for the Deployment. The Deployment controller uses this field as a collision avoidance mechanism when it needs to create the name for the newest ReplicaSet.</param>
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