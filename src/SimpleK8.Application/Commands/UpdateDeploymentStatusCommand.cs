namespace SimpleK8.Cluster.Commands;

public record UpdateDeploymentStatusCommand(string namespaceName, string deploymentName);