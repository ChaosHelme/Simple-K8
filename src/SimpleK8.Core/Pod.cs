using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace SimpleK8.Core;

public class Pod
{
	public string Id { get; private set; }
	public PodStatus Status { get; private set; }

	public bool HasFailedContainers => Containers.Any(c => c.Status == ContainerStatus.Failed);
	public List<Container> Containers { get; }
	public string? AssignedNode { get; set; }

	readonly ILogger<Pod> _logger;
	
	public Pod(string image, ILogger<Pod> logger, IServiceProvider serviceProvider)
	{
		Id = Guid.NewGuid().ToString();
		Containers = [new Container(image, serviceProvider.GetRequiredService<ILogger<Container>>())];
		_logger = logger;
		Status = PodStatus.Pending;
	}
	
	public async Task Start()
	{
		_logger.LogInformation("Starting pod {Id}", Id);
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

	public void SimulateFailure()
	{
		Containers.First().SimulateFailure();
		Status = PodStatus.Failed;
		_logger.LogInformation("Pod {Id} has failed!", Id);
	}

	public void Stop()
	{
		_logger.LogInformation($"Deleting pod {Id}");
		foreach (var container in Containers)
		{
			container.Stop();
		}
		Status = PodStatus.Succeeded;
	}
}
