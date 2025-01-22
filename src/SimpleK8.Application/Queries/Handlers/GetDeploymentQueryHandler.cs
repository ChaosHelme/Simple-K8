using System.Text.Json;
using MediatR;
using SimpleK8.ControlPlane;
using SimpleK8.DataContracts;

namespace SimpleK8.Cluster.Queries.Handlers;

public class GetDeploymentQueryHandler(IStore store) : IRequestHandler<GetDeploymentQuery, Deployment> {
	public Task<Deployment> Handle(GetDeploymentQuery request, CancellationToken cancellationToken)
	{
		return Task.FromResult(JsonSerializer.Deserialize<Deployment>(store.Get($"deployments_{request.NamespaceName}_{request.DeploymentName}")));
	}
}