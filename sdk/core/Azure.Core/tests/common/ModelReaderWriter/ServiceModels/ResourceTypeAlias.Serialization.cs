// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core.Tests.Common;

namespace Azure.Core.Tests.Models.ResourceManager.Resources
{
    public partial class ResourceTypeAlias : IUtf8JsonSerializable, IJsonModel<ResourceTypeAlias>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ResourceTypeAlias>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        internal static ResourceTypeAlias DeserializeResourceTypeAlias(JsonElement element, ModelReaderWriterOptions options = default)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<IReadOnlyList<ResourceTypeAliasPath>> paths = default;
            Optional<ResourceTypeAliasType> type = default;
            Optional<string> defaultPath = default;
            Optional<ResourceTypeAliasPattern> defaultPattern = default;
            Optional<ResourceTypeAliasPathMetadata> defaultMetadata = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("paths"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceTypeAliasPath> array = new List<ResourceTypeAliasPath>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceTypeAliasPath.DeserializeResourceTypeAliasPath(item, options));
                    }
                    paths = array;
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = property.Value.GetString().ToResourceTypeAliasType();
                    continue;
                }
                if (property.NameEquals("defaultPath"u8))
                {
                    defaultPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("defaultPattern"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defaultPattern = ResourceTypeAliasPattern.DeserializeResourceTypeAliasPattern(property.Value, options);
                    continue;
                }
                if (property.NameEquals("defaultMetadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defaultMetadata = ResourceTypeAliasPathMetadata.DeserializeResourceTypeAliasPathMetadata(property.Value, options);
                    continue;
                }
            }
            return new ResourceTypeAlias(name.Value, Optional.ToList(paths), Optional.ToNullable(type), defaultPath.Value, defaultPattern.Value, defaultMetadata.Value);
        }

        void IJsonModel<ResourceTypeAlias>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => Serialize(writer, options);

        private void Serialize(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsCollectionDefined(Paths))
            {
                writer.WritePropertyName("paths"u8);
                writer.WriteStartArray();
                foreach (var item in Paths)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AliasType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(AliasType.ToString());
            }
            if (Optional.IsDefined(DefaultPath))
            {
                writer.WritePropertyName("defaultPath"u8);
                writer.WriteStringValue(DefaultPath);
            }
            if (Optional.IsDefined(DefaultPattern))
            {
                writer.WritePropertyName("defaultPattern"u8);
                writer.WriteObjectValue(DefaultPattern);
            }
            if (Optional.IsDefined(DefaultMetadata))
            {
                writer.WritePropertyName("defaultMetadata"u8);
                writer.WriteObjectValue(DefaultMetadata);
            }
            writer.WriteEndObject();
        }

        private struct ResourceTypeAliasProperties
        {
            public Optional<string> Name { get; set; }
            public Optional<IReadOnlyList<ResourceTypeAliasPath>> Paths { get; set; }
            public Optional<ResourceTypeAliasType> AliasType { get; set; }
            public Optional<string> DefaultPath { get; set; }
            public Optional<ResourceTypeAliasPattern> DefaultPattern { get; set; }
            public Optional<ResourceTypeAliasPathMetadata> DefaultMetadata { get; set; }
        }

        ResourceTypeAlias IJsonModel<ResourceTypeAlias>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceTypeAlias(doc.RootElement, options);
        }

        ResourceTypeAlias IModel<ResourceTypeAlias>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            using var doc = JsonDocument.Parse(data);
            return DeserializeResourceTypeAlias(doc.RootElement, options);
        }

        BinaryData IModel<ResourceTypeAlias>.Write(ModelReaderWriterOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelReaderWriter.Write(this, options);
        }

        ModelReaderWriterFormat IModel<ResourceTypeAlias>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
