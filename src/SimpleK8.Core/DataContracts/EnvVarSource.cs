namespace SimpleK8.Core.DataContracts;

/// <summary>
/// EnvVarSource represents a source for the value of an EnvVar.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class EnvVarSource
{
	/// <summary>
	/// Selects a key of a ConfigMap.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("configMapKeyRef", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public ConfigMapKeySelector ConfigMapKeyRef { get; set; }

	/// <summary>
	/// Selects a field of the pod: supports metadata.name, metadata.namespace, `metadata.labels['&lt;KEY&gt;']`, `metadata.annotations['&lt;KEY&gt;']`, spec.nodeName, spec.serviceAccountName, status.hostIP, status.podIP, status.podIPs.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("fieldRef", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public ObjectFieldSelector FieldRef { get; set; }

	/// <summary>
	/// Selects a resource of the container: only resources limits and requests (limits.cpu, limits.memory, limits.ephemeral-storage, requests.cpu, requests.memory and requests.ephemeral-storage) are currently supported.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("resourceFieldRef", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public ResourceFieldSelector ResourceFieldRef { get; set; }

	/// <summary>
	/// Selects a key of a secret in the pod's namespace
	/// </summary>
	[Newtonsoft.Json.JsonProperty("secretKeyRef", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public SecretKeySelector SecretKeyRef { get; set; }

}