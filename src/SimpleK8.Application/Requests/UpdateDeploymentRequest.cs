namespace SimpleK8.Application.Requests;

public record UpdateDeploymentRequest(string? Name, string? Image, int? ReplicaCount);