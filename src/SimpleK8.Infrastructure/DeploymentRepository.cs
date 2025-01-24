using System.Text.Json;
using dotnet_etcd.interfaces;
using Microsoft.Extensions.Logging;
using SimpleK8.Cluster;
using SimpleK8.DataContracts;

namespace SimpleK8.Infrastructure;

public class DeploymentRepository(IEtcdClient etcdClient, ILogger<DeploymentRepository> logger) : IDeploymentRepository
{
	public async Task<Deployment?> GetDeployment(string namespaceName, string deploymentName)
	{
		var value = await etcdClient.GetValAsync($"deployments/{namespaceName}/{deploymentName}");
		return JsonSerializer.Deserialize<Deployment>(value);
	}

	public async Task<bool> CreateDeployment(string namespaceName, string deploymentName, Deployment deployment)
	{
		var response = await etcdClient.PutAsync($"deployments/{namespaceName}/{deploymentName}", JsonSerializer.Serialize(deployment));
		logger.LogInformation($"Created deployment {deployment.Name}");
		logger.LogInformation("etcd information: {info}", response.Header.ToString());

		return true;
	}
}