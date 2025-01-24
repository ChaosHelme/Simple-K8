namespace SimpleK8.DataContracts;

public record DeploymentList(string ApiVersion, List<Deployment> Items, string Kind, object? Metadata)
{
	public static DeploymentList Empty => new("v1", new List<Deployment>(), "deployments", null);
}