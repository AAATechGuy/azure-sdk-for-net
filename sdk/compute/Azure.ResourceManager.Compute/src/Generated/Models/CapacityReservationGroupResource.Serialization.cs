// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Compute
{
    public partial class CapacityReservationGroupResource : IJsonModel<CapacityReservationGroupData>
    {
        void IJsonModel<CapacityReservationGroupData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        CapacityReservationGroupData IJsonModel<CapacityReservationGroupData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<CapacityReservationGroupData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<CapacityReservationGroupData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        CapacityReservationGroupData IPersistableModel<CapacityReservationGroupData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<CapacityReservationGroupData>(data, options);
        }

        string IPersistableModel<CapacityReservationGroupData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
