namespace SimpleK8.Core.DataContracts;

/// <summary>
/// HTTPIngressRuleValue is a list of http selectors pointing to backends. In the example: http://&lt;host&gt;/&lt;path&gt;?&lt;searchpart&gt; -&gt; backend where where parts of the url correspond to RFC 3986, this resource will be used to match against everything after the last '/' and before the first '?' or '#'.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class HTTPIngressRuleValue
{
	/// <summary>
	/// paths is a collection of paths that map requests to backends.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("paths", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required]
	public System.Collections.Generic.List<HTTPIngressPath> Paths { get; set; } = new System.Collections.Generic.List<HTTPIngressPath>();

}