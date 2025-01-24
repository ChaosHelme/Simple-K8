using System.Text.Json;
using Asp.Versioning;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using SimpleK8.DataContracts;

namespace SimpleK8.Api.Controllers.Cluster;

[ApiController]
[ApiVersion("1.0")]
[Route("/api/v{version:apiVersion}/[controller]")]
public class NodesController(IMediator mediator) : ControllerBase
{
	/// <summary>
	/// Read the specified Node
	/// </summary>
	/// <param name="nodeName">Name of the node</param>
	/// <returns></returns>
	[HttpGet("{nodeName}")]
	public ActionResult<Node?> GetNodes(string nodeName)
	{
		return Ok();
		//return JsonSerializer.Deserialize<Node>(store.Get($"nodes_{nodeName}") ?? string.Empty);
	}
	
	/// <summary>
	/// Create a Node
	/// </summary>
	/// <param name="node"></param>
	/// <returns></returns>
	[HttpPost]
	public ActionResult<Node> CreateNode([FromBody] Node node)
	{
		return Ok();
		// store.Save($"nodes_{node.Spec.Name}", JsonSerializer.Serialize(node));
		// return Created("/nodes", node.Spec.Name);
	}
}