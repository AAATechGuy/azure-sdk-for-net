// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    public partial class RegulatoryComplianceStandardData : IUtf8JsonSerializable, IJsonModel<RegulatoryComplianceStandardData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RegulatoryComplianceStandardData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RegulatoryComplianceStandardData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RegulatoryComplianceStandardData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RegulatoryComplianceStandardData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(PassedControls))
            {
                writer.WritePropertyName("passedControls"u8);
                writer.WriteNumberValue(PassedControls.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(FailedControls))
            {
                writer.WritePropertyName("failedControls"u8);
                writer.WriteNumberValue(FailedControls.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(SkippedControls))
            {
                writer.WritePropertyName("skippedControls"u8);
                writer.WriteNumberValue(SkippedControls.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(UnsupportedControls))
            {
                writer.WritePropertyName("unsupportedControls"u8);
                writer.WriteNumberValue(UnsupportedControls.Value);
            }
            writer.WriteEndObject();
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

        RegulatoryComplianceStandardData IJsonModel<RegulatoryComplianceStandardData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RegulatoryComplianceStandardData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RegulatoryComplianceStandardData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRegulatoryComplianceStandardData(document.RootElement, options);
        }

        internal static RegulatoryComplianceStandardData DeserializeRegulatoryComplianceStandardData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<RegulatoryComplianceState> state = default;
            Optional<int> passedControls = default;
            Optional<int> failedControls = default;
            Optional<int> skippedControls = default;
            Optional<int> unsupportedControls = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("state"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            state = new RegulatoryComplianceState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("passedControls"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            passedControls = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("failedControls"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            failedControls = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("skippedControls"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            skippedControls = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("unsupportedControls"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            unsupportedControls = property0.Value.GetInt32();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RegulatoryComplianceStandardData(id, name, type, systemData.Value, Optional.ToNullable(state), Optional.ToNullable(passedControls), Optional.ToNullable(failedControls), Optional.ToNullable(skippedControls), Optional.ToNullable(unsupportedControls), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RegulatoryComplianceStandardData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RegulatoryComplianceStandardData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RegulatoryComplianceStandardData)} does not support '{options.Format}' format.");
            }
        }

        RegulatoryComplianceStandardData IPersistableModel<RegulatoryComplianceStandardData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RegulatoryComplianceStandardData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRegulatoryComplianceStandardData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RegulatoryComplianceStandardData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RegulatoryComplianceStandardData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
