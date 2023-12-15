// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class DiskRestorePointAttributes : IUtf8JsonSerializable, IJsonModel<DiskRestorePointAttributes>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DiskRestorePointAttributes>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DiskRestorePointAttributes>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiskRestorePointAttributes>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(DiskRestorePointAttributes)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Encryption))
            {
                writer.WritePropertyName("encryption"u8);
                writer.WriteObjectValue(Encryption);
            }
            if (Optional.IsDefined(SourceDiskRestorePoint))
            {
                writer.WritePropertyName("sourceDiskRestorePoint"u8);
                JsonSerializer.Serialize(writer, SourceDiskRestorePoint);
            }
            if (options.Format != "W" && Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
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

        DiskRestorePointAttributes IJsonModel<DiskRestorePointAttributes>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiskRestorePointAttributes>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(DiskRestorePointAttributes)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDiskRestorePointAttributes(document.RootElement, options);
        }

        internal static DiskRestorePointAttributes DeserializeDiskRestorePointAttributes(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<RestorePointEncryption> encryption = default;
            Optional<WritableSubResource> sourceDiskRestorePoint = default;
            Optional<ResourceIdentifier> id = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("encryption"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    encryption = RestorePointEncryption.DeserializeRestorePointEncryption(property.Value);
                    continue;
                }
                if (property.NameEquals("sourceDiskRestorePoint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceDiskRestorePoint = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DiskRestorePointAttributes(id.Value, serializedAdditionalRawData, encryption.Value, sourceDiskRestorePoint);
        }

        BinaryData IPersistableModel<DiskRestorePointAttributes>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiskRestorePointAttributes>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(DiskRestorePointAttributes)} does not support '{options.Format}' format.");
            }
        }

        DiskRestorePointAttributes IPersistableModel<DiskRestorePointAttributes>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiskRestorePointAttributes>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDiskRestorePointAttributes(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(DiskRestorePointAttributes)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DiskRestorePointAttributes>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
