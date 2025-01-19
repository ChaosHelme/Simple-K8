using Microsoft.Extensions.Logging;

namespace SimpleK8.ControlPlane;

public class ApiServer(ILogger<ApiServer> logger) : IApiServer
{
	public void HandleRequest(string request)
	{
		logger.LogInformation("Handling request {request}", request);
	}
}