using SimpleK8.ControlPlane.Controllers;
using SimpleK8.ControlPlane.Controllers.Deployment;
using SimpleK8.Core;

namespace SimpleK8.ControlPlane;

public interface IApiServer
{
	void HandleRequest(string request);
	List<Deployment> GetDesiredDeployments();
	List<Deployment> GetCurrentDeployments();
	void ApplyDeploymentDifferences(List<DeploymentDifference> diff);
	void SetDesiredReplicaCount(int diffDesiredReplicas);
	int GetDesiredReplicaCount();
	void SetDesiredImage(string newImage);
	void CreateReplicaSet(string deploymentName, string deploymentImage, int deploymentReplicaCount);
	void DeleteReplicaSet(string deploymentName);
	int GetReplicaCount(string currentDeploymentName);
	void ScaleReplicaSet(string desiredDeploymentName, int p1);
	void UpdateDeploymentStatus(string deploymentName, DeploymentStatus status);
	void UpdateDeployment(Deployment rollbackDeployment);
}