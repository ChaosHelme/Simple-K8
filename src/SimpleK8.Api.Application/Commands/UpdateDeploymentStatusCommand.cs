namespace SimpleK8.Api.Application.Commands;

public record UpdateDeploymentStatusCommand(string namespaceName, string deploymentName);