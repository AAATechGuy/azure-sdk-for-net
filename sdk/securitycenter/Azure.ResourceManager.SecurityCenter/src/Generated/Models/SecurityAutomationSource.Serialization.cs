// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class SecurityAutomationSource : IUtf8JsonSerializable, IJsonModel<SecurityAutomationSource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityAutomationSource>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SecurityAutomationSource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityAutomationSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityAutomationSource)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(EventSource))
            {
                writer.WritePropertyName("eventSource"u8);
                writer.WriteStringValue(EventSource.Value.ToString());
            }
            if (Optional.IsCollectionDefined(RuleSets))
            {
                writer.WritePropertyName("ruleSets"u8);
                writer.WriteStartArray();
                foreach (var item in RuleSets)
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

        SecurityAutomationSource IJsonModel<SecurityAutomationSource>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityAutomationSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityAutomationSource)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityAutomationSource(document.RootElement, options);
        }

        internal static SecurityAutomationSource DeserializeSecurityAutomationSource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SecurityEventSource> eventSource = default;
            Optional<IList<SecurityAutomationRuleSet>> ruleSets = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("eventSource"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    eventSource = new SecurityEventSource(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ruleSets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SecurityAutomationRuleSet> array = new List<SecurityAutomationRuleSet>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SecurityAutomationRuleSet.DeserializeSecurityAutomationRuleSet(item));
                    }
                    ruleSets = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SecurityAutomationSource(Optional.ToNullable(eventSource), Optional.ToList(ruleSets), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SecurityAutomationSource>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityAutomationSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SecurityAutomationSource)} does not support '{options.Format}' format.");
            }
        }

        SecurityAutomationSource IPersistableModel<SecurityAutomationSource>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityAutomationSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSecurityAutomationSource(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SecurityAutomationSource)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecurityAutomationSource>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
