using Microsoft.Extensions.Logging;
using SimpleK8.Core;

namespace SimpleK8.Worker;

public class WorkerNode(string nodeName, ILogger<WorkerNode> logger) : IWorkerNode
{
	public List<Pod> Pods { get; } = [];
	public string Name { get; } = nodeName;

	public async Task RunPod(Pod pod)
	{
		Pods.Add(pod);
		await pod.Start();
		logger.LogInformation("Running pod {Id} on node {Name}", pod.Id, Name);
	}
}