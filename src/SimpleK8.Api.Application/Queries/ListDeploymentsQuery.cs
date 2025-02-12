using MediatR;
using SimpleK8.Core.DataContracts;

namespace SimpleK8.Api.Application.Queries;

public record ListDeploymentsQuery(string NamespaceName) : IRequest<DeploymentList?>;