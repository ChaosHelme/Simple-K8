namespace SimpleK8.Core.DataContracts;

/// <summary>
/// NodeSystemInfo is a set of ids/uuids to uniquely identify the node.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class NodeSystemInfo
{
	/// <summary>
	/// The Architecture reported by the node
	/// </summary>
	[Newtonsoft.Json.JsonProperty("architecture", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Architecture { get; set; }

	/// <summary>
	/// Boot ID reported by the node.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("bootID", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string BootID { get; set; }

	/// <summary>
	/// ContainerRuntime Version reported by the node through runtime remote API (e.g. containerd://1.4.2).
	/// </summary>
	[Newtonsoft.Json.JsonProperty("containerRuntimeVersion", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string ContainerRuntimeVersion { get; set; }

	/// <summary>
	/// Kernel Version reported by the node from 'uname -r' (e.g. 3.16.0-0.bpo.4-amd64).
	/// </summary>
	[Newtonsoft.Json.JsonProperty("kernelVersion", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string KernelVersion { get; set; }

	/// <summary>
	/// Deprecated: KubeProxy Version reported by the node.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("kubeProxyVersion", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string KubeProxyVersion { get; set; }

	/// <summary>
	/// Kubelet Version reported by the node.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("kubeletVersion", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string KubeletVersion { get; set; }

	/// <summary>
	/// MachineID reported by the node. For unique machine identification in the cluster this field is preferred. Learn more from man(5) machine-id: http://man7.org/linux/man-pages/man5/machine-id.5.html
	/// </summary>
	[Newtonsoft.Json.JsonProperty("machineID", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string MachineID { get; set; }

	/// <summary>
	/// The Operating System reported by the node
	/// </summary>
	[Newtonsoft.Json.JsonProperty("operatingSystem", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string OperatingSystem { get; set; }

	/// <summary>
	/// OS Image reported by the node from /etc/os-release (e.g. Debian GNU/Linux 7 (wheezy)).
	/// </summary>
	[Newtonsoft.Json.JsonProperty("osImage", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string OsImage { get; set; }

	/// <summary>
	/// SystemUUID reported by the node. For unique machine identification MachineID is preferred. This field is specific to Red Hat hosts https://access.redhat.com/documentation/en-us/red_hat_subscription_management/1/html/rhsm/uuid
	/// </summary>
	[Newtonsoft.Json.JsonProperty("systemUUID", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string SystemUUID { get; set; }

}