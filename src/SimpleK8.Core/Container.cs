namespace SimpleK8.Core;

public class Container
{
	public string Id { get; private set; }
	public string Image { get; set; }
	public ContainerStatus Status { get; private set; }

	public void Start() { /* Implementation */ }
	public void Stop() { /* Implementation */ }
}
