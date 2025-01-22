using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using SimpleK8.Core;

namespace SimpleK8.Api.Controllers.Workload;

[ApiController]
[ApiVersion("1.0")]
[Route("/api/v{version:apiVersion}")]
public class PodsController : ControllerBase
{
	[HttpPost("namespaces/{namespaceName}/[controller]")]
	public ActionResult<Pod> CreatePod(string namespaceName, [FromBody] Pod pod)
	{
		return Ok(pod);
	}
}