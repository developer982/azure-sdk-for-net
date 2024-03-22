// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class ManagementLockOwner : IUtf8JsonSerializable, IJsonModel<ManagementLockOwner>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagementLockOwner>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagementLockOwner>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagementLockOwner>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagementLockOwner)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ApplicationId))
            {
                writer.WritePropertyName("applicationId"u8);
                writer.WriteStringValue(ApplicationId);
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

        ManagementLockOwner IJsonModel<ManagementLockOwner>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagementLockOwner>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagementLockOwner)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagementLockOwner(document.RootElement, options);
        }

        internal static ManagementLockOwner DeserializeManagementLockOwner(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string applicationId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("applicationId"u8))
                {
                    applicationId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ManagementLockOwner(applicationId, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ApplicationId), out propertyOverride);
            if (Optional.IsDefined(ApplicationId) || hasPropertyOverride)
            {
                builder.Append("  applicationId: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (ApplicationId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ApplicationId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ApplicationId}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ManagementLockOwner>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagementLockOwner>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ManagementLockOwner)} does not support writing '{options.Format}' format.");
            }
        }

        ManagementLockOwner IPersistableModel<ManagementLockOwner>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagementLockOwner>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagementLockOwner(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagementLockOwner)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagementLockOwner>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
