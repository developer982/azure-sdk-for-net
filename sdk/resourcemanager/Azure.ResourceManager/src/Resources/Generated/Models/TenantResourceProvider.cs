// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Resource provider information. </summary>
    public partial class TenantResourceProvider
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="TenantResourceProvider"/>. </summary>
        internal TenantResourceProvider()
        {
            ResourceTypes = new ChangeTrackingList<ProviderResourceType>();
        }

        /// <summary> Initializes a new instance of <see cref="TenantResourceProvider"/>. </summary>
        /// <param name="namespace"> The namespace of the resource provider. </param>
        /// <param name="resourceTypes"> The collection of provider resource types. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TenantResourceProvider(string @namespace, IReadOnlyList<ProviderResourceType> resourceTypes, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Namespace = @namespace;
            ResourceTypes = resourceTypes;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The namespace of the resource provider. </summary>
        [WirePath("namespace")]
        public string Namespace { get; }
        /// <summary> The collection of provider resource types. </summary>
        [WirePath("resourceTypes")]
        public IReadOnlyList<ProviderResourceType> ResourceTypes { get; }
    }
}
