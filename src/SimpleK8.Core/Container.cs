using Microsoft.Extensions.Logging;

namespace SimpleK8.Core;

public class Container
{
	public string Id {get; }
	public ContainerStatus Status { get; private set; }

	readonly ILogger<Container> _logger;
	readonly string _image;
	

	public Container(string image, ILogger<Container> logger)
	{
		Id = Guid.NewGuid().ToString();
		_image = image;
		_logger = logger;
	}
	
	public async Task Start()
	{
		Status = ContainerStatus.Created;
		_logger.LogInformation($"Starting container {Id} with image {_image}");
		await Task.Delay(2500); // Simulate startup time
		Status = ContainerStatus.Running;
	}

	public void Stop()
	{
		_logger.LogInformation($"Stopping container {Id}");
		Status = ContainerStatus.Stopped;
	}
	
	public void SimulateFailure()
	{
		_logger.LogInformation($"Container {Id} has failed!");
		Status = ContainerStatus.Failed;
	}
}
