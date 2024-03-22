// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ManagementGroups.Models
{
    public partial class ManagementGroupInfo : IUtf8JsonSerializable, IJsonModel<ManagementGroupInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagementGroupInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagementGroupInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagementGroupInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagementGroupInfo)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteNumberValue(Version.Value);
            }
            if (Optional.IsDefined(UpdatedOn))
            {
                writer.WritePropertyName("updatedTime"u8);
                writer.WriteStringValue(UpdatedOn.Value, "O");
            }
            if (Optional.IsDefined(UpdatedBy))
            {
                writer.WritePropertyName("updatedBy"u8);
                writer.WriteStringValue(UpdatedBy);
            }
            if (Optional.IsDefined(Parent))
            {
                writer.WritePropertyName("parent"u8);
                writer.WriteObjectValue(Parent);
            }
            if (Optional.IsCollectionDefined(Path))
            {
                if (Path != null)
                {
                    writer.WritePropertyName("path"u8);
                    writer.WriteStartArray();
                    foreach (var item in Path)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("path");
                }
            }
            if (Optional.IsCollectionDefined(ManagementGroupAncestors))
            {
                if (ManagementGroupAncestors != null)
                {
                    writer.WritePropertyName("managementGroupAncestors"u8);
                    writer.WriteStartArray();
                    foreach (var item in ManagementGroupAncestors)
                    {
                        writer.WriteStringValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("managementGroupAncestors");
                }
            }
            if (Optional.IsCollectionDefined(ManagementGroupAncestorChain))
            {
                if (ManagementGroupAncestorChain != null)
                {
                    writer.WritePropertyName("managementGroupAncestorsChain"u8);
                    writer.WriteStartArray();
                    foreach (var item in ManagementGroupAncestorChain)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("managementGroupAncestorsChain");
                }
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

        ManagementGroupInfo IJsonModel<ManagementGroupInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagementGroupInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagementGroupInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagementGroupInfo(document.RootElement, options);
        }

        internal static ManagementGroupInfo DeserializeManagementGroupInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? version = default;
            DateTimeOffset? updatedTime = default;
            string updatedBy = default;
            ParentManagementGroupInfo parent = default;
            IReadOnlyList<ManagementGroupPathElement> path = default;
            IReadOnlyList<string> managementGroupAncestors = default;
            IReadOnlyList<ManagementGroupPathElement> managementGroupAncestorsChain = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("version"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    version = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("updatedTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    updatedTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("updatedBy"u8))
                {
                    updatedBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    parent = ParentManagementGroupInfo.DeserializeParentManagementGroupInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("path"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        path = null;
                        continue;
                    }
                    List<ManagementGroupPathElement> array = new List<ManagementGroupPathElement>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagementGroupPathElement.DeserializeManagementGroupPathElement(item, options));
                    }
                    path = array;
                    continue;
                }
                if (property.NameEquals("managementGroupAncestors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        managementGroupAncestors = null;
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    managementGroupAncestors = array;
                    continue;
                }
                if (property.NameEquals("managementGroupAncestorsChain"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        managementGroupAncestorsChain = null;
                        continue;
                    }
                    List<ManagementGroupPathElement> array = new List<ManagementGroupPathElement>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagementGroupPathElement.DeserializeManagementGroupPathElement(item, options));
                    }
                    managementGroupAncestorsChain = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ManagementGroupInfo(
                version,
                updatedTime,
                updatedBy,
                parent,
                path ?? new ChangeTrackingList<ManagementGroupPathElement>(),
                managementGroupAncestors ?? new ChangeTrackingList<string>(),
                managementGroupAncestorsChain ?? new ChangeTrackingList<ManagementGroupPathElement>(),
                serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Version), out propertyOverride);
            if (Optional.IsDefined(Version) || hasPropertyOverride)
            {
                builder.Append("  version: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"{Version.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(UpdatedOn), out propertyOverride);
            if (Optional.IsDefined(UpdatedOn) || hasPropertyOverride)
            {
                builder.Append("  updatedTime: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    var formattedDateTimeString = TypeFormatters.ToString(UpdatedOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(UpdatedBy), out propertyOverride);
            if (Optional.IsDefined(UpdatedBy) || hasPropertyOverride)
            {
                builder.Append("  updatedBy: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (UpdatedBy.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{UpdatedBy}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{UpdatedBy}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Parent), out propertyOverride);
            if (Optional.IsDefined(Parent) || hasPropertyOverride)
            {
                builder.Append("  parent: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    BicepSerializationHelpers.AppendChildObject(builder, Parent, options, 2, false, "  parent: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Path), out propertyOverride);
            if (Optional.IsCollectionDefined(Path) || hasPropertyOverride)
            {
                if (Path.Any() || hasPropertyOverride)
                {
                    builder.Append("  path: ");
                    if (hasPropertyOverride)
                    {
                        builder.AppendLine($"{propertyOverride}");
                    }
                    else
                    {
                        builder.AppendLine("[");
                        foreach (var item in Path)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  path: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ManagementGroupAncestors), out propertyOverride);
            if (Optional.IsCollectionDefined(ManagementGroupAncestors) || hasPropertyOverride)
            {
                if (ManagementGroupAncestors.Any() || hasPropertyOverride)
                {
                    builder.Append("  managementGroupAncestors: ");
                    if (hasPropertyOverride)
                    {
                        builder.AppendLine($"{propertyOverride}");
                    }
                    else
                    {
                        builder.AppendLine("[");
                        foreach (var item in ManagementGroupAncestors)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("    '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"    '{item}'");
                            }
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ManagementGroupAncestorChain), out propertyOverride);
            if (Optional.IsCollectionDefined(ManagementGroupAncestorChain) || hasPropertyOverride)
            {
                if (ManagementGroupAncestorChain.Any() || hasPropertyOverride)
                {
                    builder.Append("  managementGroupAncestorsChain: ");
                    if (hasPropertyOverride)
                    {
                        builder.AppendLine($"{propertyOverride}");
                    }
                    else
                    {
                        builder.AppendLine("[");
                        foreach (var item in ManagementGroupAncestorChain)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  managementGroupAncestorsChain: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ManagementGroupInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagementGroupInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ManagementGroupInfo)} does not support writing '{options.Format}' format.");
            }
        }

        ManagementGroupInfo IPersistableModel<ManagementGroupInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagementGroupInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagementGroupInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagementGroupInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagementGroupInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
