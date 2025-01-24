using MediatR;

namespace SimpleK8.Cluster.Commands.Handlers;

public class DeleteDeploymentCollectionCommandHandler(IDeploymentRepository deploymentRepository) : IRequestHandler<DeleteDeploymentCollectionCommand, bool>
{
	public async Task<bool> Handle(DeleteDeploymentCollectionCommand request, CancellationToken cancellationToken)
	{
		return await deploymentRepository.DeleteDeploymentCollection(request.NamespaceName, cancellationToken);
	}
}