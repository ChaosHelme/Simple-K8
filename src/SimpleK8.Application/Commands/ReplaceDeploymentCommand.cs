using MediatR;
using SimpleK8.DataContracts;

namespace SimpleK8.Cluster.Commands;

public record ReplaceDeploymentCommand(string NamespaceName, string Name, Deployment Deployment) : IRequest<Deployment?>;