using Microsoft.Extensions.Logging;

namespace SimpleK8.Core;

public class Container(string image, ILogger<Container> logger)
{
	public string Id { get; } = Guid.NewGuid().ToString();
	public ContainerStatus Status { get; private set; } = ContainerStatus.Created;

	public async Task Start()
	{
		logger.LogInformation($"Starting container {Id} with image {image}");
		await Task.Delay(new Random().Next(1000, 3500)); // Simulate startup time
		Status = ContainerStatus.Running;
	}

	public void Stop()
	{
		logger.LogInformation($"Stopping container {Id}");
		Status = ContainerStatus.Stopped;
	}
	
	public void SimulateFailure()
	{
		logger.LogInformation($"Container {Id} has failed!");
		Status = ContainerStatus.Failed;
	}
}
