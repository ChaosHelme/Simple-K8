using MediatR;
using SimpleK8.Core.DataContracts;

namespace SimpleK8.Cluster.Commands.Handlers;

public class UpdateDeploymentCommandHandler(IDeploymentRepository deploymentRepository) : IRequestHandler<UpdateDeploymentCommand, Deployment?>
{
	public async Task<Deployment?> Handle(UpdateDeploymentCommand request, CancellationToken cancellationToken)
	{
		return await deploymentRepository.UpdateDeployment(request.NamespaceName, request.Name, request.Update, cancellationToken);
	}
}