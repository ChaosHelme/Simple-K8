namespace SimpleK8.DataContracts;

/// <summary>
/// This is defined by the user and describes the desired state of system. Fill this in when creating or updating an object.
/// </summary>
/// <param name="MinReadySeconds"></param>
/// <param name="Paused"></param>
/// <param name="ProgressDeadlineSeconds"></param>
/// <param name="Replicas"></param>
/// <param name="RevisionHistoryLimit"></param>
/// <param name="Selector"></param>
/// <param name="Strategy"></param>
/// <param name="Template"></param>
public record DeploymentSpec(
	int MinReadySeconds,
	int Paused,
	int ProgressDeadlineSeconds,
	int Replicas,
	int RevisionHistoryLimit,
	LabelSelector Selector,
	DeploymentStrategie Strategy,
	PodTemplateSpec Template);
	
public record DeploymentCondition;

public record PodTemplateSpec;

public record DeploymentStrategie;

public record LabelSelector;