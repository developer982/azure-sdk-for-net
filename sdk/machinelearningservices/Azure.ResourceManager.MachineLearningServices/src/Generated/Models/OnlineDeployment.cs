// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> The OnlineDeployment. </summary>
    public partial class OnlineDeployment
    {
        /// <summary> Initializes a new instance of OnlineDeployment. </summary>
        public OnlineDeployment()
        {
            EnvironmentVariables = new ChangeTrackingDictionary<string, string>();
            Properties = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of OnlineDeployment. </summary>
        /// <param name="appInsightsEnabled"> If true, enables Application Insights logging. </param>
        /// <param name="codeConfiguration"> Code configuration for the endpoint deployment. </param>
        /// <param name="description"> Description of the endpoint deployment. </param>
        /// <param name="endpointComputeType"> The compute type of the endpoint. </param>
        /// <param name="environmentId"> ARM resource ID of the environment specification for the endpoint deployment. </param>
        /// <param name="environmentVariables"> Environment variables configuration for the deployment. </param>
        /// <param name="livenessProbe"></param>
        /// <param name="model"> Reference to the model asset for the endpoint deployment. </param>
        /// <param name="properties"> Property dictionary. Properties can be added, but not removed or altered. </param>
        /// <param name="provisioningState"> Provisioning state for the endpoint deployment. </param>
        /// <param name="requestSettings"></param>
        /// <param name="scaleSettings"></param>
        internal OnlineDeployment(bool? appInsightsEnabled, CodeConfiguration codeConfiguration, string description, EndpointComputeType endpointComputeType, string environmentId, IDictionary<string, string> environmentVariables, ProbeSettings livenessProbe, AssetReferenceBase model, IDictionary<string, string> properties, DeploymentProvisioningState? provisioningState, OnlineRequestSettings requestSettings, OnlineScaleSettings scaleSettings)
        {
            AppInsightsEnabled = appInsightsEnabled;
            CodeConfiguration = codeConfiguration;
            Description = description;
            EndpointComputeType = endpointComputeType;
            EnvironmentId = environmentId;
            EnvironmentVariables = environmentVariables;
            LivenessProbe = livenessProbe;
            Model = model;
            Properties = properties;
            ProvisioningState = provisioningState;
            RequestSettings = requestSettings;
            ScaleSettings = scaleSettings;
        }

        /// <summary> If true, enables Application Insights logging. </summary>
        public bool? AppInsightsEnabled { get; set; }
        /// <summary> Code configuration for the endpoint deployment. </summary>
        public CodeConfiguration CodeConfiguration { get; set; }
        /// <summary> Description of the endpoint deployment. </summary>
        public string Description { get; set; }
        /// <summary> The compute type of the endpoint. </summary>
        internal EndpointComputeType EndpointComputeType { get; set; }
        /// <summary> ARM resource ID of the environment specification for the endpoint deployment. </summary>
        public string EnvironmentId { get; set; }
        /// <summary> Environment variables configuration for the deployment. </summary>
        public IDictionary<string, string> EnvironmentVariables { get; }
        public ProbeSettings LivenessProbe { get; set; }
        /// <summary> Reference to the model asset for the endpoint deployment. </summary>
        public AssetReferenceBase Model { get; set; }
        /// <summary> Property dictionary. Properties can be added, but not removed or altered. </summary>
        public IDictionary<string, string> Properties { get; }
        /// <summary> Provisioning state for the endpoint deployment. </summary>
        public DeploymentProvisioningState? ProvisioningState { get; }
        public OnlineRequestSettings RequestSettings { get; set; }
        public OnlineScaleSettings ScaleSettings { get; set; }
    }
}
