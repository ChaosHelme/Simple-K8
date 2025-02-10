namespace SimpleK8.Core.DataContracts;

/// <summary>
/// NodeDaemonEndpoints lists ports opened by daemons running on the Node.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class NodeDaemonEndpoints
{
	/// <summary>
	/// Endpoint on which Kubelet is listening.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("kubeletEndpoint", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public DaemonEndpoint KubeletEndpoint { get; set; }

}