using SimpleK8.DataContracts;
using SimpleK8.DataContracts.Dtos;

namespace SimpleK8.Cluster;

public interface IDeploymentRepository
{
	Task<Deployment?> GetDeployment(string namespaceName, string deploymentName, CancellationToken cancellationToken);
	Task<DeploymentList> ListDeployments(string namespaceName, CancellationToken cancellationToken);
	Task<bool> CreateDeployment(Deployment deployment, CancellationToken cancellationToken);
	Task<Deployment?> UpdateDeployment(string requestNamespaceName, string requestName, DeploymentUpdateDto requestUpdate, CancellationToken cancellationToken);
	Task<DeploymentList> ListDeploymentNamespaces(CancellationToken cancellationToken);
	Task<Deployment?> ReplaceDeployment(string requestNamespaceName, string requestName, Deployment requestDeployment, CancellationToken cancellationToken);
	Task<bool> DeleteDeployment(string requestNamespaceName, string requestName, CancellationToken cancellationToken);
	Task<bool> DeleteDeploymentCollection(string requestNamespaceName, CancellationToken cancellationToken);
}