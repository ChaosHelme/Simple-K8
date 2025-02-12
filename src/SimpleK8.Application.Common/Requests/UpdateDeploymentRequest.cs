namespace SimpleK8.Application.Common.Requests;

public record UpdateDeploymentRequest(string? Name, string? Image, int? ReplicaCount);