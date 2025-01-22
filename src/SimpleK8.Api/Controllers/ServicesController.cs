using System.Text.Json;
using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using SimpleK8.ControlPlane;
using SimpleK8.DataContracts;

namespace SimpleK8.Api.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Route("/apis/app/v{version:apiVersion}")]
public class ServicesController(IStore store) : ControllerBase
{
	/// <summary>
	/// Read the specified Service
	/// </summary>
	/// <param name="namespaceName"></param>
	/// <param name="serviceName"></param>
	/// <returns></returns>
	[HttpGet("namespaces/{namespaceName}/[controller]/{serviceName}")]
	public ActionResult<Service?> GetService(string namespaceName, string serviceName)
	{
		return JsonSerializer.Deserialize<Service>(store.Get($"services_{namespaceName}_{serviceName}") ?? string.Empty);
	}

	/// <summary>
	/// List or watch objects of kind Service
	/// </summary>
	/// <param name="namespaceName"></param>
	/// <param name="pretty"></param>
	/// <returns></returns>
	[HttpGet("namespaces/{namespaceName}/[controller]")]
	public ActionResult<Service?> GetServices(string namespaceName, [FromQuery] bool pretty = false)
	{
		return JsonSerializer.Deserialize<Service>(store.Get($"services_{namespaceName}") ?? string.Empty);
	}
}