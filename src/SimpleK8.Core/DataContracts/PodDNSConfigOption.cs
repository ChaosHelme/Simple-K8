namespace SimpleK8.Core.DataContracts;

/// <summary>
/// PodDNSConfigOption defines DNS resolver options of a pod.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class PodDNSConfigOption
{
	/// <summary>
	/// Name is this DNS resolver option's name. Required.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Name { get; set; }

	/// <summary>
	/// Value is this DNS resolver option's value.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Value { get; set; }

}