using Microsoft.Extensions.Logging;

namespace SimpleK8.Core;

public class Pod(List<Container> containers, ILogger<Pod> logger)
{
	public string Id => Guid.NewGuid().ToString();
	public PodStatus Status { get; private set; }

	public async Task Create()
	{
		logger.LogInformation($"Creating pod {Id}");
		foreach (var container in containers)
		{
			await container.Start();
		}
		Status = PodStatus.Running;
	}

	public void Delete()
	{
		logger.LogInformation($"Deleting pod {Id}");
		foreach (var container in containers)
		{
			container.Stop();
		}
		Status = PodStatus.Succeeded;
	}
}
