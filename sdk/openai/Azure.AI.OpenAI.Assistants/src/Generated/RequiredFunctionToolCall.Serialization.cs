// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;

namespace Azure.AI.OpenAI.Assistants
{
    public partial class RequiredFunctionToolCall
    {
        internal static RequiredFunctionToolCall DeserializeRequiredFunctionToolCall(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            InternalFunctionDefinition function = default;
            string type = default;
            string id = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("function"u8))
                {
                    function = Assistants.InternalFunctionDefinition.DeserializeInternalFunctionDefinition(property.Value);
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
            }
            return new RequiredFunctionToolCall(type, id, function);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new RequiredFunctionToolCall FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeRequiredFunctionToolCall(document.RootElement);
        }
    }
}
