// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallingServer
{
    public partial class GroupCallLocatorModel : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("groupId");
            writer.WriteStringValue(GroupId);
            writer.WriteEndObject();
        }

        internal static GroupCallLocatorModel DeserializeGroupCallLocatorModel(JsonElement element)
        {
            string groupId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("groupId"))
                {
                    groupId = property.Value.GetString();
                    continue;
                }
            }
            return new GroupCallLocatorModel(groupId);
        }
    }
}
