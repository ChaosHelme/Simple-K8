using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SimpleK8.Core;

namespace SimpleK8.ControlPlane;

public class ControllerManager(ILogger<ControllerManager> logger, IServiceProvider serviceProvider) : IControllerManager
{
	List<Pod> _managedPods = [];
	
	public void AddPod(Pod pod) => _managedPods.Add(pod);
	
	public void ManageControllers()
	{
		logger.LogInformation("Controller Manager managing controllers");
		var failedPods = _managedPods.Where(p => p.Status == PodStatus.Failed).ToList();
		foreach (var failedPod in failedPods)
		{
			logger.LogWarning("Recreating failed pod {Id}", failedPod.Id);
			_managedPods.Remove(failedPod);
			var newPod = new Pod(failedPod.Containers.First().Image, serviceProvider.GetRequiredService<ILogger<Pod>>(), serviceProvider);
			_managedPods.Add(newPod);
		}
	}
}