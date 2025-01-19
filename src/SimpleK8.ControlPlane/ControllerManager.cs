using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SimpleK8.ControlPlane.Controllers;

namespace SimpleK8.ControlPlane;

public class ControllerManager(IApiServer apiServer, ILogger<ControllerManager> logger, IServiceProvider serviceProvider) : IControllerManager
{
	readonly List<IController> _controllers = [
		new DeploymentController(apiServer, "myapp:v1", 3, serviceProvider.GetRequiredService<ILogger<DeploymentController>>(), serviceProvider),
		new StatefulSetController(apiServer, serviceProvider.GetRequiredService<ILogger<StatefulSetController>>()),
		new ReplicaSetController(apiServer, serviceProvider.GetRequiredService<ILogger<ReplicaSetController>>())
	];

	public void StartControllers(CancellationToken cancellationToken)
	{
		foreach (var controller in _controllers)
		{
			Task.Run(() => controller.Run(cancellationToken), cancellationToken);
		}
		logger.LogInformation("Controllers started");
	}
	
	public void ManageControllers(CancellationToken cancellationToken)
	{
		Task.Run(() =>
		{
			foreach (var controller in _controllers)
			{
				// ToDo: Observer the state of the controllers and manage them...
			}
		}, cancellationToken);
	}
}