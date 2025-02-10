namespace SimpleK8.Core.DataContracts;

/// <summary>
/// ClusterTrustBundleSpec contains the signer and trust anchors.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class ClusterTrustBundleSpec
{
	/// <summary>
	/// signerName indicates the associated signer, if any.
	/// <br/>
	/// <br/>In order to create or update a ClusterTrustBundle that sets signerName, you must have the following cluster-scoped permission: group=certificates.k8s.io resource=signers resourceName=&lt;the signer name&gt; verb=attest.
	/// <br/>
	/// <br/>If signerName is not empty, then the ClusterTrustBundle object must be named with the signer name as a prefix (translating slashes to colons). For example, for the signer name `example.com/foo`, valid ClusterTrustBundle object names include `example.com:foo:abc` and `example.com:foo:v1`.
	/// <br/>
	/// <br/>If signerName is empty, then the ClusterTrustBundle object's name must not have such a prefix.
	/// <br/>
	/// <br/>List/watch requests for ClusterTrustBundles can filter on this field using a `spec.signerName=NAME` field selector.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("signerName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string SignerName { get; set; }

	/// <summary>
	/// trustBundle contains the individual X.509 trust anchors for this bundle, as PEM bundle of PEM-wrapped, DER-formatted X.509 certificates.
	/// <br/>
	/// <br/>The data must consist only of PEM certificate blocks that parse as valid X.509 certificates.  Each certificate must include a basic constraints extension with the CA bit set.  The API server will reject objects that contain duplicate certificates, or that use PEM block headers.
	/// <br/>
	/// <br/>Users of ClusterTrustBundles, including Kubelet, are free to reorder and deduplicate certificate blocks in this file according to their own logic, as well as to drop PEM block headers and inter-block data.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("trustBundle", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string TrustBundle { get; set; }

}