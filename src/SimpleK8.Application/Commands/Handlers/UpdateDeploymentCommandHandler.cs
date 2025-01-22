using System.Text.Json;
using MediatR;
using SimpleK8.ControlPlane;
using SimpleK8.DataContracts;

namespace SimpleK8.Cluster.Commands.Handlers;

public class UpdateDeploymentCommandHandler(IStore store) : IRequestHandler<UpdateDeploymentCommand, Deployment?>
{
	public Task<Deployment?> Handle(UpdateDeploymentCommand request, CancellationToken cancellationToken)
	{
		var persistedDeployment = JsonSerializer.Deserialize<Deployment>(store.Get($"deployments_{request.NamespaceName}_{request.Name}"));
		if (persistedDeployment is null)
		{
			return Task.FromResult<Deployment?>(null);
		}
		
		//var newDeployment = new Deployment()
		return Task.FromResult<Deployment?>(persistedDeployment);
	}
}