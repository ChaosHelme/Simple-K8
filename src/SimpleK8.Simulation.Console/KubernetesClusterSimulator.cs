using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SimpleK8.Core.DataContracts;
using SimpleK8.Worker;

namespace SimpleK8.Simulation.Console;

public sealed class KubernetesClusterSimulator
{
	public List<IWorkerNode> WorkerNodes { get; } = [];

	readonly DeploymentSimulator _deploymentSimulator;
	readonly ILogger<KubernetesClusterSimulator> _logger;
	readonly IServiceProvider _serviceProvider;
	
	public KubernetesClusterSimulator(KubernetesHttpClientFactory httpClientFactory,
		ILogger<KubernetesClusterSimulator> logger,
		IServiceProvider serviceProvider)
	{
		_logger = logger;
		_serviceProvider = serviceProvider;
		
		_logger.LogInformation("Initializing Kubernetes cluster");
		
		_deploymentSimulator = new DeploymentSimulator(
			httpClientFactory,
			_serviceProvider.GetRequiredService<ILogger<DeploymentSimulator>>());
	}
	
	public void AddWorkerNode(string nodeName)
	{
		WorkerNodes.Add(new WorkerNode(nodeName, _serviceProvider.GetRequiredService<ILogger<WorkerNode>>()));
		_logger.LogInformation("Added worker node: {NodeName}", nodeName);
	}
	
	public async Task RunClusterAsync(CancellationToken token)
	{
		_logger.LogInformation("Starting cluster simulation");

		DeploymentList? deploymentList = null;
		while (deploymentList is null || deploymentList.Items.Count <= 0 || token.IsCancellationRequested)
		{
			_logger.LogInformation("Fetching deployment list...");
			deploymentList = await _deploymentSimulator.GetDeploymentListAsync(token);
			if (deploymentList is not null && deploymentList.Items.Count > 0)
			{
				break;
			}

			await _deploymentSimulator.CreateDeploymentAsync(token);
		}
		
		_logger.LogInformation("Received {Count} deployment items", deploymentList.Items.Count);
		foreach (var deployment in deploymentList.Items)
		{
			_logger.LogInformation("Processing deployment: {Deployment}", deployment);
			var deploymentStatus = await _deploymentSimulator!.GetDeploymentStatusAsync(deployment.Metadata.Name, deployment.Metadata.Name, token);
			if (deploymentStatus is not null)
			{
				var diff = deployment.DetermineDiff(deploymentStatus);
				_logger.LogInformation("Processing differences: {Diff}", diff);
			}
		}

		// controllerManager.StartControllers(token);
		//
		// while (!token.IsCancellationRequested)
		// {
		// 	controllerManager.ManageControllers(token);
		// 	
		// 	await CreatePod("myapp:v1");
		//
		// 	if (WorkerNodes.Any(n => n.Pods.Any()))
		// 	{
		// 		var randomNode = WorkerNodes[new Random().Next(WorkerNodes.Count)];
		// 		if (randomNode.Pods.Count != 0)
		// 		{
		// 			var randomPod = randomNode.Pods[new Random().Next(randomNode.Pods.Count)];
		// 			randomPod.SimulateFailure();
		// 		}
		// 	}
		// 	
		// 	await Task.Delay(_waitTimeSpan, token);
		// }
	}

	async Task CreatePod(string image)
	{
		// var pod = new Pod(image, serviceProvider.GetRequiredService<ILogger<Pod>>(), serviceProvider);
		// scheduler.SchedulePod(pod, WorkerNodes, serviceProvider.GetRequiredService<ILogger<Scheduler>>());
		//
		// if (!string.IsNullOrEmpty(pod.AssignedNode))
		// {
		// 	var node = WorkerNodes.First(n => n.Name == pod.AssignedNode);
		// 	await node.RunPod(pod);
		// }
	}
}