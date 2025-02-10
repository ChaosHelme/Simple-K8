namespace SimpleK8.Core.DataContracts;

/// <summary>
/// ContainerResizePolicy represents resource resize policy for the container.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class ContainerResizePolicy
{
	/// <summary>
	/// Name of the resource to which this resource resize policy applies. Supported values: cpu, memory.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("resourceName", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string ResourceName { get; set; }

	/// <summary>
	/// Restart policy to apply when specified resource is resized. If not specified, it defaults to NotRequired.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("restartPolicy", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string RestartPolicy { get; set; }

}