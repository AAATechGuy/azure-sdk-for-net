// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    /// <summary> The Private Endpoint Connection resource. </summary>
    public partial class DesktopVirtualizationPrivateEndpointConnection : ResourceData
    {
        /// <summary> Initializes a new instance of DesktopVirtualizationPrivateEndpointConnection. </summary>
        public DesktopVirtualizationPrivateEndpointConnection()
        {
        }

        /// <summary> Initializes a new instance of DesktopVirtualizationPrivateEndpointConnection. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="privateEndpoint"> The resource of private end point. </param>
        /// <param name="connectionState"> A collection of information about the state of the connection between service consumer and provider. </param>
        /// <param name="provisioningState"> The provisioning state of the private endpoint connection resource. </param>
        internal DesktopVirtualizationPrivateEndpointConnection(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SubResource privateEndpoint, DesktopVirtualizationPrivateLinkServiceConnectionState connectionState, DesktopVirtualizationPrivateEndpointConnectionProvisioningState? provisioningState) : base(id, name, resourceType, systemData)
        {
            PrivateEndpoint = privateEndpoint;
            ConnectionState = connectionState;
            ProvisioningState = provisioningState;
        }

        /// <summary> The resource of private end point. </summary>
        internal SubResource PrivateEndpoint { get; set; }
        /// <summary> Gets Id. </summary>
        public ResourceIdentifier PrivateEndpointId
        {
            get => PrivateEndpoint is null ? default : PrivateEndpoint.Id;
        }

        /// <summary> A collection of information about the state of the connection between service consumer and provider. </summary>
        public DesktopVirtualizationPrivateLinkServiceConnectionState ConnectionState { get; set; }
        /// <summary> The provisioning state of the private endpoint connection resource. </summary>
        public DesktopVirtualizationPrivateEndpointConnectionProvisioningState? ProvisioningState { get; }
    }
}
