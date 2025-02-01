using System.Net.Http.Json;
using Microsoft.Extensions.Logging;
using SimpleK8.DataContracts;

namespace SimpleK8.Simulation.Console;

public class DeploymentSimulator(
	IHttpClientFactory httpClientFactory,
	ILogger<DeploymentSimulator> logger) : IDisposable
{
	HttpClient? _apiServerClient;
	bool _initialized;

	public void Init()
	{
		logger.LogInformation("Initializing Deployment Simulator");
		
		_apiServerClient = httpClientFactory.CreateClient("kubernetes");
		_initialized = true;
	}

	public async Task RunAsync(CancellationToken cancellationToken)
	{
		logger.LogInformation("Starting Deployment Simulator");

		if (!_initialized)
		{
			Init();
		}
		
		var deployment = CreateDeployment();
		
		var response = await _apiServerClient!.PostAsJsonAsync("deployments", deployment, cancellationToken);
		response.EnsureSuccessStatusCode();
	}

	static Deployment CreateDeployment()
	{
		var deployment = new Deployment(
			"v1",
			"deployment",
			new ObjectMetadata(
				Guid.NewGuid(), 
				"test",
				"default"),
			new DeploymentSpec(
				5,
				0,
				5,
				2,
				2,
				new LabelSelector(),
				new DeploymentStrategie(),
				new PodTemplateSpec()));

		return deployment;
	}

	public void Dispose()
	{
		_apiServerClient?.Dispose();
	}
}