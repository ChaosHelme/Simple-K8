namespace SimpleK8.Core.DataContracts;

/// <summary>
/// IngressServiceBackend references a Kubernetes Service as a Backend.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class IngressServiceBackend
{
	/// <summary>
	/// name is the referenced service. The service must exist in the same namespace as the Ingress object.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Name { get; set; }

	/// <summary>
	/// port of the referenced service. A port name or port number is required for a IngressServiceBackend.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("port", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public ServiceBackendPort Port { get; set; }

}