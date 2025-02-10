namespace SimpleK8.Core.DataContracts;

/// <summary>
/// Preconditions must be fulfilled before an operation (update, delete, etc.) is carried out.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class Preconditions
{
	/// <summary>
	/// Specifies the target ResourceVersion
	/// </summary>
	[Newtonsoft.Json.JsonProperty("resourceVersion", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string ResourceVersion { get; set; }

	/// <summary>
	/// Specifies the target UID.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("uid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Uid { get; set; }

}