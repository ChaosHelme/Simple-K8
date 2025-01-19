using Microsoft.Extensions.Logging;

namespace SimpleK8.ControlPlane.Controllers;

public class StatefulSetController(IApiServer apiServer, ILogger<StatefulSetController> logger) : IController
{
	public async Task Run(CancellationToken cancellationToken)
	{
		while (!cancellationToken.IsCancellationRequested)
		{
			await Task.Delay(2500, cancellationToken);
			logger.LogInformation("StatefulSet controller watching for changes...");
		}
	}
}