using System.Text.Json;
using Asp.Versioning;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using SimpleK8.Cluster.Commands;
using SimpleK8.Cluster.Queries;
using SimpleK8.ControlPlane;
using SimpleK8.DataContracts;
using SimpleK8.DataContracts.Dtos;

namespace SimpleK8.Api.Controllers.Workload;

[ApiController]
[ApiVersion("1.0")]
[Route("/apis/app/v{version:apiVersion}")]
public class DeploymentsController(IStore store, IMediator mediator) : ControllerBase
{
	/// <summary>
	/// List all namespaces
	/// </summary>
	/// <returns><see cref="DeploymentList"/></returns>
	[HttpGet("[controller]")]
	public ActionResult<DeploymentList> ListAllNamespaces()
	{
		var deployments = new DeploymentList("v1", [], "", null);
		return Ok(deployments);
	}
	
	[HttpGet("namespaces/{namespaceName}/[controller]")]
	public ActionResult<DeploymentList?> ListDeployments(string namespaceName)
	{
		var deployment = JsonSerializer.Deserialize<DeploymentList>(store.Get($"deployment_{namespaceName}") ?? string.Empty);
		return Ok(deployment);
	}

	[HttpGet("namespaces/{namespaceName}/[controller]/{deploymentName}")]
	public ActionResult<Deployment> GetSpecifiedDeployment(string namespaceName, string deploymentName)
	{
		return Ok(mediator.Send(new GetDeploymentQuery(deploymentName, namespaceName)));
	}
	
	/// <summary>
	/// Read status of the specified Deployment
	/// </summary>
	/// <param name="namespaceName"></param>
	/// <param name="deploymentName"></param>
	/// <returns></returns>
	[HttpGet("namespaces/{namespaceName}/[controller]/{deploymentName}/status")]
	public ActionResult<Deployment> PatchStatus(string namespaceName, string deploymentName)
	{
		return Ok(store.Get($"deployment_{namespaceName}_{deploymentName}_status"));
	}

	/// <summary>
	/// Create a <see cref="Deployment"/>
	/// </summary>
	/// <param name="namespaceName">object name and auth scope, such as for teams and projects</param>
	/// <param name="deployment"></param>
	/// <param name="pretty">If 'true', then the output is pretty printed. Defaults to 'false'
	/// unless the user-agent indicates a browser or command-line HTTP tool (curl and wget).</param>
	/// <param name="dryRun">When present, indicates that modifications should not be persisted.
	///     An invalid or unrecognized dryRun directive will result in an error response and no further processing of the request.
	///     Valid values are: - All: all dry run stages will be processed</param>
	/// <returns>201 with created <see cref="Deployment"/></returns>
	[HttpPost("namespaces/{namespaceName}/[controller]")]
	public ActionResult<Deployment> CreateDeployment(string namespaceName, [FromBody] Deployment deployment, 
		[FromQuery] bool pretty = false ,[FromQuery] bool dryRun = false)
	{
		if (dryRun)
		{
			store.Save($"deployment_{namespaceName}_{deployment.Name}", JsonSerializer.Serialize(deployment));	
		}
		return Created($"namespaces/{namespaceName}/deployments/{deployment.Name}", deployment);
	}

	/// <summary>
	/// Partially update the specified Deployment
	/// </summary>
	/// <param name="namespaceName">object name and auth scope, such as for teams and projects</param>
	/// <param name="deploymentName">name of the Deployment</param>
	/// <param name="deploymentUpdate"></param>
	/// <returns></returns>
	[HttpPatch("namespaces/{namespaceName}/[controller]/{deploymentName}")]
	public ActionResult<Deployment> UpdateDeployment(string namespaceName, string deploymentName, [FromBody] DeploymentUpdateDto deploymentUpdate)
	{
		return Ok(mediator.Send(new UpdateDeploymentCommand(namespaceName, deploymentName, deploymentUpdate)));
	}

	/// <summary>
	/// Replace the specified Deployment
	/// </summary>
	/// <param name="namespaceName"></param>
	/// <param name="deploymentName"></param>
	/// <param name="deployment"></param>
	/// <returns></returns>
	[HttpPut("namespaces/{namespaceName}/[controller]/{deploymentName}")]
	public ActionResult<Deployment> ReplaceDeployment(string namespaceName, string deploymentName, [FromBody] Deployment deployment)
	{
		var persistedDeployment = JsonSerializer.Deserialize<Deployment>(store.Get($"deployment_{namespaceName}_{deploymentName}") ?? string.Empty);
		if (persistedDeployment is null )
			return NotFound($"deployment {deploymentName} not found");

		store.Save($"deployment_{namespaceName}_{deploymentName}", JsonSerializer.Serialize(deployment));
		return Ok(deployment);
	}

	/// <summary>
	/// Delete a Deployment
	/// </summary>
	/// <param name="namespaceName"></param>
	/// <param name="deploymentName"></param>
	/// <returns></returns>
	[HttpDelete("namespaces/{namespaceName}/[controller]/{deploymentName}")]
	public ActionResult DeleteDeploymentForNamespace(string namespaceName, string deploymentName)
	{
		store.Delete($"deployment_{namespaceName}_{deploymentName}");
		return Ok();
	}
	
	/// <summary>
	/// Delete collection of Deployment
	/// </summary>
	/// <param name="namespaceName">object name and auth scope, such as for teams and projects</param>
	/// <returns></returns>
	[HttpDelete("namespaces/{namespaceName}/[controller]")]
	public ActionResult DeleteDeploymentCollection(string namespaceName)
	{
		store.Delete($"deployment_{namespaceName}");
		return Ok();
	}
}