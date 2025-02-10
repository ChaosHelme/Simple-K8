namespace SimpleK8.Core.DataContracts;

/// <summary>
/// ResourceRequirements describes the compute resource requirements.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class ResourceRequirements
{
	/// <summary>
	/// Claims lists the names of resources, defined in spec.resourceClaims, that are used by this container.
	/// <br/>
	/// <br/>This is an alpha field and requires enabling the DynamicResourceAllocation feature gate.
	/// <br/>
	/// <br/>This field is immutable. It can only be set for containers.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("claims", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<ResourceClaim> Claims { get; set; }

	/// <summary>
	/// Limits describes the maximum amount of compute resources allowed. More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/
	/// </summary>
	[Newtonsoft.Json.JsonProperty("limits", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.IDictionary<string, string> Limits { get; set; }

	/// <summary>
	/// Requests describes the minimum amount of compute resources required. If Requests is omitted for a container, it defaults to Limits if that is explicitly specified, otherwise to an implementation-defined value. Requests cannot exceed Limits. More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/
	/// </summary>
	[Newtonsoft.Json.JsonProperty("requests", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.IDictionary<string, string> Requests { get; set; }

}