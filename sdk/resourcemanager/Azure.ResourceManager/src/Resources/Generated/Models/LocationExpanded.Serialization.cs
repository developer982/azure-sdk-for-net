// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class LocationExpanded : IUtf8JsonSerializable, IJsonModel<LocationExpanded>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LocationExpanded>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LocationExpanded>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LocationExpanded>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(LocationExpanded)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W" && Optional.IsDefined(SubscriptionId))
            {
                writer.WritePropertyName("subscriptionId"u8);
                writer.WriteStringValue(SubscriptionId);
            }
            if (options.Format != "W" && Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && Optional.IsDefined(LocationType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(LocationType.Value.ToSerialString());
            }
            if (options.Format != "W" && Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (options.Format != "W" && Optional.IsDefined(RegionalDisplayName))
            {
                writer.WritePropertyName("regionalDisplayName"u8);
                writer.WriteStringValue(RegionalDisplayName);
            }
            if (Optional.IsDefined(Metadata))
            {
                writer.WritePropertyName("metadata"u8);
                writer.WriteObjectValue(Metadata);
            }
            if (Optional.IsCollectionDefined(AvailabilityZoneMappings))
            {
                writer.WritePropertyName("availabilityZoneMappings"u8);
                writer.WriteStartArray();
                foreach (var item in AvailabilityZoneMappings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        LocationExpanded IJsonModel<LocationExpanded>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LocationExpanded>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(LocationExpanded)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLocationExpanded(document.RootElement, options);
        }

        internal static LocationExpanded DeserializeLocationExpanded(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<string> subscriptionId = default;
            Optional<string> name = default;
            Optional<LocationType> type = default;
            Optional<string> displayName = default;
            Optional<string> regionalDisplayName = default;
            Optional<LocationMetadata> metadata = default;
            Optional<IReadOnlyList<AvailabilityZoneMappings>> availabilityZoneMappings = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subscriptionId"u8))
                {
                    subscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = property.Value.GetString().ToLocationType();
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("regionalDisplayName"u8))
                {
                    regionalDisplayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    metadata = LocationMetadata.DeserializeLocationMetadata(property.Value);
                    continue;
                }
                if (property.NameEquals("availabilityZoneMappings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AvailabilityZoneMappings> array = new List<AvailabilityZoneMappings>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.AvailabilityZoneMappings.DeserializeAvailabilityZoneMappings(item));
                    }
                    availabilityZoneMappings = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LocationExpanded(id.Value, subscriptionId.Value, name.Value, Optional.ToNullable(type), displayName.Value, regionalDisplayName.Value, metadata.Value, Optional.ToList(availabilityZoneMappings), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LocationExpanded>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LocationExpanded>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(LocationExpanded)} does not support '{options.Format}' format.");
            }
        }

        LocationExpanded IPersistableModel<LocationExpanded>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LocationExpanded>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLocationExpanded(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(LocationExpanded)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<LocationExpanded>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
