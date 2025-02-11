using MediatR;

namespace SimpleK8.Application.Commands;

public record DeleteDeploymentCommand(string NamespaceName, string Name) : IRequest<bool>;