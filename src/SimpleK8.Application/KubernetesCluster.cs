using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SimpleK8.ControlPlane;
using SimpleK8.Core;
using SimpleK8.Worker;

namespace SimpleK8.Cluster;

public class KubernetesCluster(
	IApiServer apiServer,
	IStore store,
	IControllerManager controllerManager,
	IScheduler scheduler,
	ILogger<KubernetesCluster> logger,
	IServiceProvider serviceProvider)
{
	public List<IWorkerNode> WorkerNodes { get; } = [];

	readonly TimeSpan _waitTimeSpan = TimeSpan.FromSeconds(5);
	
	public void AddWorkerNode(string nodeName)
	{
		WorkerNodes.Add(new WorkerNode(nodeName, serviceProvider.GetRequiredService<ILogger<WorkerNode>>()));
		logger.LogInformation($"Added worker node: {nodeName}");
	}

	public async Task CreatePod(string image)
	{
		var pod = new Pod(image, serviceProvider.GetRequiredService<ILogger<Pod>>(), serviceProvider);
		controllerManager.AddPod(pod);
		scheduler.SchedulePod(pod, WorkerNodes, serviceProvider.GetRequiredService<ILogger<Scheduler>>());

		if (!string.IsNullOrEmpty(pod.AssignedNode))
		{
			var node = WorkerNodes.First(n => n.Name == pod.AssignedNode);
			await node.RunPod(pod);
		}
	}

	public async Task RunCluster(CancellationToken token)
	{
		while (!token.IsCancellationRequested)
		{
			apiServer.HandleRequest("Sample request");
			store.Save("config", "cluster_config");
			controllerManager.ManageControllers();
			
			await CreatePod("myapp:v1");

			if (WorkerNodes.Any(n => n.Pods.Any()))
			{
				var randomNode = WorkerNodes[new Random().Next(WorkerNodes.Count)];
				if (randomNode.Pods.Any())
				{
					var randomPod = randomNode.Pods[new Random().Next(randomNode.Pods.Count)];
					randomPod.SimulateFailure();
				}
			}
			
			await Task.Delay(_waitTimeSpan, token);
		}
	}
}