using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace SimpleK8.Console;

public class HostedService(
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
			Task.Run(async () =>
			{
				try
				{
					var cluster = new KubernetesClusterSimulator(
						serviceProvider.GetRequiredService<ILogger<KubernetesClusterSimulator>>(),
						serviceProvider);
					
					cluster.Init();	
					
					cluster.AddWorkerNode("worker-1");
					cluster.AddWorkerNode("worker-2");

					await cluster.RunCluster(cancellationToken);

					logger.LogInformation($"Simulation completed");

					_exitCode = 0;
				}
				catch (Exception ex)
				{
					logger.LogError(ex, "Unhandled exception!");
					_exitCode = 1;
				}
				finally
				{
					appLifetime.StopApplication();
				}
			}, cancellationToken);
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