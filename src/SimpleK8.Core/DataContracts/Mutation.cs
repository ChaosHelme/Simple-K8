namespace SimpleK8.Core.DataContracts;

/// <summary>
/// Mutation specifies the CEL expression which is used to apply the Mutation.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class Mutation
{
	/// <summary>
	/// applyConfiguration defines the desired configuration values of an object. The configuration is applied to the admission object using [structured merge diff](https://github.com/kubernetes-sigs/structured-merge-diff). A CEL expression is used to create apply configuration.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("applyConfiguration", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public ApplyConfiguration ApplyConfiguration { get; set; }

	/// <summary>
	/// jsonPatch defines a [JSON patch](https://jsonpatch.com/) operation to perform a mutation to the object. A CEL expression is used to create the JSON patch.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("jsonPatch", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public JSONPatch JsonPatch { get; set; }

	/// <summary>
	/// patchType indicates the patch strategy used. Allowed values are "ApplyConfiguration" and "JSONPatch". Required.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("patchType", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string PatchType { get; set; }

}