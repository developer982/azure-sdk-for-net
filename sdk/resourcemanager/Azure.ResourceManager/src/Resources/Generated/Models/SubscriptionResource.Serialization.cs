// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Resources
{
    public partial class SubscriptionResource : IJsonModel<SubscriptionData>
    {
        void IJsonModel<SubscriptionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        SubscriptionData IJsonModel<SubscriptionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<SubscriptionData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<SubscriptionData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        SubscriptionData IPersistableModel<SubscriptionData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<SubscriptionData>(data, options);
        }

        string IPersistableModel<SubscriptionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
