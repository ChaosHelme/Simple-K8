namespace SimpleK8.Core.DataContracts;

/// <summary>
/// ExpressionWarning is a warning information that targets a specific expression.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class ExpressionWarning
{
	/// <summary>
	/// The path to the field that refers the expression. For example, the reference to the expression of the first item of validations is "spec.validations[0].expression"
	/// </summary>
	[Newtonsoft.Json.JsonProperty("fieldRef", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string FieldRef { get; set; }

	/// <summary>
	/// The content of type checking information in a human-readable form. Each line of the warning contains the type that the expression is checked against, followed by the type check error from the compiler.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("warning", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Warning { get; set; }

}