using MediatR;
using SimpleK8.Core.DataContracts;

namespace SimpleK8.Application.Queries.Handlers;

public class ListDeploymentsQueryHandler(IDeploymentRepository deploymentRepository) : IRequestHandler<ListDeploymentsQuery, DeploymentList?>
{
	public async Task<DeploymentList?> Handle(ListDeploymentsQuery request, CancellationToken cancellationToken)
	{
		return await deploymentRepository.ListDeployments(request.NamespaceName, cancellationToken);
	}
}