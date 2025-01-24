using MediatR;
using SimpleK8.DataContracts;

namespace SimpleK8.Cluster.Queries.Handlers;

public class ListDeploymentNamespacesQueryHandler(IDeploymentRepository deploymentRepository) 
	: IRequestHandler<ListDeploymentNamespacesQuery, DeploymentList>
{
	public async Task<DeploymentList> Handle(ListDeploymentNamespacesQuery request, CancellationToken cancellationToken)
	{
		return await deploymentRepository.ListDeploymentNamespaces(cancellationToken);
	}
}