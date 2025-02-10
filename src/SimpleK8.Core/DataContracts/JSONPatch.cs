namespace SimpleK8.Core.DataContracts;

/// <summary>
/// JSONPatch defines a JSON Patch.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class JSONPatch
{
	/// <summary>
	/// expression will be evaluated by CEL to create a [JSON patch](https://jsonpatch.com/). ref: https://github.com/google/cel-spec
	/// <br/>
	/// <br/>expression must return an array of JSONPatch values.
	/// <br/>
	/// <br/>For example, this CEL expression returns a JSON patch to conditionally modify a value:
	/// <br/>
	/// <br/>	  [
	/// <br/>	    JSONPatch{op: "test", path: "/spec/example", value: "Red"},
	/// <br/>	    JSONPatch{op: "replace", path: "/spec/example", value: "Green"}
	/// <br/>	  ]
	/// <br/>
	/// <br/>To define an object for the patch value, use Object types. For example:
	/// <br/>
	/// <br/>	  [
	/// <br/>	    JSONPatch{
	/// <br/>	      op: "add",
	/// <br/>	      path: "/spec/selector",
	/// <br/>	      value: Object.spec.selector{matchLabels: {"environment": "test"}}
	/// <br/>	    }
	/// <br/>	  ]
	/// <br/>
	/// <br/>To use strings containing '/' and '~' as JSONPatch path keys, use "jsonpatch.escapeKey". For example:
	/// <br/>
	/// <br/>	  [
	/// <br/>	    JSONPatch{
	/// <br/>	      op: "add",
	/// <br/>	      path: "/metadata/labels/" + jsonpatch.escapeKey("example.com/environment"),
	/// <br/>	      value: "test"
	/// <br/>	    },
	/// <br/>	  ]
	/// <br/>
	/// <br/>CEL expressions have access to the types needed to create JSON patches and objects:
	/// <br/>
	/// <br/>- 'JSONPatch' - CEL type of JSON Patch operations. JSONPatch has the fields 'op', 'from', 'path' and 'value'.
	/// <br/>  See [JSON patch](https://jsonpatch.com/) for more details. The 'value' field may be set to any of: string,
	/// <br/>  integer, array, map or object.  If set, the 'path' and 'from' fields must be set to a
	/// <br/>  [JSON pointer](https://datatracker.ietf.org/doc/html/rfc6901/) string, where the 'jsonpatch.escapeKey()' CEL
	/// <br/>  function may be used to escape path keys containing '/' and '~'.
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
	/// <br/>CEL expressions have access to [Kubernetes CEL function libraries](https://kubernetes.io/docs/reference/using-api/cel/#cel-options-language-features-and-libraries) as well as:
	/// <br/>
	/// <br/>- 'jsonpatch.escapeKey' - Performs JSONPatch key escaping. '~' and  '/' are escaped as '~0' and `~1' respectively).
	/// <br/>
	/// <br/>Only property names of the form `[a-zA-Z_.-/][a-zA-Z0-9_.-/]*` are accessible. Required.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("expression", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Expression { get; set; }

}