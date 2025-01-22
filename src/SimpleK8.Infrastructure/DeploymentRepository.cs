using System.Text.Json;
using dotnet_etcd.interfaces;
using SimpleK8.Cluster;
using SimpleK8.DataContracts;

namespace SimpleK8.Infrastructure;

public class DeploymentRepository(IEtcdClient etcdClient) : IDeploymentRepository
{
	public async Task<Deployment?> GetDeployment(string namespaceName, string deploymentName)
	{
		var value = await etcdClient.GetValAsync($"deployments/{namespaceName}/{deploymentName}");
		return JsonSerializer.Deserialize<Deployment>(value);
	}
}