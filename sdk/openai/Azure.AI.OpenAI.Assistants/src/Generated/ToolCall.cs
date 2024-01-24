// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.AI.OpenAI.Assistants
{
    /// <summary>
    /// An abstract representation of a detailed tool call as recorded within a run step for an existing run.
    /// Please note <see cref="ToolCall"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="CodeInterpreterToolCall"/>, <see cref="RetrievalToolCall"/> and <see cref="FunctionToolCall"/>.
    /// </summary>
    public abstract partial class ToolCall
    {
        /// <summary> Initializes a new instance of <see cref="ToolCall"/>. </summary>
        /// <param name="id"> The ID of the tool call. This ID must be referenced when you submit tool outputs. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        protected ToolCall(string id)
        {
            Argument.AssertNotNull(id, nameof(id));

            Id = id;
        }

        /// <summary> Initializes a new instance of <see cref="ToolCall"/>. </summary>
        /// <param name="type"> The object type. </param>
        /// <param name="id"> The ID of the tool call. This ID must be referenced when you submit tool outputs. </param>
        internal ToolCall(string type, string id)
        {
            Type = type;
            Id = id;
        }

        /// <summary> The object type. </summary>
        internal string Type { get; set; }
        /// <summary> The ID of the tool call. This ID must be referenced when you submit tool outputs. </summary>
        public string Id { get; }
    }
}
