namespace SimpleK8.DataContracts.Dtos;

public record DeploymentUpdateDto(string? Name, string? Image, int? ReplicaCount);