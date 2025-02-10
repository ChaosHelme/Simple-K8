namespace SimpleK8.Core.DataContracts;

/// <summary>
/// CSINodeSpec holds information about the specification of all CSI drivers installed on a node
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class CSINodeSpec
{
	/// <summary>
	/// drivers is a list of information of all CSI Drivers existing on a node. If all drivers in the list are uninstalled, this can become empty.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("drivers", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required]
	public System.Collections.Generic.List<CSINodeDriver> Drivers { get; set; } = new System.Collections.Generic.List<CSINodeDriver>();

}