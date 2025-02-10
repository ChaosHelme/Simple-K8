namespace SimpleK8.Core.DataContracts;

/// <summary>
/// CustomResourceConversion describes how to convert different versions of a CR.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class CustomResourceConversion
{
	/// <summary>
	/// strategy specifies how custom resources are converted between versions. Allowed values are: - `"None"`: The converter only change the apiVersion and would not touch any other field in the custom resource. - `"Webhook"`: API Server will call to an external webhook to do the conversion. Additional information
	/// <br/>  is needed for this option. This requires spec.preserveUnknownFields to be false, and spec.conversion.webhook to be set.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("strategy", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Strategy { get; set; }

	/// <summary>
	/// webhook describes how to call the conversion webhook. Required when `strategy` is set to `"Webhook"`.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("webhook", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public WebhookConversion Webhook { get; set; }

}