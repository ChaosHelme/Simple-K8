namespace SimpleK8.ControlPlane.Controllers.Deployment;

public enum DeploymentState
{
	Progressing = 0,
	Completed = 1,
	Failed = 2,
	Paused = 3
}