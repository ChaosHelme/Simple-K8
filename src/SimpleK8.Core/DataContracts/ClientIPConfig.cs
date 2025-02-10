namespace SimpleK8.Core.DataContracts;

/// <summary>
/// ClientIPConfig represents the configurations of Client IP based session affinity.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class ClientIPConfig
{
	/// <summary>
	/// timeoutSeconds specifies the seconds of ClientIP type session sticky time. The value must be &gt;0 &amp;&amp; &lt;=86400(for 1 day) if ServiceAffinity == "ClientIP". Default value is 10800(for 3 hours).
	/// </summary>
	[Newtonsoft.Json.JsonProperty("timeoutSeconds", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? TimeoutSeconds { get; set; }

}