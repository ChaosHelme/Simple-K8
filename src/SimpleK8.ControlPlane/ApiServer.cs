using Microsoft.Extensions.Logging;
using SimpleK8.ControlPlane.Controllers.Deployment;
using SimpleK8.Core;

namespace SimpleK8.ControlPlane;

public class ApiServer(IStore store, ILogger<ApiServer> logger) : IApiServer
{
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
	
	public void DeleteReplicaSet(string deploymentName)
	{
		store.Delete($"deployment_{deploymentName}_replica");
	}
	public int GetReplicaCount(string deploymentName) => int.Parse(store.Get($"deployment_{deploymentName}_replica") ?? string.Empty);

	public void SetReplicaSet(string deploymentName, int replicaCount)
	{
		store.Save($"deployment_{deploymentName}_replica", replicaCount.ToString());
	}
	public void UpdateDeploymentStatus(string deploymentName, DeploymentStatus status)
	{
		store.Save($"deployment_{deploymentName}_status", status.ToString());
	}
	public void UpdateDeployment(Deployment deployment)
	{
		store.Save($"deployment_{deployment.Name}_replica", deployment.ReplicaCount.ToString());
		store.Save($"deployment_{deployment.Name}_image", deployment.Image);
	}

	public void UpdatePodStatus(string podId, PodStatus status)
	{
		store.Save($"pod_{podId}_{status}", status.ToString());
	}
}