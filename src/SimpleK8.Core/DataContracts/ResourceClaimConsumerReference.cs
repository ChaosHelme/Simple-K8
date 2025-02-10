namespace SimpleK8.Core.DataContracts;

/// <summary>
/// ResourceClaimConsumerReference contains enough information to let you locate the consumer of a ResourceClaim. The user must be a resource in the same namespace as the ResourceClaim.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class ResourceClaimConsumerReference
{
	/// <summary>
	/// APIGroup is the group for the resource being referenced. It is empty for the core API. This matches the group in the APIVersion that is used when creating the resources.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("apiGroup", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string ApiGroup { get; set; }

	/// <summary>
	/// Name is the name of resource being referenced.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Name { get; set; }

	/// <summary>
	/// Resource is the type of resource being referenced, for example "pods".
	/// </summary>
	[Newtonsoft.Json.JsonProperty("resource", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Resource { get; set; }

	/// <summary>
	/// UID identifies exactly one incarnation of the resource.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("uid", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Uid { get; set; }

}