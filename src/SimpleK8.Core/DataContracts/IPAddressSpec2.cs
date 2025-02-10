namespace SimpleK8.Core.DataContracts;

/// <summary>
/// IPAddressSpec describe the attributes in an IP Address.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class IPAddressSpec2
{
	/// <summary>
	/// ParentRef references the resource that an IPAddress is attached to. An IPAddress must reference a parent object.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("parentRef", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required]
	public ParentReference2 ParentRef { get; set; } = new ParentReference2();

}