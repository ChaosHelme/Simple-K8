using Asp.Versioning;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using SimpleK8.Cluster.Commands;
using SimpleK8.Cluster.Queries;
using SimpleK8.DataContracts;
using SimpleK8.DataContracts.Dtos;

namespace SimpleK8.Api.Controllers.Workload;

[ApiController]
[ApiVersion("1.0")]
[Route("/apis/app/v{version:apiVersion}")]
public class DeploymentsController(IMediator mediator) : ControllerBase
{
	/// <summary>
	/// List all namespaces
	/// </summary>
	/// <returns><see cref="DeploymentList"/></returns>
	[HttpGet("[controller]")]
	public async Task<ActionResult<DeploymentList>> ListAllNamespaces()
	{
		var result = await mediator.Send(new ListDeploymentNamespacesQuery());
		return Ok(result);
	}
	
	[HttpGet("namespaces/{namespaceName}/[controller]")]
	public async Task<ActionResult<DeploymentList?>> ListDeployments(string namespaceName)
	{
		var deployment = await mediator.Send(new ListDeploymentsQuery(namespaceName));
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
	public async Task<ActionResult<Deployment>> PatchStatus(string namespaceName, string deploymentName)
	{
		return Ok(mediator.Send(new UpdateDeploymentStatusCommand(namespaceName, deploymentName)));
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
	public async Task<ActionResult<Deployment>> CreateDeployment(string namespaceName, [FromBody] Deployment deployment, 
		[FromQuery] bool pretty = false ,[FromQuery] bool dryRun = false)
	{
		var result = await mediator.Send(new CreateDeploymentCommand(namespaceName, deployment.Metadata.Name, deployment));
		return result ? Created($"namespaces/{namespaceName}/deployments/{deployment.Metadata.Name}", deployment) : NotFound();
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
	public async Task<ActionResult<Deployment>> ReplaceDeployment(string namespaceName, string deploymentName, [FromBody] Deployment deployment)
	{
		var response = await mediator.Send(new ReplaceDeploymentCommand(namespaceName, deploymentName, deployment));
		return response == null ? NotFound() : Ok(response);
	}

	/// <summary>
	/// Delete a Deployment
	/// </summary>
	/// <param name="namespaceName"></param>
	/// <param name="deploymentName"></param>
	/// <returns></returns>
	[HttpDelete("namespaces/{namespaceName}/[controller]/{deploymentName}")]
	public async Task<ActionResult> DeleteSpecificDeployment(string namespaceName, string deploymentName)
	{
		var response = await mediator.Send(new DeleteDeploymentCommand(namespaceName, deploymentName));
		return response ? Ok() : BadRequest();
	}
	
	/// <summary>
	/// Delete collection of Deployment
	/// </summary>
	/// <param name="namespaceName">object name and auth scope, such as for teams and projects</param>
	/// <returns></returns>
	[HttpDelete("namespaces/{namespaceName}/[controller]")]
	public async Task<ActionResult> DeleteDeploymentCollection(string namespaceName)
	{
		var response = await mediator.Send(new DeleteDeploymentCollectionCommand(namespaceName));
		return response ? Ok() : BadRequest();
	}
}