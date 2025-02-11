using MediatR;

namespace SimpleK8.Application.Commands;

public record DeleteDeploymentCollectionCommand(string NamespaceName) : IRequest<bool>;