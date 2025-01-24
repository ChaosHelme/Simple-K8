using MediatR;
using SimpleK8.DataContracts;

namespace SimpleK8.Cluster.Queries;

public record ListDeploymentsQuery(string NamespaceName) : IRequest<DeploymentList>;