namespace SimpleK8.Core.DataContracts;

/// <summary>
/// ResourceAttributes includes the authorization attributes available for resource requests to the Authorizer interface
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class ResourceAttributes
{
	/// <summary>
	/// fieldSelector describes the limitation on access based on field.  It can only limit access, not broaden it.
	/// <br/>
	/// <br/>This field  is alpha-level. To use this field, you must enable the `AuthorizeWithSelectors` feature gate (disabled by default).
	/// </summary>
	[Newtonsoft.Json.JsonProperty("fieldSelector", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public FieldSelectorAttributes FieldSelector { get; set; }

	/// <summary>
	/// Group is the API Group of the Resource.  "*" means all.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("group", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Group { get; set; }

	/// <summary>
	/// labelSelector describes the limitation on access based on labels.  It can only limit access, not broaden it.
	/// <br/>
	/// <br/>This field  is alpha-level. To use this field, you must enable the `AuthorizeWithSelectors` feature gate (disabled by default).
	/// </summary>
	[Newtonsoft.Json.JsonProperty("labelSelector", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public LabelSelectorAttributes LabelSelector { get; set; }

	/// <summary>
	/// Name is the name of the resource being requested for a "get" or deleted for a "delete". "" (empty) means all.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Name { get; set; }

	/// <summary>
	/// Namespace is the namespace of the action being requested.  Currently, there is no distinction between no namespace and all namespaces "" (empty) is defaulted for LocalSubjectAccessReviews "" (empty) is empty for cluster-scoped resources "" (empty) means "all" for namespace scoped resources from a SubjectAccessReview or SelfSubjectAccessReview
	/// </summary>
	[Newtonsoft.Json.JsonProperty("namespace", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Namespace { get; set; }

	/// <summary>
	/// Resource is one of the existing resource types.  "*" means all.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("resource", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Resource { get; set; }

	/// <summary>
	/// Subresource is one of the existing resource types.  "" means none.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("subresource", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Subresource { get; set; }

	/// <summary>
	/// Verb is a kubernetes resource API verb, like: get, list, watch, create, update, delete, proxy.  "*" means all.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("verb", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Verb { get; set; }

	/// <summary>
	/// Version is the API Version of the Resource.  "*" means all.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("version", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Version { get; set; }

}