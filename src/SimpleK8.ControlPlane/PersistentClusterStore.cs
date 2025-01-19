using Microsoft.Extensions.Logging;

namespace SimpleK8.ControlPlane;

public class PersistentClusterStore(ILogger<PersistentClusterStore> logger) : IStore
{
	readonly Dictionary<string, string> _store = [];
	
	public void Save(string key, string value)
	{
		_store[key] = value;
		logger.LogInformation("Persistent cluster store saved {key}:{value}", key, value);
	}
	
	public string? Get(string key) => _store.GetValueOrDefault(key);
}