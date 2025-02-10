namespace SimpleK8.Core.DataContracts;

/// <summary>
/// Represents a Flocker volume mounted by the Flocker agent. One and only one of datasetName and datasetUUID should be set. Flocker volumes do not support ownership management or SELinux relabeling.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class FlockerVolumeSource
{
	/// <summary>
	/// datasetName is Name of the dataset stored as metadata -&gt; name on the dataset for Flocker should be considered as deprecated
	/// </summary>
	[Newtonsoft.Json.JsonProperty("datasetName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string DatasetName { get; set; }

	/// <summary>
	/// datasetUUID is the UUID of the dataset. This is unique identifier of a Flocker dataset
	/// </summary>
	[Newtonsoft.Json.JsonProperty("datasetUUID", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string DatasetUUID { get; set; }

}