namespace SimpleK8.ControlPlane;

public interface IControllerManager
{
	void StartControllers(CancellationToken cancellationToken);
	void ManageControllers(CancellationToken cancellationToken);
}