using MediatR;
using SimpleK8.DataContracts;

namespace SimpleK8.Cluster.Commands;

public record CreateDeploymentCommand(string NamespaceName, string DeploymentName, Deployment Deployment) : IRequest<bool>;