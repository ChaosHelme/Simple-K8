namespace SimpleK8.Core.DataContracts;

/// <summary>
/// ApplyConfiguration defines the desired configuration values of an object.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class ApplyConfiguration
{
	/// <summary>
	/// expression will be evaluated by CEL to create an apply configuration. ref: https://github.com/google/cel-spec
	/// <br/>
	/// <br/>Apply configurations are declared in CEL using object initialization. For example, this CEL expression returns an apply configuration to set a single field:
	/// <br/>
	/// <br/>	Object{
	/// <br/>	  spec: Object.spec{
	/// <br/>	    serviceAccountName: "example"
	/// <br/>	  }
	/// <br/>	}
	/// <br/>
	/// <br/>Apply configurations may not modify atomic structs, maps or arrays due to the risk of accidental deletion of values not included in the apply configuration.
	/// <br/>
	/// <br/>CEL expressions have access to the object types needed to create apply configurations:
	/// <br/>
	/// <br/>- 'Object' - CEL type of the resource object. - 'Object.&lt;fieldName&gt;' - CEL type of object field (such as 'Object.spec') - 'Object.&lt;fieldName1&gt;.&lt;fieldName2&gt;...&lt;fieldNameN&gt;` - CEL type of nested field (such as 'Object.spec.containers')
	/// <br/>
	/// <br/>CEL expressions have access to the contents of the API request, organized into CEL variables as well as some other useful variables:
	/// <br/>
	/// <br/>- 'object' - The object from the incoming request. The value is null for DELETE requests. - 'oldObject' - The existing object. The value is null for CREATE requests. - 'request' - Attributes of the API request([ref](/pkg/apis/admission/types.go#AdmissionRequest)). - 'params' - Parameter resource referred to by the policy binding being evaluated. Only populated if the policy has a ParamKind. - 'namespaceObject' - The namespace object that the incoming object belongs to. The value is null for cluster-scoped resources. - 'variables' - Map of composited variables, from its name to its lazily evaluated value.
	/// <br/>  For example, a variable named 'foo' can be accessed as 'variables.foo'.
	/// <br/>- 'authorizer' - A CEL Authorizer. May be used to perform authorization checks for the principal (user or service account) of the request.
	/// <br/>  See https://pkg.go.dev/k8s.io/apiserver/pkg/cel/library#Authz
	/// <br/>- 'authorizer.requestResource' - A CEL ResourceCheck constructed from the 'authorizer' and configured with the
	/// <br/>  request resource.
	/// <br/>
	/// <br/>The `apiVersion`, `kind`, `metadata.name` and `metadata.generateName` are always accessible from the root of the object. No other metadata properties are accessible.
	/// <br/>
	/// <br/>Only property names of the form `[a-zA-Z_.-/][a-zA-Z0-9_.-/]*` are accessible. Required.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("expression", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Expression { get; set; }

}