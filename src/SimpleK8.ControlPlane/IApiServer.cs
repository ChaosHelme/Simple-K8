using SimpleK8.Core;

namespace SimpleK8.ControlPlane;

public interface IApiServer
{
	void HandleRequest(string request);
	List<Deployment> GetDesiredDeployments();
	List<Deployment> GetCurrentDeployments();
	void ApplyDeploymentDifferences(List<DeploymentDifference> diff);
}