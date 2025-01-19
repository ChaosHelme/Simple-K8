using Microsoft.Extensions.Logging;

namespace SimpleK8.Core;

public class Container(string image, ILogger<Container> logger)
{
	public string Id => Guid.NewGuid().ToString();
	public string Image => image;
	public ContainerStatus Status { get; private set; }
	
	public async Task Start()
	{
		logger.LogInformation($"Starting container {Id} with image {Image}");
		await Task.Delay(2500); // Simulate startup time
		Status = ContainerStatus.Running;
	}

	public void Stop()
	{
		logger.LogInformation($"Stopping container {Id}");
		Status = ContainerStatus.Stopped;
	}
}
