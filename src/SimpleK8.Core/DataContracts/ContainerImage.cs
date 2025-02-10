namespace SimpleK8.Core.DataContracts;

/// <summary>
/// Describe a container image
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class ContainerImage
{
	/// <summary>
	/// Names by which this image is known. e.g. ["kubernetes.example/hyperkube:v1.0.7", "cloud-vendor.registry.example/cloud-vendor/hyperkube:v1.0.7"]
	/// </summary>
	[Newtonsoft.Json.JsonProperty("names", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<string> Names { get; set; }

	/// <summary>
	/// The size of the image in bytes.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("sizeBytes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public long? SizeBytes { get; set; }

}