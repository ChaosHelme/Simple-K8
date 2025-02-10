namespace SimpleK8.Core.DataContracts;

/// <summary>
/// PodSchedulingGate is associated to a Pod to guard its scheduling.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class PodSchedulingGate
{
	/// <summary>
	/// Name of the scheduling gate. Each scheduling gate must have a unique name field.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Name { get; set; }

}