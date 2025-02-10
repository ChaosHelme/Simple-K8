namespace SimpleK8.Core.DataContracts;

/// <summary>
/// CustomResourceSubresources defines the status and scale subresources for CustomResources.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class CustomResourceSubresources
{
	/// <summary>
	/// scale indicates the custom resource should serve a `/scale` subresource that returns an `autoscaling/v1` Scale object.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("scale", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public CustomResourceSubresourceScale Scale { get; set; }

	/// <summary>
	/// status indicates the custom resource should serve a `/status` subresource. When enabled: 1. requests to the custom resource primary endpoint ignore changes to the `status` stanza of the object. 2. requests to the custom resource `/status` subresource ignore changes to anything other than the `status` stanza of the object.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public CustomResourceSubresourceStatus Status { get; set; }

}