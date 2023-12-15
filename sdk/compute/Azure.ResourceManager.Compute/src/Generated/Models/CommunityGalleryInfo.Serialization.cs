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
    public partial class CommunityGalleryInfo : IUtf8JsonSerializable, IJsonModel<CommunityGalleryInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CommunityGalleryInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CommunityGalleryInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommunityGalleryInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(CommunityGalleryInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(PublisherUri))
            {
                writer.WritePropertyName("publisherUri"u8);
                writer.WriteStringValue(PublisherUri.AbsoluteUri);
            }
            if (Optional.IsDefined(PublisherContact))
            {
                writer.WritePropertyName("publisherContact"u8);
                writer.WriteStringValue(PublisherContact);
            }
            if (Optional.IsDefined(Eula))
            {
                writer.WritePropertyName("eula"u8);
                writer.WriteStringValue(Eula);
            }
            if (Optional.IsDefined(PublicNamePrefix))
            {
                writer.WritePropertyName("publicNamePrefix"u8);
                writer.WriteStringValue(PublicNamePrefix);
            }
            if (options.Format != "W" && Optional.IsDefined(CommunityGalleryEnabled))
            {
                writer.WritePropertyName("communityGalleryEnabled"u8);
                writer.WriteBooleanValue(CommunityGalleryEnabled.Value);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(PublicNames))
            {
                writer.WritePropertyName("publicNames"u8);
                writer.WriteStartArray();
                foreach (var item in PublicNames)
                {
                    writer.WriteStringValue(item);
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

        CommunityGalleryInfo IJsonModel<CommunityGalleryInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommunityGalleryInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(CommunityGalleryInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCommunityGalleryInfo(document.RootElement, options);
        }

        internal static CommunityGalleryInfo DeserializeCommunityGalleryInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Uri> publisherUri = default;
            Optional<string> publisherContact = default;
            Optional<string> eula = default;
            Optional<string> publicNamePrefix = default;
            Optional<bool> communityGalleryEnabled = default;
            Optional<IReadOnlyList<string>> publicNames = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("publisherUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publisherUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("publisherContact"u8))
                {
                    publisherContact = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("eula"u8))
                {
                    eula = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("publicNamePrefix"u8))
                {
                    publicNamePrefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("communityGalleryEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    communityGalleryEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("publicNames"u8))
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
                    publicNames = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CommunityGalleryInfo(publisherUri.Value, publisherContact.Value, eula.Value, publicNamePrefix.Value, Optional.ToNullable(communityGalleryEnabled), Optional.ToList(publicNames), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CommunityGalleryInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommunityGalleryInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(CommunityGalleryInfo)} does not support '{options.Format}' format.");
            }
        }

        CommunityGalleryInfo IPersistableModel<CommunityGalleryInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommunityGalleryInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCommunityGalleryInfo(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(CommunityGalleryInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CommunityGalleryInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
