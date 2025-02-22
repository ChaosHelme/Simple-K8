namespace SimpleK8.Core.DataContracts;

/// <summary>
/// CustomResourceDefinitionSpec describes how a user wants their resource to appear
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class CustomResourceDefinitionSpec
{
	/// <summary>
	/// conversion defines conversion settings for the CRD.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("conversion", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public CustomResourceConversion Conversion { get; set; }

	/// <summary>
	/// group is the API group of the defined custom resource. The custom resources are served under `/apis/&lt;group&gt;/...`. Must match the name of the CustomResourceDefinition (in the form `&lt;names.plural&gt;.&lt;group&gt;`).
	/// </summary>
	[Newtonsoft.Json.JsonProperty("group", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Group { get; set; }

	/// <summary>
	/// names specify the resource and kind names for the custom resource.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("names", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required]
	public CustomResourceDefinitionNames Names { get; set; } = new CustomResourceDefinitionNames();

	/// <summary>
	/// preserveUnknownFields indicates that object fields which are not specified in the OpenAPI schema should be preserved when persisting to storage. apiVersion, kind, metadata and known fields inside metadata are always preserved. This field is deprecated in favor of setting `x-preserve-unknown-fields` to true in `spec.versions[*].schema.openAPIV3Schema`. See https://kubernetes.io/docs/tasks/extend-kubernetes/custom-resources/custom-resource-definitions/#field-pruning for details.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("preserveUnknownFields", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public bool? PreserveUnknownFields { get; set; }

	/// <summary>
	/// scope indicates whether the defined custom resource is cluster- or namespace-scoped. Allowed values are `Cluster` and `Namespaced`.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("scope", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Scope { get; set; }

	/// <summary>
	/// versions is the list of all API versions of the defined custom resource. Version names are used to compute the order in which served versions are listed in API discovery. If the version string is "kube-like", it will sort above non "kube-like" version strings, which are ordered lexicographically. "Kube-like" versions start with a "v", then are followed by a number (the major version), then optionally the string "alpha" or "beta" and another number (the minor version). These are sorted first by GA &gt; beta &gt; alpha (where GA is a version with no suffix such as beta or alpha), and then by comparing major version, then minor version. An example sorted list of versions: v10, v2, v1, v11beta2, v10beta3, v3beta1, v12alpha1, v11alpha2, foo1, foo10.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("versions", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required]
	public System.Collections.Generic.List<CustomResourceDefinitionVersion> Versions { get; set; } = new System.Collections.Generic.List<CustomResourceDefinitionVersion>();

}