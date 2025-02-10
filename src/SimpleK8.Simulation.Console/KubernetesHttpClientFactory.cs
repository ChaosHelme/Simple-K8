using Microsoft.Extensions.Configuration;

namespace SimpleK8.Simulation.Console;

public class KubernetesHttpClientFactory(IHttpClientFactory httpClientFactory, IConfiguration config)
{
	public HttpClient CreateClient()
	{
		var baseAddress = config.GetRequiredSection("KubernetesApi").GetValue<string>("AppsBaseAddress");
		if (string.IsNullOrWhiteSpace(baseAddress))
		{
			throw new InvalidOperationException("Missing Kubernetes AppsBaseAddress in config.");
		}
		var client = httpClientFactory.CreateClient("kubernetes");
		client.BaseAddress = new Uri(baseAddress);
		return client;
	}
}
