// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> List of skus with features. </summary>
    internal partial class SkuListResult
    {
        /// <summary> Initializes a new instance of SkuListResult. </summary>
        internal SkuListResult()
        {
            Value = new ChangeTrackingList<WorkspaceSku>();
        }

        /// <summary> Initializes a new instance of SkuListResult. </summary>
        /// <param name="value"></param>
        /// <param name="nextLink"> The URI to fetch the next page of Workspace Skus. Call ListNext() with this URI to fetch the next page of Workspace Skus. </param>
        internal SkuListResult(IReadOnlyList<WorkspaceSku> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        public IReadOnlyList<WorkspaceSku> Value { get; }
        /// <summary> The URI to fetch the next page of Workspace Skus. Call ListNext() with this URI to fetch the next page of Workspace Skus. </summary>
        public string NextLink { get; }
    }
}
