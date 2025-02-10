namespace SimpleK8.Core.DataContracts.Dtos;

public record DeploymentUpdateDto(string? Name, string? Image, int? ReplicaCount);