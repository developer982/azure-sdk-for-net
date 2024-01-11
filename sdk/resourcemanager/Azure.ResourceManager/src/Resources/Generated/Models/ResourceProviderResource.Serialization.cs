// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Resources
{
    public partial class ResourceProviderResource : IJsonModel<ResourceProviderData>
    {
        void IJsonModel<ResourceProviderData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        ResourceProviderData IJsonModel<ResourceProviderData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<ResourceProviderData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<ResourceProviderData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        ResourceProviderData IPersistableModel<ResourceProviderData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<ResourceProviderData>(data, options);
        }

        string IPersistableModel<ResourceProviderData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
