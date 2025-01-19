namespace SimpleK8.Core;

public class RevisionHistory(Deployment deployment)
{
	public string Image { get; } = deployment.Image;
	public int ReplicaCount { get; } = deployment.ReplicaCount;
	public DateTime Timestamp { get; } = DateTime.UtcNow;
}