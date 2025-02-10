namespace SimpleK8.Core.DataContracts;

/// <summary>
/// TypeChecking contains results of type checking the expressions in the ValidatingAdmissionPolicy
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class TypeChecking
{
	/// <summary>
	/// The type checking warnings for each expression.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("expressionWarnings", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<ExpressionWarning> ExpressionWarnings { get; set; }

}