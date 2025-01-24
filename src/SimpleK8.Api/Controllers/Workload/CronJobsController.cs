using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace SimpleK8.Api.Controllers.Workload;

[ApiController]
[ApiVersion("1.0")]
[Route("/apis/batch/v{version:apiVersion}")]
public class CronJobsController : ControllerBase
{
	
}