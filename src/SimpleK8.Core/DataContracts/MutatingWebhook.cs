namespace SimpleK8.Core.DataContracts;

/// <summary>
/// MutatingWebhook describes an admission webhook and the resources and operations it applies to.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class MutatingWebhook
{
	/// <summary>
	/// AdmissionReviewVersions is an ordered list of preferred `AdmissionReview` versions the Webhook expects. API server will try to use first version in the list which it supports. If none of the versions specified in this list supported by API server, validation will fail for this object. If a persisted webhook configuration specifies allowed versions and does not include any versions known to the API Server, calls to the webhook will fail and be subject to the failure policy.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("admissionReviewVersions", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required]
	public System.Collections.Generic.List<string> AdmissionReviewVersions { get; set; } = new System.Collections.Generic.List<string>();

	/// <summary>
	/// ClientConfig defines how to communicate with the hook. Required
	/// </summary>
	[Newtonsoft.Json.JsonProperty("clientConfig", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required]
	public WebhookClientConfig ClientConfig { get; set; } = new WebhookClientConfig();

	/// <summary>
	/// FailurePolicy defines how unrecognized errors from the admission endpoint are handled - allowed values are Ignore or Fail. Defaults to Fail.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("failurePolicy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string FailurePolicy { get; set; }

	/// <summary>
	/// MatchConditions is a list of conditions that must be met for a request to be sent to this webhook. Match conditions filter requests that have already been matched by the rules, namespaceSelector, and objectSelector. An empty list of matchConditions matches all requests. There are a maximum of 64 match conditions allowed.
	/// <br/>
	/// <br/>The exact matching logic is (in order):
	/// <br/>  1. If ANY matchCondition evaluates to FALSE, the webhook is skipped.
	/// <br/>  2. If ALL matchConditions evaluate to TRUE, the webhook is called.
	/// <br/>  3. If any matchCondition evaluates to an error (but none are FALSE):
	/// <br/>     - If failurePolicy=Fail, reject the request
	/// <br/>     - If failurePolicy=Ignore, the error is ignored and the webhook is skipped
	/// </summary>
	[Newtonsoft.Json.JsonProperty("matchConditions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<MatchCondition> MatchConditions { get; set; }

	/// <summary>
	/// matchPolicy defines how the "rules" list is used to match incoming requests. Allowed values are "Exact" or "Equivalent".
	/// <br/>
	/// <br/>- Exact: match a request only if it exactly matches a specified rule. For example, if deployments can be modified via apps/v1, apps/v1beta1, and extensions/v1beta1, but "rules" only included `apiGroups:["apps"], apiVersions:["v1"], resources: ["deployments"]`, a request to apps/v1beta1 or extensions/v1beta1 would not be sent to the webhook.
	/// <br/>
	/// <br/>- Equivalent: match a request if modifies a resource listed in rules, even via another API group or version. For example, if deployments can be modified via apps/v1, apps/v1beta1, and extensions/v1beta1, and "rules" only included `apiGroups:["apps"], apiVersions:["v1"], resources: ["deployments"]`, a request to apps/v1beta1 or extensions/v1beta1 would be converted to apps/v1 and sent to the webhook.
	/// <br/>
	/// <br/>Defaults to "Equivalent"
	/// </summary>
	[Newtonsoft.Json.JsonProperty("matchPolicy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string MatchPolicy { get; set; }

	/// <summary>
	/// The name of the admission webhook. Name should be fully qualified, e.g., imagepolicy.kubernetes.io, where "imagepolicy" is the name of the webhook, and kubernetes.io is the name of the organization. Required.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string Name { get; set; }

	/// <summary>
	/// NamespaceSelector decides whether to run the webhook on an object based on whether the namespace for that object matches the selector. If the object itself is a namespace, the matching is performed on object.metadata.labels. If the object is another cluster scoped resource, it never skips the webhook.
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
	/// <br/>If instead you want to only run the webhook on any objects whose namespace is associated with the "environment" of "prod" or "staging"; you will set the selector as follows: "namespaceSelector": {
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
	/// ObjectSelector decides whether to run the webhook based on if the object has matching labels. objectSelector is evaluated against both the oldObject and newObject that would be sent to the webhook, and is considered to match if either object matches the selector. A null object (oldObject in the case of create, or newObject in the case of delete) or an object that cannot have labels (like a DeploymentRollback or a PodProxyOptions object) is not considered to match. Use the object selector only if the webhook is opt-in, because end users may skip the admission webhook by setting the labels. Default to the empty LabelSelector, which matches everything.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("objectSelector", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public LabelSelector ObjectSelector { get; set; }

	/// <summary>
	/// reinvocationPolicy indicates whether this webhook should be called multiple times as part of a single admission evaluation. Allowed values are "Never" and "IfNeeded".
	/// <br/>
	/// <br/>Never: the webhook will not be called more than once in a single admission evaluation.
	/// <br/>
	/// <br/>IfNeeded: the webhook will be called at least one additional time as part of the admission evaluation if the object being admitted is modified by other admission plugins after the initial webhook call. Webhooks that specify this option *must* be idempotent, able to process objects they previously admitted. Note: * the number of additional invocations is not guaranteed to be exactly one. * if additional invocations result in further modifications to the object, webhooks are not guaranteed to be invoked again. * webhooks that use this option may be reordered to minimize the number of additional invocations. * to validate an object after all mutations are guaranteed complete, use a validating admission webhook instead.
	/// <br/>
	/// <br/>Defaults to "Never".
	/// </summary>
	[Newtonsoft.Json.JsonProperty("reinvocationPolicy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string ReinvocationPolicy { get; set; }

	/// <summary>
	/// Rules describes what operations on what resources/subresources the webhook cares about. The webhook cares about an operation if it matches _any_ Rule. However, in order to prevent ValidatingAdmissionWebhooks and MutatingAdmissionWebhooks from putting the cluster in a state which cannot be recovered from without completely disabling the plugin, ValidatingAdmissionWebhooks and MutatingAdmissionWebhooks are never called on admission requests for ValidatingWebhookConfiguration and MutatingWebhookConfiguration objects.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("rules", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<RuleWithOperations> Rules { get; set; }

	/// <summary>
	/// SideEffects states whether this webhook has side effects. Acceptable values are: None, NoneOnDryRun (webhooks created via v1beta1 may also specify Some or Unknown). Webhooks with side effects MUST implement a reconciliation system, since a request may be rejected by a future step in the admission chain and the side effects therefore need to be undone. Requests with the dryRun attribute will be auto-rejected if they match a webhook with sideEffects == Unknown or Some.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("sideEffects", Required = Newtonsoft.Json.Required.Always)]
	[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
	public string SideEffects { get; set; }

	/// <summary>
	/// TimeoutSeconds specifies the timeout for this webhook. After the timeout passes, the webhook call will be ignored or the API call will fail based on the failure policy. The timeout value must be between 1 and 30 seconds. Default to 10 seconds.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("timeoutSeconds", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public int? TimeoutSeconds { get; set; }

}