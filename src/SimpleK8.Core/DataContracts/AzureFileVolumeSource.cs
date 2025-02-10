namespace SimpleK8.Core.DataContracts;

/// <summary>
/// AzureFile represents an Azure File Service mount on the host and bind mount to the pod.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class AzureFileVolumeSource
{
	/// <summary>
	/// readOnly defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("readOnly", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public bool? ReadOnly { get; set; }

	/// <summary>
	/// secretName is the  name of secret that contains Azure Storage Account Name and Key
	/// </summary>
	[Newtonsoft.Json.JsonProperty("secretName", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string SecretName { get; set; }

	/// <summary>
	/// shareName is the azure share Name
	/// </summary>
	[Newtonsoft.Json.JsonProperty("shareName", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string ShareName { get; set; }

}