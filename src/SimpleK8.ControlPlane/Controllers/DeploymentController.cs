using Microsoft.Extensions.Logging;
using SimpleK8.Core;

namespace SimpleK8.ControlPlane.Controllers;

public class DeploymentController(
	IApiServer apiServer,
	ILogger<DeploymentController> logger) : IController
{
	public async Task Run(CancellationToken cancellationToken)
	{
		logger.LogInformation("Deployment controller watching for changes...");
		while (!cancellationToken.IsCancellationRequested)
		{
			await Reconcile(cancellationToken);
			await Task.Delay(5000, cancellationToken);
		}
	}
	
	async Task Reconcile(CancellationToken cancellationToken)
	{
		// 1. Obtain desired state
		var desiredState = apiServer.GetDesiredDeployments();
		
		// 2. Observer current state
		var currentDeployments = apiServer.GetCurrentDeployments();
		
		// 3. Determine differences
		var differences = DetermineDifferences(desiredState, currentDeployments);
		
		// 4. Reconcile differences
		await ReconcileDifferences(differences, cancellationToken);

		if (differences.Count > 0)
		{
			apiServer.ApplyDeploymentDifferences(differences);
		}
	}
	
	List<DeploymentDifference> DetermineDifferences(List<Deployment> desired, List<Deployment> current)
	{
		// Implementation to compare desired and current states
		var result = new List<DeploymentDifference>(desired.Count);
		var currentList = current.Where(d => desired.Select(x => x.Name).Contains(d.Name)).ToList();
		var desiredList = desired.Where(d => !desired.Select(x => x.Name).Contains(d.Name)).ToList();

		foreach (var currentDeployment in currentList)
		{
			var desiredDeployment = desired.FirstOrDefault(x => x.Name.Equals(currentDeployment.Name));
			if (desiredDeployment == null)
			{
				logger.LogError("No deployment found for {currentDeployment}", currentDeployment.Name);
				continue;
			}
			
			var deploymentDifference = new DeploymentDifference(
				currentDeployment.Id,
				currentDeployment.Name,
				currentDeployment.Image, 
				desiredDeployment.Image, 
				currentDeployment.ReplicaCount,
				desiredDeployment.ReplicaCount);
			
			var containsDifferences = deploymentDifference.DetermineDifferences();
			if(containsDifferences)
			{
				result.Add(deploymentDifference);
			}
		}

		foreach (var desiredDeployment in desiredList)
		{
			
			var currentDeployment = current.FirstOrDefault(x => x.Name.Equals(desiredDeployment.Name));
			if (currentDeployment == null)
			{
				logger.LogError("No deployment found for {currentDeployment}", desiredDeployment.Name);
				continue;
			}
			
			var deploymentDifference = new DeploymentDifference(desiredDeployment.Id,
				desiredDeployment.Name,
				desiredDeployment.Image,
				currentDeployment.Image,
				desiredDeployment.ReplicaCount,
				currentDeployment.ReplicaCount);

			var containsDifferences = deploymentDifference.DetermineDifferences();
			if(containsDifferences)
			{
				result.Add(deploymentDifference);
			}
		}
		
		return result;
	}
	
	async Task ReconcileDifferences(List<DeploymentDifference> differences, CancellationToken cancellationToken)
	{
		foreach (var diff in differences)
		{
			if (diff.CurrentImage != diff.DesiredImage)
			{
				await UpdateImage(diff.DesiredImage, cancellationToken);
			}
            
			if (diff.CurrentReplicas != diff.DesiredReplicas)
			{
				apiServer.SetDesiredReplicaCount(diff.DesiredReplicas);
				// The ReplicaSetController will handle the actual scaling
			}
		}
	}
	
	async Task UpdateImage(string newImage, CancellationToken cancellationToken)
	{
		logger.LogInformation("Updating image to {newImage}", newImage);
		apiServer.SetDesiredImage(newImage);
		// The ReplicaSetController will handle updating the pods
	}
}
