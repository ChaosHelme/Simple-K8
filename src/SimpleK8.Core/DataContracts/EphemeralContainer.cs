namespace SimpleK8.Core.DataContracts;

/// <summary>
/// An EphemeralContainer is a temporary container that you may add to an existing Pod for user-initiated activities such as debugging. Ephemeral containers have no resource or scheduling guarantees, and they will not be restarted when they exit or when a Pod is removed or restarted. The kubelet may evict a Pod if an ephemeral container causes the Pod to exceed its resource allocation.
/// <br/>
/// <br/>To add an ephemeral container, use the ephemeralcontainers subresource of an existing Pod. Ephemeral containers may not be removed or restarted.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class EphemeralContainer
{
	/// <summary>
	/// Arguments to the entrypoint. The image's CMD is used if this is not provided. Variable references $(VAR_NAME) are expanded using the container's environment. If a variable cannot be resolved, the reference in the input string will be unchanged. Double $$ are reduced to a single $, which allows for escaping the $(VAR_NAME) syntax: i.e. "$$(VAR_NAME)" will produce the string literal "$(VAR_NAME)". Escaped references will never be expanded, regardless of whether the variable exists or not. Cannot be updated. More info: https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell
	/// </summary>
	[Newtonsoft.Json.JsonProperty("args", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<string> Args { get; set; }

	/// <summary>
	/// Entrypoint array. Not executed within a shell. The image's ENTRYPOINT is used if this is not provided. Variable references $(VAR_NAME) are expanded using the container's environment. If a variable cannot be resolved, the reference in the input string will be unchanged. Double $$ are reduced to a single $, which allows for escaping the $(VAR_NAME) syntax: i.e. "$$(VAR_NAME)" will produce the string literal "$(VAR_NAME)". Escaped references will never be expanded, regardless of whether the variable exists or not. Cannot be updated. More info: https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell
	/// </summary>
	[Newtonsoft.Json.JsonProperty("command", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<string> Command { get; set; }

	/// <summary>
	/// List of environment variables to set in the container. Cannot be updated.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("env", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<EnvVar> Env { get; set; }

	/// <summary>
	/// List of sources to populate environment variables in the container. The keys defined within a source must be a C_IDENTIFIER. All invalid keys will be reported as an event when the container is starting. When a key exists in multiple sources, the value associated with the last source will take precedence. Values defined by an Env with a duplicate key will take precedence. Cannot be updated.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("envFrom", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<EnvFromSource> EnvFrom { get; set; }

	/// <summary>
	/// Container image name. More info: https://kubernetes.io/docs/concepts/containers/images
	/// </summary>
	[Newtonsoft.Json.JsonProperty("image", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Image { get; set; }

	/// <summary>
	/// Image pull policy. One of Always, Never, IfNotPresent. Defaults to Always if :latest tag is specified, or IfNotPresent otherwise. Cannot be updated. More info: https://kubernetes.io/docs/concepts/containers/images#updating-images
	/// </summary>
	[Newtonsoft.Json.JsonProperty("imagePullPolicy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string ImagePullPolicy { get; set; }

	/// <summary>
	/// Lifecycle is not allowed for ephemeral containers.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("lifecycle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public Lifecycle Lifecycle { get; set; }

	/// <summary>
	/// Probes are not allowed for ephemeral containers.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("livenessProbe", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public Probe LivenessProbe { get; set; }

	/// <summary>
	/// Name of the ephemeral container specified as a DNS_LABEL. This name must be unique among all containers, init containers and ephemeral containers.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Name { get; set; }

	/// <summary>
	/// Ports are not allowed for ephemeral containers.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("ports", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<ContainerPort> Ports { get; set; }

	/// <summary>
	/// Probes are not allowed for ephemeral containers.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("readinessProbe", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public Probe ReadinessProbe { get; set; }

	/// <summary>
	/// Resources resize policy for the container.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("resizePolicy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<ContainerResizePolicy> ResizePolicy { get; set; }

	/// <summary>
	/// Resources are not allowed for ephemeral containers. Ephemeral containers use spare resources already allocated to the pod.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("resources", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public ResourceRequirements Resources { get; set; }

	/// <summary>
	/// Restart policy for the container to manage the restart behavior of each container within a pod. This may only be set for init containers. You cannot set this field on ephemeral containers.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("restartPolicy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string RestartPolicy { get; set; }

	/// <summary>
	/// Optional: SecurityContext defines the security options the ephemeral container should be run with. If set, the fields of SecurityContext override the equivalent fields of PodSecurityContext.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("securityContext", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public SecurityContext SecurityContext { get; set; }

	/// <summary>
	/// Probes are not allowed for ephemeral containers.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("startupProbe", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public Probe StartupProbe { get; set; }

	/// <summary>
	/// Whether this container should allocate a buffer for stdin in the container runtime. If this is not set, reads from stdin in the container will always result in EOF. Default is false.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("stdin", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public bool? Stdin { get; set; }

	/// <summary>
	/// Whether the container runtime should close the stdin channel after it has been opened by a single attach. When stdin is true the stdin stream will remain open across multiple attach sessions. If stdinOnce is set to true, stdin is opened on container start, is empty until the first client attaches to stdin, and then remains open and accepts data until the client disconnects, at which time stdin is closed and remains closed until the container is restarted. If this flag is false, a container processes that reads from stdin will never receive an EOF. Default is false
	/// </summary>
	[Newtonsoft.Json.JsonProperty("stdinOnce", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public bool? StdinOnce { get; set; }

	/// <summary>
	/// If set, the name of the container from PodSpec that this ephemeral container targets. The ephemeral container will be run in the namespaces (IPC, PID, etc) of this container. If not set then the ephemeral container uses the namespaces configured in the Pod spec.
	/// <br/>
	/// <br/>The container runtime must implement support for this feature. If the runtime does not support namespace targeting then the result of setting this field is undefined.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("targetContainerName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string TargetContainerName { get; set; }

	/// <summary>
	/// Optional: Path at which the file to which the container's termination message will be written is mounted into the container's filesystem. Message written is intended to be brief final status, such as an assertion failure message. Will be truncated by the node if greater than 4096 bytes. The total message length across all containers will be limited to 12kb. Defaults to /dev/termination-log. Cannot be updated.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("terminationMessagePath", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string TerminationMessagePath { get; set; }

	/// <summary>
	/// Indicate how the termination message should be populated. File will use the contents of terminationMessagePath to populate the container status message on both success and failure. FallbackToLogsOnError will use the last chunk of container log output if the termination message file is empty and the container exited with an error. The log output is limited to 2048 bytes or 80 lines, whichever is smaller. Defaults to File. Cannot be updated.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("terminationMessagePolicy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string TerminationMessagePolicy { get; set; }

	/// <summary>
	/// Whether this container should allocate a TTY for itself, also requires 'stdin' to be true. Default is false.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("tty", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public bool? Tty { get; set; }

	/// <summary>
	/// volumeDevices is the list of block devices to be used by the container.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("volumeDevices", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<VolumeDevice> VolumeDevices { get; set; }

	/// <summary>
	/// Pod volumes to mount into the container's filesystem. Subpath mounts are not allowed for ephemeral containers. Cannot be updated.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("volumeMounts", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<VolumeMount> VolumeMounts { get; set; }

	/// <summary>
	/// Container's working directory. If not specified, the container runtime's default will be used, which might be configured in the container image. Cannot be updated.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("workingDir", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string WorkingDir { get; set; }

}