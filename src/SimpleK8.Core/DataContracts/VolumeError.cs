namespace SimpleK8.Core.DataContracts;

/// <summary>
/// VolumeError captures an error encountered during a volume operation.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class VolumeError
{
	/// <summary>
	/// message represents the error encountered during Attach or Detach operation. This string may be logged, so it should not contain sensitive information.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("message", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Message { get; set; }

	/// <summary>
	/// time represents the time the error was encountered.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("time", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.DateTimeOffset? Time { get; set; }

}