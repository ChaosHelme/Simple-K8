using MediatR;
using SimpleK8.Application.Common.Requests;
using SimpleK8.Core.DataContracts;

namespace SimpleK8.Api.Application.Commands;

public record CreateDeploymentCommand(CreateDeploymentRequest DeploymentRequest, string ApiVersion, string Kind) : IRequest<Deployment>;