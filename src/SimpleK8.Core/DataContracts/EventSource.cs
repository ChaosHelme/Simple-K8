namespace SimpleK8.Core.DataContracts;

/// <summary>
/// EventSource contains information for an event.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class EventSource
{
	/// <summary>
	/// Component from which the event is generated.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("component", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Component { get; set; }

	/// <summary>
	/// Node name on which the event is generated.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("host", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Host { get; set; }

}