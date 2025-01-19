namespace SimpleK8.Core;

public record DeploymentDifference(Guid Id, string Name, string CurrentImage, string DesiredImage, int CurrentReplicas, int DesiredReplicas)
{
	public int Replicas;
	public string Image = DesiredImage;
	
	public bool DetermineDifferences()
	{
		var containsDifferences = false;
		
		Replicas = Math.Abs(DesiredReplicas - CurrentReplicas);
		if (CurrentImage != DesiredImage)
				Image = DesiredImage;
		
		if (Replicas > 0 || CurrentImage != DesiredImage)
			containsDifferences = true;
		
		return containsDifferences;
	}
}