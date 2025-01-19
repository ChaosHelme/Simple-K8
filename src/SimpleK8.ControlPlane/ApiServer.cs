using Microsoft.Extensions.Logging;
using SimpleK8.ControlPlane.Controllers;
using SimpleK8.ControlPlane.Controllers.Deployment;
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

	int _desiredReplicaCount = 3;
	public void SetDesiredReplicaCount(int diffDesiredReplicas)
	{
		_desiredReplicaCount = diffDesiredReplicas;
	}

	public int GetDesiredReplicaCount() => _desiredReplicaCount;
	public void SetDesiredImage(string newImage)
	{
		throw new NotImplementedException();
	}

	public void CreateReplicaSet(string deploymentName, string deploymentImage, int deploymentReplicaCount)
	{
		throw new NotImplementedException();
	}
	public void DeleteReplicaSet(string deploymentName)
	{
		throw new NotImplementedException();
	}
	public int GetReplicaCount(string currentDeploymentName) => throw new NotImplementedException();

	public void ScaleReplicaSet(string desiredDeploymentName, int p1)
	{
		throw new NotImplementedException();
	}
	public void UpdateDeploymentStatus(string deploymentName, DeploymentStatus status)
	{
		throw new NotImplementedException();
	}
	public void UpdateDeployment(Deployment rollbackDeployment)
	{
		throw new NotImplementedException();
	}

	public void UpdatePodStatus(string podId, PodStatus status)
	{
		store.Save($"pod_{podId}_{status}", status.ToString());
	}
}