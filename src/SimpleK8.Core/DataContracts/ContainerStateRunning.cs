namespace SimpleK8.Core.DataContracts;

/// <summary>
/// ContainerStateRunning is a running state of a container.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class ContainerStateRunning
{
	/// <summary>
	/// Time at which the container was last (re-)started
	/// </summary>
	[Newtonsoft.Json.JsonProperty("startedAt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.DateTimeOffset? StartedAt { get; set; }

}