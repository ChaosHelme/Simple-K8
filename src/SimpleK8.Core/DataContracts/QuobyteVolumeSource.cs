namespace SimpleK8.Core.DataContracts;

/// <summary>
/// Represents a Quobyte mount that lasts the lifetime of a pod. Quobyte volumes do not support ownership management or SELinux relabeling.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class QuobyteVolumeSource
{
	/// <summary>
	/// group to map volume access to Default is no group
	/// </summary>
	[Newtonsoft.Json.JsonProperty("group", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Group { get; set; }

	/// <summary>
	/// readOnly here will force the Quobyte volume to be mounted with read-only permissions. Defaults to false.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("readOnly", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public bool? ReadOnly { get; set; }

	/// <summary>
	/// registry represents a single or multiple Quobyte Registry services specified as a string as host:port pair (multiple entries are separated with commas) which acts as the central registry for volumes
	/// </summary>
	[Newtonsoft.Json.JsonProperty("registry", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Registry { get; set; }

	/// <summary>
	/// tenant owning the given Quobyte volume in the Backend Used with dynamically provisioned Quobyte volumes, value is set by the plugin
	/// </summary>
	[Newtonsoft.Json.JsonProperty("tenant", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Tenant { get; set; }

	/// <summary>
	/// user to map volume access to Defaults to serivceaccount user
	/// </summary>
	[Newtonsoft.Json.JsonProperty("user", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string User { get; set; }

	/// <summary>
	/// volume is a string that references an already created Quobyte volume by name.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("volume", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Volume { get; set; }

}