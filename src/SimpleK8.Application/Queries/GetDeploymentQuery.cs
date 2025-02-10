using MediatR;
using SimpleK8.Core.DataContracts;

namespace SimpleK8.Cluster.Queries;

public record GetDeploymentQuery(string DeploymentName, string NamespaceName) : IRequest<Deployment?>;