using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SimpleK8.Core;

namespace SimpleK8.Console;

public class HostedService(ILogger<HostedService> logger, IHostApplicationLifetime appLifetime, IServiceProvider serviceProvider) : IHostedService
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
					var registry = serviceProvider.GetRequiredService<IServiceRegistry>();
					var loadBalancer = new LoadBalancer(registry);
					var deployment = new DeploymentController(serviceProvider.GetRequiredService<ILogger<DeploymentController>>(),
						serviceProvider, "myapp:v1", 3);

					foreach (var pod in deployment.ManagedPods)
					{
						registry.Register("myapp", pod);
					}

					for (var i = 0; i < 10; i++)
					{
						var pod = loadBalancer.GetNextPod("myapp");
						if (pod == null)
						{
							System.Console.WriteLine($"No pod found for {i}");
						}
						System.Console.WriteLine($"Request routed to pod {pod.Id}");
					}

					await deployment.Scale(5);

					await deployment.UpdateImage("myapp:v2");
					
					System.Console.WriteLine($"Simulation completed");
					
					_exitCode = 0;
				}
				catch (Exception ex)
				{
					logger.LogError(ex, "Unhandled exception!");
					_exitCode = 1;
				}
				finally
				{
					// Stop the application once the work is done
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