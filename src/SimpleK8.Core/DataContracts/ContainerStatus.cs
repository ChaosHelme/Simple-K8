namespace SimpleK8.Core.DataContracts;

/// <summary>
/// ContainerStatus contains details for the current status of this container.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class ContainerStatus
{
	/// <summary>
	/// AllocatedResources represents the compute resources allocated for this container by the node. Kubelet sets this value to Container.Resources.Requests upon successful pod admission and after successfully admitting desired pod resize.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("allocatedResources", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.IDictionary<string, string> AllocatedResources { get; set; }

	/// <summary>
	/// AllocatedResourcesStatus represents the status of various resources allocated for this Pod.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("allocatedResourcesStatus", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<ResourceStatus> AllocatedResourcesStatus { get; set; }

	/// <summary>
	/// ContainerID is the ID of the container in the format '&lt;type&gt;://&lt;container_id&gt;'. Where type is a container runtime identifier, returned from Version call of CRI API (for example "containerd").
	/// </summary>
	[Newtonsoft.Json.JsonProperty("containerID", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string ContainerID { get; set; }

	/// <summary>
	/// Image is the name of container image that the container is running. The container image may not match the image used in the PodSpec, as it may have been resolved by the runtime. More info: https://kubernetes.io/docs/concepts/containers/images.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("image", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Image { get; set; }

	/// <summary>
	/// ImageID is the image ID of the container's image. The image ID may not match the image ID of the image used in the PodSpec, as it may have been resolved by the runtime.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("imageID", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string ImageID { get; set; }

	/// <summary>
	/// LastTerminationState holds the last termination state of the container to help debug container crashes and restarts. This field is not populated if the container is still running and RestartCount is 0.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("lastState", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public ContainerState LastState { get; set; }

	/// <summary>
	/// Name is a DNS_LABEL representing the unique name of the container. Each container in a pod must have a unique name across all container types. Cannot be updated.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Name { get; set; }

	/// <summary>
	/// Ready specifies whether the container is currently passing its readiness check. The value will change as readiness probes keep executing. If no readiness probes are specified, this field defaults to true once the container is fully started (see Started field).
	/// <br/>
	/// <br/>The value is typically used to determine whether a container is ready to accept traffic.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("ready", Required = Newtonsoft.Json.Required.Always)]
	public bool Ready { get; set; }

	/// <summary>
	/// Resources represents the compute resource requests and limits that have been successfully enacted on the running container after it has been started or has been successfully resized.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("resources", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public ResourceRequirements Resources { get; set; }

	/// <summary>
	/// RestartCount holds the number of times the container has been restarted. Kubelet makes an effort to always increment the value, but there are cases when the state may be lost due to node restarts and then the value may be reset to 0. The value is never negative.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("restartCount", Required = Newtonsoft.Json.Required.Always)]
	public int RestartCount { get; set; }

	/// <summary>
	/// Started indicates whether the container has finished its postStart lifecycle hook and passed its startup probe. Initialized as false, becomes true after startupProbe is considered successful. Resets to false when the container is restarted, or if kubelet loses state temporarily. In both cases, startup probes will run again. Is always true when no startupProbe is defined and container is running and has passed the postStart lifecycle hook. The null value must be treated the same as false.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("started", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public bool? Started { get; set; }

	/// <summary>
	/// State holds details about the container's current condition.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("state", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public ContainerState State { get; set; }

	/// <summary>
	/// User represents user identity information initially attached to the first process of the container
	/// </summary>
	[Newtonsoft.Json.JsonProperty("user", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public ContainerUser User { get; set; }

	/// <summary>
	/// Status of volume mounts.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("volumeMounts", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<VolumeMountStatus> VolumeMounts { get; set; }

}