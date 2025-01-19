namespace SimpleK8.Core;

public class Pod
{
	public string Id { get; private set; }
	public List<Container> Containers { get; private set; }
	public PodStatus Status { get; private set; }

	public void Create() { /* Implementation */ }
	public void Delete() { /* Implementation */ }
}
