using Microsoft.Extensions.Logging;
using SimpleK8.Core.DataContracts;

namespace SimpleK8.Core;

public class ContainerWrapper(Container container, ILogger<ContainerWrapper> logger)
{
	public string Id { get; } = Guid.NewGuid().ToString();
	public ContainerStatus Status { get; private set; } = ContainerStatus.Created;
	
	public async Task Start()
	{
		logger.LogInformation("Starting container {Id} with image {Image}", Id, container.Image);
		await Task.Delay(new Random().Next(1000, 3500)); // Simulate startup time
		Status = ContainerStatus.Running;
	}

	public void Stop()
	{
		logger.LogInformation("Stopping container {Id}", Id);
		Status = ContainerStatus.Stopped;
	}
	
	public void SimulateFailure()
	{
		logger.LogInformation("Container {Id} has failed!", Id);
		Status = ContainerStatus.Failed;
	}
}
