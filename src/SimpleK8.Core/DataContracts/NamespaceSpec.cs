namespace SimpleK8.Core.DataContracts;

/// <summary>
/// NamespaceSpec describes the attributes on a Namespace.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class NamespaceSpec
{
	/// <summary>
	/// Finalizers is an opaque list of values that must be empty to permanently remove object from storage. More info: https://kubernetes.io/docs/tasks/administer-cluster/namespaces/
	/// </summary>
	[Newtonsoft.Json.JsonProperty("finalizers", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<string> Finalizers { get; set; }

}