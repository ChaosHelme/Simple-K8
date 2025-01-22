using SimpleK8.ControlPlane.Controllers.Deployment;
using SimpleK8.Core;
using SimpleK8.DataContracts;

namespace SimpleK8.ControlPlane;

public interface IApiServer
{
	List<Deployment> GetDesiredDeployments();
	Task<List<Deployment>?> GetCurrentDeployments();
	void ApplyDeploymentDifferences(List<DeploymentDifference> diff);
	void SetDesiredReplicaCount(int diffDesiredReplicas);
	int GetDesiredReplicaCount();
	void SetDesiredImage(string newImage);
	void DeleteReplicaSet(string deploymentName);
	int GetReplicaCount(string deploymentName);
	void SetReplicaSet(string deploymentName, int p1);
	void UpdateDeploymentStatus(string deploymentName, DeploymentStatus status);
	void UpdateDeployment(Deployment deployment);
}