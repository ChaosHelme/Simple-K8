namespace SimpleK8.Core.DataContracts;

/// <summary>
/// SleepAction describes a "sleep" action.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class SleepAction
{
	/// <summary>
	/// Seconds is the number of seconds to sleep.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("seconds", Required = Newtonsoft.Json.Required.Always)]
	public long Seconds { get; set; }

}