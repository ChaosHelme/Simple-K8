namespace SimpleK8.DataContracts;

public record DeploymentList(string ApiVersion, List<Deployment> Items, string Kind, object? Metadata);