namespace SimpleK8.Core.DataContracts;

/// <summary>
/// EventSeries contain information on series of events, i.e. thing that was/is happening continuously for some time.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class EventSeries
{
	/// <summary>
	/// Number of occurrences in this series up to the last heartbeat time
	/// </summary>
	[Newtonsoft.Json.JsonProperty("count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? Count { get; set; }

	/// <summary>
	/// Time of the last occurrence observed
	/// </summary>
	[Newtonsoft.Json.JsonProperty("lastObservedTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.DateTimeOffset? LastObservedTime { get; set; }

}