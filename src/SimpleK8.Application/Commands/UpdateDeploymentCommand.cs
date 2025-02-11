using MediatR;
using SimpleK8.Application.Requests;
using SimpleK8.Core.DataContracts;

namespace SimpleK8.Application.Commands;

public record UpdateDeploymentCommand(string NamespaceName, string Name, UpdateDeploymentRequest Update) : IRequest<Deployment?>;