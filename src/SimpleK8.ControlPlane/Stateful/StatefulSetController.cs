using Microsoft.Extensions.Logging;
using SimpleK8.ControlPlane.Controllers;

namespace SimpleK8.ControlPlane.Stateful;

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