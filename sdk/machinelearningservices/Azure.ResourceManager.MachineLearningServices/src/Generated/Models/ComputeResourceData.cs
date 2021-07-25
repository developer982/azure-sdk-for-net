// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> A class representing the ComputeResource data model. </summary>
    public partial class ComputeResourceData : Resource<ResourceGroupResourceIdentifier>
    {
        /// <summary> Initializes a new instance of ComputeResourceData. </summary>
        public ComputeResourceData()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of ComputeResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="identity"> The identity of the resource. </param>
        /// <param name="location"> Specifies the location of the resource. </param>
        /// <param name="tags"> Contains resource tags defined as key/value pairs. </param>
        /// <param name="sku"> The sku of the workspace. </param>
        /// <param name="systemData"> Metadata pertaining to creation and last modification of the resource. </param>
        /// <param name="properties"> Compute properties. </param>
        internal ComputeResourceData(ResourceGroupResourceIdentifier id, string name, ResourceType type, Identity identity, string location, IDictionary<string, string> tags, Sku sku, SystemData systemData, Compute properties) : base(id, name, type)
        {
            Identity = identity;
            Location = location;
            Tags = tags;
            Sku = sku;
            SystemData = systemData;
            Properties = properties;
        }

        /// <summary> The identity of the resource. </summary>
        public Identity Identity { get; set; }
        /// <summary> Specifies the location of the resource. </summary>
        public string Location { get; set; }
        /// <summary> Contains resource tags defined as key/value pairs. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The sku of the workspace. </summary>
        public Sku Sku { get; set; }
        /// <summary> Metadata pertaining to creation and last modification of the resource. </summary>
        public SystemData SystemData { get; }
        /// <summary> Compute properties. </summary>
        public Compute Properties { get; set; }
    }
}
