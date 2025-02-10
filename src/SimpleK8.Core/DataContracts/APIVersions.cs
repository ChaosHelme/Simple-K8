namespace SimpleK8.Core.DataContracts;

/// <summary>
/// APIVersions lists the versions that are available, to allow clients to discover the API at /api, which is the root path of the legacy v1 API.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class APIVersions
{
	/// <summary>
	/// APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
	/// </summary>
	[Newtonsoft.Json.JsonProperty("apiVersion", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string ApiVersion { get; set; }

	/// <summary>
	/// Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
	/// </summary>
	[Newtonsoft.Json.JsonProperty("kind", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Kind { get; set; }

	/// <summary>
	/// a map of client CIDR to server address that is serving this group. This is to help clients reach servers in the most network-efficient way possible. Clients can use the appropriate server address as per the CIDR that they match. In case of multiple matches, clients should use the longest matching CIDR. The server returns only those CIDRs that it thinks that the client can match. For example: the master will return an internal IP CIDR only, if the client reaches the server using an internal IP. Server looks at X-Forwarded-For header or X-Real-Ip header or request.RemoteAddr (in that order) to get the client IP.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("serverAddressByClientCIDRs", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required]
	public System.Collections.Generic.List<ServerAddressByClientCIDR> ServerAddressByClientCIDRs { get; set; } = new System.Collections.Generic.List<ServerAddressByClientCIDR>();

	/// <summary>
	/// versions are the api versions that are available.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("versions", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required]
	public System.Collections.Generic.List<string> Versions { get; set; } = new System.Collections.Generic.List<string>();

}