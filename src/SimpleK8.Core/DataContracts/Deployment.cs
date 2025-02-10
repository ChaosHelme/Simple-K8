namespace SimpleK8.Core.DataContracts;

public record Deployment(string ApiVersion, string Kind, ObjectMetadata Metadata, DeploymentSpec Spec, DeploymentStatus? Status = null)
	: ApiDataContract(ApiVersion, Kind, Metadata)
{
	public DeploymentDiff DetermineDiff(DeploymentStatus deploymentStatus)
	{
		var replicaDiff = deploymentStatus.Replicas - Spec.Replicas;
		return new DeploymentDiff(replicaDiff);
	}
}

public record DeploymentDiff(int ReplicaDiff);