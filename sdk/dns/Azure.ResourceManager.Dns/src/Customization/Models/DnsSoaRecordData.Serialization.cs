// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Dns.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Dns
{
    public partial class DnsSoaRecordData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag");
                writer.WriteStringValue(ETag.Value.ToString());
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Metadata))
            {
                writer.WritePropertyName("metadata");
                writer.WriteStartObject();
                foreach (var item in Metadata)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(TtlInSeconds))
            {
                writer.WritePropertyName("TTL");
                writer.WriteNumberValue(TtlInSeconds.Value);
            }
            if (Optional.IsDefined(TargetResource))
            {
                writer.WritePropertyName("targetResource");
                JsonSerializer.Serialize(writer, TargetResource);
            }
            if (Optional.IsDefined(TrafficManagementProfile))
            {
                writer.WritePropertyName("trafficManagementProfile"u8);
                JsonSerializer.Serialize(writer, TrafficManagementProfile);
            }
            if (Optional.IsDefined(DnsSoaRecord))
            {
                writer.WritePropertyName("SOARecord");
                writer.WriteObjectValue(DnsSoaRecord);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static DnsSoaRecordData DeserializeDnsSoaRecordData(JsonElement element)
        {
            Optional<ETag> etag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            ResourceManager.Models.SystemData systemData = default;
            Optional<IDictionary<string, string>> metadata = default;
            Optional<long> ttl = default;
            Optional<string> fqdn = default;
            Optional<string> provisioningState = default;
            Optional<WritableSubResource> targetResource = default;
            Optional<WritableSubResource> trafficManagementProfile = default;
            Optional<DnsSoaRecordInfo> soaRecord = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"))
                {
                     if (property.Value.ValueKind == JsonValueKind.Null)
                     {
                         property.ThrowNonNullablePropertyIsNull();
                         continue;
                     }
                     etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    systemData = JsonSerializer.Deserialize<ResourceManager.Models.SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("metadata"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            metadata = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("TTL"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            ttl = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("fqdn"))
                        {
                            fqdn = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("targetResource"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            targetResource = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.ToString());
                            continue;
                        }
                        if (property0.NameEquals("trafficManagementProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            trafficManagementProfile = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("SOARecord"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            soaRecord = DnsSoaRecordInfo.DeserializeDnsSoaRecordInfo(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new DnsSoaRecordData(id, name, type, systemData, Optional.ToNullable(etag), Optional.ToDictionary(metadata), Optional.ToNullable(ttl), fqdn.Value, provisioningState.Value, targetResource, trafficManagementProfile, soaRecord.Value);
        }
    }
}
