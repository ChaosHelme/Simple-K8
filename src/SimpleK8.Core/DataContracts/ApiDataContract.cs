namespace SimpleK8.Core.DataContracts;

public record ApiDataContract(string ApiVersion, string Kind, ObjectMetadata Metadata);

public record ObjectMetadata(Guid Uuid,
	string Name, 
	string Namespace, 
	string? ResourceVersion = null,
	int[]? Generation = null,
	DateTimeOffset? CreationTimeUtc = null, 
	DateTimeOffset? DeletionTimeUtc = null,
	string[]? Annotations = null,
	string[]? Labels = null);