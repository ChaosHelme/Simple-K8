using SimpleK8.DataContracts;

namespace SimpleK8.Core;

public class RevisionHistory(Deployment deployment)
{
	public string Image { get; } = "";
	public int ReplicaCount { get; } = 0;
	public DateTime Timestamp { get; } = DateTime.UtcNow;
}