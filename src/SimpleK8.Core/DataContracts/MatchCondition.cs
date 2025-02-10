namespace SimpleK8.Core.DataContracts;

/// <summary>
/// MatchCondition represents a condition which must by fulfilled for a request to be sent to a webhook.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class MatchCondition
{
	/// <summary>
	/// Expression represents the expression which will be evaluated by CEL. Must evaluate to bool. CEL expressions have access to the contents of the AdmissionRequest and Authorizer, organized into CEL variables:
	/// <br/>
	/// <br/>'object' - The object from the incoming request. The value is null for DELETE requests. 'oldObject' - The existing object. The value is null for CREATE requests. 'request' - Attributes of the admission request(/pkg/apis/admission/types.go#AdmissionRequest). 'authorizer' - A CEL Authorizer. May be used to perform authorization checks for the principal (user or service account) of the request.
	/// <br/>  See https://pkg.go.dev/k8s.io/apiserver/pkg/cel/library#Authz
	/// <br/>'authorizer.requestResource' - A CEL ResourceCheck constructed from the 'authorizer' and configured with the
	/// <br/>  request resource.
	/// <br/>Documentation on CEL: https://kubernetes.io/docs/reference/using-api/cel/
	/// <br/>
	/// <br/>Required.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("expression", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Expression { get; set; }

	/// <summary>
	/// Name is an identifier for this match condition, used for strategic merging of MatchConditions, as well as providing an identifier for logging purposes. A good name should be descriptive of the associated expression. Name must be a qualified name consisting of alphanumeric characters, '-', '_' or '.', and must start and end with an alphanumeric character (e.g. 'MyName',  or 'my.name',  or '123-abc', regex used for validation is '([A-Za-z0-9][-A-Za-z0-9_.]*)?[A-Za-z0-9]') with an optional DNS subdomain prefix and '/' (e.g. 'example.com/MyName')
	/// <br/>
	/// <br/>Required.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Name { get; set; }

}