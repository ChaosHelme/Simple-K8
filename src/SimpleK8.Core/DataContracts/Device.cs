namespace SimpleK8.Core.DataContracts;

/// <summary>
/// Device represents one individual hardware instance that can be selected based on its attributes. Besides the name, exactly one field must be set.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class Device
{
	/// <summary>
	/// Basic defines one device instance.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("basic", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public BasicDevice Basic { get; set; }

	/// <summary>
	/// Name is unique identifier among all devices managed by the driver in the pool. It must be a DNS label.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Name { get; set; }

}