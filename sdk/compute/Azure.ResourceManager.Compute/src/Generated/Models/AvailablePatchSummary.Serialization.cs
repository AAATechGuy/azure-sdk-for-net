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
    public partial class AvailablePatchSummary : IUtf8JsonSerializable, IJsonModel<AvailablePatchSummary>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AvailablePatchSummary>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AvailablePatchSummary>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvailablePatchSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(AvailablePatchSummary)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(AssessmentActivityId))
            {
                writer.WritePropertyName("assessmentActivityId"u8);
                writer.WriteStringValue(AssessmentActivityId);
            }
            if (options.Format != "W" && Optional.IsDefined(RebootPending))
            {
                writer.WritePropertyName("rebootPending"u8);
                writer.WriteBooleanValue(RebootPending.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(CriticalAndSecurityPatchCount))
            {
                writer.WritePropertyName("criticalAndSecurityPatchCount"u8);
                writer.WriteNumberValue(CriticalAndSecurityPatchCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(OtherPatchCount))
            {
                writer.WritePropertyName("otherPatchCount"u8);
                writer.WriteNumberValue(OtherPatchCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LastModifiedOn))
            {
                writer.WritePropertyName("lastModifiedTime"u8);
                writer.WriteStringValue(LastModifiedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(Error))
            {
                writer.WritePropertyName("error"u8);
                writer.WriteObjectValue(Error);
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

        AvailablePatchSummary IJsonModel<AvailablePatchSummary>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvailablePatchSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(AvailablePatchSummary)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAvailablePatchSummary(document.RootElement, options);
        }

        internal static AvailablePatchSummary DeserializeAvailablePatchSummary(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<PatchOperationStatus> status = default;
            Optional<string> assessmentActivityId = default;
            Optional<bool> rebootPending = default;
            Optional<int> criticalAndSecurityPatchCount = default;
            Optional<int> otherPatchCount = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<DateTimeOffset> lastModifiedTime = default;
            Optional<ComputeApiError> error = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new PatchOperationStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("assessmentActivityId"u8))
                {
                    assessmentActivityId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rebootPending"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rebootPending = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("criticalAndSecurityPatchCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    criticalAndSecurityPatchCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("otherPatchCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    otherPatchCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastModifiedTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastModifiedTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = ComputeApiError.DeserializeComputeApiError(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AvailablePatchSummary(Optional.ToNullable(status), assessmentActivityId.Value, Optional.ToNullable(rebootPending), Optional.ToNullable(criticalAndSecurityPatchCount), Optional.ToNullable(otherPatchCount), Optional.ToNullable(startTime), Optional.ToNullable(lastModifiedTime), error.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AvailablePatchSummary>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvailablePatchSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(AvailablePatchSummary)} does not support '{options.Format}' format.");
            }
        }

        AvailablePatchSummary IPersistableModel<AvailablePatchSummary>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvailablePatchSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAvailablePatchSummary(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(AvailablePatchSummary)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AvailablePatchSummary>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
