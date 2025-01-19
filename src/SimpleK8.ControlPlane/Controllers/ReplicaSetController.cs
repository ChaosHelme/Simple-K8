using Microsoft.Extensions.Logging;

namespace SimpleK8.ControlPlane.Controllers;

public class ReplicaSetController(IApiServer apiServer, ILogger<ReplicaSetController> logger) : IController
{
	public async Task Run(CancellationToken cancellationToken)
	{
		while (!cancellationToken.IsCancellationRequested)
		{
			await Task.Delay(2500, cancellationToken);
			logger.LogInformation("ReplicaSet controller watching for changes...");
		}
	}
}