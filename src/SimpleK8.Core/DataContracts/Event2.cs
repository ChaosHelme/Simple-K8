namespace SimpleK8.Core.DataContracts;

/// <summary>
/// Event is a report of an event somewhere in the cluster. It generally denotes some state change in the system. Events have a limited retention time and triggers and messages may evolve with time.  Event consumers should not rely on the timing of an event with a given Reason reflecting a consistent underlying trigger, or the continued existence of events with that Reason.  Events should be treated as informative, best-effort, supplemental data.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class Event2
{
	/// <summary>
	/// action is what action was taken/failed regarding to the regarding object. It is machine-readable. This field cannot be empty for new Events and it can have at most 128 characters.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("action", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Action { get; set; }

	/// <summary>
	/// APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
	/// </summary>
	[Newtonsoft.Json.JsonProperty("apiVersion", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string ApiVersion { get; set; }

	/// <summary>
	/// deprecatedCount is the deprecated field assuring backward compatibility with core.v1 Event type.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("deprecatedCount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? DeprecatedCount { get; set; }

	/// <summary>
	/// deprecatedFirstTimestamp is the deprecated field assuring backward compatibility with core.v1 Event type.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("deprecatedFirstTimestamp", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.DateTimeOffset? DeprecatedFirstTimestamp { get; set; }

	/// <summary>
	/// deprecatedLastTimestamp is the deprecated field assuring backward compatibility with core.v1 Event type.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("deprecatedLastTimestamp", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.DateTimeOffset? DeprecatedLastTimestamp { get; set; }

	/// <summary>
	/// deprecatedSource is the deprecated field assuring backward compatibility with core.v1 Event type.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("deprecatedSource", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public EventSource DeprecatedSource { get; set; }

	/// <summary>
	/// eventTime is the time when this Event was first observed. It is required.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("eventTime", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public System.DateTimeOffset EventTime { get; set; }

	/// <summary>
	/// Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
	/// </summary>
	[Newtonsoft.Json.JsonProperty("kind", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Kind { get; set; }

	/// <summary>
	/// Standard object's metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
	/// </summary>
	[Newtonsoft.Json.JsonProperty("metadata", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public ObjectMeta Metadata { get; set; }

	/// <summary>
	/// note is a human-readable description of the status of this operation. Maximal length of the note is 1kB, but libraries should be prepared to handle values up to 64kB.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("note", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Note { get; set; }

	/// <summary>
	/// reason is why the action was taken. It is human-readable. This field cannot be empty for new Events and it can have at most 128 characters.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("reason", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Reason { get; set; }

	/// <summary>
	/// regarding contains the object this Event is about. In most cases it's an Object reporting controller implements, e.g. ReplicaSetController implements ReplicaSets and this event is emitted because it acts on some changes in a ReplicaSet object.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("regarding", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public ObjectReference Regarding { get; set; }

	/// <summary>
	/// related is the optional secondary object for more complex actions. E.g. when regarding object triggers a creation or deletion of related object.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("related", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public ObjectReference Related { get; set; }

	/// <summary>
	/// reportingController is the name of the controller that emitted this Event, e.g. `kubernetes.io/kubelet`. This field cannot be empty for new Events.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("reportingController", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string ReportingController { get; set; }

	/// <summary>
	/// reportingInstance is the ID of the controller instance, e.g. `kubelet-xyzf`. This field cannot be empty for new Events and it can have at most 128 characters.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("reportingInstance", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string ReportingInstance { get; set; }

	/// <summary>
	/// series is data about the Event series this event represents or nil if it's a singleton Event.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("series", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public EventSeries2 Series { get; set; }

	/// <summary>
	/// type is the type of this event (Normal, Warning), new types could be added in the future. It is machine-readable. This field cannot be empty for new Events.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Type { get; set; }

}