// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.IO;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager
{
    internal class GenericOperationSource<T> : IOperationSource<T>
    {
        T IOperationSource<T>.CreateResult(Response response, CancellationToken cancellationToken)
            => CreateResult(response);

        ValueTask<T> IOperationSource<T>.CreateResultAsync(Response response, CancellationToken cancellationToken)
            => new ValueTask<T>(CreateResult(response));

        private static T CreateResult(Response response)
        {
            var options = new JsonSerializerOptions();
            options.Converters.Add(new ModelJsonConverter());
            var result = JsonSerializer.Deserialize<IModel>(response.Content, options);
            return (T)result;
        }
    }
}
