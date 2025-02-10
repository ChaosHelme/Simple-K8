namespace SimpleK8.Core.DataContracts;

/// <summary>
/// CertificateSigningRequestCondition describes a condition of a CertificateSigningRequest object
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class CertificateSigningRequestCondition
{
	/// <summary>
	/// lastTransitionTime is the time the condition last transitioned from one status to another. If unset, when a new condition type is added or an existing condition's status is changed, the server defaults this to the current time.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("lastTransitionTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.DateTimeOffset? LastTransitionTime { get; set; }

	/// <summary>
	/// lastUpdateTime is the time of the last update to this condition
	/// </summary>
	[Newtonsoft.Json.JsonProperty("lastUpdateTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.DateTimeOffset? LastUpdateTime { get; set; }

	/// <summary>
	/// message contains a human readable message with details about the request state
	/// </summary>
	[Newtonsoft.Json.JsonProperty("message", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Message { get; set; }

	/// <summary>
	/// reason indicates a brief reason for the request state
	/// </summary>
	[Newtonsoft.Json.JsonProperty("reason", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Reason { get; set; }

	/// <summary>
	/// status of the condition, one of True, False, Unknown. Approved, Denied, and Failed conditions may not be "False" or "Unknown".
	/// </summary>
	[Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Status { get; set; }

	/// <summary>
	/// type of the condition. Known conditions are "Approved", "Denied", and "Failed".
	/// <br/>
	/// <br/>An "Approved" condition is added via the /approval subresource, indicating the request was approved and should be issued by the signer.
	/// <br/>
	/// <br/>A "Denied" condition is added via the /approval subresource, indicating the request was denied and should not be issued by the signer.
	/// <br/>
	/// <br/>A "Failed" condition is added via the /status subresource, indicating the signer failed to issue the certificate.
	/// <br/>
	/// <br/>Approved and Denied conditions are mutually exclusive. Approved, Denied, and Failed conditions cannot be removed once added.
	/// <br/>
	/// <br/>Only one condition of a given type is allowed.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Type { get; set; }

}