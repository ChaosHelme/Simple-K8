namespace SimpleK8.Core.DataContracts;

/// <summary>
/// JSONSchemaProps is a JSON-Schema following Specification Draft 4 (http://json-schema.org/).
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.2.0.0 (NJsonSchema v11.1.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class JSONSchemaProps
{
	[Newtonsoft.Json.JsonProperty("$ref", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Ref { get; set; }

	[Newtonsoft.Json.JsonProperty("$schema", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Schema { get; set; }

	[Newtonsoft.Json.JsonProperty("additionalItems", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public JSONSchemaPropsOrBool AdditionalItems { get; set; }

	[Newtonsoft.Json.JsonProperty("additionalProperties", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public JSONSchemaPropsOrBool AdditionalProperties { get; set; }

	[Newtonsoft.Json.JsonProperty("allOf", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<JSONSchemaProps> AllOf { get; set; }

	[Newtonsoft.Json.JsonProperty("anyOf", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<JSONSchemaProps> AnyOf { get; set; }

	/// <summary>
	/// default is a default value for undefined object fields. Defaulting is a beta feature under the CustomResourceDefaulting feature gate. Defaulting requires spec.preserveUnknownFields to be false.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("default", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public JSON Default { get; set; }

	[Newtonsoft.Json.JsonProperty("definitions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.IDictionary<string, JSONSchemaProps> Definitions { get; set; }

	[Newtonsoft.Json.JsonProperty("dependencies", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.IDictionary<string, JSONSchemaPropsOrStringArray> Dependencies { get; set; }

	[Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Description { get; set; }

	[Newtonsoft.Json.JsonProperty("enum", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<JSON> Enum { get; set; }

	[Newtonsoft.Json.JsonProperty("example", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public JSON Example { get; set; }

	[Newtonsoft.Json.JsonProperty("exclusiveMaximum", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public bool? ExclusiveMaximum { get; set; }

	[Newtonsoft.Json.JsonProperty("exclusiveMinimum", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public bool? ExclusiveMinimum { get; set; }

	[Newtonsoft.Json.JsonProperty("externalDocs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public ExternalDocumentation ExternalDocs { get; set; }

	/// <summary>
	/// format is an OpenAPI v3 format string. Unknown formats are ignored. The following formats are validated:
	/// <br/>
	/// <br/>- bsonobjectid: a bson object ID, i.e. a 24 characters hex string - uri: an URI as parsed by Golang net/url.ParseRequestURI - email: an email address as parsed by Golang net/mail.ParseAddress - hostname: a valid representation for an Internet host name, as defined by RFC 1034, section 3.1 [RFC1034]. - ipv4: an IPv4 IP as parsed by Golang net.ParseIP - ipv6: an IPv6 IP as parsed by Golang net.ParseIP - cidr: a CIDR as parsed by Golang net.ParseCIDR - mac: a MAC address as parsed by Golang net.ParseMAC - uuid: an UUID that allows uppercase defined by the regex (?i)^[0-9a-f]{8}-?[0-9a-f]{4}-?[0-9a-f]{4}-?[0-9a-f]{4}-?[0-9a-f]{12}$ - uuid3: an UUID3 that allows uppercase defined by the regex (?i)^[0-9a-f]{8}-?[0-9a-f]{4}-?3[0-9a-f]{3}-?[0-9a-f]{4}-?[0-9a-f]{12}$ - uuid4: an UUID4 that allows uppercase defined by the regex (?i)^[0-9a-f]{8}-?[0-9a-f]{4}-?4[0-9a-f]{3}-?[89ab][0-9a-f]{3}-?[0-9a-f]{12}$ - uuid5: an UUID5 that allows uppercase defined by the regex (?i)^[0-9a-f]{8}-?[0-9a-f]{4}-?5[0-9a-f]{3}-?[89ab][0-9a-f]{3}-?[0-9a-f]{12}$ - isbn: an ISBN10 or ISBN13 number string like "0321751043" or "978-0321751041" - isbn10: an ISBN10 number string like "0321751043" - isbn13: an ISBN13 number string like "978-0321751041" - creditcard: a credit card number defined by the regex ^(?:4[0-9]{12}(?:[0-9]{3})?|5[1-5][0-9]{14}|6(?:011|5[0-9][0-9])[0-9]{12}|3[47][0-9]{13}|3(?:0[0-5]|[68][0-9])[0-9]{11}|(?:2131|1800|35\\d{3})\\d{11})$ with any non digit characters mixed in - ssn: a U.S. social security number following the regex ^\\d{3}[- ]?\\d{2}[- ]?\\d{4}$ - hexcolor: an hexadecimal color code like "#FFFFFF: following the regex ^#?([0-9a-fA-F]{3}|[0-9a-fA-F]{6})$ - rgbcolor: an RGB color code like rgb like "rgb(255,255,2559" - byte: base64 encoded binary data - password: any kind of string - date: a date string like "2006-01-02" as defined by full-date in RFC3339 - duration: a duration string like "22 ns" as parsed by Golang time.ParseDuration or compatible with Scala duration format - datetime: a date time string like "2014-12-15T19:30:20.000Z" as defined by date-time in RFC3339.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("format", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Format { get; set; }

	[Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Id { get; set; }

	[Newtonsoft.Json.JsonProperty("items", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public JSONSchemaPropsOrArray Items { get; set; }

	[Newtonsoft.Json.JsonProperty("maxItems", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public long? MaxItems { get; set; }

	[Newtonsoft.Json.JsonProperty("maxLength", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public long? MaxLength { get; set; }

	[Newtonsoft.Json.JsonProperty("maxProperties", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public long? MaxProperties { get; set; }

	[Newtonsoft.Json.JsonProperty("maximum", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public double? Maximum { get; set; }

	[Newtonsoft.Json.JsonProperty("minItems", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public long? MinItems { get; set; }

	[Newtonsoft.Json.JsonProperty("minLength", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public long? MinLength { get; set; }

	[Newtonsoft.Json.JsonProperty("minProperties", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public long? MinProperties { get; set; }

	[Newtonsoft.Json.JsonProperty("minimum", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public double? Minimum { get; set; }

	[Newtonsoft.Json.JsonProperty("multipleOf", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public double? MultipleOf { get; set; }

	[Newtonsoft.Json.JsonProperty("not", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public JSONSchemaProps Not { get; set; }

	[Newtonsoft.Json.JsonProperty("nullable", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public bool? Nullable { get; set; }

	[Newtonsoft.Json.JsonProperty("oneOf", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<JSONSchemaProps> OneOf { get; set; }

	[Newtonsoft.Json.JsonProperty("pattern", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Pattern { get; set; }

	[Newtonsoft.Json.JsonProperty("patternProperties", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.IDictionary<string, JSONSchemaProps> PatternProperties { get; set; }

	[Newtonsoft.Json.JsonProperty("properties", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.IDictionary<string, JSONSchemaProps> Properties { get; set; }

	[Newtonsoft.Json.JsonProperty("required", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<string> Required { get; set; }

	[Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Title { get; set; }

	[Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string Type { get; set; }

	[Newtonsoft.Json.JsonProperty("uniqueItems", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public bool? UniqueItems { get; set; }

	/// <summary>
	/// x-kubernetes-embedded-resource defines that the value is an embedded Kubernetes runtime.Object, with TypeMeta and ObjectMeta. The type must be object. It is allowed to further restrict the embedded object. kind, apiVersion and metadata are validated automatically. x-kubernetes-preserve-unknown-fields is allowed to be true, but does not have to be if the object is fully specified (up to kind, apiVersion, metadata).
	/// </summary>
	[Newtonsoft.Json.JsonProperty("x-kubernetes-embedded-resource", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public bool? XKubernetesEmbeddedResource { get; set; }

	/// <summary>
	/// x-kubernetes-int-or-string specifies that this value is either an integer or a string. If this is true, an empty type is allowed and type as child of anyOf is permitted if following one of the following patterns:
	/// <br/>
	/// <br/>1) anyOf:
	/// <br/>   - type: integer
	/// <br/>   - type: string
	/// <br/>2) allOf:
	/// <br/>   - anyOf:
	/// <br/>     - type: integer
	/// <br/>     - type: string
	/// <br/>   - ... zero or more
	/// </summary>
	[Newtonsoft.Json.JsonProperty("x-kubernetes-int-or-string", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public bool? XKubernetesIntOrString { get; set; }

	/// <summary>
	/// x-kubernetes-list-map-keys annotates an array with the x-kubernetes-list-type `map` by specifying the keys used as the index of the map.
	/// <br/>
	/// <br/>This tag MUST only be used on lists that have the "x-kubernetes-list-type" extension set to "map". Also, the values specified for this attribute must be a scalar typed field of the child structure (no nesting is supported).
	/// <br/>
	/// <br/>The properties specified must either be required or have a default value, to ensure those properties are present for all list items.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("x-kubernetes-list-map-keys", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<string> XKubernetesListMapKeys { get; set; }

	/// <summary>
	/// x-kubernetes-list-type annotates an array to further describe its topology. This extension must only be used on lists and may have 3 possible values:
	/// <br/>
	/// <br/>1) `atomic`: the list is treated as a single entity, like a scalar.
	/// <br/>     Atomic lists will be entirely replaced when updated. This extension
	/// <br/>     may be used on any type of list (struct, scalar, ...).
	/// <br/>2) `set`:
	/// <br/>     Sets are lists that must not have multiple items with the same value. Each
	/// <br/>     value must be a scalar, an object with x-kubernetes-map-type `atomic` or an
	/// <br/>     array with x-kubernetes-list-type `atomic`.
	/// <br/>3) `map`:
	/// <br/>     These lists are like maps in that their elements have a non-index key
	/// <br/>     used to identify them. Order is preserved upon merge. The map tag
	/// <br/>     must only be used on a list with elements of type object.
	/// <br/>Defaults to atomic for arrays.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("x-kubernetes-list-type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string XKubernetesListType { get; set; }

	/// <summary>
	/// x-kubernetes-map-type annotates an object to further describe its topology. This extension must only be used when type is object and may have 2 possible values:
	/// <br/>
	/// <br/>1) `granular`:
	/// <br/>     These maps are actual maps (key-value pairs) and each fields are independent
	/// <br/>     from each other (they can each be manipulated by separate actors). This is
	/// <br/>     the default behaviour for all maps.
	/// <br/>2) `atomic`: the list is treated as a single entity, like a scalar.
	/// <br/>     Atomic maps will be entirely replaced when updated.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("x-kubernetes-map-type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public string XKubernetesMapType { get; set; }

	/// <summary>
	/// x-kubernetes-preserve-unknown-fields stops the API server decoding step from pruning fields which are not specified in the validation schema. This affects fields recursively, but switches back to normal pruning behaviour if nested properties or additionalProperties are specified in the schema. This can either be true or undefined. False is forbidden.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("x-kubernetes-preserve-unknown-fields", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public bool? XKubernetesPreserveUnknownFields { get; set; }

	/// <summary>
	/// x-kubernetes-validations describes a list of validation rules written in the CEL expression language.
	/// </summary>
	[Newtonsoft.Json.JsonProperty("x-kubernetes-validations", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
	public System.Collections.Generic.List<ValidationRule> XKubernetesValidations { get; set; }

}