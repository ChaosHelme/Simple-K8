using System.Text.Json.Serialization;

namespace SimpleK8.Core.DataContracts;

/// <summary>
/// A label selector is a label query over a set of resources. The result of matchLabels and matchExpressions are ANDed. An empty label selector matches all objects. A null label selector matches no objects.
/// </summary>
public partial class LabelSelector
{
	/// <summary>
	/// matchExpressions is a list of label selector requirements. The requirements are ANDed.
	/// </summary>
	[JsonPropertyName("matchExpression")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public List<LabelSelectorRequirement> MatchExpressions { get; set; } = [];

	/// <summary>
	/// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.
	/// </summary>
	[JsonPropertyName("matchLabels")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public IDictionary<string, string> MatchLabels { get; set; } = new Dictionary<string, string>();

}