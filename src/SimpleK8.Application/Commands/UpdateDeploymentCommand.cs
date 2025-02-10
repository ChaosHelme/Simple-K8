using MediatR;
using SimpleK8.Cluster.Dtos;
using SimpleK8.Core.DataContracts;

namespace SimpleK8.Cluster.Commands;

public record UpdateDeploymentCommand(string NamespaceName, string Name, DeploymentUpdateDto Update) : IRequest<Deployment?>;