// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;
using Azure.ResourceManager.MachineLearningServices.Models;

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> A Class representing a ComputeResource along with the instance operations that can be performed on it. </summary>
    public class ComputeResource : ComputeResourceOperations
    {
        /// <summary> Initializes a new instance of the <see cref = "ComputeResource"/> class for mocking. </summary>
        protected ComputeResource() : base()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ComputeResource"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal ComputeResource(OperationsBase options, ComputeResourceData resource) : base(options, resource.Id)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the ComputeResourceData. </summary>
        public virtual ComputeResourceData Data { get; private set; }
    }
}
