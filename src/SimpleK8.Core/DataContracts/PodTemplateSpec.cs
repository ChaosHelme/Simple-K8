namespace SimpleK8.Core.DataContracts;

public record PodTemplateSpec(ObjectMetadata Metadata, PodSpec Spec);