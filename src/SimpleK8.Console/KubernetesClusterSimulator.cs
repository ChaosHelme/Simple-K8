using System.Net.Http.Json;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Polly;
using Polly.CircuitBreaker;
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
	AsyncPolicy<HttpResponseMessage> _resiliencePolicy;

	public void Init()
	{
		logger.LogInformation("Initializing Kubernetes cluster");
		
		var circuitBreakerPolicy = Policy
			.Handle<HttpRequestException>()
			.CircuitBreakerAsync(
				exceptionsAllowedBeforeBreaking: 5,
				durationOfBreak: TimeSpan.FromSeconds(30)
			);

		var retryPolicy = Policy<HttpResponseMessage>
			.Handle<HttpRequestException>()
			.OrResult(r => !r.IsSuccessStatusCode)
			.WaitAndRetryAsync(3, retryAttempt => 
				TimeSpan.FromSeconds(Math.Pow(2, retryAttempt))
			);
		
		_resiliencePolicy = circuitBreakerPolicy.WrapAsync(retryPolicy);
		
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
		try
		{
			var response = await _resiliencePolicy.ExecuteAsync(async ct =>
					await _apiServerClient!.GetAsync("deployments", cancellationToken: ct),
				cancellationToken);

			if (!response.IsSuccessStatusCode)
			{
				return null;
			}

			return await response.Content.ReadFromJsonAsync<DeploymentList>(cancellationToken: cancellationToken);
		}
		catch (BrokenCircuitException)
		{
			// Log the circuit breaker open state
			logger.LogWarning("Circuit breaker is open. Deployment service is currently unavailable.");
			throw;
		}
		catch (HttpRequestException ex)
		{
			// Log the exception
			logger.LogError($"An error occurred while fetching deployment collections: {ex.Message}");
			return null;
		}
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