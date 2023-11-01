// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Resources
{
    /// <summary>
    /// A Class representing a Feature along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="FeatureResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetFeatureResource method.
    /// Otherwise you can get one from its parent resource <see cref="ResourceProviderResource" /> using the GetFeature method.
    /// </summary>
    public partial class FeatureResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="FeatureResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceProviderNamespace"> The resourceProviderNamespace. </param>
        /// <param name="featureName"> The featureName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceProviderNamespace, string featureName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.Features/providers/{resourceProviderNamespace}/features/{featureName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _featureClientDiagnostics;
        private readonly FeaturesRestOperations _featureRestClient;
        private readonly FeatureData _data;

        /// <summary> Initializes a new instance of the <see cref="FeatureResource"/> class for mocking. </summary>
        protected FeatureResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "FeatureResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal FeatureResource(ArmClient client, FeatureData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="FeatureResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal FeatureResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _featureClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Resources", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string featureApiVersion);
            _featureRestClient = new FeaturesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, featureApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Resources/features";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual FeatureData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        /// <summary>
        /// Gets the preview feature with the specified name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Features/providers/{resourceProviderNamespace}/features/{featureName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Features_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<FeatureResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _featureClientDiagnostics.CreateScope("FeatureResource.Get");
            scope.Start();
            try
            {
                var response = await _featureRestClient.GetAsync(Id.SubscriptionId, Id.ResourceType.Namespace, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FeatureResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the preview feature with the specified name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Features/providers/{resourceProviderNamespace}/features/{featureName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Features_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<FeatureResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _featureClientDiagnostics.CreateScope("FeatureResource.Get");
            scope.Start();
            try
            {
                var response = _featureRestClient.Get(Id.SubscriptionId, Id.ResourceType.Namespace, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FeatureResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Registers the preview feature for the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Features/providers/{resourceProviderNamespace}/features/{featureName}/register</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Features_Register</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<FeatureResource>> RegisterAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _featureClientDiagnostics.CreateScope("FeatureResource.Register");
            scope.Start();
            try
            {
                var response = await _featureRestClient.RegisterAsync(Id.SubscriptionId, Id.ResourceType.Namespace, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new FeatureResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Registers the preview feature for the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Features/providers/{resourceProviderNamespace}/features/{featureName}/register</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Features_Register</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<FeatureResource> Register(CancellationToken cancellationToken = default)
        {
            using var scope = _featureClientDiagnostics.CreateScope("FeatureResource.Register");
            scope.Start();
            try
            {
                var response = _featureRestClient.Register(Id.SubscriptionId, Id.ResourceType.Namespace, Id.Name, cancellationToken);
                return Response.FromValue(new FeatureResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Unregisters the preview feature for the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Features/providers/{resourceProviderNamespace}/features/{featureName}/unregister</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Features_Unregister</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<FeatureResource>> UnregisterAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _featureClientDiagnostics.CreateScope("FeatureResource.Unregister");
            scope.Start();
            try
            {
                var response = await _featureRestClient.UnregisterAsync(Id.SubscriptionId, Id.ResourceType.Namespace, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new FeatureResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Unregisters the preview feature for the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Features/providers/{resourceProviderNamespace}/features/{featureName}/unregister</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Features_Unregister</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<FeatureResource> Unregister(CancellationToken cancellationToken = default)
        {
            using var scope = _featureClientDiagnostics.CreateScope("FeatureResource.Unregister");
            scope.Start();
            try
            {
                var response = _featureRestClient.Unregister(Id.SubscriptionId, Id.ResourceType.Namespace, Id.Name, cancellationToken);
                return Response.FromValue(new FeatureResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
