using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SimpleK8.Core;

namespace SimpleK8.ControlPlane.Controllers;

public class DeploymentController(
	IApiServer apiServer,
	string initialImage, 
	int initialReplicas,
	ILogger<DeploymentController> logger,
	IServiceProvider serviceProvider) : IController
{
	public List<Pod> ManagedPods { get; private set; } = [];
	
	string _currentImage = initialImage;
	int _desiredReplicas = initialReplicas;
	
	public async Task Run(CancellationToken cancellationToken)
	{
		logger.LogInformation("Deployment controller watching for changes...");
		while (!cancellationToken.IsCancellationRequested)
		{
			if (ManagedPods.Count != _desiredReplicas)
			{
				await ScaleTo(_desiredReplicas, cancellationToken);	
			}
			await Task.Delay(1000, cancellationToken);
		}
	}
	
	public async Task UpdateImage(string newImage)
	{
		logger.LogInformation("Updating image to {newImage}", newImage);
		_currentImage = newImage;
		var oldPods = new List<Pod>(ManagedPods);
		ManagedPods.Clear();

		foreach (var oldPod in oldPods)
		{
			var newPod = new Pod(_currentImage, serviceProvider.GetRequiredService<ILogger<Pod>>(), serviceProvider);
			await newPod.Start();
			ManagedPods.Add(newPod);
			oldPod.Stop();
		}
	}

	public void UpdateReplicaCount(int replicaCount) => _desiredReplicas = replicaCount;
	
	async Task ScaleTo(int replicas, CancellationToken cancellationToken)
	{
		logger.LogInformation("Scaling to {replicas} replicas", replicas);
		while (ManagedPods.Count < replicas)
		{
			var newPod = new Pod(_currentImage, serviceProvider.GetRequiredService<ILogger<Pod>>(), serviceProvider);
			await newPod.Start();
			ManagedPods.Add(newPod);
		}
		while (ManagedPods.Count > replicas)
		{
			var podToRemove = ManagedPods.Last();
			podToRemove.Stop();
			ManagedPods.Remove(podToRemove);
		}

		await Task.Delay(2500, cancellationToken);
	}
}
