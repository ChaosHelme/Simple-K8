namespace SimpleK8.ControlPlane;

public interface IApiServer
{
	void HandleRequest(string request);
}