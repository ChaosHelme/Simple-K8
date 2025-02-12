using System.Text.Json;
using dotnet_etcd.interfaces;
using Etcdserverpb;
using Microsoft.Extensions.Logging;
using SimpleK8.Application.Common.Repositories;
using SimpleK8.Application.Common.Requests;
using SimpleK8.Core.DataContracts;

namespace SimpleK8.Infrastructure;

public class EtcdDeploymentRepository(IEtcdClient etcdClient, ILogger<EtcdDeploymentRepository> logger) : IDeploymentRepository
{
	public async Task<Deployment?> GetDeployment(string namespaceName, string deploymentName, CancellationToken cancellationToken)
	{
		var value = await etcdClient.GetValAsync($"deployments/{namespaceName}/{deploymentName}", cancellationToken: cancellationToken);
		return JsonSerializer.Deserialize<Deployment>(value);
	}

	public async Task<DeploymentList> ListDeployments(string namespaceName, CancellationToken cancellationToken)
	{
		var value = await etcdClient.GetRangeAsync($"deployments/{namespaceName}/", cancellationToken: cancellationToken);
		return BuildDeploymentList(value);
	}

	public async Task<bool> CreateDeployment(Deployment deployment, CancellationToken cancellationToken)
	{
		var response = await etcdClient.PutAsync($"deployments/{deployment.Metadata.Namespace}/{deployment.Metadata.Name}", 
			JsonSerializer.Serialize(deployment), cancellationToken: cancellationToken);
		logger.LogInformation("Created deployment {DeploymentName}", deployment.Metadata.Name);
		logger.LogInformation("etcd information: {Info}", response.Header.ToString());

		// ToDo: How to determine if persisting was successful?
		return true;
	}

	public async Task<Deployment?> UpdateDeployment(string requestNamespaceName, string requestName, UpdateDeploymentRequest requestUpdate, CancellationToken cancellationToken)
	{
		var persistedDeploymentString = await etcdClient.GetValAsync($"deployments/{requestNamespaceName}/{requestName}", cancellationToken: cancellationToken);
		if (string.IsNullOrEmpty(persistedDeploymentString))
		{
			logger.LogWarning("No deployment to update found for {Namespace}/{Name}", requestNamespaceName, requestName);
			return null;
		}
		var persistedDeployment = JsonSerializer.Deserialize<Deployment>(persistedDeploymentString);
		
		// ToDo: Update the persistedDeployment
		
		return persistedDeployment;
	}

	public async Task<DeploymentList> ListDeploymentNamespaces(CancellationToken cancellationToken)
	{
		var value = await etcdClient.GetRangeAsync($"deployments/", cancellationToken: cancellationToken);
		return BuildDeploymentList(value);
	}

	public async Task<Deployment?> ReplaceDeployment(string requestNamespaceName, string requestName, Deployment requestDeployment, CancellationToken cancellationToken)
	{
		var deploymentString = await etcdClient.GetValAsync($"deployments/{requestNamespaceName}/{requestName}", cancellationToken: cancellationToken);
		if (string.IsNullOrEmpty(deploymentString))
		{
			return null;
		}
		await etcdClient.PutAsync($"deployments/{requestNamespaceName}/{requestName}", JsonSerializer.Serialize(requestDeployment));
		return requestDeployment;
	}

	public async Task<bool> DeleteDeployment(string requestNamespaceName, string requestName, CancellationToken cancellationToken)
	{
		var response = await etcdClient.DeleteAsync($"deployments/{requestNamespaceName}/{requestName}", cancellationToken: cancellationToken);
		return response.Deleted > 0;
	}

	public async Task<bool> DeleteDeploymentCollection(string requestNamespaceName, CancellationToken cancellationToken)
	{
		var response = await etcdClient.DeleteRangeAsync($"deployments/{requestNamespaceName}/", cancellationToken: cancellationToken);
		return response.Deleted > 0;
	}

	DeploymentList BuildDeploymentList(RangeResponse? value)
	{
		var deploymentList = new DeploymentList
		{
			ApiVersion = "v1",
			Items = [],
			Kind = "deployments",
			Metadata = new ListMeta()
		};
		if (value is null)
			return deploymentList;
		
		foreach (var keyValue in value.Kvs)
		{
			logger.LogDebug("deployment path: {Path}", keyValue.Key.ToStringUtf8());
			var deployment = JsonSerializer.Deserialize<Deployment>(keyValue.Value.ToStringUtf8());
			deploymentList.Items.Add(deployment!);
		}

		return deploymentList;
	}
}