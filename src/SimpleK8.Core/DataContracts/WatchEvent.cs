namespace SimpleK8.Core.DataContracts;

/// <summary>
/// Event represents a single event to a watched resource.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class WatchEvent
{
	/// <summary>
	/// Object is:
	/// <br/> * If Type is Added or Modified: the new state of the object.
	/// <br/> * If Type is Deleted: the state of the object immediately before deletion.
	/// <br/> * If Type is Error: *Status is recommended; other types may make sense
	/// <br/>   depending on context.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("object", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required]
	public RawExtension Object { get; set; } = new RawExtension();

	[Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Type { get; set; }

}