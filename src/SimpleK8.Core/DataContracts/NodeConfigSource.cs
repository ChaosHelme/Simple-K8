namespace SimpleK8.Core.DataContracts;

/// <summary>
/// NodeConfigSource specifies a source of node configuration. Exactly one subfield (excluding metadata) must be non-nil. This API is deprecated since 1.22
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class NodeConfigSource
{
	/// <summary>
	/// ConfigMap is a reference to a Node's ConfigMap
	/// </summary>
	[Newtonsoft.Json.JsonProperty("configMap", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public ConfigMapNodeConfigSource ConfigMap { get; set; }

}