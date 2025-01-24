using SimpleK8.DataContracts;

namespace SimpleK8.Cluster;

public interface IDeploymentRepository
{
	Task<Deployment?> GetDeployment(string namespaceName, string deploymentName, CancellationToken cancellationToken);
	Task<DeploymentList?> ListDeployments(string namespaceName, CancellationToken cancellationToken);
	Task<bool> CreateDeployment(string namespaceName, string deploymentName, Deployment deployment, CancellationToken cancellationToken);
}