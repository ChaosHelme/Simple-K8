namespace SimpleK8.Core.DataContracts;

/// <summary>
/// CertificateSigningRequestSpec contains the certificate request.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class CertificateSigningRequestSpec
{
	/// <summary>
	/// expirationSeconds is the requested duration of validity of the issued certificate. The certificate signer may issue a certificate with a different validity duration so a client must check the delta between the notBefore and and notAfter fields in the issued certificate to determine the actual duration.
	/// <br/>
	/// <br/>The v1.22+ in-tree implementations of the well-known Kubernetes signers will honor this field as long as the requested duration is not greater than the maximum duration they will honor per the --cluster-signing-duration CLI flag to the Kubernetes controller manager.
	/// <br/>
	/// <br/>Certificate signers may not honor this field for various reasons:
	/// <br/>
	/// <br/>  1. Old signer that is unaware of the field (such as the in-tree
	/// <br/>     implementations prior to v1.22)
	/// <br/>  2. Signer whose configured maximum is shorter than the requested duration
	/// <br/>  3. Signer whose configured minimum is longer than the requested duration
	/// <br/>
	/// <br/>The minimum valid value for expirationSeconds is 600, i.e. 10 minutes.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("expirationSeconds", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? ExpirationSeconds { get; set; }

	/// <summary>
	/// extra contains extra attributes of the user that created the CertificateSigningRequest. Populated by the API server on creation and immutable.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("extra", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.IDictionary<string, System.Collections.Generic.List<string>> Extra { get; set; }

	/// <summary>
	/// groups contains group membership of the user that created the CertificateSigningRequest. Populated by the API server on creation and immutable.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("groups", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<string> Groups { get; set; }

	/// <summary>
	/// request contains an x509 certificate signing request encoded in a "CERTIFICATE REQUEST" PEM block. When serialized as JSON or YAML, the data is additionally base64-encoded.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("request", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public byte[] Request { get; set; }

	/// <summary>
	/// signerName indicates the requested signer, and is a qualified name.
	/// <br/>
	/// <br/>List/watch requests for CertificateSigningRequests can filter on this field using a "spec.signerName=NAME" fieldSelector.
	/// <br/>
	/// <br/>Well-known Kubernetes signers are:
	/// <br/> 1. "kubernetes.io/kube-apiserver-client": issues client certificates that can be used to authenticate to kube-apiserver.
	/// <br/>  Requests for this signer are never auto-approved by kube-controller-manager, can be issued by the "csrsigning" controller in kube-controller-manager.
	/// <br/> 2. "kubernetes.io/kube-apiserver-client-kubelet": issues client certificates that kubelets use to authenticate to kube-apiserver.
	/// <br/>  Requests for this signer can be auto-approved by the "csrapproving" controller in kube-controller-manager, and can be issued by the "csrsigning" controller in kube-controller-manager.
	/// <br/> 3. "kubernetes.io/kubelet-serving" issues serving certificates that kubelets use to serve TLS endpoints, which kube-apiserver can connect to securely.
	/// <br/>  Requests for this signer are never auto-approved by kube-controller-manager, and can be issued by the "csrsigning" controller in kube-controller-manager.
	/// <br/>
	/// <br/>More details are available at https://k8s.io/docs/reference/access-authn-authz/certificate-signing-requests/#kubernetes-signers
	/// <br/>
	/// <br/>Custom signerNames can also be specified. The signer defines:
	/// <br/> 1. Trust distribution: how trust (CA bundles) are distributed.
	/// <br/> 2. Permitted subjects: and behavior when a disallowed subject is requested.
	/// <br/> 3. Required, permitted, or forbidden x509 extensions in the request (including whether subjectAltNames are allowed, which types, restrictions on allowed values) and behavior when a disallowed extension is requested.
	/// <br/> 4. Required, permitted, or forbidden key usages / extended key usages.
	/// <br/> 5. Expiration/certificate lifetime: whether it is fixed by the signer, configurable by the admin.
	/// <br/> 6. Whether or not requests for CA certificates are allowed.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("signerName", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string SignerName { get; set; }

	/// <summary>
	/// uid contains the uid of the user that created the CertificateSigningRequest. Populated by the API server on creation and immutable.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("uid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Uid { get; set; }

	/// <summary>
	/// usages specifies a set of key usages requested in the issued certificate.
	/// <br/>
	/// <br/>Requests for TLS client certificates typically request: "digital signature", "key encipherment", "client auth".
	/// <br/>
	/// <br/>Requests for TLS serving certificates typically request: "key encipherment", "digital signature", "server auth".
	/// <br/>
	/// <br/>Valid values are:
	/// <br/> "signing", "digital signature", "content commitment",
	/// <br/> "key encipherment", "key agreement", "data encipherment",
	/// <br/> "cert sign", "crl sign", "encipher only", "decipher only", "any",
	/// <br/> "server auth", "client auth",
	/// <br/> "code signing", "email protection", "s/mime",
	/// <br/> "ipsec end system", "ipsec tunnel", "ipsec user",
	/// <br/> "timestamping", "ocsp signing", "microsoft sgc", "netscape sgc"
	/// </summary>
	[Newtonsoft.Json.JsonProperty("usages", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<string> Usages { get; set; }

	/// <summary>
	/// username contains the name of the user that created the CertificateSigningRequest. Populated by the API server on creation and immutable.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("username", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Username { get; set; }

}