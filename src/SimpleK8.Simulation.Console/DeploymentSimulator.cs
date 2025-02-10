using System.Net.Http.Json;
using Microsoft.Extensions.Logging;
using SimpleK8.Core.DataContracts;
using Container = SimpleK8.Core.DataContracts.Container;

namespace SimpleK8.Simulation.Console;

public sealed class DeploymentSimulator : IDisposable
{
	readonly HttpClient _apiServerClient;
	readonly ILogger<DeploymentSimulator> _logger;
	
	public DeploymentSimulator(
		KubernetesHttpClientFactory httpClientFactory,
		ILogger<DeploymentSimulator> logger)
	{
		_logger = logger;
		
		_logger.LogInformation("Initializing Deployment Simulator");
		
		_apiServerClient = httpClientFactory.CreateClient();
	}
	
	public async Task CreateDeploymentAsync(CancellationToken cancellationToken)
	{
		_logger.LogInformation("Starting Deployment Simulator");
		
		var deployment = CreateDeployment();
		
		var response = await _apiServerClient!.PostAsJsonAsync("deployments", deployment, cancellationToken);
		response.EnsureSuccessStatusCode();
	}
	
	public async ValueTask<DeploymentList?> GetDeploymentListAsync(CancellationToken cancellationToken)
	{ 
		var response = await _apiServerClient!.GetAsync("deployments", cancellationToken: cancellationToken);
		response.EnsureSuccessStatusCode();

		return await response.Content.ReadFromJsonAsync<DeploymentList>(cancellationToken: cancellationToken);
	}

	public async ValueTask<Deployment?> GetDeploymentAsync(string @namespace, string name, CancellationToken cancellationToken)
	{
		var response = await _apiServerClient!.GetAsync($"namespaces/{@namespace}/deployments/{name}", cancellationToken: cancellationToken);
		response.EnsureSuccessStatusCode();
		
		return await response.Content.ReadFromJsonAsync<Deployment>(cancellationToken: cancellationToken);
	}

	public async ValueTask<DeploymentStatus?> GetDeploymentStatusAsync(string @namespace, string name, CancellationToken cancellationToken)
	{
		var deployment = await GetDeploymentAsync(@namespace, name, cancellationToken);
		return deployment?.Status;
	}

	static Deployment CreateDeployment()
	{
		var deployment = new Deployment("v1",
			"deployment",
			new ObjectMetadata(Guid.NewGuid(),
				"test",
				"default"),
			new DeploymentSpec(5,
				0,
				5,
				2,
				2,
				new LabelSelector(),
				new DeploymentStrategie(),
				new PodTemplateSpec(new ObjectMetadata(Guid.NewGuid(),
						"testPodTemplateSpec",
						"default"),
					new PodSpec([
							new Container([], [], [], "", ""),
						],
						[], "testNodeName"))));

		return deployment;
	}

	public void Dispose()
	{
		_apiServerClient?.Dispose();
	}
}