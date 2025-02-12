using MediatR;

namespace SimpleK8.Api.Application.Commands;

public record DeleteDeploymentCollectionCommand(string NamespaceName) : IRequest<bool>;