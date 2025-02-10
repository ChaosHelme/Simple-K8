namespace SimpleK8.Core.DataContracts;

/// <summary>
/// ServiceAccountSubject holds detailed information for service-account-kind subject.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class ServiceAccountSubject
{
	/// <summary>
	/// `name` is the name of matching ServiceAccount objects, or "*" to match regardless of name. Required.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Name { get; set; }

	/// <summary>
	/// `namespace` is the namespace of matching ServiceAccount objects. Required.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("namespace", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Namespace { get; set; }

}