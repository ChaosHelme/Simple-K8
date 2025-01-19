namespace SimpleK8.Core;

public record Deployment(Guid Id, string Name, string Image, int ReplicaCount);