using SimpleK8.Core;

namespace SimpleK8.ControlPlane;

public interface IControllerManager
{
	void AddPod(Pod pod);
	void ManageControllers();
}