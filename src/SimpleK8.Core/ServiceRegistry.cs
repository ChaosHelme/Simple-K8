using Microsoft.Extensions.Logging;

namespace SimpleK8.Core;

public class ServiceRegistry(ILogger<ServiceRegistry> logger) : IServiceRegistry
{
	readonly Dictionary<string, List<Pod>> _services = [];

	public void Register(string serviceName, Pod pod)
	{
		logger.LogInformation($"Registering pod {pod.Id} for service {serviceName}");
		if (!_services.TryGetValue(serviceName, out var value))
		{
            value = [];
            _services[serviceName] = value;
		}

        value.Add(pod);
	}

	public void Deregister(string serviceName, Pod pod)
	{
		logger.LogInformation($"Deregistering pod {pod.Id} from service {serviceName}");
		if (_services.TryGetValue(serviceName, out var value))
		{
            value.Remove(pod);
		}
	}

	public List<Pod> GetPodsForService(string serviceName) 
		=> _services.TryGetValue(serviceName, out var service) ? service : [];
}
