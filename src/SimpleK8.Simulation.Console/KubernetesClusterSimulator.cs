using System.Net.Http.Json;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SimpleK8.DataContracts;
using SimpleK8.Worker;

namespace SimpleK8.Simulation.Console;

public class KubernetesClusterSimulator(
	IHttpClientFactory httpClientFactory,
	ILogger<KubernetesClusterSimulator> logger,
	IServiceProvider serviceProvider) : IDisposable
{
	public List<IWorkerNode> WorkerNodes { get; } = [];

	HttpClient? _apiServerClient;
	bool _initialized;
	DeploymentSimulator? _deploymentSimulator;
	
	public void Init()
	{
		logger.LogInformation("Initializing Kubernetes cluster");
		
		_deploymentSimulator = new DeploymentSimulator(
			httpClientFactory, 
			serviceProvider.GetRequiredService<ILogger<DeploymentSimulator>>());

		_apiServerClient = httpClientFactory.CreateClient("kubernetes");
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

			await _deploymentSimulator!.RunAsync(token);
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

	async ValueTask<DeploymentList?> GetDeploymentCollections(CancellationToken cancellationToken)
	{ 
		var response = await _apiServerClient!.GetAsync("deployments", cancellationToken: cancellationToken);
		response.EnsureSuccessStatusCode();

		return await response.Content.ReadFromJsonAsync<DeploymentList>(cancellationToken: cancellationToken);
		
		// try
		// {
		// 	return await _resiliencePipeline!.ExecuteAsync(static async (state, ct) =>
		// 	{
		// 		var response = await state!.GetAsync("deployments", cancellationToken: ct);
		// 		response.EnsureSuccessStatusCode();
		//
		// 		return await response.Content.ReadFromJsonAsync<DeploymentList>(cancellationToken: ct);
		// 	}, _apiServerClient, cancellationToken);
		// }
		// catch (BrokenCircuitException bex)
		// {
		// 	// Log the circuit breaker open state
		// 	logger.LogWarning("Circuit breaker is open. Deployment service is currently unavailable.");
		// 	logger.LogWarning(bex.ToString());
		// 	await Task.Delay(TimeSpan.FromSeconds(5), cancellationToken);
		// 	return null;
		// }
		// catch (HttpRequestException ex)
		// {
		// 	// Log the exception
		// 	logger.LogError($"An error occurred while fetching deployment collections: {ex.Message}");
		// 	return null;
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

	public void Dispose()
	{
		_apiServerClient?.Dispose();
	}
}