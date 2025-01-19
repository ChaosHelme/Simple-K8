namespace SimpleK8.ControlPlane.Controllers.Deployment;

public class DeploymentStatus
{
	public DeploymentState State { get; set; }
	public string Message { get; set; }
}