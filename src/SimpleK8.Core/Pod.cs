using Microsoft.Extensions.Logging;

namespace SimpleK8.Core;

public class Pod
{
	public string Id { get; private set; }
	public PodStatus Status { get; private set; }

	public bool HasFailedContainers => Containers.Any(c => c.Status == ContainerStatus.Failed);
	public List<Container> Containers { get; }

	readonly ILogger<Pod> _logger;
	
	public Pod(List<Container> containers, ILogger<Pod> logger)
	{
		Id = Guid.NewGuid().ToString();
		Containers = containers;
		_logger = logger;
	}
	
	public async Task Create()
	{
		_logger.LogInformation($"Creating pod {Id}");
		foreach (var container in Containers)
		{
			await container.Start();
		}
		Status = PodStatus.Running;
	}

	public async Task HealFailedContainers()
	{
		foreach (var failedContainer in Containers.Where(c => c.Status == ContainerStatus.Failed))
		{
			_logger.LogInformation($"Healing failed container {failedContainer.Id}");
			await failedContainer.Start();
		}
	}

	public void Delete()
	{
		_logger.LogInformation($"Deleting pod {Id}");
		foreach (var container in Containers)
		{
			container.Stop();
		}
		Status = PodStatus.Succeeded;
	}
}
