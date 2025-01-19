using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace SimpleK8.Core;

public class DeploymentController
{
	public List<Pod> ManagedPods { get; private set; } = [];

	string _currentImage;
	readonly ILogger<DeploymentController> _logger;
	readonly IServiceProvider _serviceProvider;
	public DeploymentController(ILogger<DeploymentController> logger, IServiceProvider serviceProvider, string initialImage, int initialReplicas)
	{
		_logger = logger;
		_serviceProvider = serviceProvider;
		_currentImage = initialImage;
		Scale(initialReplicas).Wait();
	}

	public async Task Scale(int replicas)
	{
		_logger.LogInformation($"Scaling to {replicas} replicas");
		while (ManagedPods.Count < replicas)
		{
			var newPod = new Pod(new List<Container>
			{
				new Container(_currentImage, _serviceProvider.GetRequiredService<ILogger<Container>>())
			});
			await newPod.Create();
			ManagedPods.Add(newPod);
		}

		while (ManagedPods.Count > replicas)
		{
			var podToRemove = ManagedPods.Last();
			podToRemove.Delete();
			ManagedPods.Remove(podToRemove);
		}
	}

	public async Task UpdateImage(string newImage)
	{
		_logger.LogInformation($"Updating image to {newImage}");
		_currentImage = newImage;
		var oldPods = new List<Pod>(ManagedPods);
		ManagedPods.Clear();

		foreach (var oldPod in oldPods)
		{
			var newPod = new Pod(new List<Container>
			{
				new Container(newImage, _serviceProvider.GetRequiredService<ILogger<Container>>())
			});
			await newPod.Create();
			ManagedPods.Add(newPod);
			oldPod.Delete();
		}
	}
}
