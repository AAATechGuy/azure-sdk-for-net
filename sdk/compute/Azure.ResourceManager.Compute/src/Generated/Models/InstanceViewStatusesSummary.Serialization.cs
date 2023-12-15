// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    internal partial class InstanceViewStatusesSummary : IUtf8JsonSerializable, IJsonModel<InstanceViewStatusesSummary>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InstanceViewStatusesSummary>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<InstanceViewStatusesSummary>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InstanceViewStatusesSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(InstanceViewStatusesSummary)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsCollectionDefined(StatusesSummary))
            {
                writer.WritePropertyName("statusesSummary"u8);
                writer.WriteStartArray();
                foreach (var item in StatusesSummary)
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

        InstanceViewStatusesSummary IJsonModel<InstanceViewStatusesSummary>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InstanceViewStatusesSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(InstanceViewStatusesSummary)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInstanceViewStatusesSummary(document.RootElement, options);
        }

        internal static InstanceViewStatusesSummary DeserializeInstanceViewStatusesSummary(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<StatusCodeCount>> statusesSummary = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("statusesSummary"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<StatusCodeCount> array = new List<StatusCodeCount>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StatusCodeCount.DeserializeStatusCodeCount(item));
                    }
                    statusesSummary = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new InstanceViewStatusesSummary(Optional.ToList(statusesSummary), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InstanceViewStatusesSummary>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InstanceViewStatusesSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(InstanceViewStatusesSummary)} does not support '{options.Format}' format.");
            }
        }

        InstanceViewStatusesSummary IPersistableModel<InstanceViewStatusesSummary>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InstanceViewStatusesSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInstanceViewStatusesSummary(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(InstanceViewStatusesSummary)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<InstanceViewStatusesSummary>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
