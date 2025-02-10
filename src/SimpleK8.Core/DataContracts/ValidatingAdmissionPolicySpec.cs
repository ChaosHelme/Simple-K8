namespace SimpleK8.Core.DataContracts;

/// <summary>
/// ValidatingAdmissionPolicySpec is the specification of the desired behavior of the AdmissionPolicy.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class ValidatingAdmissionPolicySpec
{
	/// <summary>
	/// auditAnnotations contains CEL expressions which are used to produce audit annotations for the audit event of the API request. validations and auditAnnotations may not both be empty; a least one of validations or auditAnnotations is required.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("auditAnnotations", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<AuditAnnotation> AuditAnnotations { get; set; }

	/// <summary>
	/// failurePolicy defines how to handle failures for the admission policy. Failures can occur from CEL expression parse errors, type check errors, runtime errors and invalid or mis-configured policy definitions or bindings.
	/// <br/>
	/// <br/>A policy is invalid if spec.paramKind refers to a non-existent Kind. A binding is invalid if spec.paramRef.name refers to a non-existent resource.
	/// <br/>
	/// <br/>failurePolicy does not define how validations that evaluate to false are handled.
	/// <br/>
	/// <br/>When failurePolicy is set to Fail, ValidatingAdmissionPolicyBinding validationActions define how failures are enforced.
	/// <br/>
	/// <br/>Allowed values are Ignore or Fail. Defaults to Fail.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("failurePolicy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string FailurePolicy { get; set; }

	/// <summary>
	/// MatchConditions is a list of conditions that must be met for a request to be validated. Match conditions filter requests that have already been matched by the rules, namespaceSelector, and objectSelector. An empty list of matchConditions matches all requests. There are a maximum of 64 match conditions allowed.
	/// <br/>
	/// <br/>If a parameter object is provided, it can be accessed via the `params` handle in the same manner as validation expressions.
	/// <br/>
	/// <br/>The exact matching logic is (in order):
	/// <br/>  1. If ANY matchCondition evaluates to FALSE, the policy is skipped.
	/// <br/>  2. If ALL matchConditions evaluate to TRUE, the policy is evaluated.
	/// <br/>  3. If any matchCondition evaluates to an error (but none are FALSE):
	/// <br/>     - If failurePolicy=Fail, reject the request
	/// <br/>     - If failurePolicy=Ignore, the policy is skipped
	/// </summary>
	[Newtonsoft.Json.JsonProperty("matchConditions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<MatchCondition> MatchConditions { get; set; }

	/// <summary>
	/// MatchConstraints specifies what resources this policy is designed to validate. The AdmissionPolicy cares about a request if it matches _all_ Constraints. However, in order to prevent clusters from being put into an unstable state that cannot be recovered from via the API ValidatingAdmissionPolicy cannot match ValidatingAdmissionPolicy and ValidatingAdmissionPolicyBinding. Required.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("matchConstraints", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public MatchResources MatchConstraints { get; set; }

	/// <summary>
	/// ParamKind specifies the kind of resources used to parameterize this policy. If absent, there are no parameters for this policy and the param CEL variable will not be provided to validation expressions. If ParamKind refers to a non-existent kind, this policy definition is mis-configured and the FailurePolicy is applied. If paramKind is specified but paramRef is unset in ValidatingAdmissionPolicyBinding, the params variable will be null.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("paramKind", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public ParamKind ParamKind { get; set; }

	/// <summary>
	/// Validations contain CEL expressions which is used to apply the validation. Validations and AuditAnnotations may not both be empty; a minimum of one Validations or AuditAnnotations is required.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("validations", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<Validation> Validations { get; set; }

	/// <summary>
	/// Variables contain definitions of variables that can be used in composition of other expressions. Each variable is defined as a named CEL expression. The variables defined here will be available under `variables` in other expressions of the policy except MatchConditions because MatchConditions are evaluated before the rest of the policy.
	/// <br/>
	/// <br/>The expression of a variable can refer to other variables defined earlier in the list but not those after. Thus, Variables must be sorted by the order of first appearance and acyclic.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("variables", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<Variable> Variables { get; set; }

}