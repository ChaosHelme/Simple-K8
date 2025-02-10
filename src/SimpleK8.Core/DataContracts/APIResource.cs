namespace SimpleK8.Core.DataContracts;

/// <summary>
/// APIResource specifies the name of a resource and whether it is namespaced.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class APIResource
{
	/// <summary>
	/// categories is a list of the grouped resources this resource belongs to (e.g. 'all')
	/// </summary>
	[Newtonsoft.Json.JsonProperty("categories", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<string> Categories { get; set; }

	/// <summary>
	/// group is the preferred group of the resource.  Empty implies the group of the containing resource list. For subresources, this may have a different value, for example: Scale".
	/// </summary>
	[Newtonsoft.Json.JsonProperty("group", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Group { get; set; }

	/// <summary>
	/// kind is the kind for the resource (e.g. 'Foo' is the kind for a resource 'foo')
	/// </summary>
	[Newtonsoft.Json.JsonProperty("kind", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Kind { get; set; }

	/// <summary>
	/// name is the plural name of the resource.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Name { get; set; }

	/// <summary>
	/// namespaced indicates if a resource is namespaced or not.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("namespaced", Required = Newtonsoft.Json.Required.Always)]
	public bool Namespaced { get; set; }

	/// <summary>
	/// shortNames is a list of suggested short names of the resource.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("shortNames", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<string> ShortNames { get; set; }

	/// <summary>
	/// singularName is the singular name of the resource.  This allows clients to handle plural and singular opaquely. The singularName is more correct for reporting status on a single item and both singular and plural are allowed from the kubectl CLI interface.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("singularName", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string SingularName { get; set; }

	/// <summary>
	/// The hash value of the storage version, the version this resource is converted to when written to the data store. Value must be treated as opaque by clients. Only equality comparison on the value is valid. This is an alpha feature and may change or be removed in the future. The field is populated by the apiserver only if the StorageVersionHash feature gate is enabled. This field will remain optional even if it graduates.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("storageVersionHash", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string StorageVersionHash { get; set; }

	/// <summary>
	/// verbs is a list of supported kube verbs (this includes get, list, watch, create, update, patch, delete, deletecollection, and proxy)
	/// </summary>
	[Newtonsoft.Json.JsonProperty("verbs", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required]
	public System.Collections.Generic.List<string> Verbs { get; set; } = new System.Collections.Generic.List<string>();

	/// <summary>
	/// version is the preferred version of the resource.  Empty implies the version of the containing resource list For subresources, this may have a different value, for example: v1 (while inside a v1beta1 version of the core resource's group)".
	/// </summary>
	[Newtonsoft.Json.JsonProperty("version", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Version { get; set; }

}