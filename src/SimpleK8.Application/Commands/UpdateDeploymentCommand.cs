using MediatR;
using SimpleK8.DataContracts;
using SimpleK8.DataContracts.Dtos;

namespace SimpleK8.Cluster.Commands;

public record UpdateDeploymentCommand(string NamespaceName, string Name, DeploymentUpdateDto Update) : IRequest<Deployment?>;