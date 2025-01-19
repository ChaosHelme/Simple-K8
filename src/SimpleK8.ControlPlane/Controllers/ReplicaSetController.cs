using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SimpleK8.Core;

namespace SimpleK8.ControlPlane.Controllers;

public class ReplicaSetController(
	IApiServer apiServer,
	string initialImage,
	ILogger<ReplicaSetController> logger,
	IServiceProvider serviceProvider) : IController
{
	public List<Pod> ManagedPods { get; private set; } = [];
	
	string _currentImage = initialImage;
	
	public async Task Run(CancellationToken cancellationToken)
	{
		logger.LogInformation("ReplicaSet controller watching for changes...");
		while (!cancellationToken.IsCancellationRequested)
		{
			await Reconcile(cancellationToken);
			await Task.Delay(2500, cancellationToken);
		}
	}
	
	async Task Reconcile(CancellationToken cancellationToken)
	{
		var desiredReplicas = apiServer.GetDesiredReplicaCount();
		var currentReplicas = ManagedPods.Count;

		if (desiredReplicas != currentReplicas)
		{
			logger.LogInformation("Scaling replicas from {currentReplicas} to {desiredReplicas}", currentReplicas, desiredReplicas);
			await ScaleTo(desiredReplicas, cancellationToken);
		}

		// Check for failed pods and replace them
		var failedPods = ManagedPods.Where(p => p.Status == PodStatus.Failed).ToList();
		foreach (var failedPod in failedPods)
		{
			ManagedPods.Remove(failedPod);
			var newPod = new Pod(failedPod.Image, serviceProvider.GetRequiredService<ILogger<Pod>>(), serviceProvider);
			await newPod.Start();
			ManagedPods.Add(newPod);
		}
	}
	
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