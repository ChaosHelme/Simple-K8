using MediatR;
using SimpleK8.Application.Common;
using SimpleK8.Application.Common.Repositories;

namespace SimpleK8.Api.Application.Commands.Handlers;

public class DeleteDeploymentCommandHandler(IDeploymentRepository deploymentRepository) : IRequestHandler<DeleteDeploymentCommand, bool>
{
	public async Task<bool> Handle(DeleteDeploymentCommand request, CancellationToken cancellationToken)
	{
		return await deploymentRepository.DeleteDeployment(request.NamespaceName, request.Name, cancellationToken);
	}
}