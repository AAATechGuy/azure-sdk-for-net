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

namespace Azure.ResourceManager.IotCentral
{
    /// <summary>
    /// A Class representing an IotCentralPrivateLinkResource along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct an <see cref="IotCentralPrivateLinkResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetIotCentralPrivateLinkResource method.
    /// Otherwise you can get one from its parent resource <see cref="IotCentralAppResource" /> using the GetIotCentralPrivateLinkResource method.
    /// </summary>
    public partial class IotCentralPrivateLinkResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="IotCentralPrivateLinkResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="resourceName"> The resourceName. </param>
        /// <param name="groupId"> The groupId. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string resourceName, string groupId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTCentral/iotApps/{resourceName}/privateLinkResources/{groupId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _iotCentralPrivateLinkResourcePrivateLinksClientDiagnostics;
        private readonly PrivateLinksRestOperations _iotCentralPrivateLinkResourcePrivateLinksRestClient;
        private readonly IotCentralPrivateLinkResourceData _data;

        /// <summary> Initializes a new instance of the <see cref="IotCentralPrivateLinkResource"/> class for mocking. </summary>
        protected IotCentralPrivateLinkResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "IotCentralPrivateLinkResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal IotCentralPrivateLinkResource(ArmClient client, IotCentralPrivateLinkResourceData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="IotCentralPrivateLinkResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal IotCentralPrivateLinkResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _iotCentralPrivateLinkResourcePrivateLinksClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.IotCentral", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string iotCentralPrivateLinkResourcePrivateLinksApiVersion);
            _iotCentralPrivateLinkResourcePrivateLinksRestClient = new PrivateLinksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, iotCentralPrivateLinkResourcePrivateLinksApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.IoTCentral/iotApps/privateLinkResources";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual IotCentralPrivateLinkResourceData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a private link resource of a IoT Central Application.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTCentral/iotApps/{resourceName}/privateLinkResources/{groupId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<IotCentralPrivateLinkResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _iotCentralPrivateLinkResourcePrivateLinksClientDiagnostics.CreateScope("IotCentralPrivateLinkResource.Get");
            scope.Start();
            try
            {
                var response = await _iotCentralPrivateLinkResourcePrivateLinksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IotCentralPrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a private link resource of a IoT Central Application.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTCentral/iotApps/{resourceName}/privateLinkResources/{groupId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<IotCentralPrivateLinkResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _iotCentralPrivateLinkResourcePrivateLinksClientDiagnostics.CreateScope("IotCentralPrivateLinkResource.Get");
            scope.Start();
            try
            {
                var response = _iotCentralPrivateLinkResourcePrivateLinksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IotCentralPrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
