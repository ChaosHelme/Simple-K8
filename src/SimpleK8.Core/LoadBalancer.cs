namespace SimpleK8.Core;

public class LoadBalancer(IServiceRegistry serviceRegistry)
{
	readonly Dictionary<string, int> _roundRobinCounters = [];
	
	public Pod? GetNextPod(string serviceName)
	{
		var pods = serviceRegistry.GetPodsForService(serviceName);
		if (pods.Count == 0)
		{
			return null;
		}

		if (!_roundRobinCounters.TryGetValue(serviceName, out var value))
		{
            value = 0;
            _roundRobinCounters[serviceName] = value;
		}

		var index = value % pods.Count;
		_roundRobinCounters[serviceName] = ++value;

		return pods[index];
	}
}
