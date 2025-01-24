using SimpleK8.DataContracts;

namespace SimpleK8.Cluster;

public interface IDeploymentRepository
{
	Task<Deployment?> GetDeployment(string namespaceName, string deploymentName);
	Task<bool> CreateDeployment(string namespaceName, string deploymentName, Deployment deployment);
}