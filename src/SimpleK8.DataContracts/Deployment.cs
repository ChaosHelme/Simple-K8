using SimpleK8.DataContracts.Dtos;

namespace SimpleK8.DataContracts;

public record Deployment(Guid Id, string Name, string Image, int ReplicaCount)
{
	public static Deployment CreateUpdate(Deployment original, DeploymentUpdateDto update)
	{
		return new Deployment(original.Id, update.Name ?? original.Name,
			update.Image ?? original.Image, update.ReplicaCount ?? original.ReplicaCount);
	}
}