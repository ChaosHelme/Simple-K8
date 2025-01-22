namespace SimpleK8.DataContracts;

public record PodSpec(Container[] Containers, Container[] InitContainers, string NodeName);