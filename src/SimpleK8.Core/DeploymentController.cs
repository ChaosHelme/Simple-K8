namespace SimpleK8.Core;

public class DeploymentController
{
	public List<Pod> ManagedPods { get; private set; }

	public void Scale(int replicas) { /* Implementation */ }
	public void UpdateImage(string newImage) { /* Implementation */ }
}
