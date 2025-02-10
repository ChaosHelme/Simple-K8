namespace SimpleK8.Core.DataContracts;

/// <summary>
/// CertificateSigningRequestStatus contains conditions used to indicate approved/denied/failed status of the request, and the issued certificate.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class CertificateSigningRequestStatus
{
	/// <summary>
	/// certificate is populated with an issued certificate by the signer after an Approved condition is present. This field is set via the /status subresource. Once populated, this field is immutable.
	/// <br/>
	/// <br/>If the certificate signing request is denied, a condition of type "Denied" is added and this field remains empty. If the signer cannot issue the certificate, a condition of type "Failed" is added and this field remains empty.
	/// <br/>
	/// <br/>Validation requirements:
	/// <br/> 1. certificate must contain one or more PEM blocks.
	/// <br/> 2. All PEM blocks must have the "CERTIFICATE" label, contain no headers, and the encoded data
	/// <br/>  must be a BER-encoded ASN.1 Certificate structure as described in section 4 of RFC5280.
	/// <br/> 3. Non-PEM content may appear before or after the "CERTIFICATE" PEM blocks and is unvalidated,
	/// <br/>  to allow for explanatory text as described in section 5.2 of RFC7468.
	/// <br/>
	/// <br/>If more than one PEM block is present, and the definition of the requested spec.signerName does not indicate otherwise, the first block is the issued certificate, and subsequent blocks should be treated as intermediate certificates and presented in TLS handshakes.
	/// <br/>
	/// <br/>The certificate is encoded in PEM format.
	/// <br/>
	/// <br/>When serialized as JSON or YAML, the data is additionally base64-encoded, so it consists of:
	/// <br/>
	/// <br/>    base64(
	/// <br/>    -----BEGIN CERTIFICATE-----
	/// <br/>    ...
	/// <br/>    -----END CERTIFICATE-----
	/// <br/>    )
	/// </summary>
	[Newtonsoft.Json.JsonProperty("certificate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public byte[] Certificate { get; set; }

	/// <summary>
	/// conditions applied to the request. Known conditions are "Approved", "Denied", and "Failed".
	/// </summary>
	[Newtonsoft.Json.JsonProperty("conditions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<CertificateSigningRequestCondition> Conditions { get; set; }

}