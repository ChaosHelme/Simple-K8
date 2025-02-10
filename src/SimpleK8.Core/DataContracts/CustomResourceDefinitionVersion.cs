namespace SimpleK8.Core.DataContracts;

/// <summary>
/// CustomResourceDefinitionVersion describes a version for CRD.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class CustomResourceDefinitionVersion
{
	/// <summary>
	/// additionalPrinterColumns specifies additional columns returned in Table output. See https://kubernetes.io/docs/reference/using-api/api-concepts/#receiving-resources-as-tables for details. If no columns are specified, a single column displaying the age of the custom resource is used.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("additionalPrinterColumns", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<CustomResourceColumnDefinition> AdditionalPrinterColumns { get; set; }

	/// <summary>
	/// deprecated indicates this version of the custom resource API is deprecated. When set to true, API requests to this version receive a warning header in the server response. Defaults to false.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("deprecated", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public bool? Deprecated { get; set; }

	/// <summary>
	/// deprecationWarning overrides the default warning returned to API clients. May only be set when `deprecated` is true. The default warning indicates this version is deprecated and recommends use of the newest served version of equal or greater stability, if one exists.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("deprecationWarning", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string DeprecationWarning { get; set; }

	/// <summary>
	/// name is the version name, e.g. “v1”, “v2beta1”, etc. The custom resources are served under this version at `/apis/&lt;group&gt;/&lt;version&gt;/...` if `served` is true.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Name { get; set; }

	/// <summary>
	/// schema describes the schema used for validation, pruning, and defaulting of this version of the custom resource.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("schema", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public CustomResourceValidation Schema { get; set; }

	/// <summary>
	/// selectableFields specifies paths to fields that may be used as field selectors. A maximum of 8 selectable fields are allowed. See https://kubernetes.io/docs/concepts/overview/working-with-objects/field-selectors
	/// </summary>
	[Newtonsoft.Json.JsonProperty("selectableFields", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<SelectableField> SelectableFields { get; set; }

	/// <summary>
	/// served is a flag enabling/disabling this version from being served via REST APIs
	/// </summary>
	[Newtonsoft.Json.JsonProperty("served", Required = Newtonsoft.Json.Required.Always)]
	public bool Served { get; set; }

	/// <summary>
	/// storage indicates this version should be used when persisting custom resources to storage. There must be exactly one version with storage=true.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("storage", Required = Newtonsoft.Json.Required.Always)]
	public bool Storage { get; set; }

	/// <summary>
	/// subresources specify what subresources this version of the defined custom resource have.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("subresources", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public CustomResourceSubresources Subresources { get; set; }

}