namespace SimpleK8.Core.DataContracts;

/// <summary>
/// NodeRuntimeHandlerFeatures is a set of features implemented by the runtime handler.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class NodeRuntimeHandlerFeatures
{
	/// <summary>
	/// RecursiveReadOnlyMounts is set to true if the runtime handler supports RecursiveReadOnlyMounts.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("recursiveReadOnlyMounts", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public bool? RecursiveReadOnlyMounts { get; set; }

	/// <summary>
	/// UserNamespaces is set to true if the runtime handler supports UserNamespaces, including for volumes.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("userNamespaces", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public bool? UserNamespaces { get; set; }

}