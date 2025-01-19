using Microsoft.Extensions.Logging;
using SimpleK8.Core;

namespace SimpleK8.ControlPlane;

public class ApiServer(IStore store, ILogger<ApiServer> logger) : IApiServer
{
	public void HandleRequest(string request)
	{
		logger.LogInformation("Handling request {request}", request);
	}

	public List<Deployment> GetDesiredDeployments() => throw new NotImplementedException();

	public List<Deployment> GetCurrentDeployments() => throw new NotImplementedException();
	public void ApplyDeploymentChange(DeploymentDifference diff)
	{
		throw new NotImplementedException();
	}

	public void UpdatePodStatus(string podId, PodStatus status)
	{
		store.Save($"pod_{podId}_{status}", status.ToString());
	}
}