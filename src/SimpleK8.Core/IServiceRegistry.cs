namespace SimpleK8.Core;

public interface IServiceRegistry
{
	void Register(string serviceName, Pod pod);
	void Deregister(string serviceName, Pod pod);
	List<Pod> GetPodsForService(string serviceName);
}