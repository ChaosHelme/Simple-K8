namespace SimpleK8.DataContracts;

public record ContainerStatus(string ContainerId, string Image, string ImageId, string Name, bool Ready, int RestartCount, bool Started);