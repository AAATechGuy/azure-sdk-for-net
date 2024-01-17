// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ApplicationGatewayBackendHealthOnDemand : IUtf8JsonSerializable, IJsonModel<ApplicationGatewayBackendHealthOnDemand>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApplicationGatewayBackendHealthOnDemand>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ApplicationGatewayBackendHealthOnDemand>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationGatewayBackendHealthOnDemand>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationGatewayBackendHealthOnDemand)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(BackendAddressPool))
            {
                writer.WritePropertyName("backendAddressPool"u8);
                writer.WriteObjectValue(BackendAddressPool);
            }
            if (Optional.IsDefined(BackendHealthHttpSettings))
            {
                writer.WritePropertyName("backendHealthHttpSettings"u8);
                writer.WriteObjectValue(BackendHealthHttpSettings);
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

        ApplicationGatewayBackendHealthOnDemand IJsonModel<ApplicationGatewayBackendHealthOnDemand>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationGatewayBackendHealthOnDemand>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationGatewayBackendHealthOnDemand)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApplicationGatewayBackendHealthOnDemand(document.RootElement, options);
        }

        internal static ApplicationGatewayBackendHealthOnDemand DeserializeApplicationGatewayBackendHealthOnDemand(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ApplicationGatewayBackendAddressPool> backendAddressPool = default;
            Optional<ApplicationGatewayBackendHealthHttpSettings> backendHealthHttpSettings = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("backendAddressPool"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backendAddressPool = ApplicationGatewayBackendAddressPool.DeserializeApplicationGatewayBackendAddressPool(property.Value);
                    continue;
                }
                if (property.NameEquals("backendHealthHttpSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backendHealthHttpSettings = ApplicationGatewayBackendHealthHttpSettings.DeserializeApplicationGatewayBackendHealthHttpSettings(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ApplicationGatewayBackendHealthOnDemand(backendAddressPool.Value, backendHealthHttpSettings.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ApplicationGatewayBackendHealthOnDemand>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationGatewayBackendHealthOnDemand>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ApplicationGatewayBackendHealthOnDemand)} does not support '{options.Format}' format.");
            }
        }

        ApplicationGatewayBackendHealthOnDemand IPersistableModel<ApplicationGatewayBackendHealthOnDemand>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationGatewayBackendHealthOnDemand>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeApplicationGatewayBackendHealthOnDemand(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ApplicationGatewayBackendHealthOnDemand)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApplicationGatewayBackendHealthOnDemand>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
