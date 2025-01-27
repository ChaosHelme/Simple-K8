using System.Net.Http.Json;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SimpleK8.DataContracts;
using SimpleK8.Worker;

namespace SimpleK8.Console;

public class KubernetesClusterSimulator(
	ILogger<KubernetesClusterSimulator> logger,
	IServiceProvider serviceProvider) : IDisposable
{
	public List<IWorkerNode> WorkerNodes { get; } = [];

	HttpClient? _apiServerClient;
	bool _initialized;

	readonly TimeSpan _waitTimeSpan = TimeSpan.FromSeconds(5);

	public void Init()
	{
		logger.LogInformation("Initializing Kubernetes cluster");
		
		_apiServerClient = new HttpClient();
		_apiServerClient.BaseAddress = new Uri("http://localhost:5077/apis/app/v1/");
		_initialized = true;
	}
	
	public void AddWorkerNode(string nodeName)
	{
		WorkerNodes.Add(new WorkerNode(nodeName, serviceProvider.GetRequiredService<ILogger<WorkerNode>>()));
		logger.LogInformation("Added worker node: {nodeName}", nodeName);
	}
	
	public async Task RunClusterAsync(CancellationToken token)
	{
		logger.LogInformation("Starting cluster simulation");
		if (!_initialized)
		{
			Init();
		}

		var deploymentList = DeploymentList.Empty;
		while (deploymentList is null || deploymentList.Items.Count <= 0 || token.IsCancellationRequested)
		{
			logger.LogInformation("Fetching deployment list...");
			deploymentList = await GetDeploymentCollections(token);
			if (deploymentList is not null && deploymentList.Items.Count > 0)
			{
				break;
			}
			await Task.Delay(_waitTimeSpan, token);
		}
		
		logger.LogInformation("Received {count} deployment items", deploymentList.Items.Count);
		foreach (var deployment in deploymentList.Items)
		{
			// ToDo...
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

	async Task<DeploymentList?> GetDeploymentCollections(CancellationToken cancellationToken)
	{
		return await _apiServerClient!.GetFromJsonAsync<DeploymentList>("deployments", cancellationToken: cancellationToken);
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

	public void Dispose()
	{
		_apiServerClient?.Dispose();
	}
}