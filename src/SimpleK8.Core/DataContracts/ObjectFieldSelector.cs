namespace SimpleK8.Core.DataContracts;

/// <summary>
/// ObjectFieldSelector selects an APIVersioned field of an object.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class ObjectFieldSelector
{
	/// <summary>
	/// Version of the schema the FieldPath is written in terms of, defaults to "v1".
	/// </summary>
	[Newtonsoft.Json.JsonProperty("apiVersion", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string ApiVersion { get; set; }

	/// <summary>
	/// Path of the field to select in the specified API version.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("fieldPath", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string FieldPath { get; set; }

}