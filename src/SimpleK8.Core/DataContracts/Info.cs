namespace SimpleK8.Core.DataContracts;

/// <summary>
/// Info contains versioning information. how we'll want to distribute that information.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class Info
{
	[Newtonsoft.Json.JsonProperty("buildDate", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string BuildDate { get; set; }

	[Newtonsoft.Json.JsonProperty("compiler", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Compiler { get; set; }

	[Newtonsoft.Json.JsonProperty("gitCommit", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string GitCommit { get; set; }

	[Newtonsoft.Json.JsonProperty("gitTreeState", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string GitTreeState { get; set; }

	[Newtonsoft.Json.JsonProperty("gitVersion", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string GitVersion { get; set; }

	[Newtonsoft.Json.JsonProperty("goVersion", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string GoVersion { get; set; }

	[Newtonsoft.Json.JsonProperty("major", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Major { get; set; }

	[Newtonsoft.Json.JsonProperty("minor", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Minor { get; set; }

	[Newtonsoft.Json.JsonProperty("platform", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Platform { get; set; }

}