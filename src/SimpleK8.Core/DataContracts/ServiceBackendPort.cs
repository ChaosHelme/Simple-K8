namespace SimpleK8.Core.DataContracts;

/// <summary>
/// ServiceBackendPort is the service port being referenced.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class ServiceBackendPort
{
	/// <summary>
	/// name is the name of the port on the Service. This is a mutually exclusive setting with "Number".
	/// </summary>
	[Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Name { get; set; }

	/// <summary>
	/// number is the numerical port number (e.g. 80) on the Service. This is a mutually exclusive setting with "Name".
	/// </summary>
	[Newtonsoft.Json.JsonProperty("number", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? Number { get; set; }

}