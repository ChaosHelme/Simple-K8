﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SimpleK8.ControlPlane.Controllers;
using SimpleK8.ControlPlane.Controllers.Deployment;

namespace SimpleK8.ControlPlane;

public class ControllerManager(IApiServer apiServer, ILogger<ControllerManager> logger, IServiceProvider serviceProvider) : IControllerManager
{
	readonly List<IController> _controllers = [
		new DeploymentController(apiServer, serviceProvider.GetRequiredService<ILogger<DeploymentController>>()),
		new StatefulSetController(apiServer, serviceProvider.GetRequiredService<ILogger<StatefulSetController>>()),
		new ReplicaSetController(apiServer, "myapp:v1", serviceProvider.GetRequiredService<ILogger<ReplicaSetController>>(), serviceProvider)
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