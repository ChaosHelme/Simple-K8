using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace SimpleK8.Console;

public class HostedService(
	IHttpClientFactory httpClientFactory,
	ILogger<HostedService> logger,
	IHostApplicationLifetime appLifetime,
	IServiceProvider serviceProvider) : IHostedService
{
	int? _exitCode;
	
	public Task StartAsync(CancellationToken cancellationToken)
	{
		logger.LogDebug("Starting with arguments: {arguments}", string.Join(" ", Environment.GetCommandLineArgs()));

		appLifetime.ApplicationStarted.Register(() =>
		{
			var cluster = new KubernetesClusterSimulator(httpClientFactory, serviceProvider.GetRequiredService<ILogger<KubernetesClusterSimulator>>(),
				serviceProvider);
			
			try
			{
				cluster.Init();
				
				cluster.RunClusterAsync(cancellationToken).Wait(cancellationToken);
				logger.LogInformation($"Simulation completed");

				_exitCode = 0;
			} catch (OperationCanceledException ex)
			{
				logger.LogInformation("Operation cancelled!");
				_exitCode = 0;
			} catch (AggregateException aggEx)
			{
				if (aggEx.InnerExceptions.Any(ex => ex is OperationCanceledException))
				{
					logger.LogInformation("Operation cancelled!");
					_exitCode = 0;
				} else
				{
					logger.LogError(aggEx, "An unexpected error occured!");
					_exitCode = 1;
				}
			} finally
			{
				appLifetime.StopApplication();
			}
		});

		return Task.CompletedTask;
	}

	public Task StopAsync(CancellationToken cancellationToken)
	{
		// Exit code may be null if the user cancelled via Ctrl+C/SIGTERM
		Environment.ExitCode = _exitCode.GetValueOrDefault(-1);
		return Task.CompletedTask;
	}
}