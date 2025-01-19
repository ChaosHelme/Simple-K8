namespace SimpleK8.Core;

public class ServiceRegistry
{
	private Dictionary<string, List<Pod>> services;

	public void Register(string serviceName, Pod pod) { /* Implementation */ }
	public void Deregister(string serviceName, Pod pod) { /* Implementation */ }

	public List<Pod> GetPodsForService(string serviceName)
	{
		return new List<Pod>();
	}
}
