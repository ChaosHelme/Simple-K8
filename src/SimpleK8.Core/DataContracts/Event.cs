namespace SimpleK8.Core.DataContracts;

/// <summary>
/// Event is a report of an event somewhere in the cluster.  Events have a limited retention time and triggers and messages may evolve with time.  Event consumers should not rely on the timing of an event with a given Reason reflecting a consistent underlying trigger, or the continued existence of events with that Reason.  Events should be treated as informative, best-effort, supplemental data.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class Event
{
	/// <summary>
	/// What action was taken/failed regarding to the Regarding object.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("action", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Action { get; set; }

	/// <summary>
	/// APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
	/// </summary>
	[Newtonsoft.Json.JsonProperty("apiVersion", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string ApiVersion { get; set; }

	/// <summary>
	/// The number of times this event has occurred.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? Count { get; set; }

	/// <summary>
	/// Time when this Event was first observed.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("eventTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.DateTimeOffset? EventTime { get; set; }

	/// <summary>
	/// The time at which the event was first recorded. (Time of server receipt is in TypeMeta.)
	/// </summary>
	[Newtonsoft.Json.JsonProperty("firstTimestamp", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.DateTimeOffset? FirstTimestamp { get; set; }

	/// <summary>
	/// The object that this event is about.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("involvedObject", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required]
	public ObjectReference InvolvedObject { get; set; } = new ObjectReference();

	/// <summary>
	/// Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
	/// </summary>
	[Newtonsoft.Json.JsonProperty("kind", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Kind { get; set; }

	/// <summary>
	/// The time at which the most recent occurrence of this event was recorded.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("lastTimestamp", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.DateTimeOffset? LastTimestamp { get; set; }

	/// <summary>
	/// A human-readable description of the status of this operation.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("message", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Message { get; set; }

	/// <summary>
	/// Standard object's metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
	/// </summary>
	[Newtonsoft.Json.JsonProperty("metadata", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required]
	public ObjectMeta Metadata { get; set; } = new ObjectMeta();

	/// <summary>
	/// This should be a short, machine understandable string that gives the reason for the transition into the object's current status.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("reason", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Reason { get; set; }

	/// <summary>
	/// Optional secondary object for more complex actions.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("related", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public ObjectReference Related { get; set; }

	/// <summary>
	/// Name of the controller that emitted this Event, e.g. `kubernetes.io/kubelet`.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("reportingComponent", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string ReportingComponent { get; set; }

	/// <summary>
	/// ID of the controller instance, e.g. `kubelet-xyzf`.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("reportingInstance", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string ReportingInstance { get; set; }

	/// <summary>
	/// Data about the Event series this event represents or nil if it's a singleton Event.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("series", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public EventSeries Series { get; set; }

	/// <summary>
	/// The component reporting this event. Should be a short machine understandable string.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("source", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public EventSource Source { get; set; }

	/// <summary>
	/// Type of this event (Normal, Warning), new types could be added in the future
	/// </summary>
	[Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Type { get; set; }

}