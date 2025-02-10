namespace SimpleK8.Core.DataContracts;

/// <summary>
/// Sysctl defines a kernel parameter to be set
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class Sysctl
{
	/// <summary>
	/// Name of a property to set
	/// </summary>
	[Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Name { get; set; }

	/// <summary>
	/// Value of a property to set
	/// </summary>
	[Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Value { get; set; }

}