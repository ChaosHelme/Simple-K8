namespace SimpleK8.Core.DataContracts;

/// <summary>
/// IngressBackend describes all endpoints for a given service and port.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class IngressBackend
{
	/// <summary>
	/// resource is an ObjectRef to another Kubernetes resource in the namespace of the Ingress object. If resource is specified, a service.Name and service.Port must not be specified. This is a mutually exclusive setting with "Service".
	/// </summary>
	[Newtonsoft.Json.JsonProperty("resource", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public TypedLocalObjectReference Resource { get; set; }

	/// <summary>
	/// service references a service as a backend. This is a mutually exclusive setting with "Resource".
	/// </summary>
	[Newtonsoft.Json.JsonProperty("service", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public IngressServiceBackend Service { get; set; }

}