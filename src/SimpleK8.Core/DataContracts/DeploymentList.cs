namespace SimpleK8.Core.DataContracts;

public record DeploymentList(string ApiVersion, List<Deployment> Items, string Kind, object? Metadata)
{
	public static DeploymentList Empty => new("v1", [], "deployments", null);
}