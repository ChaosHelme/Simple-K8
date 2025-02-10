namespace SimpleK8.Core.DataContracts;

/// <summary>
/// CustomResourceDefinitionNames indicates the names to serve this CustomResourceDefinition
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class CustomResourceDefinitionNames
{
	/// <summary>
	/// categories is a list of grouped resources this custom resource belongs to (e.g. 'all'). This is published in API discovery documents, and used by clients to support invocations like `kubectl get all`.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("categories", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<string> Categories { get; set; }

	/// <summary>
	/// kind is the serialized kind of the resource. It is normally CamelCase and singular. Custom resource instances will use this value as the `kind` attribute in API calls.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("kind", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Kind { get; set; }

	/// <summary>
	/// listKind is the serialized kind of the list for this resource. Defaults to "`kind`List".
	/// </summary>
	[Newtonsoft.Json.JsonProperty("listKind", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string ListKind { get; set; }

	/// <summary>
	/// plural is the plural name of the resource to serve. The custom resources are served under `/apis/&lt;group&gt;/&lt;version&gt;/.../&lt;plural&gt;`. Must match the name of the CustomResourceDefinition (in the form `&lt;names.plural&gt;.&lt;group&gt;`). Must be all lowercase.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("plural", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Plural { get; set; }

	/// <summary>
	/// shortNames are short names for the resource, exposed in API discovery documents, and used by clients to support invocations like `kubectl get &lt;shortname&gt;`. It must be all lowercase.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("shortNames", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<string> ShortNames { get; set; }

	/// <summary>
	/// singular is the singular name of the resource. It must be all lowercase. Defaults to lowercased `kind`.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("singular", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Singular { get; set; }

}