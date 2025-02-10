namespace SimpleK8.Core.DataContracts;

/// <summary>
/// EndpointHints provides hints describing how an endpoint should be consumed.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class EndpointHints
{
	/// <summary>
	/// forZones indicates the zone(s) this endpoint should be consumed by to enable topology aware routing.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("forZones", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<ForZone> ForZones { get; set; }

}