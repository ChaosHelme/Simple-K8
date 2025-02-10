namespace SimpleK8.Core.DataContracts;

/// <summary>
/// ConfigMapNodeConfigSource contains the information to reference a ConfigMap as a config source for the Node. This API is deprecated since 1.22: https://git.k8s.io/enhancements/keps/sig-node/281-dynamic-kubelet-configuration
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class ConfigMapNodeConfigSource
{
	/// <summary>
	/// KubeletConfigKey declares which key of the referenced ConfigMap corresponds to the KubeletConfiguration structure This field is required in all cases.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("kubeletConfigKey", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string KubeletConfigKey { get; set; }

	/// <summary>
	/// Name is the metadata.name of the referenced ConfigMap. This field is required in all cases.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Name { get; set; }

	/// <summary>
	/// Namespace is the metadata.namespace of the referenced ConfigMap. This field is required in all cases.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("namespace", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Namespace { get; set; }

	/// <summary>
	/// ResourceVersion is the metadata.ResourceVersion of the referenced ConfigMap. This field is forbidden in Node.Spec, and required in Node.Status.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("resourceVersion", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string ResourceVersion { get; set; }

	/// <summary>
	/// UID is the metadata.UID of the referenced ConfigMap. This field is forbidden in Node.Spec, and required in Node.Status.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("uid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Uid { get; set; }

}