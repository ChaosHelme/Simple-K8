namespace SimpleK8.Core.DataContracts;

/// <summary>
/// CustomResourceValidation is a list of validation methods for CustomResources.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class CustomResourceValidation
{
	/// <summary>
	/// openAPIV3Schema is the OpenAPI v3 schema to use for validation and pruning.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("openAPIV3Schema", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public JSONSchemaProps OpenAPIV3Schema { get; set; }

}