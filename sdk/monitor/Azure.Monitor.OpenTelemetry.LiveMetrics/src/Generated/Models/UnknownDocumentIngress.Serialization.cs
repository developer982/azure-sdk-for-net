// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Monitor.OpenTelemetry.LiveMetrics;

namespace Azure.Monitor.OpenTelemetry.LiveMetrics.Models
{
    internal partial class UnknownDocumentIngress : IUtf8JsonSerializable, IJsonModel<DocumentIngress>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DocumentIngress>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DocumentIngress>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DocumentIngress>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DocumentIngress)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("DocumentType"u8);
            writer.WriteStringValue(DocumentType.ToString());
            if (Optional.IsCollectionDefined(DocumentStreamIds))
            {
                writer.WritePropertyName("DocumentStreamIds"u8);
                writer.WriteStartArray();
                foreach (var item in DocumentStreamIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Properties))
            {
                writer.WritePropertyName("Properties"u8);
                writer.WriteStartArray();
                foreach (var item in Properties)
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

        DocumentIngress IJsonModel<DocumentIngress>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DocumentIngress>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DocumentIngress)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDocumentIngress(document.RootElement, options);
        }

        internal static UnknownDocumentIngress DeserializeUnknownDocumentIngress(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DocumentType documentType = "AutoRest.CSharp.Output.Models.Types.EnumTypeValue";
            IList<string> documentStreamIds = default;
            IList<KeyValuePairStringString> properties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("DocumentType"u8))
                {
                    documentType = new DocumentType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("DocumentStreamIds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    documentStreamIds = array;
                    continue;
                }
                if (property.NameEquals("Properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<KeyValuePairStringString> array = new List<KeyValuePairStringString>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(KeyValuePairStringString.DeserializeKeyValuePairStringString(item, options));
                    }
                    properties = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new UnknownDocumentIngress(documentType, documentStreamIds ?? new ChangeTrackingList<string>(), properties ?? new ChangeTrackingList<KeyValuePairStringString>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DocumentIngress>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DocumentIngress>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DocumentIngress)} does not support '{options.Format}' format.");
            }
        }

        DocumentIngress IPersistableModel<DocumentIngress>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DocumentIngress>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDocumentIngress(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DocumentIngress)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DocumentIngress>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new UnknownDocumentIngress FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeUnknownDocumentIngress(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
