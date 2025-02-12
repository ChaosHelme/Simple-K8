using MediatR;
using SimpleK8.Application.Common;
using SimpleK8.Application.Common.Repositories;

namespace SimpleK8.Api.Application.Commands.Handlers;

public class DeleteDeploymentCollectionCommandHandler(IDeploymentRepository deploymentRepository) : IRequestHandler<DeleteDeploymentCollectionCommand, bool>
{
	public async Task<bool> Handle(DeleteDeploymentCollectionCommand request, CancellationToken cancellationToken)
	{
		return await deploymentRepository.DeleteDeploymentCollection(request.NamespaceName, cancellationToken);
	}
}