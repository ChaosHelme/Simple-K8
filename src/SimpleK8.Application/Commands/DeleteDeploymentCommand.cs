using MediatR;

namespace SimpleK8.Cluster.Commands;

public record DeleteDeploymentCommand(string NamespaceName, string Name) : IRequest<bool>;