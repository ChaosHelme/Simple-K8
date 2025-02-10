namespace SimpleK8.Core.DataContracts;

/// <summary>
/// PodIP represents a single IP address allocated to the pod.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class PodIP
{
	/// <summary>
	/// IP is the IP address assigned to the pod
	/// </summary>
	[Newtonsoft.Json.JsonProperty("ip", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Ip { get; set; }

}