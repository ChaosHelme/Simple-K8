using MediatR;

namespace SimpleK8.Cluster.Commands;

public record DeleteDeploymentCollectionCommand(string NamespaceName) : IRequest<bool>;