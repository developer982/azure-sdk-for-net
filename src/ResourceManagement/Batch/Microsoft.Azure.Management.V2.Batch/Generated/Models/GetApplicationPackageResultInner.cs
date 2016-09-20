// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Batch.Models
{
    using System.Linq;

    /// <summary>
    /// Response to an ApplicationOperations.GetApplicationPackage request.
    /// </summary>
    public partial class GetApplicationPackageResultInner
    {
        /// <summary>
        /// Initializes a new instance of the GetApplicationPackageResultInner
        /// class.
        /// </summary>
        public GetApplicationPackageResultInner() { }

        /// <summary>
        /// Initializes a new instance of the GetApplicationPackageResultInner
        /// class.
        /// </summary>
        /// <param name="id">The id of the application.</param>
        /// <param name="version">The version of the application package.
        /// </param>
        /// <param name="state">The current state of the application package.
        /// Possible values include: 'pending', 'active', 'unmapped'</param>
        /// <param name="format">The format of the application package, if the
        /// package is active.</param>
        /// <param name="storageUrl">The storage URL at which the application
        /// package is stored.</param>
        /// <param name="storageUrlExpiry">The UTC time at which the storage
        /// URL will expire.</param>
        /// <param name="lastActivationTime">The time at which the package was
        /// last activated, if the package is active.</param>
        public GetApplicationPackageResultInner(string id = default(string), string version = default(string), PackageState? state = default(PackageState?), string format = default(string), string storageUrl = default(string), System.DateTime? storageUrlExpiry = default(System.DateTime?), System.DateTime? lastActivationTime = default(System.DateTime?))
        {
            Id = id;
            Version = version;
            State = state;
            Format = format;
            StorageUrl = storageUrl;
            StorageUrlExpiry = storageUrlExpiry;
            LastActivationTime = lastActivationTime;
        }

        /// <summary>
        /// Gets or sets the id of the application.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the version of the application package.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets the current state of the application package.
        /// Possible values include: 'pending', 'active', 'unmapped'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "state")]
        public PackageState? State { get; set; }

        /// <summary>
        /// Gets or sets the format of the application package, if the package
        /// is active.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "format")]
        public string Format { get; set; }

        /// <summary>
        /// Gets or sets the storage URL at which the application package is
        /// stored.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "storageUrl")]
        public string StorageUrl { get; set; }

        /// <summary>
        /// Gets or sets the UTC time at which the storage URL will expire.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "storageUrlExpiry")]
        public System.DateTime? StorageUrlExpiry { get; set; }

        /// <summary>
        /// Gets or sets the time at which the package was last activated, if
        /// the package is active.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "lastActivationTime")]
        public System.DateTime? LastActivationTime { get; set; }

    }
}
