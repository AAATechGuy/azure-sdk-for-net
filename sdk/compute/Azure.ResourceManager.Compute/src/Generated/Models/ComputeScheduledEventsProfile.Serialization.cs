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
    public partial class ComputeScheduledEventsProfile : IUtf8JsonSerializable, IJsonModel<ComputeScheduledEventsProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ComputeScheduledEventsProfile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ComputeScheduledEventsProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeScheduledEventsProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ComputeScheduledEventsProfile)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(TerminateNotificationProfile))
            {
                writer.WritePropertyName("terminateNotificationProfile"u8);
                writer.WriteObjectValue(TerminateNotificationProfile);
            }
            if (Optional.IsDefined(OSImageNotificationProfile))
            {
                writer.WritePropertyName("osImageNotificationProfile"u8);
                writer.WriteObjectValue(OSImageNotificationProfile);
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

        ComputeScheduledEventsProfile IJsonModel<ComputeScheduledEventsProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeScheduledEventsProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ComputeScheduledEventsProfile)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeComputeScheduledEventsProfile(document.RootElement, options);
        }

        internal static ComputeScheduledEventsProfile DeserializeComputeScheduledEventsProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<TerminateNotificationProfile> terminateNotificationProfile = default;
            Optional<OSImageNotificationProfile> osImageNotificationProfile = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("terminateNotificationProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    terminateNotificationProfile = TerminateNotificationProfile.DeserializeTerminateNotificationProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("osImageNotificationProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    osImageNotificationProfile = OSImageNotificationProfile.DeserializeOSImageNotificationProfile(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ComputeScheduledEventsProfile(terminateNotificationProfile.Value, osImageNotificationProfile.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ComputeScheduledEventsProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeScheduledEventsProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(ComputeScheduledEventsProfile)} does not support '{options.Format}' format.");
            }
        }

        ComputeScheduledEventsProfile IPersistableModel<ComputeScheduledEventsProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeScheduledEventsProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeComputeScheduledEventsProfile(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(ComputeScheduledEventsProfile)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ComputeScheduledEventsProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
