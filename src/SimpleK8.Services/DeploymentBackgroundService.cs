using System.Net.Http.Json;
using SimpleK8.Core.DataContracts;

namespace SimpleK8.Services;

public class DeploymentBackgroundService(
	KubernetesHttpClientFactory httpClientFactory,
	ILogger<DeploymentBackgroundService> logger) : BackgroundService
{
	int _executionCount;
	HttpClient? _httpClient;
	HttpClient HttpClient => _httpClient ??= httpClientFactory.CreateClient();
	
	protected override async Task ExecuteAsync(CancellationToken stoppingToken)
	{
		logger.LogInformation("Timed Hosted Service running.");
		
		using PeriodicTimer timer = new(TimeSpan.FromSeconds(5));
		
		try
		{
			while (await timer.WaitForNextTickAsync(stoppingToken))
			{
				await ManageDeployments(stoppingToken);
			}
		}
		catch (OperationCanceledException)
		{
			logger.LogInformation("Timed Hosted Service is stopping.");
		}
	}
	
	async Task ManageDeployments(CancellationToken cancellationToken)
	{
		var count = Interlocked.Increment(ref _executionCount);
		logger.LogInformation("Timed Hosted Service is working. Count: {Count}", count);
		
		var deploymentList = await HttpClient.GetFromJsonAsync<DeploymentList>("deployments", cancellationToken);
		logger.LogInformation("Found {Count} deployments", deploymentList.Items.Count);
		foreach (var deployment in deploymentList.Items)
		{
			logger.LogInformation("Managing deployment: {Name}", deployment.Metadata.FullName);
			var diff = deployment.DetermineDiff();
			
		}
	}

	public override void Dispose()
	{
		_httpClient?.Dispose();
		base.Dispose();
	}
}