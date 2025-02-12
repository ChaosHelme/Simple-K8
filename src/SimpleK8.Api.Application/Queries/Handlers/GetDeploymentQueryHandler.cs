using MediatR;
using SimpleK8.Application.Common;
using SimpleK8.Application.Common.Repositories;
using SimpleK8.Core.DataContracts;

namespace SimpleK8.Api.Application.Queries.Handlers;

public class GetDeploymentQueryHandler(IDeploymentRepository deploymentRepository) : IRequestHandler<GetDeploymentQuery, Deployment?> {
	public async Task<Deployment?> Handle(GetDeploymentQuery request, CancellationToken cancellationToken)
	{
		return await deploymentRepository.GetDeployment(request.NamespaceName, request.DeploymentName, cancellationToken);
	}
}