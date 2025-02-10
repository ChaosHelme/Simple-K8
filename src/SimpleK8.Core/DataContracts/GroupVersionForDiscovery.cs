namespace SimpleK8.Core.DataContracts;

/// <summary>
/// GroupVersion contains the "group/version" and "version" string of a version. It is made a struct to keep extensibility.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class GroupVersionForDiscovery
{
	/// <summary>
	/// groupVersion specifies the API group and version in the form "group/version"
	/// </summary>
	[Newtonsoft.Json.JsonProperty("groupVersion", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string GroupVersion { get; set; }

	/// <summary>
	/// version specifies the version in the form of "version". This is to save the clients the trouble of splitting the GroupVersion.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("version", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Version { get; set; }

}