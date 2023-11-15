﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Net;
using System.Text;
using System.Threading;

namespace Maps;

public class MapsClient
{
    private readonly Uri _endpoint;
    private readonly KeyCredential _credential;
    private readonly ClientPipeline _pipeline;
    private readonly string _apiVersion;

    public MapsClient(Uri endpoint, KeyCredential credential, MapsClientOptions options = default)
    {
        if (endpoint is null) throw new ArgumentNullException(nameof(endpoint));
        if (credential is null) throw new ArgumentNullException(nameof(credential));

        options ??= new MapsClientOptions();

        _endpoint = endpoint;
        _credential = credential;
        _apiVersion = options.Version;

        if (options.PerCallPolicies is null)
        {
            options.PerCallPolicies = new PipelinePolicy[1];
        }
        else
        {
            var perCallPolicies = new PipelinePolicy[options.PerCallPolicies.Length + 1];
            options.PerCallPolicies.CopyTo(perCallPolicies.AsSpan());
        }

        options.PerCallPolicies[options.PerCallPolicies.Length - 1] = new KeyCredentialAuthenticationPolicy(_credential, "subscription-key");

        _pipeline = ClientPipeline.Create(options);
    }

    public virtual OutputMessage<IPAddressCountryPair> GetCountryCode(IPAddress ipAddress, CancellationToken cancellationToken = default)
    {
        if (ipAddress is null) throw new ArgumentNullException(nameof(ipAddress));

        RequestOptions options = cancellationToken.CanBeCanceled ?
            new RequestOptions() { CancellationToken = cancellationToken } :
            new RequestOptions();

        OutputMessage output = GetCountryCode(ipAddress.ToString(), options);

        PipelineResponse response = output.GetRawResponse();
        IPAddressCountryPair value = IPAddressCountryPair.FromResponse(response);

        return OutputMessage.FromValue(value, response);
    }

    public virtual OutputMessage GetCountryCode(string ipAddress, RequestOptions options = null)
    {
        if (ipAddress is null) throw new ArgumentNullException(nameof(ipAddress));

        options ??= new RequestOptions();

        using PipelineMessage message = CreateGetLocationRequest(ipAddress, options);

        _pipeline.Send(message);

        PipelineResponse response = message.Response;

        if (response.IsError && options.ErrorBehavior == ErrorBehavior.Default)
        {
            throw new ClientRequestException(response);
        }

        return OutputMessage.FromResponse(response);
    }

    private PipelineMessage CreateGetLocationRequest(string ipAddress, RequestOptions options)
    {
        PipelineMessage message = _pipeline.CreateMessage();
        options.Apply(message, new ResponseStatusClassifier(stackalloc ushort[] { 200 }));

        PipelineRequest request = message.Request;
        request.Method = "GET";

        UriBuilder uriBuilder = new(_endpoint.ToString());

        StringBuilder path = new();
        path.Append("geolocation/ip");
        path.Append("/json");
        uriBuilder.Path += path.ToString();

        StringBuilder query = new();
        query.Append("api-version=");
        query.Append(Uri.EscapeDataString(_apiVersion));
        query.Append("&ip=");
        query.Append(Uri.EscapeDataString(ipAddress));
        uriBuilder.Query = query.ToString();

        request.Uri = uriBuilder.Uri;

        request.Headers.Add("Accept", "application/json");

        return message;
    }
}
