using MediatR;
using SimpleK8.Application.Requests;
using SimpleK8.Core.DataContracts;

namespace SimpleK8.Application.Commands;

public record CreateDeploymentCommand(CreateDeploymentRequest DeploymentRequest, string ApiVersion, string Kind) : IRequest<Deployment>;