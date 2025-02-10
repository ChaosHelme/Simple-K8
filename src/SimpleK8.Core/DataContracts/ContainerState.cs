namespace SimpleK8.Core.DataContracts;

/// <summary>
/// ContainerState holds a possible state of container. Only one of its members may be specified. If none of them is specified, the default one is ContainerStateWaiting.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class ContainerState
{
	/// <summary>
	/// Details about a running container
	/// </summary>
	[Newtonsoft.Json.JsonProperty("running", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public ContainerStateRunning Running { get; set; }

	/// <summary>
	/// Details about a terminated container
	/// </summary>
	[Newtonsoft.Json.JsonProperty("terminated", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public ContainerStateTerminated Terminated { get; set; }

	/// <summary>
	/// Details about a waiting container
	/// </summary>
	[Newtonsoft.Json.JsonProperty("waiting", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public ContainerStateWaiting Waiting { get; set; }

}