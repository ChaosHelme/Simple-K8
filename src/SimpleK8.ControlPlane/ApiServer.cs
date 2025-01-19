using Microsoft.Extensions.Logging;
using SimpleK8.Core;

namespace SimpleK8.ControlPlane;

public class ApiServer(IStore store, ILogger<ApiServer> logger) : IApiServer
{
	public void HandleRequest(string request)
	{
		logger.LogInformation("Handling request {request}", request);
	}

	public List<Deployment> GetDesiredDeployments()
	{
		return new List<Deployment>();
	}

	public List<Deployment> GetCurrentDeployments()
	{
		return new List<Deployment>();
	}
	
	public void ApplyDeploymentDifferences(List<DeploymentDifference> diff)
	{
		foreach (var deploymentDifference in diff)
		{
			store.Save($"deployment_{deploymentDifference.Id}_image", deploymentDifference.Image);
			store.Save($"deployment_{deploymentDifference.Id}_replica", deploymentDifference.Replicas.ToString());
		}
	}

	public void UpdatePodStatus(string podId, PodStatus status)
	{
		store.Save($"pod_{podId}_{status}", status.ToString());
	}
}