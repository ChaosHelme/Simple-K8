namespace SimpleK8.Core.DataContracts;

public record Node(string ApiVersion, string Kind, object Metadata, NodeSpec Spec, NodeStatus Status);

public record NodeSpec
{
	public string Name { get; set; }
}

public record NodeStatus;