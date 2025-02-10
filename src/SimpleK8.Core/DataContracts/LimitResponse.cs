namespace SimpleK8.Core.DataContracts;

/// <summary>
/// LimitResponse defines how to handle requests that can not be executed right now.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class LimitResponse
{
	/// <summary>
	/// `queuing` holds the configuration parameters for queuing. This field may be non-empty only if `type` is `"Queue"`.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("queuing", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public QueuingConfiguration Queuing { get; set; }

	/// <summary>
	/// `type` is "Queue" or "Reject". "Queue" means that requests that can not be executed upon arrival are held in a queue until they can be executed or a queuing limit is reached. "Reject" means that requests that can not be executed upon arrival are rejected. Required.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Type { get; set; }

}