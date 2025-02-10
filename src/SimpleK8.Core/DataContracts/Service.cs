namespace SimpleK8.Core.DataContracts;

public record Service(string ApiVersion, string Kind, object Metadata, ServiceSpec Spec, ServiceStatus Status);

public record ServiceSpec(bool AllocateLoadBalancerNodePorts, string ClusterIp, string[] ClusterIPs);

public record ServiceStatus(string[] Conditions, object LoadBalancerStatus);