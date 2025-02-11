using MediatR;
using SimpleK8.Core.DataContracts;

namespace SimpleK8.Application.Commands.Handlers;

public class CreateDeploymentCommandHandler(IDeploymentRepository deploymentRepository) : IRequestHandler<CreateDeploymentCommand, Deployment>
{
	public async Task<Deployment> Handle(CreateDeploymentCommand request, CancellationToken cancellationToken)
	{
		var deployment = new Deployment
		{
			ApiVersion = request.ApiVersion,
			Kind = request.Kind,
			Metadata = new ObjectMeta
			{
				Uid = Guid.CreateVersion7(DateTimeOffset.UtcNow).ToString(),
				Name = request.DeploymentRequest.Name,
				Namespace = request.DeploymentRequest.Namespace,
			},
		};
		await deploymentRepository.CreateDeployment(deployment, cancellationToken);
		return deployment;
	}
}