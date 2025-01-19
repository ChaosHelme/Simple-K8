namespace SimpleK8.ControlPlane;

public interface IStore
{
	public void Save(string key, string value);
	public string? Get(string key);
}