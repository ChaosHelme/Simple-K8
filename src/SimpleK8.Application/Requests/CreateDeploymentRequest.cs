using SimpleK8.Application.DTOs;
using SimpleK8.Core.DataContracts;

namespace SimpleK8.Application.Requests;

public record CreateDeploymentRequest(ObjectMetaDto ObjectMetaDto, DeploymentSpecDto DeploymentSpec);