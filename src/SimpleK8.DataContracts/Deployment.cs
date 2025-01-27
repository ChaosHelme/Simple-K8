namespace SimpleK8.DataContracts;

public record Deployment(string ApiVersion, string Kind, ObjectMetadata Metadata, DeploymentSpec Spec, DeploymentStatus? Status = null)
	: ApiDataContract(ApiVersion, Kind, Metadata);