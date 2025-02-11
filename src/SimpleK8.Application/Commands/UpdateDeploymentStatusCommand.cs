namespace SimpleK8.Application.Commands;

public record UpdateDeploymentStatusCommand(string namespaceName, string deploymentName);