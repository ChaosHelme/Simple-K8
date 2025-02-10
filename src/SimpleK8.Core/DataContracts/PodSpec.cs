namespace SimpleK8.Core.DataContracts;

/// <summary>
/// PodSpec is a description of a pod.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class PodSpec
{
	/// <summary>
	/// Optional duration in seconds the pod may be active on the node relative to StartTime before the system will actively try to mark it failed and kill associated containers. Value must be a positive integer.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("activeDeadlineSeconds", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public long? ActiveDeadlineSeconds { get; set; }

	/// <summary>
	/// If specified, the pod's scheduling constraints
	/// </summary>
	[Newtonsoft.Json.JsonProperty("affinity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public Affinity Affinity { get; set; }

	/// <summary>
	/// AutomountServiceAccountToken indicates whether a service account token should be automatically mounted.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("automountServiceAccountToken", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public bool? AutomountServiceAccountToken { get; set; }

	/// <summary>
	/// List of containers belonging to the pod. Containers cannot currently be added or removed. There must be at least one container in a Pod. Cannot be updated.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("containers", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required]
	public System.Collections.Generic.List<Container> Containers { get; set; } = new System.Collections.Generic.List<Container>();

	/// <summary>
	/// Specifies the DNS parameters of a pod. Parameters specified here will be merged to the generated DNS configuration based on DNSPolicy.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("dnsConfig", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public PodDNSConfig DnsConfig { get; set; }

	/// <summary>
	/// Set DNS policy for the pod. Defaults to "ClusterFirst". Valid values are 'ClusterFirstWithHostNet', 'ClusterFirst', 'Default' or 'None'. DNS parameters given in DNSConfig will be merged with the policy selected with DNSPolicy. To have DNS options set along with hostNetwork, you have to specify DNS policy explicitly to 'ClusterFirstWithHostNet'.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("dnsPolicy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string DnsPolicy { get; set; }

	/// <summary>
	/// EnableServiceLinks indicates whether information about services should be injected into pod's environment variables, matching the syntax of Docker links. Optional: Defaults to true.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("enableServiceLinks", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public bool? EnableServiceLinks { get; set; }

	/// <summary>
	/// List of ephemeral containers run in this pod. Ephemeral containers may be run in an existing pod to perform user-initiated actions such as debugging. This list cannot be specified when creating a pod, and it cannot be modified by updating the pod spec. In order to add an ephemeral container to an existing pod, use the pod's ephemeralcontainers subresource.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("ephemeralContainers", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<EphemeralContainer> EphemeralContainers { get; set; }

	/// <summary>
	/// HostAliases is an optional list of hosts and IPs that will be injected into the pod's hosts file if specified.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("hostAliases", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<HostAlias> HostAliases { get; set; }

	/// <summary>
	/// Use the host's ipc namespace. Optional: Default to false.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("hostIPC", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public bool? HostIPC { get; set; }

	/// <summary>
	/// Host networking requested for this pod. Use the host's network namespace. If this option is set, the ports that will be used must be specified. Default to false.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("hostNetwork", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public bool? HostNetwork { get; set; }

	/// <summary>
	/// Use the host's pid namespace. Optional: Default to false.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("hostPID", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public bool? HostPID { get; set; }

	/// <summary>
	/// Use the host's user namespace. Optional: Default to true. If set to true or not present, the pod will be run in the host user namespace, useful for when the pod needs a feature only available to the host user namespace, such as loading a kernel module with CAP_SYS_MODULE. When set to false, a new userns is created for the pod. Setting false is useful for mitigating container breakout vulnerabilities even allowing users to run their containers as root without actually having root privileges on the host. This field is alpha-level and is only honored by servers that enable the UserNamespacesSupport feature.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("hostUsers", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public bool? HostUsers { get; set; }

	/// <summary>
	/// Specifies the hostname of the Pod If not specified, the pod's hostname will be set to a system-defined value.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("hostname", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Hostname { get; set; }

	/// <summary>
	/// ImagePullSecrets is an optional list of references to secrets in the same namespace to use for pulling any of the images used by this PodSpec. If specified, these secrets will be passed to individual puller implementations for them to use. More info: https://kubernetes.io/docs/concepts/containers/images#specifying-imagepullsecrets-on-a-pod
	/// </summary>
	[Newtonsoft.Json.JsonProperty("imagePullSecrets", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<LocalObjectReference> ImagePullSecrets { get; set; }

	/// <summary>
	/// List of initialization containers belonging to the pod. Init containers are executed in order prior to containers being started. If any init container fails, the pod is considered to have failed and is handled according to its restartPolicy. The name for an init container or normal container must be unique among all containers. Init containers may not have Lifecycle actions, Readiness probes, Liveness probes, or Startup probes. The resourceRequirements of an init container are taken into account during scheduling by finding the highest request/limit for each resource type, and then using the max of of that value or the sum of the normal containers. Limits are applied to init containers in a similar fashion. Init containers cannot currently be added or removed. Cannot be updated. More info: https://kubernetes.io/docs/concepts/workloads/pods/init-containers/
	/// </summary>
	[Newtonsoft.Json.JsonProperty("initContainers", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<Container> InitContainers { get; set; }

	/// <summary>
	/// NodeName indicates in which node this pod is scheduled. If empty, this pod is a candidate for scheduling by the scheduler defined in schedulerName. Once this field is set, the kubelet for this node becomes responsible for the lifecycle of this pod. This field should not be used to express a desire for the pod to be scheduled on a specific node. https://kubernetes.io/docs/concepts/scheduling-eviction/assign-pod-node/#nodename
	/// </summary>
	[Newtonsoft.Json.JsonProperty("nodeName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string NodeName { get; set; }

	/// <summary>
	/// NodeSelector is a selector which must be true for the pod to fit on a node. Selector which must match a node's labels for the pod to be scheduled on that node. More info: https://kubernetes.io/docs/concepts/configuration/assign-pod-node/
	/// </summary>
	[Newtonsoft.Json.JsonProperty("nodeSelector", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.IDictionary<string, string> NodeSelector { get; set; }

	/// <summary>
	/// Specifies the OS of the containers in the pod. Some pod and container fields are restricted if this is set.
	/// <br/>
	/// <br/>If the OS field is set to linux, the following fields must be unset: -securityContext.windowsOptions
	/// <br/>
	/// <br/>If the OS field is set to windows, following fields must be unset: - spec.hostPID - spec.hostIPC - spec.hostUsers - spec.securityContext.appArmorProfile - spec.securityContext.seLinuxOptions - spec.securityContext.seccompProfile - spec.securityContext.fsGroup - spec.securityContext.fsGroupChangePolicy - spec.securityContext.sysctls - spec.shareProcessNamespace - spec.securityContext.runAsUser - spec.securityContext.runAsGroup - spec.securityContext.supplementalGroups - spec.securityContext.supplementalGroupsPolicy - spec.containers[*].securityContext.appArmorProfile - spec.containers[*].securityContext.seLinuxOptions - spec.containers[*].securityContext.seccompProfile - spec.containers[*].securityContext.capabilities - spec.containers[*].securityContext.readOnlyRootFilesystem - spec.containers[*].securityContext.privileged - spec.containers[*].securityContext.allowPrivilegeEscalation - spec.containers[*].securityContext.procMount - spec.containers[*].securityContext.runAsUser - spec.containers[*].securityContext.runAsGroup
	/// </summary>
	[Newtonsoft.Json.JsonProperty("os", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public PodOS Os { get; set; }

	/// <summary>
	/// Overhead represents the resource overhead associated with running a pod for a given RuntimeClass. This field will be autopopulated at admission time by the RuntimeClass admission controller. If the RuntimeClass admission controller is enabled, overhead must not be set in Pod create requests. The RuntimeClass admission controller will reject Pod create requests which have the overhead already set. If RuntimeClass is configured and selected in the PodSpec, Overhead will be set to the value defined in the corresponding RuntimeClass, otherwise it will remain unset and treated as zero. More info: https://git.k8s.io/enhancements/keps/sig-node/688-pod-overhead/README.md
	/// </summary>
	[Newtonsoft.Json.JsonProperty("overhead", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.IDictionary<string, string> Overhead { get; set; }

	/// <summary>
	/// PreemptionPolicy is the Policy for preempting pods with lower priority. One of Never, PreemptLowerPriority. Defaults to PreemptLowerPriority if unset.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("preemptionPolicy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string PreemptionPolicy { get; set; }

	/// <summary>
	/// The priority value. Various system components use this field to find the priority of the pod. When Priority Admission Controller is enabled, it prevents users from setting this field. The admission controller populates this field from PriorityClassName. The higher the value, the higher the priority.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("priority", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? Priority { get; set; }

	/// <summary>
	/// If specified, indicates the pod's priority. "system-node-critical" and "system-cluster-critical" are two special keywords which indicate the highest priorities with the former being the highest priority. Any other name must be defined by creating a PriorityClass object with that name. If not specified, the pod priority will be default or zero if there is no default.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("priorityClassName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string PriorityClassName { get; set; }

	/// <summary>
	/// If specified, all readiness gates will be evaluated for pod readiness. A pod is ready when all its containers are ready AND all conditions specified in the readiness gates have status equal to "True" More info: https://git.k8s.io/enhancements/keps/sig-network/580-pod-readiness-gates
	/// </summary>
	[Newtonsoft.Json.JsonProperty("readinessGates", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<PodReadinessGate> ReadinessGates { get; set; }

	/// <summary>
	/// ResourceClaims defines which ResourceClaims must be allocated and reserved before the Pod is allowed to start. The resources will be made available to those containers which consume them by name.
	/// <br/>
	/// <br/>This is an alpha field and requires enabling the DynamicResourceAllocation feature gate.
	/// <br/>
	/// <br/>This field is immutable.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("resourceClaims", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<PodResourceClaim> ResourceClaims { get; set; }

	/// <summary>
	/// Resources is the total amount of CPU and Memory resources required by all containers in the pod. It supports specifying Requests and Limits for "cpu" and "memory" resource names only. ResourceClaims are not supported.
	/// <br/>
	/// <br/>This field enables fine-grained control over resource allocation for the entire pod, allowing resource sharing among containers in a pod.
	/// <br/>
	/// <br/>This is an alpha field and requires enabling the PodLevelResources feature gate.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("resources", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public ResourceRequirements Resources { get; set; }

	/// <summary>
	/// Restart policy for all containers within the pod. One of Always, OnFailure, Never. In some contexts, only a subset of those values may be permitted. Default to Always. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle/#restart-policy
	/// </summary>
	[Newtonsoft.Json.JsonProperty("restartPolicy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string RestartPolicy { get; set; }

	/// <summary>
	/// RuntimeClassName refers to a RuntimeClass object in the node.k8s.io group, which should be used to run this pod.  If no RuntimeClass resource matches the named class, the pod will not be run. If unset or empty, the "legacy" RuntimeClass will be used, which is an implicit class with an empty definition that uses the default runtime handler. More info: https://git.k8s.io/enhancements/keps/sig-node/585-runtime-class
	/// </summary>
	[Newtonsoft.Json.JsonProperty("runtimeClassName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string RuntimeClassName { get; set; }

	/// <summary>
	/// If specified, the pod will be dispatched by specified scheduler. If not specified, the pod will be dispatched by default scheduler.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("schedulerName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string SchedulerName { get; set; }

	/// <summary>
	/// SchedulingGates is an opaque list of values that if specified will block scheduling the pod. If schedulingGates is not empty, the pod will stay in the SchedulingGated state and the scheduler will not attempt to schedule the pod.
	/// <br/>
	/// <br/>SchedulingGates can only be set at pod creation time, and be removed only afterwards.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("schedulingGates", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<PodSchedulingGate> SchedulingGates { get; set; }

	/// <summary>
	/// SecurityContext holds pod-level security attributes and common container settings. Optional: Defaults to empty.  See type description for default values of each field.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("securityContext", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public PodSecurityContext SecurityContext { get; set; }

	/// <summary>
	/// DeprecatedServiceAccount is a deprecated alias for ServiceAccountName. Deprecated: Use serviceAccountName instead.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("serviceAccount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string ServiceAccount { get; set; }

	/// <summary>
	/// ServiceAccountName is the name of the ServiceAccount to use to run this pod. More info: https://kubernetes.io/docs/tasks/configure-pod-container/configure-service-account/
	/// </summary>
	[Newtonsoft.Json.JsonProperty("serviceAccountName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string ServiceAccountName { get; set; }

	/// <summary>
	/// If true the pod's hostname will be configured as the pod's FQDN, rather than the leaf name (the default). In Linux containers, this means setting the FQDN in the hostname field of the kernel (the nodename field of struct utsname). In Windows containers, this means setting the registry value of hostname for the registry key HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters to FQDN. If a pod does not have FQDN, this has no effect. Default to false.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("setHostnameAsFQDN", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public bool? SetHostnameAsFQDN { get; set; }

	/// <summary>
	/// Share a single process namespace between all of the containers in a pod. When this is set containers will be able to view and signal processes from other containers in the same pod, and the first process in each container will not be assigned PID 1. HostPID and ShareProcessNamespace cannot both be set. Optional: Default to false.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("shareProcessNamespace", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public bool? ShareProcessNamespace { get; set; }

	/// <summary>
	/// If specified, the fully qualified Pod hostname will be "&lt;hostname&gt;.&lt;subdomain&gt;.&lt;pod namespace&gt;.svc.&lt;cluster domain&gt;". If not specified, the pod will not have a domainname at all.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("subdomain", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Subdomain { get; set; }

	/// <summary>
	/// Optional duration in seconds the pod needs to terminate gracefully. May be decreased in delete request. Value must be non-negative integer. The value zero indicates stop immediately via the kill signal (no opportunity to shut down). If this value is nil, the default grace period will be used instead. The grace period is the duration in seconds after the processes running in the pod are sent a termination signal and the time when the processes are forcibly halted with a kill signal. Set this value longer than the expected cleanup time for your process. Defaults to 30 seconds.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("terminationGracePeriodSeconds", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public long? TerminationGracePeriodSeconds { get; set; }

	/// <summary>
	/// If specified, the pod's tolerations.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("tolerations", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<Toleration> Tolerations { get; set; }

	/// <summary>
	/// TopologySpreadConstraints describes how a group of pods ought to spread across topology domains. Scheduler will schedule pods in a way which abides by the constraints. All topologySpreadConstraints are ANDed.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("topologySpreadConstraints", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<TopologySpreadConstraint> TopologySpreadConstraints { get; set; }

	/// <summary>
	/// List of volumes that can be mounted by containers belonging to the pod. More info: https://kubernetes.io/docs/concepts/storage/volumes
	/// </summary>
	[Newtonsoft.Json.JsonProperty("volumes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<Volume> Volumes { get; set; }

}