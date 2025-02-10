namespace SimpleK8.Core.DataContracts;

/// <summary>
/// SeccompProfile defines a pod/container's seccomp profile settings. Only one profile source may be set.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class SeccompProfile
{
	/// <summary>
	/// localhostProfile indicates a profile defined in a file on the node should be used. The profile must be preconfigured on the node to work. Must be a descending path, relative to the kubelet's configured seccomp profile location. Must be set if type is "Localhost". Must NOT be set for any other type.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("localhostProfile", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string LocalhostProfile { get; set; }

	/// <summary>
	/// type indicates which kind of seccomp profile will be applied. Valid options are:
	/// <br/>
	/// <br/>Localhost - a profile defined in a file on the node should be used. RuntimeDefault - the container runtime default profile should be used. Unconfined - no profile should be applied.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Type { get; set; }

}