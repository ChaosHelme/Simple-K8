using MediatR;
using SimpleK8.Application.Common;
using SimpleK8.Application.Common.Mapper;
using SimpleK8.Application.Common.Repositories;
using SimpleK8.Core.DataContracts;

namespace SimpleK8.Api.Application.Commands.Handlers;

public class CreateDeploymentCommandHandler(IDeploymentRepository deploymentRepository) : IRequestHandler<CreateDeploymentCommand, Deployment>
{
	public async Task<Deployment> Handle(CreateDeploymentCommand request, CancellationToken cancellationToken)
	{
		var deployment = DeploymentMapper.CreateDeploymentRequestToDeployment(request.DeploymentRequest);
		deployment.ApiVersion = request.ApiVersion;
		deployment.Kind = request.Kind;
		deployment.Status.UnavailableReplicas = deployment.Spec.Replicas;
		
		await deploymentRepository.CreateDeployment(deployment, cancellationToken);
		return deployment;
	}
}