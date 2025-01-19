// using Microsoft.Extensions.DependencyInjection;
// using Microsoft.Extensions.Logging;
//
// namespace SimpleK8.Core;
//
// public class DeploymentController
// {
// 	public List<Pod> ManagedPods { get; private set; } = [];
//
// 	string _currentImage;
// 	Task _autoHealingTask;
// 	CancellationTokenSource _autoHealingCts;
// 	
// 	readonly ILogger<DeploymentController> _logger;
// 	readonly IServiceProvider _serviceProvider;
// 	public DeploymentController(ILogger<DeploymentController> logger, IServiceProvider serviceProvider, string initialImage, int initialReplicas)
// 	{
// 		_logger = logger;
// 		_serviceProvider = serviceProvider;
// 		_currentImage = initialImage;
// 		
// 		_autoHealingCts = new CancellationTokenSource();
// 		_autoHealingTask = StartAutoHealing(_autoHealingCts.Token);
// 		Scale(initialReplicas).Wait();
// 	}
//
// 	public void StopAutoHealing()
// 	{
// 		_autoHealingCts.Cancel();
// 		try
// 		{
// 			_autoHealingTask.Wait();
// 		} 
// 		catch (AggregateException ae)
// 		{
// 			if (ae.InnerException is TaskCanceledException)
// 			{
// 				_logger.LogInformation("Auto healing task was cancelled.");
// 				return;
// 			}
// 			_logger.LogError(ae, "Auto healing task was cancelled.");
// 		}
// 	}
//
// 	public async Task Scale(int replicas)
// 	{
// 		_logger.LogInformation($"Scaling to {replicas} replicas");
// 		while (ManagedPods.Count < replicas)
// 		{
// 			var newPod = new Pod([
// 				new Container(_currentImage, _serviceProvider.GetRequiredService<ILogger<Container>>())
// 			], _serviceProvider.GetRequiredService<ILogger<Pod>>());
// 			await newPod.Create();
// 			ManagedPods.Add(newPod);
// 		}
//
// 		while (ManagedPods.Count > replicas)
// 		{
// 			var podToRemove = ManagedPods.Last();
// 			podToRemove.Stop();
// 			ManagedPods.Remove(podToRemove);
// 		}
// 	}
//
// 	public async Task UpdateImage(string newImage)
// 	{
// 		_logger.LogInformation($"Updating image to {newImage}");
// 		_currentImage = newImage;
// 		var oldPods = new List<Pod>(ManagedPods);
// 		ManagedPods.Clear();
//
// 		foreach (var oldPod in oldPods)
// 		{
// 			var newPod = new Pod([
// 				new Container(newImage, _serviceProvider.GetRequiredService<ILogger<Container>>())
// 			], _serviceProvider.GetRequiredService<ILogger<Pod>>());
// 			await newPod.Create();
// 			ManagedPods.Add(newPod);
// 			oldPod.Stop();
// 		}
// 	}
//
// 	public void SimulateRandomFailures(int failureCount)
// 	{
// 		var random = new Random();
// 		for (var i = 0; i < failureCount; i++)
// 		{
// 			if (ManagedPods.Count <= 0)
// 			{
// 				continue;
// 			}
//
// 			var podIndex = random.Next(ManagedPods.Count);
// 			var pod = ManagedPods[podIndex];
// 			if (pod.Containers.Count > 0)
// 			{
// 				var containerIndex = random.Next(pod.Containers.Count);
// 				pod.Containers[containerIndex].SimulateFailure();
// 			}
// 		}
// 	}
// 	
// 	async Task StartAutoHealing(CancellationToken token)
// 	{
// 		while (!token.IsCancellationRequested)
// 		{
// 			await Task.Delay(5000, token);
//
// 			foreach (var pod in ManagedPods)
// 			{
// 				if (pod.HasFailedContainers)
// 				{
// 					await pod.HealFailedContainers();
// 				}
// 			}
// 		}
// 	}
// }
