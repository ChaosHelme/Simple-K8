using Riok.Mapperly.Abstractions;
using SimpleK8.Application.Common.DTOs;
using SimpleK8.Application.Common.Requests;
using SimpleK8.Core.DataContracts;

namespace SimpleK8.Application.Common.Mapper;

[Mapper]
[UseStaticMapper(typeof(ObjectMetaMapper))]
public static partial class DeploymentMapper
{
	[MapperIgnoreTarget(nameof(Deployment.Kind))]
	[MapperIgnoreTarget(nameof(Deployment.ApiVersion))]
	[MapperIgnoreTarget(nameof(Deployment.Status))]
	[MapProperty(nameof(CreateDeploymentRequest.DeploymentSpec), nameof(Deployment.Spec))]
	[MapProperty(nameof(CreateDeploymentRequest.ObjectMetaDto), nameof(Deployment.Metadata))]
	public static partial Deployment CreateDeploymentRequestToDeployment(CreateDeploymentRequest deployment);
	
	public static partial DeploymentSpecDto DeploymentSpecToDeploymentSpecDto(DeploymentSpec deploymentSpec);
	
	public static partial DeploymentSpec DeploymentSpecDtoToDeploymentSpec(DeploymentSpecDto deploymentSpec);
}