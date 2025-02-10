namespace SimpleK8.Core.DataContracts;

/// <summary>
/// LinuxContainerUser represents user identity information in Linux containers
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class LinuxContainerUser
{
	/// <summary>
	/// GID is the primary gid initially attached to the first process in the container
	/// </summary>
	[Newtonsoft.Json.JsonProperty("gid", Required = Newtonsoft.Json.Required.Always)]
	public long Gid { get; set; }

	/// <summary>
	/// SupplementalGroups are the supplemental groups initially attached to the first process in the container
	/// </summary>
	[Newtonsoft.Json.JsonProperty("supplementalGroups", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<long> SupplementalGroups { get; set; }

	/// <summary>
	/// UID is the primary uid initially attached to the first process in the container
	/// </summary>
	[Newtonsoft.Json.JsonProperty("uid", Required = Newtonsoft.Json.Required.Always)]
	public long Uid { get; set; }

}