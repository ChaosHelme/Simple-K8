namespace SimpleK8.Core.DataContracts;

/// <summary>
/// ServiceReference holds a reference to Service.legacy.k8s.io
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class ServiceReference3
{
	/// <summary>
	/// Name is the name of the service
	/// </summary>
	[Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Name { get; set; }

	/// <summary>
	/// Namespace is the namespace of the service
	/// </summary>
	[Newtonsoft.Json.JsonProperty("namespace", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Namespace { get; set; }

	/// <summary>
	/// If specified, the port on the service that hosting webhook. Default to 443 for backward compatibility. `port` should be a valid port number (1-65535, inclusive).
	/// </summary>
	[Newtonsoft.Json.JsonProperty("port", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? Port { get; set; }

}