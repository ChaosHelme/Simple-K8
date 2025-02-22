namespace SimpleK8.Core.DataContracts;

/// <summary>
/// ResourceStatus represents the status of a single resource allocated to a Pod.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class ResourceStatus
{
	/// <summary>
	/// Name of the resource. Must be unique within the pod and in case of non-DRA resource, match one of the resources from the pod spec. For DRA resources, the value must be "claim:&lt;claim_name&gt;/&lt;request&gt;". When this status is reported about a container, the "claim_name" and "request" must match one of the claims of this container.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Name { get; set; }

	/// <summary>
	/// List of unique resources health. Each element in the list contains an unique resource ID and its health. At a minimum, for the lifetime of a Pod, resource ID must uniquely identify the resource allocated to the Pod on the Node. If other Pod on the same Node reports the status with the same resource ID, it must be the same resource they share. See ResourceID type definition for a specific format it has in various use cases.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("resources", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<ResourceHealth> Resources { get; set; }

}