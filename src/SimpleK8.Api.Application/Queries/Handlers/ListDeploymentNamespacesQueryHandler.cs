using MediatR;
using SimpleK8.Application.Common;
using SimpleK8.Application.Common.Repositories;
using SimpleK8.Core.DataContracts;

namespace SimpleK8.Api.Application.Queries.Handlers;

public class ListDeploymentNamespacesQueryHandler(IDeploymentRepository deploymentRepository) 
	: IRequestHandler<ListDeploymentNamespacesQuery, DeploymentList>
{
	public async Task<DeploymentList> Handle(ListDeploymentNamespacesQuery request, CancellationToken cancellationToken)
	{
		return await deploymentRepository.ListDeploymentNamespaces(cancellationToken);
	}
}