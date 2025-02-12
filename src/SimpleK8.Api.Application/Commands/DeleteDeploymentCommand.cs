using MediatR;

namespace SimpleK8.Api.Application.Commands;

public record DeleteDeploymentCommand(string NamespaceName, string Name) : IRequest<bool>;