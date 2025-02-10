namespace SimpleK8.Core.DataContracts;

/// <summary>
/// HostAlias holds the mapping between IP and hostnames that will be injected as an entry in the pod's hosts file.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class HostAlias
{
	/// <summary>
	/// Hostnames for the above IP address.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("hostnames", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<string> Hostnames { get; set; }

	/// <summary>
	/// IP address of the host file entry.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("ip", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Ip { get; set; }

}