namespace SimpleK8.Core.DataContracts;

/// <summary>
/// MatchResources decides whether to run the admission control policy on an object based on whether it meets the match criteria. The exclude rules take precedence over include rules (if a resource matches both, it is excluded)
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class MatchResources2
{
	/// <summary>
	/// ExcludeResourceRules describes what operations on what resources/subresources the ValidatingAdmissionPolicy should not care about. The exclude rules take precedence over include rules (if a resource matches both, it is excluded)
	/// </summary>
	[Newtonsoft.Json.JsonProperty("excludeResourceRules", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<NamedRuleWithOperations2> ExcludeResourceRules { get; set; }

	/// <summary>
	/// matchPolicy defines how the "MatchResources" list is used to match incoming requests. Allowed values are "Exact" or "Equivalent".
	/// <br/>
	/// <br/>- Exact: match a request only if it exactly matches a specified rule. For example, if deployments can be modified via apps/v1, apps/v1beta1, and extensions/v1beta1, but "rules" only included `apiGroups:["apps"], apiVersions:["v1"], resources: ["deployments"]`, a request to apps/v1beta1 or extensions/v1beta1 would not be sent to the ValidatingAdmissionPolicy.
	/// <br/>
	/// <br/>- Equivalent: match a request if modifies a resource listed in rules, even via another API group or version. For example, if deployments can be modified via apps/v1, apps/v1beta1, and extensions/v1beta1, and "rules" only included `apiGroups:["apps"], apiVersions:["v1"], resources: ["deployments"]`, a request to apps/v1beta1 or extensions/v1beta1 would be converted to apps/v1 and sent to the ValidatingAdmissionPolicy.
	/// <br/>
	/// <br/>Defaults to "Equivalent"
	/// </summary>
	[Newtonsoft.Json.JsonProperty("matchPolicy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string MatchPolicy { get; set; }

	/// <summary>
	/// NamespaceSelector decides whether to run the admission control policy on an object based on whether the namespace for that object matches the selector. If the object itself is a namespace, the matching is performed on object.metadata.labels. If the object is another cluster scoped resource, it never skips the policy.
	/// <br/>
	/// <br/>For example, to run the webhook on any objects whose namespace is not associated with "runlevel" of "0" or "1";  you will set the selector as follows: "namespaceSelector": {
	/// <br/>  "matchExpressions": [
	/// <br/>    {
	/// <br/>      "key": "runlevel",
	/// <br/>      "operator": "NotIn",
	/// <br/>      "values": [
	/// <br/>        "0",
	/// <br/>        "1"
	/// <br/>      ]
	/// <br/>    }
	/// <br/>  ]
	/// <br/>}
	/// <br/>
	/// <br/>If instead you want to only run the policy on any objects whose namespace is associated with the "environment" of "prod" or "staging"; you will set the selector as follows: "namespaceSelector": {
	/// <br/>  "matchExpressions": [
	/// <br/>    {
	/// <br/>      "key": "environment",
	/// <br/>      "operator": "In",
	/// <br/>      "values": [
	/// <br/>        "prod",
	/// <br/>        "staging"
	/// <br/>      ]
	/// <br/>    }
	/// <br/>  ]
	/// <br/>}
	/// <br/>
	/// <br/>See https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/ for more examples of label selectors.
	/// <br/>
	/// <br/>Default to the empty LabelSelector, which matches everything.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("namespaceSelector", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public LabelSelector NamespaceSelector { get; set; }

	/// <summary>
	/// ObjectSelector decides whether to run the validation based on if the object has matching labels. objectSelector is evaluated against both the oldObject and newObject that would be sent to the cel validation, and is considered to match if either object matches the selector. A null object (oldObject in the case of create, or newObject in the case of delete) or an object that cannot have labels (like a DeploymentRollback or a PodProxyOptions object) is not considered to match. Use the object selector only if the webhook is opt-in, because end users may skip the admission webhook by setting the labels. Default to the empty LabelSelector, which matches everything.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("objectSelector", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public LabelSelector ObjectSelector { get; set; }

	/// <summary>
	/// ResourceRules describes what operations on what resources/subresources the ValidatingAdmissionPolicy matches. The policy cares about an operation if it matches _any_ Rule.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("resourceRules", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<NamedRuleWithOperations2> ResourceRules { get; set; }

}