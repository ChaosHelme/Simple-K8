using MediatR;

namespace SimpleK8.Cluster.Commands.Handlers;

public class DeleteDeploymentCommandHandler(IDeploymentRepository deploymentRepository) : IRequestHandler<DeleteDeploymentCommand, bool>
{
	public async Task<bool> Handle(DeleteDeploymentCommand request, CancellationToken cancellationToken)
	{
		return await deploymentRepository.DeleteDeployment(request.NamespaceName, request.Name, cancellationToken);
	}
}