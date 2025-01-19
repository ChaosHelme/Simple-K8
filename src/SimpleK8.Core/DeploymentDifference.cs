namespace SimpleK8.Core;

public record DeploymentDifference(Guid Id, string Name, string OldImage, string NewImage, int OldReplicas, int NewReplicas)
{
	public int Replicas;
	public string Image = NewImage;
	
	public bool DetermineDifferences()
	{
		var containsDifferences = false;
		
		Replicas = Math.Abs(NewReplicas - OldReplicas);
		if (OldImage != NewImage)
				Image = NewImage;
		
		if (Replicas > 0 || OldImage != NewImage)
			containsDifferences = true;
		
		return containsDifferences;
	}
}