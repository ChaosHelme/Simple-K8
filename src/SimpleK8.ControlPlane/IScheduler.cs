using Microsoft.Extensions.Logging;
using SimpleK8.Core;
using SimpleK8.Worker;

namespace SimpleK8.ControlPlane;

public interface IScheduler
{
	public void SchedulePod(Pod pod, List<IWorkerNode> availableNodes, ILogger<Scheduler> logger);
}