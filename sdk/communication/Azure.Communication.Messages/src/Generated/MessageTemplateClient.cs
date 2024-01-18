// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Communication.Messages
{
    // Data plane generated client.
    /// <summary> The MessageTemplate service client. </summary>
    public partial class MessageTemplateClient
    {
        private const string AuthorizationHeader = "Authorization";
        private readonly AzureKeyCredential _keyCredential;
        private static readonly string[] AuthorizationScopes = new string[] { "https://communication.azure.com/.default" };
        private readonly TokenCredential _tokenCredential;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of MessageTemplateClient. </summary>
        /// <param name="endpoint"> The communication resource, for example https://my-resource.communication.azure.com. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public MessageTemplateClient(Uri endpoint, AzureKeyCredential credential) : this(endpoint, credential, new CommunicationMessagesClientOptions())
        {
        }

        /// <summary> Initializes a new instance of MessageTemplateClient. </summary>
        /// <param name="endpoint"> The communication resource, for example https://my-resource.communication.azure.com. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public MessageTemplateClient(Uri endpoint, TokenCredential credential) : this(endpoint, credential, new CommunicationMessagesClientOptions())
        {
        }

        /// <summary> Initializes a new instance of MessageTemplateClient. </summary>
        /// <param name="endpoint"> The communication resource, for example https://my-resource.communication.azure.com. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public MessageTemplateClient(Uri endpoint, TokenCredential credential, CommunicationMessagesClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            Argument.AssertNotNull(credential, nameof(credential));
            options ??= new CommunicationMessagesClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _tokenCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), new HttpPipelinePolicy[] { new BearerTokenAuthenticationPolicy(_tokenCredential, AuthorizationScopes) }, new ResponseClassifier());
            _endpoint = endpoint;
            _apiVersion = options.Version;
        }

        /// <summary> List all templates for given ACS channel. </summary>
        /// <param name="channelId"> The registration ID of the channel. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="channelId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="channelId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <include file="Docs/MessageTemplateClient.xml" path="doc/members/member[@name='GetTemplatesAsync(string,CancellationToken)']/*" />
        public virtual AsyncPageable<MessageTemplateItem> GetTemplatesAsync(string channelId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(channelId, nameof(channelId));

            RequestContext context = cancellationToken.CanBeCanceled ? new RequestContext { CancellationToken = cancellationToken } : null;
            HttpMessage FirstPageRequest(int? pageSizeHint) => CreateGetTemplatesRequest(channelId, context);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => CreateGetTemplatesNextPageRequest(nextLink, channelId, context);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, MessageTemplateItem.DeserializeMessageTemplateItem, ClientDiagnostics, _pipeline, "MessageTemplateClient.GetTemplates", "value", "nextLink", context);
        }

        /// <summary> List all templates for given ACS channel. </summary>
        /// <param name="channelId"> The registration ID of the channel. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="channelId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="channelId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <include file="Docs/MessageTemplateClient.xml" path="doc/members/member[@name='GetTemplates(string,CancellationToken)']/*" />
        public virtual Pageable<MessageTemplateItem> GetTemplates(string channelId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(channelId, nameof(channelId));

            RequestContext context = cancellationToken.CanBeCanceled ? new RequestContext { CancellationToken = cancellationToken } : null;
            HttpMessage FirstPageRequest(int? pageSizeHint) => CreateGetTemplatesRequest(channelId, context);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => CreateGetTemplatesNextPageRequest(nextLink, channelId, context);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, MessageTemplateItem.DeserializeMessageTemplateItem, ClientDiagnostics, _pipeline, "MessageTemplateClient.GetTemplates", "value", "nextLink", context);
        }

        /// <summary>
        /// [Protocol Method] List all templates for given ACS channel
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="GetTemplatesAsync(string,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="channelId"> The registration ID of the channel. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="channelId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="channelId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="AsyncPageable{T}"/> from the service containing a list of <see cref="BinaryData"/> objects. Details of the body schema for each item in the collection are in the Remarks section below. </returns>
        /// <include file="Docs/MessageTemplateClient.xml" path="doc/members/member[@name='GetTemplatesAsync(string,RequestContext)']/*" />
        public virtual AsyncPageable<BinaryData> GetTemplatesAsync(string channelId, RequestContext context)
        {
            Argument.AssertNotNullOrEmpty(channelId, nameof(channelId));

            HttpMessage FirstPageRequest(int? pageSizeHint) => CreateGetTemplatesRequest(channelId, context);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => CreateGetTemplatesNextPageRequest(nextLink, channelId, context);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => BinaryData.FromString(e.GetRawText()), ClientDiagnostics, _pipeline, "MessageTemplateClient.GetTemplates", "value", "nextLink", context);
        }

        /// <summary>
        /// [Protocol Method] List all templates for given ACS channel
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="GetTemplates(string,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="channelId"> The registration ID of the channel. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="channelId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="channelId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="Pageable{T}"/> from the service containing a list of <see cref="BinaryData"/> objects. Details of the body schema for each item in the collection are in the Remarks section below. </returns>
        /// <include file="Docs/MessageTemplateClient.xml" path="doc/members/member[@name='GetTemplates(string,RequestContext)']/*" />
        public virtual Pageable<BinaryData> GetTemplates(string channelId, RequestContext context)
        {
            Argument.AssertNotNullOrEmpty(channelId, nameof(channelId));

            HttpMessage FirstPageRequest(int? pageSizeHint) => CreateGetTemplatesRequest(channelId, context);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => CreateGetTemplatesNextPageRequest(nextLink, channelId, context);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => BinaryData.FromString(e.GetRawText()), ClientDiagnostics, _pipeline, "MessageTemplateClient.GetTemplates", "value", "nextLink", context);
        }

        internal HttpMessage CreateGetTemplatesRequest(string channelId, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/messages/channels/", false);
            uri.AppendPath(channelId, true);
            uri.AppendPath("/templates", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateGetTemplatesNextPageRequest(string nextLink, string channelId, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        private static RequestContext DefaultRequestContext = new RequestContext();
        internal static RequestContext FromCancellationToken(CancellationToken cancellationToken = default)
        {
            if (!cancellationToken.CanBeCanceled)
            {
                return DefaultRequestContext;
            }

            return new RequestContext() { CancellationToken = cancellationToken };
        }

        private static ResponseClassifier _responseClassifier200;
        private static ResponseClassifier ResponseClassifier200 => _responseClassifier200 ??= new StatusCodeClassifier(stackalloc ushort[] { 200 });
    }
}
