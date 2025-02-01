using MediatR;

namespace SimpleK8.Cluster.Commands.Handlers;

public class CreateDeploymentCommandHandler(IDeploymentRepository deploymentRepository) : IRequestHandler<CreateDeploymentCommand, bool>
{
	public async Task<bool> Handle(CreateDeploymentCommand request, CancellationToken cancellationToken)
	{
		return await deploymentRepository.CreateDeployment(request.Deployment, cancellationToken);
	}
}