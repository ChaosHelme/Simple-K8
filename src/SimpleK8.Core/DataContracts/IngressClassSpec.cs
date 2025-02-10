namespace SimpleK8.Core.DataContracts;

/// <summary>
/// IngressClassSpec provides information about the class of an Ingress.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class IngressClassSpec
{
	/// <summary>
	/// controller refers to the name of the controller that should handle this class. This allows for different "flavors" that are controlled by the same controller. For example, you may have different parameters for the same implementing controller. This should be specified as a domain-prefixed path no more than 250 characters in length, e.g. "acme.io/ingress-controller". This field is immutable.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("controller", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Controller { get; set; }

	/// <summary>
	/// parameters is a link to a custom resource containing additional configuration for the controller. This is optional if the controller does not require extra parameters.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("parameters", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public IngressClassParametersReference Parameters { get; set; }

}