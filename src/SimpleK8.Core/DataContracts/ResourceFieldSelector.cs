namespace SimpleK8.Core.DataContracts;

/// <summary>
/// ResourceFieldSelector represents container resources (cpu, memory) and their output format
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class ResourceFieldSelector
{
	/// <summary>
	/// Container name: required for volumes, optional for env vars
	/// </summary>
	[Newtonsoft.Json.JsonProperty("containerName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string ContainerName { get; set; }

	/// <summary>
	/// Specifies the output format of the exposed resources, defaults to "1"
	/// </summary>
	[Newtonsoft.Json.JsonProperty("divisor", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Divisor { get; set; }

	/// <summary>
	/// Required: resource to select
	/// </summary>
	[Newtonsoft.Json.JsonProperty("resource", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Resource { get; set; }

}