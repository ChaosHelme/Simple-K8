using MediatR;
using SimpleK8.DataContracts;

namespace SimpleK8.Cluster.Queries.Handlers;

public class ListDeploymentsQueryHandler(IDeploymentRepository deploymentRepository) : IRequestHandler<ListDeploymentsQuery, DeploymentList>
{
	public async Task<DeploymentList> Handle(ListDeploymentsQuery request, CancellationToken cancellationToken)
	{
		var deploymentList = await deploymentRepository.ListDeployments(request.NamespaceName, cancellationToken);
		return deploymentList ?? DeploymentList.Empty;	
	}
}