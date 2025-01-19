namespace SimpleK8.ControlPlane.Controllers;

public interface IController
{
	Task Run(CancellationToken cancellationToken);
}