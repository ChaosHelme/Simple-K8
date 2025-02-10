namespace SimpleK8.Core.DataContracts;

/// <summary>
/// PriorityLevelConfigurationReference contains information that points to the "request-priority" being used.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class PriorityLevelConfigurationReference
{
	/// <summary>
	/// `name` is the name of the priority level configuration being referenced Required.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Name { get; set; }

}