using Microsoft.Extensions.Logging;
using SimpleK8.Core;

namespace SimpleK8.ControlPlane;

public class ApiServer(IStore store, ILogger<ApiServer> logger) : IApiServer
{
	public void HandleRequest(string request)
	{
		logger.LogInformation("Handling request {request}", request);
	}

	public void UpdatePodStatus(string podId, PodStatus status)
	{
		store.Save($"pod_{podId}_{status}", status.ToString());
	}
}