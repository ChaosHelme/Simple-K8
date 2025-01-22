using MediatR;
using SimpleK8.DataContracts;

namespace SimpleK8.Cluster.Queries.Handlers;

public class GetDeploymentQueryHandler(IDeploymentRepository deploymentRepository) : IRequestHandler<GetDeploymentQuery, Deployment?> {
	public async Task<Deployment?> Handle(GetDeploymentQuery request, CancellationToken cancellationToken)
	{
		return await deploymentRepository.GetDeployment(request.NamespaceName, request.DeploymentName);
	}
}