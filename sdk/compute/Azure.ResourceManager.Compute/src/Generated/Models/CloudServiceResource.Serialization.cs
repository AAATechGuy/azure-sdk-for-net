// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Compute
{
    public partial class CloudServiceResource : IJsonModel<CloudServiceData>
    {
        void IJsonModel<CloudServiceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        CloudServiceData IJsonModel<CloudServiceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<CloudServiceData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<CloudServiceData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        CloudServiceData IPersistableModel<CloudServiceData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<CloudServiceData>(data, options);
        }

        string IPersistableModel<CloudServiceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
