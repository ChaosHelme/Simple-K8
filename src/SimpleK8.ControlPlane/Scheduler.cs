using Microsoft.Extensions.Logging;
using SimpleK8.Core;
using SimpleK8.Worker;

namespace SimpleK8.ControlPlane;

public class Scheduler : IScheduler
{
	public void SchedulePod(Pod pod, List<IWorkerNode> availableNodes, ILogger<Scheduler> logger)
	{
		if (availableNodes.Count < 0)
		{
			logger.LogWarning("No available nodes to schedule pod {Id}", pod.Id);
			return;
		}
		
		var selectedNode = availableNodes[new Random().Next(availableNodes.Count)];
		pod.AssignedNode = selectedNode.Name;
		logger.LogInformation("Scheduling pod {Id} on Node {Name}", pod.Id, selectedNode.Name);
	}
}