namespace SimpleK8.Core.DataContracts;

/// <summary>
/// HostIP represents a single IP address allocated to the host.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class HostIP
{
	/// <summary>
	/// IP is the IP address assigned to the host
	/// </summary>
	[Newtonsoft.Json.JsonProperty("ip", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Ip { get; set; }

}