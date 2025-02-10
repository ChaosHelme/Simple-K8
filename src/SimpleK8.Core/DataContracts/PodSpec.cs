namespace SimpleK8.Core.DataContracts;

public record PodSpec(Container[] Containers, Container[] InitContainers, string NodeName);