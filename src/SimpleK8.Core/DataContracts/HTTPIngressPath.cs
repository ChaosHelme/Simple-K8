namespace SimpleK8.Core.DataContracts;

/// <summary>
/// HTTPIngressPath associates a path with a backend. Incoming urls matching the path are forwarded to the backend.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class HTTPIngressPath
{
	/// <summary>
	/// backend defines the referenced service endpoint to which the traffic will be forwarded to.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("backend", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required]
	public IngressBackend Backend { get; set; } = new IngressBackend();

	/// <summary>
	/// path is matched against the path of an incoming request. Currently it can contain characters disallowed from the conventional "path" part of a URL as defined by RFC 3986. Paths must begin with a '/' and must be present when using PathType with value "Exact" or "Prefix".
	/// </summary>
	[Newtonsoft.Json.JsonProperty("path", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Path { get; set; }

	/// <summary>
	/// pathType determines the interpretation of the path matching. PathType can be one of the following values: * Exact: Matches the URL path exactly. * Prefix: Matches based on a URL path prefix split by '/'. Matching is
	/// <br/>  done on a path element by element basis. A path element refers is the
	/// <br/>  list of labels in the path split by the '/' separator. A request is a
	/// <br/>  match for path p if every p is an element-wise prefix of p of the
	/// <br/>  request path. Note that if the last element of the path is a substring
	/// <br/>  of the last element in request path, it is not a match (e.g. /foo/bar
	/// <br/>  matches /foo/bar/baz, but does not match /foo/barbaz).
	/// <br/>* ImplementationSpecific: Interpretation of the Path matching is up to
	/// <br/>  the IngressClass. Implementations can treat this as a separate PathType
	/// <br/>  or treat it identically to Prefix or Exact path types.
	/// <br/>Implementations are required to support all path types.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("pathType", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string PathType { get; set; }

}