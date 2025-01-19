using SimpleK8.Core;

namespace SimpleK8.Worker;

public interface IWorkerNode
{
	Task RunPod(Pod pod);
	List<Pod> Pods { get; }
	string Name { get; }
}