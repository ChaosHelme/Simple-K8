using SimpleK8.DataContracts.Dtos;

namespace SimpleK8.DataContracts;

public record Deployment(string ApiVersion, string Kind, object Metadata, DeploymentSpec Spec, DeploymentStatus Status)
	: ApiDataContract(ApiVersion, Kind, Metadata)
{
	public Guid Id { get; init; }
	public required string Name { get; init; }
}

public record DeploymentStatus(
	int AvailableReplicas,
	int CollisionCount,
	DeploymentCondition Conditions,
	int ObservedGeneration,
	int ReadyReplicas,
	int Replicas,
	int UnavailableReplicas,
	int UpdatedReplicas);

public record DeploymentCondition;

public record DeploymentSpec(
	int MinReadySeconds,
	int Paused,
	int ProgressDeadlineSeconds,
	int Replicas,
	int RevisionHistoryLimit,
	LabelSelector Selector,
	DeploymentStrategie Strategy,
	PodTemplateSpec Template);

public record PodTemplateSpec;

public record DeploymentStrategie;

public record LabelSelector;