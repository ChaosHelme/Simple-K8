using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using SimpleK8.ControlPlane;
using SimpleK8.Core;

namespace SimpleK8.Api.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Route("/api/v{version:apiVersion}/[controller]")]
public class DeploymentsController(IStore store) : ControllerBase
{
	[HttpGet]
	public ActionResult<List<Deployment>> GetDeployments()
	{
		store.Get("deployments");
		return Ok(new List<Deployment>());
	}

	[HttpGet("{deploymentName}")]
	public ActionResult<Deployment> GetDeployment(string deploymentName)
	{
		var deployment = store.Get($"deployment_{deploymentName}");
		if (string.IsNullOrEmpty(deployment))
		{
			return NotFound();
		}
		return Ok(deployment);
	}

	[HttpPost]
	public ActionResult<Deployment> CreateDeployment([FromBody] Deployment deployment)
	{
		return Created($"deployments/{deployment.Name}", deployment);
	}

	[HttpPut("{deploymentName}")]
	public ActionResult<Deployment> UpdateDeployment(string deploymentName, [FromBody] Deployment deployment)
	{
		return Ok(deployment);
	}

	[HttpDelete("{deploymentName}")]
	public ActionResult<Deployment> DeleteDeployment(string deploymentName)
	{
		return Ok(deploymentName);
	}
}