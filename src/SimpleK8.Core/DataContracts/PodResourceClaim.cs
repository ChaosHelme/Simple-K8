namespace SimpleK8.Core.DataContracts;

/// <summary>
/// PodResourceClaim references exactly one ResourceClaim, either directly or by naming a ResourceClaimTemplate which is then turned into a ResourceClaim for the pod.
/// <br/>
/// <br/>It adds a name to it that uniquely identifies the ResourceClaim inside the Pod. Containers that need access to the ResourceClaim reference it with this name.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class PodResourceClaim
{
	/// <summary>
	/// Name uniquely identifies this resource claim inside the pod. This must be a DNS_LABEL.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Name { get; set; }

	/// <summary>
	/// ResourceClaimName is the name of a ResourceClaim object in the same namespace as this pod.
	/// <br/>
	/// <br/>Exactly one of ResourceClaimName and ResourceClaimTemplateName must be set.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("resourceClaimName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string ResourceClaimName { get; set; }

	/// <summary>
	/// ResourceClaimTemplateName is the name of a ResourceClaimTemplate object in the same namespace as this pod.
	/// <br/>
	/// <br/>The template will be used to create a new ResourceClaim, which will be bound to this pod. When this pod is deleted, the ResourceClaim will also be deleted. The pod name and resource name, along with a generated component, will be used to form a unique name for the ResourceClaim, which will be recorded in pod.status.resourceClaimStatuses.
	/// <br/>
	/// <br/>This field is immutable and no changes will be made to the corresponding ResourceClaim by the control plane after creating the ResourceClaim.
	/// <br/>
	/// <br/>Exactly one of ResourceClaimName and ResourceClaimTemplateName must be set.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("resourceClaimTemplateName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string ResourceClaimTemplateName { get; set; }

}