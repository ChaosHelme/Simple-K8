using MediatR;
using SimpleK8.DataContracts;

namespace SimpleK8.Cluster.Commands;

public record CreateDeploymentCommand(Deployment Deployment) : IRequest<bool>;