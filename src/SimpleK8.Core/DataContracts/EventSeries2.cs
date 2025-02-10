namespace SimpleK8.Core.DataContracts;

/// <summary>
/// EventSeries contain information on series of events, i.e. thing that was/is happening continuously for some time. How often to update the EventSeries is up to the event reporters. The default event reporter in "k8s.io/client-go/tools/events/event_broadcaster.go" shows how this struct is updated on heartbeats and can guide customized reporter implementations.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class EventSeries2
{
	/// <summary>
	/// count is the number of occurrences in this series up to the last heartbeat time.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("count", Required = Newtonsoft.Json.Required.Always)]
	public int Count { get; set; }

	/// <summary>
	/// lastObservedTime is the time when last Event from the series was seen before last heartbeat.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("lastObservedTime", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public System.DateTimeOffset LastObservedTime { get; set; }

}