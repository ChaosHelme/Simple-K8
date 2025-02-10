using MediatR;
using SimpleK8.Core.DataContracts;
using SimpleK8.Core.DataContracts.Dtos;

namespace SimpleK8.Cluster.Commands;

public record UpdateDeploymentCommand(string NamespaceName, string Name, DeploymentUpdateDto Update) : IRequest<Deployment?>;