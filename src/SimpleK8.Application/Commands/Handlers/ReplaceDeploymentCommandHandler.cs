using MediatR;
using SimpleK8.Core.DataContracts;

namespace SimpleK8.Cluster.Commands.Handlers;

public class ReplaceDeploymentCommandHandler(IDeploymentRepository deploymentRepository) : IRequestHandler<ReplaceDeploymentCommand, Deployment?>
{
	public async Task<Deployment?> Handle(ReplaceDeploymentCommand request, CancellationToken cancellationToken)
	{
		return await deploymentRepository.ReplaceDeployment(request.NamespaceName, request.Name, request.Deployment, cancellationToken);
	}
}