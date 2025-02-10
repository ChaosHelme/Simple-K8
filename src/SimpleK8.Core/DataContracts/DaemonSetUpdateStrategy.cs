namespace SimpleK8.Core.DataContracts;

/// <summary>
/// DaemonSetUpdateStrategy is a struct used to control the update strategy for a DaemonSet.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class DaemonSetUpdateStrategy
{
	/// <summary>
	/// Rolling update config params. Present only if type = "RollingUpdate".
	/// </summary>
	[Newtonsoft.Json.JsonProperty("rollingUpdate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public RollingUpdateDaemonSet RollingUpdate { get; set; }

	/// <summary>
	/// Type of daemon set update. Can be "RollingUpdate" or "OnDelete". Default is RollingUpdate.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Type { get; set; }

}