// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    public partial class WorkspaceConnectionData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Category))
            {
                writer.WritePropertyName("category");
                writer.WriteStringValue(Category);
            }
            if (Optional.IsDefined(Target))
            {
                writer.WritePropertyName("target");
                writer.WriteStringValue(Target);
            }
            if (Optional.IsDefined(AuthType))
            {
                writer.WritePropertyName("authType");
                writer.WriteStringValue(AuthType);
            }
            if (Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value");
                writer.WriteStringValue(Value);
            }
            if (Optional.IsDefined(ValueFormat))
            {
                writer.WritePropertyName("valueFormat");
                writer.WriteStringValue(ValueFormat.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static WorkspaceConnectionData DeserializeWorkspaceConnectionData(JsonElement element)
        {
            ResourceGroupResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<string> category = default;
            Optional<string> target = default;
            Optional<string> authType = default;
            Optional<string> value = default;
            Optional<ValueFormat> valueFormat = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
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
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("category"))
                        {
                            category = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("target"))
                        {
                            target = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("authType"))
                        {
                            authType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("value"))
                        {
                            value = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("valueFormat"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            valueFormat = new ValueFormat(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new WorkspaceConnectionData(id, name, type, category.Value, target.Value, authType.Value, value.Value, Optional.ToNullable(valueFormat));
        }
    }
}
