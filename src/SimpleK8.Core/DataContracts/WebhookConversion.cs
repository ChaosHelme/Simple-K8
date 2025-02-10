namespace SimpleK8.Core.DataContracts;

/// <summary>
/// WebhookConversion describes how to call a conversion webhook
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class WebhookConversion
{
	/// <summary>
	/// clientConfig is the instructions for how to call the webhook if strategy is `Webhook`.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("clientConfig", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public WebhookClientConfig2 ClientConfig { get; set; }

	/// <summary>
	/// conversionReviewVersions is an ordered list of preferred `ConversionReview` versions the Webhook expects. The API server will use the first version in the list which it supports. If none of the versions specified in this list are supported by API server, conversion will fail for the custom resource. If a persisted Webhook configuration specifies allowed versions and does not include any versions known to the API Server, calls to the webhook will fail.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("conversionReviewVersions", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required]
	public System.Collections.Generic.List<string> ConversionReviewVersions { get; set; } = new System.Collections.Generic.List<string>();

}