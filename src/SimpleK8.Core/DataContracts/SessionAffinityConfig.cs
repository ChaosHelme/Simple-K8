namespace SimpleK8.Core.DataContracts;

/// <summary>
/// SessionAffinityConfig represents the configurations of session affinity.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class SessionAffinityConfig
{
	/// <summary>
	/// clientIP contains the configurations of Client IP based session affinity.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("clientIP", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public ClientIPConfig ClientIP { get; set; }

}