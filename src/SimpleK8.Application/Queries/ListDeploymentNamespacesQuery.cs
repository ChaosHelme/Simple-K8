using MediatR;
using SimpleK8.DataContracts;

namespace SimpleK8.Cluster.Queries;

public record ListDeploymentNamespacesQuery() : IRequest<DeploymentList>;