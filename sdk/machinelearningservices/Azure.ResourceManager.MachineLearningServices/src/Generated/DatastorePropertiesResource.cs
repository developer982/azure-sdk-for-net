// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;
using Azure.ResourceManager.MachineLearningServices.Models;

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> A Class representing a DatastorePropertiesResource along with the instance operations that can be performed on it. </summary>
    public class DatastorePropertiesResource : DatastorePropertiesResourceOperations
    {
        /// <summary> Initializes a new instance of the <see cref = "DatastorePropertiesResource"/> class for mocking. </summary>
        protected DatastorePropertiesResource() : base()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "DatastorePropertiesResource"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal DatastorePropertiesResource(OperationsBase options, DatastorePropertiesResourceData resource) : base(options, resource.Id)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the DatastorePropertiesResourceData. </summary>
        public virtual DatastorePropertiesResourceData Data { get; private set; }
    }
}
