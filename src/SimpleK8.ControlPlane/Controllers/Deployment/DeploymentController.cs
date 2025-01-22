﻿using Microsoft.Extensions.Logging;
using SimpleK8.Core;

namespace SimpleK8.ControlPlane.Controllers.Deployment;

public class DeploymentController(
    IApiServer apiServer,
    ILogger<DeploymentController> logger)
    : IController
{
    readonly Dictionary<string, DeploymentStatus> _deploymentStatuses = new();
    readonly Dictionary<string, List<RevisionHistory>> _revisionHistories = new();

    public async Task Run(CancellationToken cancellationToken)
    {
        logger.LogInformation("Deployment controller watching for changes...");
        while (!cancellationToken.IsCancellationRequested)
        {
            await Reconcile(cancellationToken);
            await Task.Delay(5000, cancellationToken);
        }
    }
    
    public void PauseDeployment(string deploymentName)
    {
        logger.LogInformation("Pausing deployment: {DeploymentName}", deploymentName);
        _deploymentStatuses[deploymentName] = new DeploymentStatus { State = DeploymentState.Paused };
    }

    public void ResumeDeployment(string deploymentName)
    {
        logger.LogInformation("Resuming deployment: {DeploymentName}", deploymentName);
        _deploymentStatuses[deploymentName] = new DeploymentStatus { State = DeploymentState.Progressing };
    }

    public void RollbackDeployment(string deploymentName, int revisionNumber)
    {
        logger.LogInformation("Rolling back deployment: {DeploymentName} to revision {RevisionNumber}", deploymentName, revisionNumber);
        var revisionHistory = _revisionHistories[deploymentName];
        if (revisionNumber <= 0 || revisionNumber > revisionHistory.Count)
        {
            throw new ArgumentException("Invalid revision number");
        }

        var targetRevision = revisionHistory[revisionNumber - 1];
        var rollbackDeployment = new DataContracts.Deployment(Guid.NewGuid(), deploymentName, targetRevision.Image, targetRevision.ReplicaCount);

        apiServer.UpdateDeployment(rollbackDeployment);
    }

    async Task Reconcile(CancellationToken cancellationToken)
    {
        var desiredDeployments = await apiServer.GetDesiredDeployments();
        var currentDeployments = await apiServer.GetCurrentDeployments();

        foreach (var desiredDeployment in desiredDeployments.Items)
        {
            var currentDeployment = currentDeployments.Items.FirstOrDefault(d => d.Name == desiredDeployment.Name);
            if (currentDeployment == null)
            {
                CreateDeployment(desiredDeployment, cancellationToken);
            }
            else if (NeedsUpdate(currentDeployment, desiredDeployment))
            {
                await UpdateDeployment(currentDeployment, desiredDeployment, cancellationToken);
            }
        }

        // Handle deletions
        foreach (var currentDeployment in currentDeployments.Items)
        {
            if (!desiredDeployments.Items.Any(d => d.Name == currentDeployment.Name))
            {
                DeleteDeployment(currentDeployment, cancellationToken);
            }
        }
    }

    void CreateDeployment(DataContracts.Deployment deployment, CancellationToken cancellationToken)
    {
        logger.LogInformation("Creating new deployment: {DeploymentName}", deployment.Name);
        apiServer.SetReplicaSet(deployment.Name, deployment.ReplicaCount);
        _deploymentStatuses[deployment.Name] = new DeploymentStatus { State = DeploymentState.Progressing };
        _revisionHistories[deployment.Name] = new List<RevisionHistory> { new(deployment) };
        UpdateDeploymentStatus(deployment.Name, cancellationToken);
    }

    async Task UpdateDeployment(DataContracts.Deployment currentDeployment, DataContracts.Deployment desiredDeployment, CancellationToken cancellationToken)
    {
        logger.LogInformation("Updating deployment: {DeploymentName}", desiredDeployment.Name);
        await PerformRollingUpdate(currentDeployment, desiredDeployment, cancellationToken);
        _revisionHistories[desiredDeployment.Name].Add(new RevisionHistory(desiredDeployment));
        UpdateDeploymentStatus(desiredDeployment.Name, cancellationToken);
    }

    void DeleteDeployment(DataContracts.Deployment deployment, CancellationToken cancellationToken)
    {
        logger.LogInformation("Deleting deployment: {DeploymentName}", deployment.Name);
        apiServer.DeleteReplicaSet(deployment.Name);
        _deploymentStatuses.Remove(deployment.Name);
        _revisionHistories.Remove(deployment.Name);
    }

    async Task PerformRollingUpdate(DataContracts.Deployment currentDeployment, DataContracts.Deployment desiredDeployment, CancellationToken cancellationToken)
    {
        _deploymentStatuses[desiredDeployment.Name] = new DeploymentStatus { State = DeploymentState.Progressing };

        var currentReplicas = apiServer.GetReplicaCount(currentDeployment.Name);
        var desiredReplicas = desiredDeployment.ReplicaCount;

        // Gradually scale up new ReplicaSet while scaling down the old one
        for (var i = 1; i <= desiredReplicas; i++)
        {
            apiServer.SetReplicaSet(desiredDeployment.Name, i);
            if (currentReplicas > desiredReplicas - i)
            {
                apiServer.SetReplicaSet(currentDeployment.Name, desiredReplicas - i);
            }
            await Task.Delay(1000, cancellationToken); // Simulate delay between updates
        }

        _deploymentStatuses[desiredDeployment.Name] = new DeploymentStatus { State = DeploymentState.Completed };
    }

    void UpdateDeploymentStatus(string deploymentName, CancellationToken cancellationToken)
    {
        var status = _deploymentStatuses[deploymentName];
        apiServer.UpdateDeploymentStatus(deploymentName, status);
    }

    bool NeedsUpdate(DataContracts.Deployment current, DataContracts.Deployment desired)
    {
        return current.Image != desired.Image || current.ReplicaCount != desired.ReplicaCount;
    }
}