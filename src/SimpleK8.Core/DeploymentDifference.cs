namespace SimpleK8.Core;

public record DeploymentDifference()
{
	public int replicas;
	public string image;
}