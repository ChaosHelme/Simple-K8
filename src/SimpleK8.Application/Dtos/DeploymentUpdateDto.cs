namespace SimpleK8.Cluster.Dtos;

public record DeploymentUpdateDto(string? Name, string? Image, int? ReplicaCount);