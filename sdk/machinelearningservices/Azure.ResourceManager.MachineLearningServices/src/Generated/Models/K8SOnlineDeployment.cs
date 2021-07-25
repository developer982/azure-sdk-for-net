// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> The K8SOnlineDeployment. </summary>
    public partial class K8SOnlineDeployment : OnlineDeployment
    {
        /// <summary> Initializes a new instance of K8SOnlineDeployment. </summary>
        public K8SOnlineDeployment()
        {
            EndpointComputeType = EndpointComputeType.K8S;
        }

        /// <summary> Initializes a new instance of K8SOnlineDeployment. </summary>
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
        /// <param name="containerResourceRequirements"> The resource requirements for the container (cpu and memory). </param>
        internal K8SOnlineDeployment(bool? appInsightsEnabled, CodeConfiguration codeConfiguration, string description, EndpointComputeType endpointComputeType, string environmentId, IDictionary<string, string> environmentVariables, ProbeSettings livenessProbe, AssetReferenceBase model, IDictionary<string, string> properties, DeploymentProvisioningState? provisioningState, OnlineRequestSettings requestSettings, OnlineScaleSettings scaleSettings, ContainerResourceRequirements containerResourceRequirements) : base(appInsightsEnabled, codeConfiguration, description, endpointComputeType, environmentId, environmentVariables, livenessProbe, model, properties, provisioningState, requestSettings, scaleSettings)
        {
            ContainerResourceRequirements = containerResourceRequirements;
            EndpointComputeType = endpointComputeType;
        }

        /// <summary> The resource requirements for the container (cpu and memory). </summary>
        public ContainerResourceRequirements ContainerResourceRequirements { get; set; }
    }
}
